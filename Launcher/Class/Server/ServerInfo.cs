using System;
using System.IO;

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


        public ServerInfo(ServerIp server) : base(server)
        {
            serverPassword = false;
            currentPlayers = 0;
            maxPlayers = 0;
            serverHostname = null;
            serverGamemode = null;
            serverLanguage = null;
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


        public bool Info()
        {
            if (Send(OpcodeKey.INFO) && Receive())
            {
                return true;
            }

            return false;
        }

        private bool Receive()
        {
            byte[] buffer = new byte[256];

            if (base.Receive(ref buffer))
            {
                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        if (stream.Length <= 10)
                            return false;
                        else
                            reader.ReadBytes(10);

                        if (reader.ReadChar() == OpcodeKey.INFO)
                        {
                            serverPassword = reader.ReadByte() == 0 ? false : true;
                            currentPlayers = reader.ReadInt16();
                            maxPlayers = reader.ReadInt16();
                            serverHostname = new string(reader.ReadChars(reader.ReadInt32()));
                            serverGamemode = new string(reader.ReadChars(reader.ReadInt32()));
                            serverLanguage = new string(reader.ReadChars(reader.ReadInt32()));

                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
