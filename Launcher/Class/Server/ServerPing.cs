using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jasarsoft.Launcher.SAMP
{
    class ServerPing : ServerQuery
    {
        public ServerPing(string ip, int port) : base(ip, port)
        {
            //pingValue = Ping();
        }


        public int Ping()
        {
            if(Send(ServerOpcode.PING))
            {
                if(Receive() > 0)
                {
                    return Convert.ToInt32(Result[0]);
                }
            }

            return 0;
        }
    }
}
