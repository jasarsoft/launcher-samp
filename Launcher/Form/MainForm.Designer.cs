#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Jasarsoft.Launcher.SAMP
{
    partial class MainForm
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.serverMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.forumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.teamSpeakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rolePlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.launcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLogin = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textboxUser = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.labelUser = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textboxPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.statusBarAdv1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.statusBarMain = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarPlayers = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarPing = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.statusBarInfo = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.workerPing = new System.ComponentModel.BackgroundWorker();
            this.workerStatus = new System.ComponentModel.BackgroundWorker();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textboxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).BeginInit();
            this.statusBarAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.serverMenu,
            this.toolsMenu,
            this.helpMenu});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.ShowItemToolTips = true;
            this.menuMain.Size = new System.Drawing.Size(344, 24);
            this.menuMain.TabIndex = 1;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // editMenu
            // 
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // serverMenu
            // 
            this.serverMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forumToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.toolStripSeparator2,
            this.youTubeToolStripMenuItem,
            this.facebookToolStripMenuItem,
            this.toolStripSeparator3,
            this.teamSpeakToolStripMenuItem});
            this.serverMenu.Name = "serverMenu";
            this.serverMenu.Size = new System.Drawing.Size(51, 20);
            this.serverMenu.Text = "&Server";
            // 
            // forumToolStripMenuItem
            // 
            this.forumToolStripMenuItem.Name = "forumToolStripMenuItem";
            this.forumToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.forumToolStripMenuItem.Text = "&Forum";
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.websiteToolStripMenuItem.Text = "&Website";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.youTubeToolStripMenuItem.Text = "&YouTube";
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.facebookToolStripMenuItem.Text = "Face&book";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
            // 
            // teamSpeakToolStripMenuItem
            // 
            this.teamSpeakToolStripMenuItem.Name = "teamSpeakToolStripMenuItem";
            this.teamSpeakToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.teamSpeakToolStripMenuItem.Text = "&Team Speak";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(48, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.playersToolStripMenuItem.Text = "&Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolePlayToolStripMenuItem,
            this.toolStripSeparator1,
            this.launcherToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // rolePlayToolStripMenuItem
            // 
            this.rolePlayToolStripMenuItem.Name = "rolePlayToolStripMenuItem";
            this.rolePlayToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.rolePlayToolStripMenuItem.Text = "&RolePlay";
            this.rolePlayToolStripMenuItem.Click += new System.EventHandler(this.rolePlayToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // launcherToolStripMenuItem
            // 
            this.launcherToolStripMenuItem.Name = "launcherToolStripMenuItem";
            this.launcherToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.launcherToolStripMenuItem.Text = "&Launcher";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.BeforeTouchSize = new System.Drawing.Size(320, 59);
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogin.IsBackStageButton = false;
            this.buttonLogin.Location = new System.Drawing.Point(12, 232);
            this.buttonLogin.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(320, 59);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyle = true;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textboxUser
            // 
            this.textboxUser.BackColor = System.Drawing.Color.White;
            this.textboxUser.BeforeTouchSize = new System.Drawing.Size(214, 22);
            this.textboxUser.BorderColor = System.Drawing.Color.Gainsboro;
            this.textboxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxUser.FocusBorderColor = System.Drawing.Color.DarkCyan;
            this.textboxUser.ForeColor = System.Drawing.Color.Black;
            this.textboxUser.Location = new System.Drawing.Point(118, 138);
            this.textboxUser.MaxLength = 24;
            this.textboxUser.Metrocolor = System.Drawing.Color.Gainsboro;
            this.textboxUser.Name = "textboxUser";
            this.textboxUser.Size = new System.Drawing.Size(214, 22);
            this.textboxUser.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textboxUser.TabIndex = 4;
            this.textboxUser.Text = "User_Name";
            this.textboxUser.WordWrap = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = false;
            this.labelUser.Location = new System.Drawing.Point(12, 138);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(100, 22);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User Name:";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = false;
            this.labelPassword.Location = new System.Drawing.Point(12, 175);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 22);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Server Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.Color.White;
            this.textboxPassword.BeforeTouchSize = new System.Drawing.Size(214, 22);
            this.textboxPassword.BorderColor = System.Drawing.Color.Gainsboro;
            this.textboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxPassword.FocusBorderColor = System.Drawing.Color.DarkCyan;
            this.textboxPassword.ForeColor = System.Drawing.Color.Black;
            this.textboxPassword.Location = new System.Drawing.Point(118, 175);
            this.textboxPassword.MaxLength = 64;
            this.textboxPassword.Metrocolor = System.Drawing.Color.Gainsboro;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(214, 22);
            this.textboxPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textboxPassword.TabIndex = 5;
            this.textboxPassword.Text = "Password";
            this.textboxPassword.WordWrap = false;
            // 
            // autoLabel2
            // 
            this.autoLabel2.AutoSize = false;
            this.autoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.autoLabel2.Location = new System.Drawing.Point(12, 227);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(320, 2);
            this.autoLabel2.TabIndex = 6;
            this.autoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusBarAdv1
            // 
            this.statusBarAdv1.BeforeTouchSize = new System.Drawing.Size(344, 22);
            this.statusBarAdv1.BorderColor = System.Drawing.Color.DimGray;
            this.statusBarAdv1.BorderSides = System.Windows.Forms.Border3DSide.Top;
            this.statusBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBarAdv1.Controls.Add(this.statusBarMain);
            this.statusBarAdv1.Controls.Add(this.statusBarPlayers);
            this.statusBarAdv1.Controls.Add(this.statusBarPing);
            this.statusBarAdv1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv1.Location = new System.Drawing.Point(0, 297);
            this.statusBarAdv1.Name = "statusBarAdv1";
            this.statusBarAdv1.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv1.Size = new System.Drawing.Size(344, 22);
            this.statusBarAdv1.SizingGrip = false;
            this.statusBarAdv1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv1.TabIndex = 10;
            // 
            // statusBarMain
            // 
            this.statusBarMain.AutoScroll = true;
            this.statusBarMain.BackColor = System.Drawing.Color.Transparent;
            this.statusBarMain.BeforeTouchSize = new System.Drawing.Size(219, 16);
            this.statusBarMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarMain.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusBarMain.ForeColor = System.Drawing.Color.DimGray;
            this.statusBarMain.IsMarquee = true;
            this.statusBarMain.Location = new System.Drawing.Point(0, 2);
            this.statusBarMain.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.PreferredSize = new System.Drawing.Size(295, 16);
            this.statusBarMain.Size = new System.Drawing.Size(219, 16);
            this.statusBarMain.TabIndex = 0;
            this.statusBarMain.Text = "  Server: 127.0.0.1:7777";
            // 
            // statusBarPlayers
            // 
            this.statusBarPlayers.BackColor = System.Drawing.Color.Transparent;
            this.statusBarPlayers.BeforeTouchSize = new System.Drawing.Size(60, 16);
            this.statusBarPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarPlayers.ForeColor = System.Drawing.Color.Black;
            this.statusBarPlayers.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right;
            this.statusBarPlayers.Location = new System.Drawing.Point(245, 2);
            this.statusBarPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarPlayers.Name = "statusBarPlayers";
            this.statusBarPlayers.Size = new System.Drawing.Size(60, 16);
            this.statusBarPlayers.TabIndex = 1;
            this.statusBarPlayers.Text = "500/1000";
            this.statusBarPlayers.ToolTip = "Trenutno stanje igraèa na serveru";
            // 
            // statusBarPing
            // 
            this.statusBarPing.BackColor = System.Drawing.Color.Transparent;
            this.statusBarPing.BeforeTouchSize = new System.Drawing.Size(28, 16);
            this.statusBarPing.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.statusBarPing.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.statusBarPing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarPing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusBarPing.ForeColor = System.Drawing.Color.DarkCyan;
            this.statusBarPing.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right;
            this.statusBarPing.Location = new System.Drawing.Point(307, 2);
            this.statusBarPing.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarPing.Name = "statusBarPing";
            this.statusBarPing.Size = new System.Drawing.Size(28, 16);
            this.statusBarPing.TabIndex = 1;
            this.statusBarPing.Text = "000";
            this.statusBarPing.ToolTip = "Server ping vrijednost";
            // 
            // statusBarInfo
            // 
            this.statusBarInfo.AnimationDelay = 1;
            this.statusBarInfo.AutoScroll = true;
            this.statusBarInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusBarInfo.BeforeTouchSize = new System.Drawing.Size(320, 18);
            this.statusBarInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBarInfo.ForeColor = System.Drawing.Color.DimGray;
            this.statusBarInfo.IsMarquee = true;
            this.statusBarInfo.Location = new System.Drawing.Point(12, 209);
            this.statusBarInfo.Margin = new System.Windows.Forms.Padding(0);
            this.statusBarInfo.Name = "statusBarInfo";
            this.statusBarInfo.Size = new System.Drawing.Size(320, 18);
            this.statusBarInfo.TabIndex = 11;
            this.statusBarInfo.Text = "Trenutna korisnicki postavljena obavjestenja servera koja se ucitavaju iz baze po" +
    "dataka.";
            this.statusBarInfo.ToolTip = "Trenutna obavjestenja servera";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Image = global::Jasarsoft.Launcher.SAMP.Properties.Resources.gtasa_cover;
            this.pictureLogo.Location = new System.Drawing.Point(12, 27);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(320, 96);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 4;
            this.pictureLogo.TabStop = false;
            // 
            // workerPing
            // 
            this.workerPing.WorkerSupportsCancellation = true;
            this.workerPing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerPing_DoWork);
            this.workerPing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerPing_RunWorkerCompleted);
            // 
            // workerStatus
            // 
            this.workerStatus.WorkerSupportsCancellation = true;
            this.workerStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerStatus_DoWork);
            this.workerStatus.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerStatus_RunWorkerCompleted);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // MainForm
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
            this.ClientSize = new System.Drawing.Size(344, 319);
            this.Controls.Add(this.statusBarInfo);
            this.Controls.Add(this.statusBarAdv1);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.textboxUser);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.DarkCyan;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAMP Launcher | Login";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textboxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).EndInit();
            this.statusBarAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private Syncfusion.Windows.Forms.ButtonAdv buttonLogin;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textboxUser;
        private System.Windows.Forms.PictureBox pictureLogo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelUser;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelPassword;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textboxPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem serverMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem forumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem teamSpeakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolePlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem launcherToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv1;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarMain;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarPlayers;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarPing;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarInfo;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker workerPing;
        private System.ComponentModel.BackgroundWorker workerStatus;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}