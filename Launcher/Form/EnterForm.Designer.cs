#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Jasarsoft.Launcher.SAMP
{
    partial class EnterForm
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
            this.numericPort = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.textAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.labelInfo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.buttonOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPort
            // 
            this.numericPort.BackColor = System.Drawing.Color.White;
            this.numericPort.BeforeTouchSize = new System.Drawing.Size(62, 22);
            this.numericPort.BorderColor = System.Drawing.Color.DarkCyan;
            this.numericPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericPort.ForeColor = System.Drawing.Color.Black;
            this.numericPort.Location = new System.Drawing.Point(225, 72);
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
            this.numericPort.TabIndex = 8;
            this.numericPort.Value = new decimal(new int[] {
            7777,
            0,
            0,
            0});
            this.numericPort.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // textAddress
            // 
            this.textAddress.BeforeTouchSize = new System.Drawing.Size(214, 22);
            this.textAddress.BorderColor = System.Drawing.Color.DarkCyan;
            this.textAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAddress.FocusBorderColor = System.Drawing.Color.Aqua;
            this.textAddress.Location = new System.Drawing.Point(12, 72);
            this.textAddress.Metrocolor = System.Drawing.Color.DarkCyan;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(207, 22);
            this.textAddress.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textAddress.TabIndex = 7;
            this.textAddress.Text = "127.0.0.1";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = false;
            this.labelInfo.Location = new System.Drawing.Point(12, 18);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(275, 42);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Molimo vas unesite u polje ispod validnu IP Adresu\r\ni Port servera, zatim potvrdi" +
    "te istu za njenu provjeru.";
            // 
            // buttonOK
            // 
            this.buttonOK.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonOK.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonOK.BeforeTouchSize = new System.Drawing.Size(275, 36);
            this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOK.IsBackStageButton = false;
            this.buttonOK.Location = new System.Drawing.Point(12, 111);
            this.buttonOK.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(275, 36);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "UREDU";
            this.buttonOK.UseVisualStyle = true;
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // autoLabel2
            // 
            this.autoLabel2.AutoSize = false;
            this.autoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.autoLabel2.Location = new System.Drawing.Point(12, 106);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(275, 2);
            this.autoLabel2.TabIndex = 14;
            this.autoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnterForm
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
            this.ClientSize = new System.Drawing.Size(299, 159);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericPort);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MetroColor = System.Drawing.Color.DarkCyan;
            this.Name = "EnterForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAMP Launcher | Enter Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericPort;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textAddress;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelInfo;
        private Syncfusion.Windows.Forms.ButtonAdv buttonOK;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
    }
}