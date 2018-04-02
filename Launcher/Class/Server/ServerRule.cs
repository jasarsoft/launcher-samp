using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class ServerRule : ServerQuery
    {
        private string serverLogcomp;
        private string serverMapname;
        private string serverVersion;
        private string serverWeather;
        private string serverWeburl;
        private string serverWorldtime;
        

        public ServerRule(string ip, int port) : base(ip, port)
        {
            GetRule();
        }


        public string Logcomp
        {
            get { return serverLogcomp; }
        }

        public string Mapname
        {
            get { return serverMapname; }
        }

        public string Version
        {
            get { return serverVersion; }
        }

        public string Weather
        {
            get { return serverWeather; }
        }

        public string Weburl
        {
            get { return serverWeburl; }
        }

        public string Worldtime
        {
            get { return serverWorldtime; }
        }

        

        public bool GetRule()
        {
            if(Send(ServerOpcode.RULE))
            {
                for(int i = 0; i < Result.Length; i++)
                {
                    switch(Result[i].ToString())
                    {
                        case "lagcomp":
                            serverLogcomp = Result[++i];
                            break;
                        case "mapname":
                            serverMapname = Result[++i];
                            break;
                        case "version":
                            serverVersion = Result[++i];
                            break;
                        case "weather":
                            serverWeather = Result[++i];
                            break;
                        case "weburl":
                            serverWeburl = Result[++i];
                            break;
                        case "worldtime":
                            serverWorldtime = Result[++i];
                            break;

                    }
                }
            }

            return true;
        }

        
    }
}
