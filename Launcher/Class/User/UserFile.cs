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


        public void Read()
        {
            fileServers = new List<UserServer>();

            if (!File.Exists(filePath)) return;

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                fileHeader = reader.ReadChars(4);   //header
                fileVersion = reader.ReadInt32();   //file version
                fileLength = reader.ReadInt32();    //server count

                for (int i = 0; i < fileLength; i++)
                {
                    //address
                    int addresslen = reader.ReadInt32();
                    string address = new string(reader.ReadChars(addresslen));
                    //port
                    int port = reader.ReadInt32();
                    //hostname
                    int hostlen = reader.ReadInt32();
                    string host = new string(reader.ReadChars(hostlen));
                    //password
                    int pwlen = reader.ReadInt32();
                    string pw = new string(reader.ReadChars(pwlen));
                    //rcon
                    int rconlen = reader.ReadInt32();
                    string rcon = new string(reader.ReadChars(rconlen));

                    fileServers.Add(new UserServer(address, port, host, pw, rcon));
                }
            }
        }
    }
}
