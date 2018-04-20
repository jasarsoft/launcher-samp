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


        public bool GetInfo()
        {
            if(Send(OpcodeKey.PLAYER) && Receive())
            {
                return true;
            }

            return false;
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
                        if (stream.Length <= 10)
                            return false;
                        else
                            reader.ReadBytes(10);

                        if (reader.ReadChar() == OpcodeKey.PLAYER)
                        {
                            int playercount = reader.ReadInt16();
                            playersInfo = new List<PlayerInfo>();

                            for (int i = 0; i < playercount; i++)
                            {
                                //int playerid = reader.ReadByte();
                                //int playernicklen = reader.ReadByte();
                                //string playernick = new string(reader.ReadChars(playernicklen));
                                //int playerscore = reader.ReadInt32();
                                //int playerping = reader.ReadInt32();

                                //playersInfo.Add(new PlayerInfo(playerid, playernick, playerscore, playerping));


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
