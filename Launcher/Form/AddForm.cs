#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Jasarsoft.Launcher.SAMP
{
    public partial class AddForm : Syncfusion.Windows.Forms.MetroForm
    {
        private ServerInfo serverInfo;
        private List<ServerItem> serverItems;

        public AddForm()
        {
            InitializeComponent();

            serverItems = new List<ServerItem>();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            gridListServers.DataSource = serverItems;
            gridListServers.Grid.ColWidths[1] = 40;
            gridListServers.Grid.ColWidths[2] = 60;
            gridListServers.Grid.ColWidths[3] = 230;
            gridListServers.Grid.ColWidths[4] = 130;
            gridListServers.Grid.ColWidths[4] = 110;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            serverInfo = new ServerInfo(textAddress.Text, (int)numericPort.Value);

            if (serverInfo.Info())
            {
                serverItems.Add(new ServerItem(serverInfo.Password,
                                               serverInfo.CurrentPlayers,
                                               serverInfo.MaxPlayers,
                                               serverInfo.Hostname,
                                               serverInfo.Gamemode,
                                               serverInfo.Language));
            }

            gridListServers.DataSource = null;
            gridListServers.Refresh();
            gridListServers.DataSource = serverItems;

            gridListServers.Refresh();
        }

        private class ServerItem
        {
            private string serverKey;           //server je zakljucan/otkljucan
            private string serverPlayers;       //broj igraca na serveru
            private string serverHostname;      //hostname servera
            private string serverGamemode;      //gamemode servera
            private string serverLanguage;      //jezik servera


            public ServerItem(int players, int max, string host, string game, string lang)
            {
                Initialize(false, players, max, ref host, ref game, ref lang);
            }

            public ServerItem(bool key, int players, int max, string host, string game, string lang)
            {
                Initialize(key, players, max, ref host, ref game, ref lang);
            }


            public string Key
            {
                get { return serverKey; }
            }

            public string Players
            {
                get { return serverPlayers; }
            }

            public string Hostname
            {
                get { return serverHostname; }
            }

            public string Gamemode
            {
                get { return serverGamemode; }
            }

            public string Language
            {
                get { return serverLanguage; }
            }


            private void Initialize(bool key, int players, int max, ref string host, ref string game, ref string lang)
            {
                this.serverKey= key ? "Da" : "Ne";
                this.serverPlayers = String.Format("{0}/{1}",players, max);
                this.serverHostname = host;
                this.serverGamemode = game;
                this.serverLanguage = lang;
            }
        }
    }
}
