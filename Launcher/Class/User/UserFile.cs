using System;
using System.IO;
using System.Collections.Generic;


namespace Jasarsoft.Launcher.SAMP
{
    class UserFile
    {
        private readonly string filePath;
        private List<UserServer> fileServers;

        
        public UserFile()
        {
            this.filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                            @"\GTA San Andreas User Files\SAMP\USERDATA.DAT";
        }


        public UserServer[] Servers
        {
            get { return this.fileServers.ToArray(); }
        }

        public string Path
        {
            get { return this.filePath; }
        }


        public bool Read()
        {
            this.fileServers = new List<UserServer>();

            if (!File.Exists(this.filePath)) return false;

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(this.filePath, FileMode.Open)))
                {
                    char[] fileHeader = reader.ReadChars(4);    //header
                    int fileVersion = reader.ReadInt32();       //file version
                    int fileLength = reader.ReadInt32();        //server count

                    for (int i = 0; i < fileLength; i++)
                    {
                        //address
                        string address = new string(reader.ReadChars(reader.ReadInt32()));
                        //port
                        int port = reader.ReadInt32();
                        //hostname
                        string host = new string(reader.ReadChars(reader.ReadInt32()));
                        //password
                        string pw = new string(reader.ReadChars(reader.ReadInt32()));
                        //rcon
                        string rcon = new string(reader.ReadChars(reader.ReadInt32()));

                        this.fileServers.Add(new UserServer(address, port, host, pw, rcon));
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
