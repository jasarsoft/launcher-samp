using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Jasarsoft.Launcher.SAMP
{
    class ServerPlayer : ServerQuery
    {
        List<PlayerInfo> playersInfo;


        public ServerPlayer(string ip, int ping) : base(ip, ping)
        {
            playersInfo = new List<PlayerInfo>();

        }


        public PlayerInfo[] Players
        {
            get { return playersInfo.ToArray(); }
        }


        public bool GetInfo()
        {
            if(Send(ServerOpcode.PLAYER) && Receive())
            {
                return true;
            }

            return false;
        }

        private bool Receive2()
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

                        if (reader.ReadChar() == ServerOpcode.PLAYER)
                        {
                            int playercount = reader.ReadInt16();

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

        private new bool Receive()
        {
            byte[] buffer = new byte[3402];

            try
            {
                //endpoint = new IPEndPoint(serverAddress, serverPort);
                serverSocket.ReceiveFrom(buffer, ref endpoint);
            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex.Message);
                return false;
            }

            timeEnd = DateTime.Now;

            using (MemoryStream stream = new MemoryStream(buffer))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    //if (stream.Length <= 10) return serverCount;

                    reader.ReadBytes(10);

                    if(reader.ReadChar() == 'd')
                    {
                        int playercount = reader.ReadInt16();

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

            return false;
        }
    }
}
