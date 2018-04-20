using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
            return Send(OpcodeKey.CLIENT) && Receive() ? true : false;
        }

        private new bool Receive()
        {
            byte[] buffer = new byte[1024 * 8];

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
#if DEBUG
                        string debug = String.Format("{0}: Binary stream size {1}",
                                                      this.ToString(), stream.Length);

                        System.Diagnostics.Debug.WriteLine(debug);
#endif

                        if (reader.ReadChar() == OpcodeKey.CLIENT)
                        {
                            int playercount = reader.ReadInt16();
                            playerClient = new List<PlayerClient>();

#if DEBUG
                            System.Diagnostics.Debug.Write(String.Format("{0}: Player count: {1}", this.ToString(), playercount));
#endif

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
