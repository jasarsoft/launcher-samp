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
        ServerIp serverIp;

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

            try
            {
                serverIp = new ServerIp(this.textAddress.Text, (int)this.numericPort.Value);
                if (serverIp.Address == null) throw new ArgumentNullException();

                ServerPing sp = new ServerPing(serverIp);
                if(sp.Ping() > 0)
                {
                    this.Close();
                    return;
                }
            }
            catch (Exception)
            {
                TitleError error = new TitleError();
                text = "Server adresa nije validna, pokusajte ponovo unijeti istu.";
                MessageBoxAdv.Show(text, error.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                serverIp = null;
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
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
