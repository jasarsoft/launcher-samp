#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Jasarsoft.Launcher.SAMP
{
    public partial class PlayersForm : Syncfusion.Windows.Forms.MetroForm
    {
        ServerInfo serverInfo;
        ServerPlayer serverPlayer;
        List<PlayerInfo> playerList;
        

        public PlayersForm()
        {
            InitializeComponent();

            labelPlayers.Text = "...loading";

            playerList = new List<PlayerInfo>();
        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            workerPlayers.RunWorkerAsync();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if(workerPlayers.IsBusy)
            {
                workerPlayers.CancelAsync();
            }
            
            this.Close();
        }

        private void PlayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(workerPlayers.IsBusy || !workerPlayers.CancellationPending)
            {
                workerPlayers.CancelAsync();
            }
        }

        private void workerPlayers_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker == null)
                return;

            serverInfo = new ServerInfo("193.70.72.221", 7777);
            serverPlayer = new ServerPlayer("193.70.72.221", 7777);
            
            if (serverPlayer.GetInfo())
            {
                foreach (PlayerInfo p in serverPlayer.Players)
                {
                    if(worker.CancellationPending)
                    {
                        //e.Result = false;
                        e.Cancel = true;
                        return;
                    }

                    playerList.Add(p);
                }

                e.Result = true;
            }
            else
            {
                e.Result = false;
            }
        }

        private void workerPlayers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                return;

            if ((bool)e.Result)
            {
                gridListControlPlayers.DataSource = playerList;
                if (gridListControlPlayers.Grid.ColCount == 4)
                {
                    gridListControlPlayers.Grid.ColWidths[1] = 45;
                    gridListControlPlayers.Grid.ColWidths[2] = 135;
                    gridListControlPlayers.Grid.ColWidths[3] = 59;
                    gridListControlPlayers.Grid.ColWidths[4] = 59;
                }

                workerInfo.RunWorkerAsync();
            }
            else
            {
                workerPlayers.RunWorkerAsync();
            }
        }

        private void workerInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker == null) return;

            serverInfo = new ServerInfo("193.70.72.221", 7777);

            e.Result = serverInfo.Info();
        }

        private void workerInfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                labelPlayers.Text = String.Format("{0}/{1}", serverInfo.CurrentPlayers, serverInfo.MaxPlayers);
            }
            else
            {
                workerInfo.RunWorkerAsync();
            }
        }
    }
}
