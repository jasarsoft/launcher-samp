using System;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class ServerItem
    {
        private ServerIp serverIp;
        private string serverPassword;        
        private string serverRcon;
        private int serverCurPlayers;       //trenutni broj igraca na serveru
        private int serverMaxPlayers;       //podrzani broj igraca
        private string serverHostname;      //hostname servera
        private string serverGamemode;      //gamemode servera
        private string serverLanguage;      //jezik servera


        public ServerItem(ServerIp server)
        {
            this.serverIp = server;
            this.serverPassword = null;
            this.serverCurPlayers = 0;
            this.serverMaxPlayers = 0;
            this.serverHostname = null;
            this.serverGamemode = null;
            this.serverLanguage = null;
        }

        public ServerItem(ServerIp server, string host) : this(server)
        {
            this.serverHostname = host;
        }

        public ServerItem(ServerIp server, string host, string password, string rcon) : this(server, host)
        {
            this.serverPassword = password;
            this.serverRcon = rcon;
        }

        public ServerItem(ServerIp server, int players, int max, string host, string password, string rcon) : this(server, host, password, rcon)
        {
            this.serverCurPlayers = players;
            this.serverMaxPlayers = max;
        }

        public ServerItem(ServerIp server, int players, int max, string host, string game, string lang, string password, string rcon) : this(server, players, max, host, password, rcon)
        {
            this.serverGamemode = game;
            this.serverLanguage = lang;
        }


        public ServerIp Server
        {
            get { return this.serverIp; }
        }

        public string Password
        {
            get { return this.serverPassword; }
            set { this.serverPassword = value; }
        }

        public string PasswordRcon
        {
            get { return this.serverRcon; }
            set { this.serverRcon = value; }
        }

        public string Players
        {
            get { return String.Format("{0}/{1}", this.serverCurPlayers, this.serverMaxPlayers); }
        }

        public int PlayerCurrent
        {
            get { return this.serverCurPlayers; }
            set { this.serverCurPlayers = value; }
        }

        public int PlayerMax
        {
            get { return this.serverMaxPlayers; }
            set { this.serverMaxPlayers = value; }
        }

        public string Hostname
        {
            get { return this.serverHostname; }
            set { this.serverHostname = value; }
        }

        public string Gamemode
        {
            get { return this.serverGamemode; }
            set { this.serverGamemode = value; }
        }

        public string Language
        {
            get { return this.serverLanguage; }
            set { this.serverLanguage = value; }
        }


        public bool IsLock()
        {
            return this.serverPassword != null ? true : false;
        }

        public bool IsLive()
        {
            ServerPing sp = new ServerPing(this.serverIp);

            return sp.Ping() > 0 ? true : false;
        }
    }
}
