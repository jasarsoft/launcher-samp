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
        List<PlayerClient> lists;
        List<PlayerInfo> lists2;
        ServerClient client;
        ServerPlayer player;
        ServerPing serverPing;

        public PlayersForm()
        {
            InitializeComponent();

            lists = new List<PlayerClient>();
            lists2 = new List<PlayerInfo>();
            //client = new ServerClient("193.70.72.221", 7777);
            player = new ServerPlayer("193.70.72.221", 7777);
            serverPing = new ServerPing("193.70.72.221", 7777);

            workerPing.RunWorkerAsync();
        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            /*if(client.Client())
            {
                foreach(PlayerClient pc in client.Players)
                {
                    lists.Add(pc);
                }
            }*/

            if(player.GetInfo())
            {
                foreach(PlayerInfo p in player.Players)
                {
                    lists2.Add(p);
                }
            }

            gridListControlPlayers.DataSource = lists2;
            gridListControlPlayers.Grid.ColWidths[1] = 45;
            gridListControlPlayers.Grid.ColWidths[2] = 135;
            gridListControlPlayers.Grid.ColWidths[3] = 65;
            gridListControlPlayers.Grid.ColWidths[4] = 65;
            //gridListControlPlayers.Grid.ColWidths[1] = 50;
            //gridListControlPlayers.Grid.ColWidths[2] = 80;
            //gridListControlPlayers.Grid.ColWidths[3] = 80;
        }

        private void workerPing_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker != null && worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            Thread.Sleep(3000);
            e.Result = serverPing.Ping();
        }

        private void workerPing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                return;
            else
            {
                labelPingText.Text = String.Format("{0:D3}", e.Result);

                workerPing.RunWorkerAsync();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            workerPing.CancelAsync();
            this.Close();
        }

        private void PlayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!workerPing.CancellationPending)
                workerPing.CancelAsync();
        }
    }
}
