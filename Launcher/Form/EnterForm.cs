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
using Syncfusion.Windows.Forms;

namespace Jasarsoft.Launcher.SAMP
{
    public partial class EnterForm : Syncfusion.Windows.Forms.MetroForm
    {
        private ServerIp serverIp;
        private UserFile userFile;

        public EnterForm()
        {
            InitializeComponent();
        }


        public ServerIp Server
        {
            get { return this.serverIp; }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string text;

            this.serverIp = new ServerIp(this.textAddress.Text, (int)this.numericPort.Value);

            if(this.serverIp.Address == null)
            {
                TitleError error = new TitleError();
                text = "Server adresa nije validna, pokusajte ponovo unijeti istu.";
                MessageBoxAdv.Show(text, error.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                serverIp = null;
                return;
            }

            ServerPing sp = new ServerPing(serverIp);
            if (sp.Ping() > 0)
            {
                this.userFile.ServerList.Add(new UserServer(this.textAddress.Text, (int)this.numericPort.Value));
                this.userFile.Write();
                this.Close();
                return;
            }

            TitleWarning warn = new TitleWarning();
            text = "Server nije odgovorio na zahtjev, pokusajte ponovo potvrditi!";
            MessageBoxAdv.Show(text, warn.Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void EnterForm_FormClosed(object sender, FormClosedEventArgs e)
        {            
           //Application.Exit();
        }

        private void EnterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason != CloseReason.UserClosing;
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            this.userFile = new UserFile();

            if(!this.userFile.Read()) this.userFile.Default();
        }
    }
}
