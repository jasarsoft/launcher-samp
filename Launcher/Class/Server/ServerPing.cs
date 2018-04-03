using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Jasarsoft.Launcher.SAMP
{
    class ServerPing : ServerQuery
    {
        private int pingValue;

        public ServerPing(string ip, int port) : base(ip, port)
        {
            //pingValue = Ping();
        }


        public int Ping()
        {
            if(Send(ServerOpcode.PING))
            {
                if(Receive())
                {
                    return pingValue;
                }
            }

            return 0;
        }

        private new bool Receive()
        {
            byte[] buffer = new byte[64];

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

                        if (reader.ReadChar() == ServerOpcode.PING)
                        {
                            pingValue = timeEnd.Subtract(timeStart).Milliseconds;
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
