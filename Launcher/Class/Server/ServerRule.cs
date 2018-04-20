using System;
using System.Collections.Generic;
using System.IO;
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
        

        public ServerRule(ServerIp server) : base(server)
        {
            //nothing
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


        public bool Rule()
        {
            return Send(OpcodeKey.RULE) && Receive() ? true : false;
        }

        private bool Receive()
        {
            byte[] buffer = new byte[256];

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

                        if (reader.ReadChar() == OpcodeKey.RULE)
                        {
                            int rulecount = reader.ReadInt16();

                            for (int i = 0; i < rulecount; i++)
                            {
                                int rulelen = reader.ReadByte();
                                string rule = new string(reader.ReadChars(rulelen));

                                int valuelen = reader.ReadByte();
                                string value = new string(reader.ReadChars(valuelen));

                                switch (rule)
                                {
                                    case RuleKey.LOGMAP:
                                        serverLogcomp = value;
                                        break;
                                    case RuleKey.MAPNAME:
                                        serverMapname = value;
                                        break;
                                    case RuleKey.VERSION:
                                        serverVersion = value;
                                        break;
                                    case RuleKey.WEATHER:
                                        serverWeather = value;
                                        break;
                                    case RuleKey.WEBURL:
                                        serverWeburl = value;
                                        break;
                                    case RuleKey.WORLDTIME:
                                        serverWorldtime = value;
                                        break;
                                }
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
