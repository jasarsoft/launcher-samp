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

        public ServerPing(ServerIp server) : base(server)
        {
            //pingValue = Ping();
        }


        public int Ping()
        {
            if(Send(OpcodeKey.PING))
            {
                if(Receive())
                {
                    return pingValue;
                }
            }

            return 0;
        }

        private bool Receive()
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

                        if (reader.ReadChar() == OpcodeKey.PING)
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
