using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class ServerItem
    {
        private static int serverId = 0;    //redni broj servera
        private bool serverPassword;        //server je zakljucan/otkljucan
        private int serverPlayers;          //trenutni broj igraca na serveru
        private int serverMaxPlayers;       //podrzani broj igraca
        private string serverHostname;      //hostname servera
        private string serverGamemode;      //gamemode servera
        private string serverLanguage;      //jezik servera


        public ServerItem(string host, string game, string lang)
        {
            Initialize(false, 0, 0, ref host, ref game, ref lang);
        }

        public ServerItem(int players, int max, string host, string game, string lang)
        {
            Initialize(false, players, max, ref host, ref game, ref lang);
        }

        public ServerItem(bool key, int players, int max, string host, string game, string lang)
        {
            Initialize(key, players, max, ref host, ref game, ref lang);
        }


        public int Id
        {
            get { return serverId; }
        }

        public bool Password
        {
            get { return serverPassword; }
        }

        public int Players
        {
            get { return serverPlayers; }
        }

        public int MaxPlayers
        {
            get { return serverMaxPlayers; }
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


        private void Initialize(bool key, int players, int max, ref string host, ref string game, ref string lang)
        {
            serverId++;
            this.serverPassword = key;
            this.serverPlayers = players;
            this.serverMaxPlayers = max;
            this.serverHostname = host;
            this.serverGamemode = game;
            this.serverLanguage = lang;
        }
    }
}
