using System;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class ServerItem
    {
        private ServerIp serverIp;
        private bool serverKey;             //server zakljucan
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
            this.serverKey = false;
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

        public ServerItem(ServerIp server, bool key, int players, int max, string host, string game, string lang) : this(server, host)
        {
            this.serverKey = key;
            this.serverCurPlayers = players;
            this.serverMaxPlayers = max;
            this.serverGamemode = game;
            this.serverLanguage = lang;
        }



        public string Key
        {
            get { return this.serverKey ? "Da" : "Ne"; }
        }

        public string Players
        {
            get { return String.Format("{0}/{1}", this.serverCurPlayers, this.serverMaxPlayers); }
        }


        public string Hostname
        {
            get { return this.serverHostname; }
            //set { this.serverHostname = value; }
        }

        public string Gamemode
        {
            get { return this.serverGamemode; }
            //set { this.serverGamemode = value; }
        }

        public string Language
        {
            get { return this.serverLanguage; }
            //set { this.serverLanguage = value; }
        }


        public bool IsLock()
        {
            return this.serverKey;
        }

        public bool IsLive()
        {
            ServerPing sp = new ServerPing(this.serverIp);

            return sp.Ping() > 0 ? true : false;
        }

        public ServerIp GetServer()
        {
            return this.serverIp;
        }

        public string GetAddress()
        {
            return this.serverIp.Address;
        }

        public int GetPort()
        {
            return this.serverIp.Port;
        }

        public string GetPassword()
        {
            return this.serverPassword;
        }

        public void SetPassword(string password)
        {
            this.serverPassword = password;
        }

        public void ResetPassword()
        {
            SetPassword(null); //this.serverPassword = null;
        }

        public string GetRconPassword()
        {
            return this.serverRcon;
        }

        public void SetRconPassword(string rcon)
        {
            this.serverRcon = rcon;
        }

        public void ResetRconPassword()
        {
            SetRconPassword(null); //this.serverRcon = null;
        }
    }
}
