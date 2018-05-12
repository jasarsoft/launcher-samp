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
        private ServerPing serverPing;
        private ServerInfo serverInfo;

        private ServerIp serverIp;
        private UserFile userFile;

    
        public MainForm()
        {
            InitializeComponent();

            statusBarMain.Text = String.Empty;
            statusBarPlayers.Text = String.Empty;
            statusBarPing.Text = String.Empty;

            timerStatus.Enabled = true;
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.userFile = new UserFile();

            if (!this.userFile.Read() || this.userFile.Servers.Length == 0)
            {
                EnterForm enter = new EnterForm();
                enter.ShowDialog();

                if (enter.Server != null)
                {
                    serverPing = new ServerPing(serverIp);
                    serverInfo = new ServerInfo(serverIp);

                    workerStatus.RunWorkerAsync(0);
                }

                return;
            }

            this.serverIp = new ServerIp(this.userFile.Servers[0].Address, this.userFile.Servers[0].Port);

            if(this.serverIp.Address == null)
            {
                EnterForm enter = new EnterForm();
                enter.ShowDialog();

                if (enter.Server != null)
                {
                    serverPing = new ServerPing(serverIp);
                    serverInfo = new ServerInfo(serverIp);

                    workerStatus.RunWorkerAsync(0);
                }

                return;
            }

            serverPing = new ServerPing(serverIp);
            serverInfo = new ServerInfo(serverIp);
            workerStatus.RunWorkerAsync(0);

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

            statusBarInfo.StartAnimation();
            
        }

        private void rolePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuleForm rule = new RuleForm();
            rule.ShowDialog();
        }
        
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workerStatus.CancelAsync();
            PlayersForm pf = new PlayersForm(serverIp);

            pf.ShowDialog();

            if (!workerStatus.IsBusy)
                workerStatus.RunWorkerAsync();
        }

        private void workerStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker == null) return;

            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if(e.Argument != null)
            {
                e.Result = serverInfo.Info() ? -1 : -2;
                return;
            }

            for (int i = 0; i < 20; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                Thread.Sleep(500);
            }

            e.Result = serverPing.Ping();
        }

        private void workerStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) return;
            if (e.Result == null) return;

            int result = (int)e.Result;

            if (result == -1)
            {
                if (timerStatus.Enabled) timerStatus.Start();
                workerStatus.RunWorkerAsync();
                return;
            }

            if (result == -2)
            {
                workerStatus.RunWorkerAsync(0);
                return;
            }

            //if (timerStatus.Enabled) timerStatus.Start();
            
            if (result == 0)
            {
                statusBarPing.ForeColor = Color.DarkOrange;
            }
            else
            {
                statusBarPing.ForeColor = Color.DarkCyan;
                statusBarPing.Text = String.Format("{0:D3}", result);
            }

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
            workerStatus.CancelAsync();

            AddForm add = new AddForm();
            add.ShowDialog();
            this.serverIp = add.Server;
            //while (workerStatus.IsBusy) Thread.Sleep(10);
            serverPing = new ServerPing(serverIp);
            serverInfo = new ServerInfo(serverIp);

            if (!workerStatus.IsBusy)
                workerStatus.RunWorkerAsync(0);
        }

        private void exitItemFileMenu_Click(object sender, EventArgs e)
        {
            workerStatus.CancelAsync();

            Application.Exit();
        }

        private void newItemFileMenu_Click(object sender, EventArgs e)
        {
            workerStatus.CancelAsync();

            EnterForm enter = new EnterForm();
            enter.ShowDialog();

            if(enter.Server != null)
            {
                serverPing = new ServerPing(serverIp);
                serverInfo = new ServerInfo(serverIp);

                if (!workerStatus.IsBusy)
                    workerStatus.RunWorkerAsync();
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (this.serverInfo == null || this.serverInfo.Hostname == null) return;

            Random rnd = new Random();

            switch (rnd.Next(3))
            {
                case 0:
                    statusBarMain.Text = String.Format("  [HOST] {0}", serverInfo.Hostname);
                    break;
                case 1:
                    statusBarMain.Text = String.Format("  [LANG] {0}", serverInfo.Language);
                    break;
                case 2:
                    statusBarMain.Text = String.Format("  [MODE] {0}", serverInfo.Gamemode);
                    break;
            }

            statusBarPlayers.Text = String.Format("{0}/{1}", serverInfo.CurrentPlayers, serverInfo.MaxPlayers);
        }
    }
}
