#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Jasarsoft.Launcher.SAMP
{
    partial class PlayersForm
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
            this.gridListControlPlayers = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.labelInfo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.buttonClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.workerPlayers = new System.ComponentModel.BackgroundWorker();
            this.labelPlayers = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.workerInfo = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControlPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListControlPlayers
            // 
            this.gridListControlPlayers.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridListControlPlayers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridListControlPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridListControlPlayers.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridListControlPlayers.HeaderBackColor = System.Drawing.Color.Gainsboro;
            this.gridListControlPlayers.HeaderTextColor = System.Drawing.Color.Black;
            this.gridListControlPlayers.ItemHeight = 17;
            this.gridListControlPlayers.Location = new System.Drawing.Point(12, 43);
            this.gridListControlPlayers.MultiColumn = true;
            this.gridListControlPlayers.Name = "gridListControlPlayers";
            this.gridListControlPlayers.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListControlPlayers.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridListControlPlayers.SelectedIndex = -1;
            this.gridListControlPlayers.Size = new System.Drawing.Size(320, 230);
            this.gridListControlPlayers.TabIndex = 0;
            this.gridListControlPlayers.ThemesEnabled = true;
            this.gridListControlPlayers.TopIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = false;
            this.labelInfo.Location = new System.Drawing.Point(12, 18);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(249, 22);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Detaljna lista igraèa:";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonClose
            // 
            this.buttonClose.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonClose.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClose.BeforeTouchSize = new System.Drawing.Size(320, 59);
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.IsBackStageButton = false;
            this.buttonClose.Location = new System.Drawing.Point(12, 288);
            this.buttonClose.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(320, 59);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyle = true;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // workerPlayers
            // 
            this.workerPlayers.WorkerSupportsCancellation = true;
            this.workerPlayers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerPlayers_DoWork);
            this.workerPlayers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerPlayers_RunWorkerCompleted);
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = false;
            this.labelPlayers.Location = new System.Drawing.Point(267, 18);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(65, 22);
            this.labelPlayers.TabIndex = 9;
            this.labelPlayers.Text = "500/1000";
            this.labelPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // workerInfo
            // 
            this.workerInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerInfo_DoWork);
            this.workerInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerInfo_RunWorkerCompleted);
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderColor = System.Drawing.Color.DarkCyan;
            this.BorderThickness = 6;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.DarkCyan;
            this.CaptionBarHeight = 24;
            this.CaptionButtonColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaptionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(344, 359);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.gridListControlPlayers);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(128, 128);
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.DarkCyan;
            this.Name = "PlayersForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SAMP Launcher | Players";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayersForm_FormClosing);
            this.Shown += new System.EventHandler(this.PlayersForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridListControlPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridListControl gridListControlPlayers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelInfo;
        private Syncfusion.Windows.Forms.ButtonAdv buttonClose;
        private System.ComponentModel.BackgroundWorker workerPlayers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelPlayers;
        private System.ComponentModel.BackgroundWorker workerInfo;
    }
}