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
    public partial class RuleForm : Syncfusion.Windows.Forms.MetroForm
    {
        RolePlayBS rolePlay;

        public RuleForm()
        {
            InitializeComponent();

            rolePlay = new RolePlayBS();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RuleForm_Load(object sender, EventArgs e)
        {
            comboRule.Items.Clear();

            for (int i = 0; i < rolePlay.Lenght; i++)
            {
                comboRule.Items.Add(rolePlay[i]);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textRule.Text = ((RoleRule)comboRule.SelectedItem).Info;
        }
    }
}
