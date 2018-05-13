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
using System.Threading;
using System.Threading.Tasks;

namespace Jasarsoft.Launcher.SAMP
{
    public partial class AddForm : Syncfusion.Windows.Forms.MetroForm
    {
        private ServerIp serverIp;
        private UserFile userFile;
        private ServerInfo serverInfo;
        private List<ServerItem> serverItems;

        public AddForm()
        {
            InitializeComponent();

            serverItems = new List<ServerItem>();
        }


        public ServerIp Server
        {
            get { return this.serverIp; }
        }
        

        private void AddForm_Load(object sender, EventArgs e)
        {
            this.userFile = new UserFile();

            if (this.userFile.Read())
            {
                foreach (var us in this.userFile.Servers)
                {
                    this.serverIp = new ServerIp(us.Address, us.Port);
                    this.serverItems.Add(new ServerItem(serverIp, us.Hostname, us.Password, us.Rcon));
                }
            }
            else
            {
                this.userFile.Default();
            }

            gridListServers.DataSource = this.serverItems;
            gridListServers.Grid.ColWidths[1] = 40;
            gridListServers.Grid.ColWidths[2] = 60;
            gridListServers.Grid.ColWidths[3] = 235;
            gridListServers.Grid.ColWidths[4] = 120;
            gridListServers.Grid.ColWidths[5] = 110;

            gridListServers.SelectedIndex = -1;
            buttonDelete.Enabled = false; 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            workerServer.CancelAsync();

            serverIp = new ServerIp(textAddress.Text, (int)numericPort.Value);
            if (serverIp.Address == null)
            {
                TitleError title = new TitleError();
                string msg = "Server adresa nije validna, molimo vas unesite ispravan ip i port!";

                MessageBoxAdv.Show(msg, title.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            serverInfo = new ServerInfo(serverIp);

            if (serverInfo.Info())
            {
                serverItems.Add(new ServerItem(serverIp,
                                               serverInfo.Password,
                                               serverInfo.CurrentPlayers,
                                               serverInfo.MaxPlayers,
                                               serverInfo.Hostname,
                                               serverInfo.Gamemode,
                                               serverInfo.Language));  
            }
            else
            {
                serverItems.Add(new ServerItem(serverIp));
            }

            ListSoruce();

            gridListServers.SelectedIndex = -1;
            buttonDelete.Enabled = false;

            this.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            workerServer.CancelAsync();
            this.buttonDelete.Enabled = false;

            if (gridListServers.SelectedIndex != -1)
            {
                int index = gridListServers.SelectedIndex;
                ServerItem item = this.serverItems[index];

                this.serverItems.RemoveAt(index);

                ListSoruce();

                this.userFile.Delete(item.GetAddress(), item.GetPort());
                this.userFile.Write();
            }

            this.gridListServers.SelectedIndex = -1;
        }

        private void gridListServers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (gridListServers.SelectedIndex != -1)
            {
                if (!workerServer.IsBusy)
                {
                    workerServer.RunWorkerAsync(this.serverItems[gridListServers.SelectedIndex]);
                }

                buttonDelete.Enabled = true;
            }                
            else
                buttonDelete.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            workerServer.CancelAsync();
            this.gridListServers.SelectedIndex = -1;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {           
            workerServer.CancelAsync();

            if (gridListServers.SelectedIndex == -1)
            {
                TitleError title = new TitleError();
                string msg = "Za promjenu servera odaberite isti sa liste prije potvrde!";

                MessageBoxAdv.Show(msg, title.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int index = gridListServers.SelectedIndex;
                serverIp = serverItems[index].GetServer();
                var us = this.userFile.ServerList[index];

                this.userFile.ServerList.Remove(userFile.ServerList[index]);
                this.userFile.ServerList.Insert(0, us);
            }

            if (!this.userFile.Write())
            {
                TitleError title = new TitleError();
                string msg = "Doslo je do greske prilikom spremanja server liste!";

                MessageBoxAdv.Show(msg, title.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void workerServer_DoWork(object sender, DoWorkEventArgs e)
        {
            ServerItem item = e.Argument as ServerItem;
            BackgroundWorker worker = sender as BackgroundWorker;

            if (item == null || worker == null) return;

            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            item.Info();
        }

        private void workerServer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                ListUpdate();
            }
        }

        private void ListUpdate()
        {
            this.gridListServers.BeginUpdate();
            this.gridListServers.Update();
            this.gridListServers.EndUpdate();
        }

        private void ListSoruce()
        {
            this.gridListServers.BeginUpdate();
            this.gridListServers.DataSource = serverItems;
            this.gridListServers.EndUpdate();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            foreach (var us in this.serverItems)
            {
                if (us.Info())
                {
                    ListUpdate();
                }
            }

            this.Enabled = true;
        }
    }
}
