using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Jasarsoft.Launcher.SAMP
{
    class UserXml
    {
        private readonly string filePath;
        private List<UserServer> fileServers;


        public UserXml()
        {
            this.filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                            @"\GTA San Andreas User Files\SAMP\launcher.xml";
        }


        public List<UserServer> Servers
        {
            get { return this.fileServers; }
            set { this.fileServers = value; }
        }


        public void Read()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(this.filePath);

            XmlNodeList nodelist = xd.SelectNodes("/launcher/server");

            foreach (XmlNode node in nodelist)
            {
                try
                {
                    var address = node.SelectSingleNode("address").InnerText;
                    var port = node.SelectSingleNode("port").InnerText;
                    var hostname = node.SelectSingleNode("hostname").InnerText;
                    var password = node.SelectSingleNode("password").InnerText;
                    var rcon = node.SelectSingleNode("rcon").InnerText;

                    //System.Diagnostics.Debug.WriteLine("IZLAZ: " + address);
                    //System.Diagnostics.Debug.WriteLine("IZLAZ: " + port);
                    //System.Diagnostics.Debug.WriteLine("IZLAZ: " + hostname);
                    //System.Diagnostics.Debug.WriteLine("IZLAZ: " + password);
                    //System.Diagnostics.Debug.WriteLine("IZLAZ: " + rcon);
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("ERROR: Xml read document");
                }
            }
        }

        public void Write()
        {
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Indent = true;
            xws.NewLineHandling = NewLineHandling.Entitize;

            XmlDocument doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement launcherElement = doc.CreateElement(string.Empty, "launcher", string.Empty);
            doc.AppendChild(launcherElement);

            foreach(var server in this.fileServers)
            {
                XmlElement serverElement = doc.CreateElement("server");
                launcherElement.AppendChild(serverElement);

                //address
                XmlElement addressElement = doc.CreateElement("address");
                XmlText addressText = doc.CreateTextNode(server.Address);
                addressElement.AppendChild(addressText);
                launcherElement.AppendChild(addressElement);

                //port
                XmlElement portElement = doc.CreateElement("port");
                XmlText portText = doc.CreateTextNode(server.Port.ToString());
                portElement.AppendChild(portText);
                launcherElement.AppendChild(portElement);

                //hostname
                XmlElement hostElement = doc.CreateElement("hostname");
                XmlText hostText = doc.CreateTextNode(server.Hostname);
                hostElement.AppendChild(hostText);
                launcherElement.AppendChild(hostElement);

                //password
                XmlElement passwordElement = doc.CreateElement("password");
                XmlText passwordText = doc.CreateTextNode(server.Password);
                passwordElement.AppendChild(passwordText);
                launcherElement.AppendChild(passwordElement);

                //rcon
                XmlElement rconElement = doc.CreateElement("rcon");
                XmlText rconText = doc.CreateTextNode(server.Rcon);
                rconElement.AppendChild(rconText);
                launcherElement.AppendChild(rconElement);
            }

            doc.Save(this.filePath);
        }

        public void Write2()
        {
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(this.filePath, xws))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("launcher");

                foreach(var server in this.fileServers)
                {
                    writer.WriteStartElement("server");
                    writer.WriteElementString("address", server.Address);
                    writer.WriteElementString("port", server.Port.ToString());
                    writer.WriteElementString("hostname", server.Hostname);
                    writer.WriteElementString("password", server.Password);
                    writer.WriteElementString("rcon", server.Rcon);
                    //writer.WriteElementString("password", server.Password == null ? String.Empty : server.Password);
                    //writer.WriteElementString("rcon", server.Rcon == null ? String.Empty : server.Rcon);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
