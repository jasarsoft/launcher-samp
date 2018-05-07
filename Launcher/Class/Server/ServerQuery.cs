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
        private ServerIp serverIp;

        protected Socket serverSocket;
        protected EndPoint endPoint;

        protected DateTime timeStart;
        protected DateTime timeEnd;


        protected struct OpcodeKey
        {
            public const char INFO = 'i';
            public const char RULE = 'r';
            public const char CLIENT = 'c';
            public const char PLAYER = 'd';
            public const char RCON = 'x';
            public const char PING = 'p';
        }


        public ServerQuery(ServerIp server)
        {
            if (server == null || server.Address == null || server.Port == 0)
                throw new ArgumentNullException("Ip adresa i/ili port nisu definisani.");

            this.serverIp= server;

            this.serverSocket = new Socket(AddressFamily.InterNetwork, 
                                           SocketType.Dgram, 
                                           ProtocolType.Udp);

            this.serverSocket.SendTimeout = 10000;
            this.serverSocket.ReceiveTimeout = 10000;

            try
            {
                this.endPoint = new IPEndPoint(serverIp.Address, serverIp.Port);
            }
            catch
            {
                throw;
            }
        }


        public ServerIp Server
        {
            get { return this.serverIp; }
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
                splitip = serverIp.Address.ToString().Split('.');
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

                    string[] splitip = serverIp.Address.ToString().Split('.');

                    writer.Write(Convert.ToByte(Convert.ToInt32(splitip[0])));
                    writer.Write(Convert.ToByte(Convert.ToInt32(splitip[1])));
                    writer.Write(Convert.ToByte(Convert.ToInt32(splitip[2])));
                    writer.Write(Convert.ToByte(Convert.ToInt32(splitip[3])));

                    writer.Write((ushort)serverIp.Port);

                    writer.Write(opcode);

                    if (opcode == OpcodeKey.PING)
                        writer.Write("8493".ToCharArray());
                }

                this.timeStart = DateTime.Now;

                try
                {
                    //endpoint = new IPEndPoint(serverAddress, serverPort);
                    if (this.serverSocket.SendTo(stream.ToArray(), this.endPoint) > 0)
                        return true;
                }
                catch (Exception ex)
                {
#if DEBUG
                    Debug.WriteLine(this.ToString() + "|Send soccket|" + ex.Message);
#endif
                    return false;
                }
            }
            

            return false;
        }

        protected bool Receive(ref byte[] buffer)
        {
            try
            {
                this.serverSocket.ReceiveFrom(buffer, ref endPoint);
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(this.ToString() + "|Receive soccket|" +  ex.Message);
#endif
                return false;
            }

            this.timeEnd = DateTime.Now;

            return true;
        }
    }
}
