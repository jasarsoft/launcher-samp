﻿using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Jasarsoft.Launcher.SAMP
{
    abstract class ServerQuery
    {
        int serverPort = 0;
        private int serverCount = 0;

        Socket serverSocket;
        IPAddress serverAddress;
        EndPoint endpoint;


        private string[] serverResults;

        DateTime timeStart;
        DateTime timeEnd;
        DateTime[] timeStamp = new DateTime[2];

        public ServerQuery(string ip, int port)
        {
            if (ip == null || ip == String.Empty || port == 0)
                throw new ArgumentNullException("Ip adresa i/ili port nisu definisani.");


            serverSocket = new Socket(AddressFamily.InterNetwork, 
                                      SocketType.Dgram, 
                                      ProtocolType.Udp);

            serverSocket.SendTimeout = 5000;
            serverSocket.ReceiveTimeout = 5000;

            try
            {
                serverPort = port;
                serverAddress = Dns.GetHostAddresses(ip)[0];
                endpoint = new IPEndPoint(serverAddress, serverPort);
            }
            catch
            {

            }
        }

        protected int Cout
        {
            get { return serverCount; }
        }

        protected string[] Result
        {
            get { return serverResults; }
        }


        protected bool Send(char opcode)
        {
            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(stream))
                    {
                        writer.Write("SAMP".ToCharArray());

                        string[] splitIP = serverAddress.ToString().Split('.');

                        writer.Write(Convert.ToByte(Convert.ToInt32(splitIP[0])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(splitIP[1])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(splitIP[2])));
                        writer.Write(Convert.ToByte(Convert.ToInt32(splitIP[3])));

                        writer.Write((ushort)serverPort);

                        writer.Write(opcode);

                        if (opcode ==  ServerOpcode.INFO)
                            writer.Write("8493".ToCharArray());
                    }

                    timeStart = DateTime.Now;

                    if (serverSocket.SendTo(stream.ToArray(), endpoint) > 0)
                        return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        public int Receive()
        {
            serverCount = 0;
            byte[] buffer = new byte[3402];

            try
            {
                serverSocket.ReceiveFrom(buffer, ref endpoint);

                timeEnd = DateTime.Now;

                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        //if (stream.Length <= 10) return serverCount;

                        reader.ReadBytes(10);

                        switch (reader.ReadChar())
                        {
                            case 'i': // Information
                                {
                                    serverResults = new string[6];

                                    serverResults[serverCount++] = Convert.ToString(reader.ReadByte());
                                    serverResults[serverCount++] = Convert.ToString(reader.ReadInt16());
                                    serverResults[serverCount++] = Convert.ToString(reader.ReadInt16());

                                    int hostnamelen = reader.ReadInt32();
                                    serverResults[serverCount++] = new string(reader.ReadChars(hostnamelen));

                                    int gamemodelen = reader.ReadInt32();
                                    serverResults[serverCount++] = new string(reader.ReadChars(gamemodelen));

                                    int mapnamelen = reader.ReadInt32();
                                    serverResults[serverCount++] = new string(reader.ReadChars(mapnamelen));

                                    return serverCount;
                                }

                            case 'r': // Rules
                                {
                                    int rulecount = reader.ReadInt16();

                                    serverResults = new string[rulecount * 2];

                                    for (int i = 0; i < rulecount; i++)
                                    {
                                        int rulelen = reader.ReadByte();
                                        serverResults[serverCount++] = new string(reader.ReadChars(rulelen));

                                        int valuelen = reader.ReadByte();
                                        serverResults[serverCount++] = new string(reader.ReadChars(valuelen));
                                    }

                                    return serverCount;
                                }

                            case 'c': // Client list
                                {
                                    int playercount = reader.ReadInt16();

                                    serverResults = new string[playercount * 2];

                                    for (int i = 0; i < playercount; i++)
                                    {
                                        int namelen = reader.ReadByte();
                                        serverResults[serverCount++] = new string(reader.ReadChars(namelen));

                                        serverResults[serverCount++] = Convert.ToString(reader.ReadInt32());
                                    }

                                    return serverCount;
                                }

                            case 'd': // Detailed player information
                                {
                                    int playercount = reader.ReadInt16();

                                    serverResults = new string[playercount * 4];

                                    for (int i = 0; i < playercount; i++)
                                    {
                                        serverResults[serverCount++] = Convert.ToString(reader.ReadByte());

                                        int namelen = reader.ReadByte();
                                        serverResults[serverCount++] = new string(reader.ReadChars(namelen));

                                        serverResults[serverCount++] = Convert.ToString(reader.ReadInt32());
                                        serverResults[serverCount++] = Convert.ToString(reader.ReadInt32());
                                    }

                                    return serverCount;
                                }

                            case 'p': // Ping
                                {
                                    serverResults = new string[1];

                                    serverResults[serverCount++] = timeEnd.Subtract(timeStart).Milliseconds.ToString();

                                    return serverCount;
                                }

                            default:
                                return serverCount;
                        }
                    }
                }
            }

            catch
            {
                return serverCount;
            }
        }

        public string[] Store(int count)
        {
            string[] rString = new string[count];

            for (int i = 0; i < count && i < serverCount; i++)
                rString[i] = serverResults[i];

            serverCount = 0;

            return rString;
        }
    }
}
