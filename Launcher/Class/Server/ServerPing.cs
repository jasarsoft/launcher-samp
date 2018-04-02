using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jasarsoft.Launcher.SAMP
{
    class ServerPing : ServerQuery
    {
        private int pingValue;      //ping milisecond value

        public ServerPing(string ip, int port) : base(ip, port)
        {
            pingValue = Ping();
        }

        public int Value
        {
            get { return pingValue; }
        }


        public int Ping()
        {
            if(Send(ServerOpcode.PING))
            {
                pingValue = Convert.ToInt32(Result[0]);
            }

            return 0;
        }
    }
}
