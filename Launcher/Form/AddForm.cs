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
using Syncfusion.Windows.Forms;
using System.IO;

namespace Jasarsoft.Launcher.SAMP
{
    public partial class AddForm : Syncfusion.Windows.Forms.MetroForm
    {
        private ServerIp serverIp;
        private ServerInfo serverInfo;
        private List<ServerItem> serverItems;

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
                this.serverKey = key ? "Da" : "Ne";
                this.serverPlayers = String.Format("{0}/{1}", players, max);
                this.serverHostname = host;
                this.serverGamemode = game;
                this.serverLanguage = lang;
            }
        }

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

            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            serverIp = new ServerIp(textAddress.Text, (int)numericPort.Value);
            serverInfo = new ServerInfo(serverIp);

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

            if(gridListServers.SelectedIndex != -1)
                buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (gridListServers.SelectedIndex != -1)
            {
                serverItems.Remove((ServerItem)gridListServers.SelectedItem);

                gridListServers.DataSource = null;
                gridListServers.Refresh();
                gridListServers.DataSource = serverItems;

                gridListServers.Refresh();

                buttonDelete.Enabled = false;
            }
        }

        private void gridListServers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (gridListServers.SelectedIndex != -1)
                buttonDelete.Enabled = true;
            else
                buttonDelete.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(gridListServers.SelectedIndex != -1)
            {
                TitleError title = new TitleError();
                string msg = "Za promjenu servera odaberite isti sa liste prije potvrde!";

                MessageBoxAdv.Show(msg, title.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //int index = gridListServers.SelectedIndex;
                //ServerItem item = serverItems[index];
                //serverIp = new ServerIp(item.)
            }
        }
    }
}
