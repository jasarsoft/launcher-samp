using System;
using System.Net;

namespace Jasarsoft.Launcher.SAMP
{
    public sealed class ServerIp
    {
        private string serverIp;
        private int serverPort;
        private IPAddress serverAddress;
        

        public ServerIp(string ip, int port)
        {
            serverIp = ip;
            serverPort = port;

            try
            {
                serverAddress = Dns.GetHostAddresses(ip)[0];
            }
            catch (Exception)
            {
                this.serverAddress = null;
                //throw;
            }
        }


        public string Ip
        {
            get { return this.serverIp; }
        }

        public IPAddress Address
        {
            get { return serverAddress; }
        }

        public int Port
        {
            get { return serverPort; }
        }

        public bool IsLive()
        {
            ServerPing sp = new ServerPing(this);

            return sp.Ping() > 0 ? true : false;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}", serverIp, serverPort);
        }
    }
}
