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

                    ServerItem si = new ServerItem(serverIp, us.Hostname, us.Password, us.Rcon);
                    //si.SetPassword(us.Password);
                    //si.SetRconPassword(us.Rcon);

                    this.serverItems.Add(si);
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

            buttonDelete.Enabled = false; 
        }

        private void AddForm_Shown(object sender, EventArgs e)
        {
            if(this.userFile.Servers.Length > 0)
            {
                workerLoad.RunWorkerAsync();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ServerItem si;
            serverIp = new ServerIp(textAddress.Text, (int)numericPort.Value);
            serverInfo = new ServerInfo(serverIp);

            if (serverInfo.Info())
            {
                si = new ServerItem(serverIp,
                                    serverInfo.Password,
                                    serverInfo.CurrentPlayers,
                                    serverInfo.MaxPlayers,
                                    serverInfo.Hostname,
                                    serverInfo.Gamemode,
                                    serverInfo.Language);

                gridListServers.BeginUpdate();
                gridListServers.DataSource = serverItems;
                //gridListServers.Update();
                gridListServers.EndUpdate();
            }
            else
            {
                si = new ServerItem(serverIp);
                
                serverItems.Add(si);
            }
           
            if(gridListServers.SelectedIndex != -1)
                buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (gridListServers.SelectedIndex != -1)
            {
                int index = gridListServers.SelectedIndex;
                ServerItem item = this.serverItems[index];
                this.serverItems.RemoveAt(index);

                gridListServers.BeginUpdate();
                gridListServers.DataSource = serverItems;
                //gridListServers.Update();
                gridListServers.EndUpdate();

                buttonDelete.Enabled = false;

                this.userFile.Delete(item.GetAddress(), item.GetPort());
                this.userFile.Write();
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
            if(workerLoad.IsBusy)
            {
                workerLoad.CancelAsync();
            }

            if(gridListServers.SelectedIndex == -1)
            {
                TitleError title = new TitleError();
                string msg = "Za promjenu servera odaberite isti sa liste prije potvrde!";

                MessageBoxAdv.Show(msg, title.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = gridListServers.SelectedIndex;
                serverIp = serverItems[index].GetServer();
                var us = this.userFile.ServerList[index];
                this.userFile.ServerList.Remove(userFile.ServerList[index]);
                this.userFile.ServerList.Insert(0, us);
            }

            if(!this.userFile.Write())
            {
                TitleError title = new TitleError();
                string msg = "Doslo je do greske prilikom spremanja server liste!";

                MessageBoxAdv.Show(msg, title.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void workerLoad_DoWork(object sender, DoWorkEventArgs e)
        {            
            BackgroundWorker bw = sender as BackgroundWorker;

            if (bw == null) return;

            foreach (var us in this.serverItems)
            {
                if(us.Info()) bw.ReportProgress(0);

                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                //System.Threading.Thread.Sleep(3000);
            }
        }

        private void workerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void workerLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            gridListServers.BeginUpdate();
            gridListServers.Update();
            gridListServers.EndUpdate();
        }        
    }
}
