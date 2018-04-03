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

namespace Jasarsoft.Launcher.SAMP
{
    public partial class MainForm : Syncfusion.Windows.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
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
        }

        private void rolePlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RuleForm rule = new RuleForm();
            rule.ShowDialog();
        }
    }
}
