#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Jasarsoft.Launcher.SAMP
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridListServers = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.labelInfo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.numericPort = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.buttonClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdd = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonDelete = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonOK = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridListServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListServers
            // 
            this.gridListServers.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridListServers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridListServers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridListServers.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridListServers.HeaderBackColor = System.Drawing.Color.WhiteSmoke;
            this.gridListServers.HeaderTextColor = System.Drawing.Color.DarkCyan;
            this.gridListServers.ItemHeight = 20;
            this.gridListServers.Location = new System.Drawing.Point(12, 55);
            this.gridListServers.MultiColumn = true;
            this.gridListServers.Name = "gridListServers";
            this.gridListServers.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListServers.Properties.FixedLinesColor = System.Drawing.Color.DarkCyan;
            this.gridListServers.Properties.ForceImmediateRepaint = true;
            this.gridListServers.Properties.GridLineColor = System.Drawing.Color.DarkTurquoise;
            this.gridListServers.Properties.ThemedHeader = true;
            this.gridListServers.SelectedIndex = -1;
            this.gridListServers.Size = new System.Drawing.Size(509, 185);
            this.gridListServers.TabIndex = 0;
            this.gridListServers.ThemesEnabled = true;
            this.gridListServers.TopIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = false;
            this.labelInfo.Location = new System.Drawing.Point(12, 18);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(260, 22);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Unesite novi u polje ili odaberite sa liste server:";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textAddress
            // 
            this.textAddress.BeforeTouchSize = new System.Drawing.Size(175, 22);
            this.textAddress.BorderColor = System.Drawing.Color.DarkCyan;
            this.textAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAddress.FocusBorderColor = System.Drawing.Color.Aqua;
            this.textAddress.Location = new System.Drawing.Point(278, 18);
            this.textAddress.Metrocolor = System.Drawing.Color.DarkCyan;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(175, 22);
            this.textAddress.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textAddress.TabIndex = 4;
            this.textAddress.Text = "127.0.0.1";
            // 
            // numericPort
            // 
            this.numericPort.BackColor = System.Drawing.Color.White;
            this.numericPort.BeforeTouchSize = new System.Drawing.Size(62, 22);
            this.numericPort.BorderColor = System.Drawing.Color.DarkCyan;
            this.numericPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericPort.ForeColor = System.Drawing.Color.Black;
            this.numericPort.Location = new System.Drawing.Point(459, 18);
            this.numericPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericPort.MetroColor = System.Drawing.Color.DarkCyan;
            this.numericPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(62, 22);
            this.numericPort.TabIndex = 5;
            this.numericPort.Value = new decimal(new int[] {
            7777,
            0,
            0,
            0});
            this.numericPort.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // buttonClose
            // 
            this.buttonClose.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonClose.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClose.BeforeTouchSize = new System.Drawing.Size(75, 32);
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.IsBackStageButton = false;
            this.buttonClose.Location = new System.Drawing.Point(446, 256);
            this.buttonClose.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 32);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyle = true;
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.BeforeTouchSize = new System.Drawing.Size(75, 32);
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdd.IsBackStageButton = false;
            this.buttonAdd.Location = new System.Drawing.Point(12, 256);
            this.buttonAdd.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 32);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyle = true;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDelete.BeforeTouchSize = new System.Drawing.Size(75, 32);
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.IsBackStageButton = false;
            this.buttonDelete.Location = new System.Drawing.Point(93, 256);
            this.buttonDelete.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 32);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyle = true;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonOK.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonOK.BeforeTouchSize = new System.Drawing.Size(95, 32);
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOK.IsBackStageButton = false;
            this.buttonOK.Location = new System.Drawing.Point(345, 256);
            this.buttonOK.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 32);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyle = true;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderColor = System.Drawing.Color.DarkCyan;
            this.BorderThickness = 4;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.DarkCyan;
            this.CaptionBarHeight = 24;
            this.CaptionButtonColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaptionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.numericPort);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.gridListServers);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.MetroColor = System.Drawing.Color.DarkCyan;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SAMP Launcher | Add Server";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridListControl gridListServers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelInfo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textAddress;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericPort;
        private Syncfusion.Windows.Forms.ButtonAdv buttonClose;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdd;
        private Syncfusion.Windows.Forms.ButtonAdv buttonDelete;
        private Syncfusion.Windows.Forms.ButtonAdv buttonOK;
    }
}