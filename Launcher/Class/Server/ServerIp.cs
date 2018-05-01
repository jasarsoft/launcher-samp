using System;
using System.Net;

namespace Jasarsoft.Launcher.SAMP
{
    public sealed class ServerIp
    {
        private static IPAddress addressIp;
        private static int addressPort;

        public ServerIp(string ip, int port)
        {
            try
            {
                addressPort = port;
                addressIp = Dns.GetHostAddresses(ip)[0];
            }
            catch
            {
                addressPort = 0;
                addressIp = null;
            }
        }


        public IPAddress Ip
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

            if (sp.Ping() > 0)
                return true;

            return false;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}", addressIp, addressPort);
        }
    }
}
