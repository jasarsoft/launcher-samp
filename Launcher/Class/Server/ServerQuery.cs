using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime;

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

            serverPort = port;

            serverSocket = new Socket(AddressFamily.InterNetwork, 
                                      SocketType.Dgram, 
                                      ProtocolType.Udp);

            serverSocket.SendTimeout = 5000;
            serverSocket.ReceiveTimeout = 5000;

            try
            {
                serverAddress = Dns.GetHostAddresses(ip)[0];
                endpoint = new IPEndPoint(serverAddress, serverPort);
            }
            catch
            {
                throw;
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

        private bool ValidAddressNumber(string number)
        {
            int result;

            if (Int32.TryParse(number, out result))
            {
                if (result >= 0 && result <= 255)
                    return true;
            }

            return false;
        }


        private bool CheckAddress(IPAddress ip)
        {
            string[] splitip;

            try
            {
                splitip = serverAddress.ToString().Split('.');
            }
            catch (Exception)
            {
                return false;
            }

            if (ValidAddressNumber(splitip[0]) && ValidAddressNumber(splitip[1]) &&
                    ValidAddressNumber(splitip[2]) && ValidAddressNumber(splitip[3]))
                return true;

            return false;
        }


        protected bool Send(char opcode)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write("SAMP".ToCharArray());

                    string[] splitip = serverAddress.ToString().Split('.');

                    writer.Write(Convert.ToByte(Convert.ToInt32(splitip[0])));
                    writer.Write(Convert.ToByte(Convert.ToInt32(splitip[1])));
                    writer.Write(Convert.ToByte(Convert.ToInt32(splitip[2])));
                    writer.Write(Convert.ToByte(Convert.ToInt32(splitip[3])));

                    writer.Write((ushort)serverPort);

                    writer.Write(opcode);

                    if (opcode == ServerOpcode.PING)
                        writer.Write("8493".ToCharArray());
                }

                timeStart = DateTime.Now;

                try
                {
                    endpoint = new IPEndPoint(serverAddress, serverPort);
                    if (serverSocket.SendTo(stream.ToArray(), endpoint) > 0)
                        return true;
                }
                catch
                {
                    return false;
                }
            }
            

            return false;
        }

        public int Receive()
        {
            serverCount = 0;
            byte[] buffer = new byte[3402];

            try
            {
                endpoint = new IPEndPoint(serverAddress, serverPort);
                serverSocket.ReceiveFrom(buffer, ref endpoint);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return serverCount;
            }

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
