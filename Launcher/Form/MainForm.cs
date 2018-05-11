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
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Syncfusion.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Jasarsoft.Launcher.SAMP
{
    public partial class MainForm : Syncfusion.Windows.Forms.MetroForm
    {
        private int statusShow;             //trenutni slijed prikaza u statusu
        private ServerPing serverPing;
        private ServerInfo serverInfo;

        private ServerIp serverIp;
        private UserFile userFile;

        private Task pingValue;
    
        public MainForm()
        {
            InitializeComponent();

            statusShow = 0;
            //serverIp = new ServerIp("193.70.72.221", 7777);
            //serverPing = new ServerPing(serverIp);
            //serverInfo = new ServerInfo(serverIp);
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            workerLoad.RunWorkerAsync();

            

            SampRegistry reg = new SampRegistry();

            if(reg.Valid() && reg.Read())
            {
                this.textboxUser.Text = reg.PlayerName;
            }
            else
            {
                reg.Default();
                reg.Write();
                this.textboxUser.Text = reg.PlayerName;
            }

            //workerPing.RunWorkerAsync();
            //workerStatus.RunWorkerAsync();

            statusBarInfo.StartAnimation();

            statusBarPlayers.Text = String.Format("{0}/{1}", serverInfo.CurrentPlayers, serverInfo.MaxPlayers);
        }

        private void rolePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuleForm rule = new RuleForm();
            rule.ShowDialog();
        }
        
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersForm pf = new PlayersForm(serverIp);

            pf.ShowDialog();
        }

        private void StatusPing()
        {
            int ping = serverPing.Ping();

            if(ping > 0)
            {
                statusBarPing.ForeColor = Color.DarkCyan;
                statusBarPing.Text = String.Format("{0:D3}", ping);
            }
            else
            {
                statusBarPing.ForeColor = Color.DarkOrange;
            }            
        }

        private void workerPing_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if(worker != null && worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                Thread.Sleep(1000);
            }

            e.Result = serverPing.Ping();

            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private void workerPing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                return;
            else
            {
                if ((int)e.Result > 0)
                {
                    statusBarPing.ForeColor = Color.DarkCyan;
                    statusBarPing.Text = String.Format("{0:D3}", e.Result);
                }
                else
                {
                    statusBarPing.ForeColor = Color.DarkOrange;
                }
                    
                workerPing.RunWorkerAsync();
            }
        }

        private void workerStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker != null && worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            Thread.Sleep(11333);
            if (serverInfo.Info())
            {
                if (statusShow > 3) //reset trenutnog broja prikaza
                    statusShow = 0;

                switch (statusShow++)
                {
                    case 0:
                        statusBarMain.Text = String.Format("  Host: {0}", serverInfo.Hostname);
                        break;
                    case 1:
                        statusBarMain.Text = String.Format("  Lang: {0}", serverInfo.Language);
                        break;
                    case 2:
                        statusBarMain.Text = String.Format("  Mode: {0}", serverInfo.Gamemode);
                        break;
                }

                statusBarPlayers.Text = String.Format("{0}/{1}", serverInfo.CurrentPlayers, serverInfo.MaxPlayers);
            }
        }

        private void workerStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                return;
            else
                workerStatus.RunWorkerAsync();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //UserFile uf = new UserFile();
            //uf.Read();
            //UserXml uxml = new UserXml();
            //uxml.Servers = uf.ServerList;
            //uxml.Write2();
            //uxml.Read();

            /*if (this.textboxUser.Text.Length > 0)
            {
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.FileName = "samp.exe";
                processInfo.WorkingDirectory = @".\";
                processInfo.Arguments = String.Format("{0} {1}", "IP", "PASSWORD");
                Process.Start(processInfo);
            }*/
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DEBUG
            //workerPing.CancelAsync();
            //workerStatus.CancelAsync();
            AddForm add = new AddForm();
            add.ShowDialog();
            this.serverIp = add.Server;
            //workerPing.RunWorkerAsync();
            //workerStatus.RunWorkerAsync();
#endif
        }

        private void workerLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            this.userFile = new UserFile();
            if (this.userFile.Read())
            {
                if(this.userFile.Servers.Length > 0)
                {
                    serverIp = new ServerIp(this.userFile.Servers[0].Address, this.userFile.Servers[0].Port);

                    serverPing = new ServerPing(serverIp);
                    //serverInfo = new ServerInfo(serverIp);

                    workerPing.RunWorkerAsync();
                    //workerStatus.RunWorkerAsync();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void workerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                EnterForm ef = new EnterForm();

                ef.ShowDialog();

                if (ef.Server != null)
                {
                    serverPing = new ServerPing(serverIp);
                    //serverInfo = new ServerInfo(serverIp);

                    workerPing.RunWorkerAsync();
                    //workerStatus.RunWorkerAsync();

                    //this.userFile.Default();
                }
            }

            MessageBox.Show(serverIp.Ip + serverIp.Port);
        }

        private void exitItemFileMenu_Click(object sender, EventArgs e)
        {
            if (workerPing.IsBusy)
            {
                workerPing.CancelAsync();
            }

            Application.Exit();
        }

        private void newItemFileMenu_Click(object sender, EventArgs e)
        {
            if(workerPing.IsBusy)
            {
                workerPing.CancelAsync();
            }

            EnterForm enter = new EnterForm();

            enter.ShowDialog();

            if(enter.Server != null)
            {
                serverPing = new ServerPing(serverIp);
                //serverInfo = new ServerInfo(serverIp);

                workerPing.RunWorkerAsync();
            }
        }
    }
}
