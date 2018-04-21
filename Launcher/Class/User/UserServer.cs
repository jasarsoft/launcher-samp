using System;


namespace Jasarsoft.Launcher.SAMP
{
    sealed class UserServer
    {
        private string userAddress;
        private int userPort;
        private string userHostname;
        private string userPassword;
        private string userRcon;


        public UserServer(string ip, int port)
        {
            this.userAddress = ip;
            this.userPort = port;
        }

        public UserServer(string ip, int port, string host) : this(ip, port)
        {
            this.userHostname = host;
        }

        public UserServer(string ip, int port, string host, string password) : this(ip, port, host)
        {
            this.userPassword = password;
        }

        public UserServer(string ip, int port, string host, string password, string rcon) : this(ip, port, host, password)
        {
            this.userRcon = rcon;
        }


        public string Address
        {
            get { return userAddress; }
        }

        public int Port
        {
            get { return userPort; }
        }

        public string Hostname
        {
            get { return userHostname; }
        }

        public string Password
        {
            get { return userPassword; }
        }

        public string Rcon
        {
            get { return userRcon; }
        }
    }
}
