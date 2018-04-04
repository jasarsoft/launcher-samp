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

namespace Jasarsoft.Launcher.SAMP
{
    public partial class MainForm : Syncfusion.Windows.Forms.MetroForm
    {
        ServerPing serverPing;
        ServerInfo serverInfo;

        public MainForm()
        {
            InitializeComponent();

            serverPing = new ServerPing("127.0.0.1", 7777);
            serverInfo = new ServerInfo("127.0.0.1", 7777);
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
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

            workerPing.RunWorkerAsync();

            statusBarInfo.StartAnimation();
            timerStatus.Start();

            statusBarPlayers.Text = String.Format("{0}/{1}", serverInfo.CurrentPlayers, serverInfo.MaxPlayers);
        }

        private void rolePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuleForm rule = new RuleForm();
            rule.ShowDialog();
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if(serverInfo.Info())
            {
                Random rnd = new Random();
                switch(rnd.Next(2))
                {
                    case 0:
                        statusBarMain.Text = String.Format("  Server hostname: {0}", serverInfo.Hostname);
                        break;
                    case 1:
                        statusBarMain.Text = String.Format("  Server language: {0}", serverInfo.Language);
                        break;
                    case 2:
                        statusBarMain.Text = String.Format("  Server gamemode: {0}", serverInfo.Gamemode);
                        break;
                }

                statusBarPlayers.Text = String.Format("{0}/{1}", serverInfo.CurrentPlayers, serverInfo.MaxPlayers);
            }
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersForm pf = new PlayersForm();

            pf.ShowDialog();
        }

        private void workerPing_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if(worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            Thread.Sleep(1000);
            e.Result = serverPing.Ping();
        }

        private void workerPing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                return;
            else
            {
                statusBarPing.Text = String.Format("{0:D3}", e.Result);
                
                workerPing.RunWorkerAsync();
            }
        }
    }
}
