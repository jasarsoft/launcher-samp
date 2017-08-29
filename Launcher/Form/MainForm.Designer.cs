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
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLogin = new Syncfusion.Windows.Forms.ButtonAdv();
            this.textboxUser = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelUser = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.labelPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textboxPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textboxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
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
            this.serverMenu.Name = "serverMenu";
            this.serverMenu.Size = new System.Drawing.Size(51, 20);
            this.serverMenu.Text = "&Server";
            // 
            // toolsMenu
            // 
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(47, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.BeforeTouchSize = new System.Drawing.Size(320, 59);
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogin.IsBackStageButton = false;
            this.buttonLogin.Location = new System.Drawing.Point(12, 227);
            this.buttonLogin.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(320, 59);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyle = true;
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textboxUser
            // 
            this.textboxUser.BackColor = System.Drawing.Color.White;
            this.textboxUser.BeforeTouchSize = new System.Drawing.Size(214, 22);
            this.textboxUser.BorderColor = System.Drawing.Color.Gainsboro;
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
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Location = new System.Drawing.Point(12, 27);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(320, 96);
            this.pictureLogo.TabIndex = 4;
            this.pictureLogo.TabStop = false;
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
            this.autoLabel2.Location = new System.Drawing.Point(12, 212);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(320, 2);
            this.autoLabel2.TabIndex = 6;
            this.autoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ClientSize = new System.Drawing.Size(344, 298);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.textboxUser);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.DarkCyan;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAMP Launcher | Login";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textboxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxPassword)).EndInit();
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
    }
}