using System;
using System.Net;

namespace Jasarsoft.Launcher.SAMP
{
    public sealed class ServerIp
    {
        private string addressIp;
        private int addressPort;

        public ServerIp(string ip, int port)
        {
            addressIp = ip;
            addressPort = port;
        }


        public string Address
        {
            get { return addressIp; }
        }

        public int Port
        {
            get { return addressPort; }
        }

        public bool IsLive()
        {
            ServerPing sp = new ServerPing(this);

            return sp.Ping() > 0 ? true : false;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}", addressIp, addressPort);
        }
    }
}
