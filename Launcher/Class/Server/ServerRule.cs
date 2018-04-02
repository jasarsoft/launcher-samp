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
                    switch(Result[i].ToString().ToLower())
                    {
                        case RuleKey.LOGMAP:
                            serverLogcomp = Result[++i];
                            break;
                        case RuleKey.MAPNAME:
                            serverMapname = Result[++i];
                            break;
                        case RuleKey.VERSION:
                            serverVersion = Result[++i];
                            break;
                        case RuleKey.WEATHER:
                            serverWeather = Result[++i];
                            break;
                        case RuleKey.WEBURL:
                            serverWeburl = Result[++i];
                            break;
                        case RuleKey.WORLDTIME:
                            serverWorldtime = Result[++i];
                            break;

                    }
                }
            }

            return true;
        }

        
        private struct RuleKey
        {
            public const string LOGMAP = "lagcomp";
            public const string MAPNAME = "mapname";
            public const string VERSION = "version";
            public const string WEATHER = "weather";
            public const string WEBURL = "weburl";
            public const string WORLDTIME = "worldtime";
        }
    }
}
