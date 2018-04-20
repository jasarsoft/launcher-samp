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

namespace Jasarsoft.Launcher.SAMP
{
    public partial class MainForm : Syncfusion.Windows.Forms.MetroForm
    {
        private int statusShow;             //trenutni slijed prikaza u statusu
        private ServerPing serverPing;
        private ServerInfo serverInfo;

        private ServerIp serverIp;
    
        public MainForm()
        {
            InitializeComponent();

            statusShow = 0;
            serverIp = new ServerIp("193.70.72.221", 7777);
            serverPing = new ServerPing(serverIp);
            serverInfo = new ServerInfo(serverIp);
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
            workerStatus.RunWorkerAsync();

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

        private void workerPing_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if(worker != null && worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            Thread.Sleep(2500);
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
                        statusBarMain.Text = String.Format("  Hostname: {0}", serverInfo.Hostname);
                        break;
                    case 1:
                        statusBarMain.Text = String.Format("  Language: {0}", serverInfo.Language);
                        break;
                    case 2:
                        statusBarMain.Text = String.Format("  Gamemode: {0}", serverInfo.Gamemode);
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
        }

        private bool CheckUserName(string name)
        {
            return true;
            if (name.ToLower() == "ime_prezime")
            {
                //MessageTitle title = new MessageTitle();

                string message = "Korisnièko ime ne može biti poèetno postaljeno (Ime_Prezime).\n" +
                                 "Unesite vaše korisnièko za prijavu na server formata 'Ime_Prezime'.";

                //MessageBoxAdv.Show(message, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }

            /*
            if (this.textName.Text.Length < 4)
            {
                MessageTitle title = new MessageTitle();
                string text = "Korisnièko ime mora sadržavati najmanje 4 karaktera.\nFormat korisnièkog imena mora biti 'Ime_Prezime'.";
                MessageBoxAdv.Show(text, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textName.Text = "Ime_Prezime";
                //this.Show();
                return;
            }

            if (this.textName.Text.Length > 21)
            {
                MessageTitle title = new MessageTitle();
                string text = "Korisnièko ime može imati najviše 21 karakter.\nFormat korisnièkog imena mora biti 'Ime_Prezime'.";
                MessageBoxAdv.Show(text, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textName.Text = "Ime_Prezime";
                //this.Show();
                return;
            }*/

            //if (!this.textName.Text.Contains("_"))
            //{
            //    MessageTitle title = new MessageTitle();
            //    string text = "Korisnièko ime mora sadržavati znak '_' u sebi.\nFormat korisnièkog imena mora biti 'Ime_Prezime'.";
            //    MessageBoxAdv.Show(text, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.textName.Text = "Ime_Prezime";
            //    //this.Show();
            //    return;
            //}

            //if (this.textName.Text.Contains("_"))
            //{
            //    string temp = this.textName.Text.Remove(this.textName.Text.IndexOf("_"), 1);
            //    if (temp.Contains("_"))
            //    {
            //        MessageTitle title = new MessageTitle();
            //        string text = "Korisnièko ime može samo sadržavati jednu donju-crtu '_'.\nFormat korisnièkog imena mora biti 'Ime_Prezime'.";
            //        MessageBoxAdv.Show(text, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        this.textName.Text = "Ime_Prezime";
            //        //this.Show();
            //        return;
            //    }
            //}

            //if (!Regex.IsMatch(this.textName.Text, @"^[a-zA-Z_]+$"))
            //{
            //    MessageTitle title = new MessageTitle();
            //    string text = String.Format("Korisnièko ime može sadržavati samo slova i znak donje-crte '_'.\nFormat korisnièkog imena mora biti 'Ime_Prezime', maksimalne dužine 21 karakter.");
            //    MessageBoxAdv.Show(text, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.textName.Text = "Ime_Prezime";
            //    return;
            //}

            //string name = this.textName.Text.Substring(0, this.textName.Text.IndexOf("_"));
            //string surname = this.textName.Text.Substring(this.textName.Text.IndexOf("_") + 1);

            //if (name.Length < 3 || surname.Length < 4)
            //{
            //    MessageTitle title = new MessageTitle();
            //    string text = "Dio 'Ime' može imati najamnje 3 slova, dok 'Prezime' najmanje 4 slova.\nFormat korisnièkog imena mora biti 'Ime_Prezime', maksimalne dužine 21 karakter.";
            //    MessageBoxAdv.Show(text, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.textName.Text = "Ime_Prezime";
            //    //this.Show();
            //    return;
            //}

            //if (name.Substring(0, 1) != name.Substring(0, 1).ToUpper())
            //{
            //    MessageTitle title = new MessageTitle();
            //    string text =String.Format("Dio '{0}' mora poèinjati velikim slovom.\nFormat korisnièkog imena mora biti 'Ime_Prezime'.", name);
            //    MessageBoxAdv.Show(text, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.textName.Text = "Ime_Prezime";
            //    return;
            //}

            //if (surname.Substring(0, 1) != surname.Substring(0, 1).ToUpper())
            //{
            //    MessageTitle title = new MessageTitle();
            //    string text = String.Format("Dio '{0}' mora poèinjati velikim slovom.\nFormat korisnièkog imena mora biti 'Ime_Prezime'.", surname);
            //    MessageBoxAdv.Show(text, title.ErrorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.textName.Text = "Ime_Prezime";
            //    return;
            //}
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DEBUG
            //workerPing.CancelAsync();
            //workerStatus.CancelAsync();
            AddForm add = new AddForm();
            add.ShowDialog();
            //workerPing.RunWorkerAsync();
            //workerStatus.RunWorkerAsync();
#endif
        }
    }
}
