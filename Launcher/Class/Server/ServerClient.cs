using System;
using System.IO;
using System.Collections.Generic;


namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class ServerClient : ServerQuery
    {
        List<PlayerClient> playerClient;
        

        public ServerClient(ServerIp server) : base(server)
        {
            playerClient = new List<PlayerClient>();
        }


        public PlayerClient[] Players
        {
            get { return playerClient.ToArray(); }
        }


        public bool Client()
        {
            return Send(OpcodeKey.CLIENT) && Receive();
        }

        private bool Receive()
        {
            byte[] buffer = new byte[1024 * 8];

            if (base.Receive(ref buffer))
            {
                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        if (stream.Length <= 10) return false;

                        reader.ReadBytes(10);

                        if (reader.ReadChar() == OpcodeKey.CLIENT)
                        {
                            int playercount = reader.ReadInt16();
                            playerClient = new List<PlayerClient>();

                            for (int i = 0; i < playercount; i++)
                            {
                                int namelen = reader.ReadByte();
                                string name = new string(reader.ReadChars(namelen));

                                int score = reader.ReadInt32();

                                playerClient.Add(new PlayerClient(name, score));
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
