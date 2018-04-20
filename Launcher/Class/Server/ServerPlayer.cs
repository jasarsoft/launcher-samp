using System;
using System.IO;
using System.Collections.Generic;


namespace Jasarsoft.Launcher.SAMP
{
    class ServerPlayer : ServerQuery
    {
        List<PlayerInfo> playersInfo;


        public ServerPlayer(ServerIp server) : base(server)
        {
            playersInfo = new List<PlayerInfo>();
        }


        public PlayerInfo[] Players
        {
            get { return playersInfo.ToArray(); }
        }


        public bool Info()
        {
            return Send(OpcodeKey.PLAYER) && Receive();
        }

        private bool Receive()
        {
            byte[] buffer = new byte[3402];

            if(Receive(ref buffer))
            {
                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        if (stream.Length <= 10) return false;
                        
                        reader.ReadBytes(10);

                        if (reader.ReadChar() == OpcodeKey.PLAYER)
                        {
                            int playercount = reader.ReadInt16();
                            playersInfo = new List<PlayerInfo>();

                            for (int i = 0; i < playercount; i++)
                            {
                                playersInfo.Add(new PlayerInfo(reader.ReadByte(),
                                                               new string(reader.ReadChars(reader.ReadByte())),
                                                               reader.ReadInt32(),
                                                               reader.ReadInt32()));
                            }

                            return true;
                        }
                    }
                }
            }

            return false;   
        }
    }
}
