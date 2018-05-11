using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


namespace Jasarsoft.Launcher.SAMP
{
    class UserFile
    {
        private readonly string filePath;
        private List<UserServer> fileServers;

        private char[] fileHeader;
        private int fileVersion;
        private int fileLength;


        public UserFile()
        {
            this.fileHeader = "SAMP".ToCharArray();
            this.fileVersion = 1;
            this.fileLength = 0;
            this.filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                            @"\GTA San Andreas User Files\SAMP\USERDATA.DAT";
        }


        public List<UserServer> ServerList
        {
            get { return this.fileServers; }
            set { this.fileServers = value; }
        }

        public UserServer[] Servers
        {
            get { return this.fileServers.ToArray(); }
        }

        public string Path
        {
            get { return this.filePath; }
        }

        public void Delete(UserServer server)
        {
            for (int i = 0; i < this.fileServers.Count; i++)
            {
                if(this.fileServers[i].Equals(server))
                {
                    this.fileServers.Remove(server);
                }
            }
        }

        public void Delete(string address, int port)
        {
            for (int i = 0; i < this.fileServers.Count; i++)
            {
                if(this.fileServers[i].Address == address && this.fileServers[i].Port == port)
                {
                    this.fileServers.RemoveAt(i);
                    this.fileLength--;
                }
            }
        }

        public bool Read()
        {
            this.fileServers = new List<UserServer>();

            if (!File.Exists(this.filePath)) return false;

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(this.filePath, FileMode.Open)))
                {
                    this.fileHeader = reader.ReadChars(4);    //header
                    this.fileVersion = reader.ReadInt32();       //file version
                    this.fileLength = reader.ReadInt32();        //server count

                    for (int i = 0; i < fileLength; i++)
                    {
                        //address
                        int addresslen = reader.ReadInt32();
                        string address = addresslen > 0 ? new string(reader.ReadChars(addresslen)) : null;
                        //port
                        int port = reader.ReadInt32();
                        //hostname
                        int hostlen = reader.ReadInt32();
                        string host = hostlen > 0 ? new string(reader.ReadChars(hostlen)) : null;
                        //password
                        int pwlen = reader.ReadInt32();
                        string pw = pwlen > 0 ? new string(reader.ReadChars(pwlen)) : null;
                        //rcon
                        int rconlen = reader.ReadInt32();
                        string rcon = rconlen > 0 ? new string(reader.ReadChars(rconlen)) : null;

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

        public bool Write()
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(this.filePath, FileMode.Open)))
                {
                    byte[] data;

                    data = Encoding.Default.GetBytes(this.fileHeader);
                    writer.Write(data);

                    writer.Write(this.fileVersion);
                    writer.Write(this.fileLength);

                    for (int i = 0; i < this.fileLength; i++)
                    {
                        //address
                        if(this.fileServers[i].Address != null)
                        {
                            data = Encoding.Default.GetBytes(this.fileServers[i].Address);
                            writer.Write(data.Length);
                            writer.Write(data);
                        }
                        else
                        {
                            writer.Write(0);
                            //writer.Write(String.Empty);
                        }

                        //port
                        writer.Write(this.fileServers[i].Port);
                        
                        //hostname
                        if (this.fileServers[i].Hostname != null)
                        {
                            data = Encoding.Default.GetBytes(this.fileServers[i].Hostname);
                            writer.Write(data.Length);
                            writer.Write(data);
                        }
                        else
                        {
                            writer.Write(0);
                            //writer.Write(String.Empty);
                        }
                        
                        //password
                        if (this.fileServers[i].Password != null)
                        {
                            data = Encoding.Default.GetBytes(this.fileServers[i].Password);
                            writer.Write(data.Length);
                            writer.Write(data);
                        }
                        else
                        {
                            writer.Write(0);
                            //writer.Write(String.Empty);
                        }
                        
                        //rcon
                        if (this.fileServers[i].Rcon != null)
                        {
                            data = Encoding.Default.GetBytes(this.fileServers[i].Rcon);
                            writer.Write(data.Length);
                            writer.Write(data);
                        }
                        else
                        {
                            writer.Write(0);
                            //writer.Write(String.Empty);
                        }
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Default()
        {
            char[] header = "SAMP".ToCharArray();
            int version = 1;
            int length = 0;

            try
            {                
                using (BinaryWriter writer = new BinaryWriter(File.Open(this.filePath, FileMode.Create)))
                {
                    writer.Write(Encoding.Default.GetBytes(header));
                    writer.Write(version);
                    writer.Write(length); 

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
