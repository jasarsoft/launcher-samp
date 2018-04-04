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
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.labelHostname = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelGamemode = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelPlayers = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelAddress = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelLang = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelPing = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelHostnameText = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelGamemodeText = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelPlayersText = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelAddressText = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelLangText = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelPingText = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControlPlayers)).BeginInit();
            this.groupBoxServer.SuspendLayout();
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
            this.gridListControlPlayers.Size = new System.Drawing.Size(332, 230);
            this.gridListControlPlayers.TabIndex = 0;
            this.gridListControlPlayers.ThemesEnabled = true;
            this.gridListControlPlayers.TopIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = false;
            this.labelInfo.Location = new System.Drawing.Point(12, 18);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(332, 22);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Detaljna lista igraca na serveru";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonClose
            // 
            this.buttonClose.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonClose.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClose.BeforeTouchSize = new System.Drawing.Size(336, 44);
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.IsBackStageButton = false;
            this.buttonClose.Location = new System.Drawing.Point(350, 229);
            this.buttonClose.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(336, 44);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyle = true;
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.labelPingText);
            this.groupBoxServer.Controls.Add(this.labelLangText);
            this.groupBoxServer.Controls.Add(this.labelAddressText);
            this.groupBoxServer.Controls.Add(this.labelPlayersText);
            this.groupBoxServer.Controls.Add(this.labelGamemodeText);
            this.groupBoxServer.Controls.Add(this.labelHostnameText);
            this.groupBoxServer.Controls.Add(this.labelPing);
            this.groupBoxServer.Controls.Add(this.labelLang);
            this.groupBoxServer.Controls.Add(this.labelAddress);
            this.groupBoxServer.Controls.Add(this.labelPlayers);
            this.groupBoxServer.Controls.Add(this.labelGamemode);
            this.groupBoxServer.Controls.Add(this.labelHostname);
            this.groupBoxServer.Location = new System.Drawing.Point(350, 43);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(336, 172);
            this.groupBoxServer.TabIndex = 9;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Server Information";
            // 
            // labelHostname
            // 
            this.labelHostname.AutoSize = false;
            this.labelHostname.Location = new System.Drawing.Point(6, 28);
            this.labelHostname.Name = "labelHostname";
            this.labelHostname.Size = new System.Drawing.Size(85, 22);
            this.labelHostname.TabIndex = 3;
            this.labelHostname.Text = "Hostname:";
            this.labelHostname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGamemode
            // 
            this.labelGamemode.AutoSize = false;
            this.labelGamemode.Location = new System.Drawing.Point(6, 50);
            this.labelGamemode.Name = "labelGamemode";
            this.labelGamemode.Size = new System.Drawing.Size(85, 22);
            this.labelGamemode.TabIndex = 4;
            this.labelGamemode.Text = "Gamemode:";
            this.labelGamemode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = false;
            this.labelPlayers.Location = new System.Drawing.Point(6, 72);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(85, 22);
            this.labelPlayers.TabIndex = 5;
            this.labelPlayers.Text = "Players:";
            this.labelPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = false;
            this.labelAddress.Location = new System.Drawing.Point(6, 94);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(85, 22);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "IP Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = false;
            this.labelLang.Location = new System.Drawing.Point(6, 116);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(85, 22);
            this.labelLang.TabIndex = 7;
            this.labelLang.Text = "Language:";
            this.labelLang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPing
            // 
            this.labelPing.AutoSize = false;
            this.labelPing.Location = new System.Drawing.Point(6, 138);
            this.labelPing.Name = "labelPing";
            this.labelPing.Size = new System.Drawing.Size(85, 22);
            this.labelPing.TabIndex = 8;
            this.labelPing.Text = "Current Ping:";
            this.labelPing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHostnameText
            // 
            this.labelHostnameText.AutoSize = false;
            this.labelHostnameText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelHostnameText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHostnameText.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHostnameText.Location = new System.Drawing.Point(97, 28);
            this.labelHostnameText.Name = "labelHostnameText";
            this.labelHostnameText.Size = new System.Drawing.Size(225, 22);
            this.labelHostnameText.TabIndex = 9;
            this.labelHostnameText.Text = "Los Balkan RPG/DM [www.los-balkan]";
            this.labelHostnameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGamemodeText
            // 
            this.labelGamemodeText.AutoSize = false;
            this.labelGamemodeText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelGamemodeText.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGamemodeText.Location = new System.Drawing.Point(97, 50);
            this.labelGamemodeText.Name = "labelGamemodeText";
            this.labelGamemodeText.Size = new System.Drawing.Size(225, 22);
            this.labelGamemodeText.TabIndex = 10;
            this.labelGamemodeText.Text = "RPG/DM 2.9.1 - Theo";
            this.labelGamemodeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlayersText
            // 
            this.labelPlayersText.AutoSize = false;
            this.labelPlayersText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelPlayersText.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayersText.Location = new System.Drawing.Point(97, 72);
            this.labelPlayersText.Name = "labelPlayersText";
            this.labelPlayersText.Size = new System.Drawing.Size(225, 22);
            this.labelPlayersText.TabIndex = 11;
            this.labelPlayersText.Text = "64/300";
            this.labelPlayersText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAddressText
            // 
            this.labelAddressText.AutoSize = false;
            this.labelAddressText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelAddressText.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddressText.Location = new System.Drawing.Point(97, 94);
            this.labelAddressText.Name = "labelAddressText";
            this.labelAddressText.Size = new System.Drawing.Size(225, 22);
            this.labelAddressText.TabIndex = 12;
            this.labelAddressText.Text = "5.230.21.34:7780";
            this.labelAddressText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLangText
            // 
            this.labelLangText.AutoSize = false;
            this.labelLangText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelLangText.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLangText.Location = new System.Drawing.Point(97, 116);
            this.labelLangText.Name = "labelLangText";
            this.labelLangText.Size = new System.Drawing.Size(225, 22);
            this.labelLangText.TabIndex = 13;
            this.labelLangText.Text = "HR/BiH/SR";
            this.labelLangText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPingText
            // 
            this.labelPingText.AutoSize = false;
            this.labelPingText.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelPingText.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPingText.Location = new System.Drawing.Point(97, 138);
            this.labelPingText.Name = "labelPingText";
            this.labelPingText.Size = new System.Drawing.Size(225, 22);
            this.labelPingText.TabIndex = 14;
            this.labelPingText.Text = "31";
            this.labelPingText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayersForm
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
            this.ClientSize = new System.Drawing.Size(698, 285);
            this.Controls.Add(this.groupBoxServer);
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
            this.Load += new System.EventHandler(this.PlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListControlPlayers)).EndInit();
            this.groupBoxServer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridListControl gridListControlPlayers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelInfo;
        private Syncfusion.Windows.Forms.ButtonAdv buttonClose;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelHostnameText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelPing;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelLang;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelAddress;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelPlayers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelGamemode;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelHostname;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelPingText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelLangText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelAddressText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelPlayersText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelGamemodeText;
    }
}