using System;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class ServerInfo : ServerQuery
    {
        private bool serverPassword;            //server ima/nema postavljen password
        private int currentPlayers;             //broj trenutni igraca
        private int maxPlayers;                 //broj maksimalno dozvoljeni igraca
        private string serverHostname;          //naziv server host-a
        private string serverGamemode;          //naziv server gamemode-a
        private string serverLanguage;          //jezik servera


        public ServerInfo(string ip, int port) : base(ip, port)
        {
            GetInfo();
        }


        public bool Password
        {
            get { return serverPassword; }
        }

        public int CurrentPlayers
        {
            get { return currentPlayers; }
        }

        public int MaxPlayers
        {
            get { return maxPlayers; }
        }

        public string Hostname
        {
            get { return serverHostname; }
        }

        public string Gamemode
        {
            get { return serverGamemode; }
        }

        public string Language
        {
            get { return serverLanguage; }
        }


        public bool GetInfo()
        {
            if (Send(ServerOpcode.INFO))
            {
                serverPassword = Result[0] == "0" ? false : true;
                currentPlayers = Convert.ToInt32(Result[1]);
                maxPlayers = Convert.ToInt32(Result[2]);
                serverHostname = Result[3];
                serverGamemode = Result[4];
                serverLanguage = Result[5];

                return true;
            }

            return false;
        }
    }
}
