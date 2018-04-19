using System;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class ServerIp
    {
        private static string ip;
        private static int port;

        public ServerIp(string _ip, int _port)
        {
            ip = _ip;
            port = _port;
        }


        public string Ip
        {
            get { return ip; }
        }

        public int Port
        {
            get { return port; }
        }

        public string Address
        {
            get { return String.Format("{0}:{1}", ip, port); }
        }
    }
}
