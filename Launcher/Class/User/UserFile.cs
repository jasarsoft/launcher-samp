using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Jasarsoft.Launcher.SAMP
{
    class UserFile
    {
        private char[] fileHeader;
        private int fileVersion;
        private int fileLength;
        private List<UserServer> fileServers;

        private readonly string filePath;

        public UserFile()
        {
            this.filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                            @"\GTA San Andreas User Files\SAMP\USERDATA.DAT";
        }


        public UserServer[] Servers
        {
            get { return fileServers.ToArray(); }
        }


        public bool Read()
        {
            fileServers = new List<UserServer>();

            if (!File.Exists(filePath)) return false;

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    fileHeader = reader.ReadChars(4);   //header
                    fileVersion = reader.ReadInt32();   //file version
                    fileLength = reader.ReadInt32();    //server count

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

                        fileServers.Add(new UserServer(address, port, host, pw, rcon));
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
