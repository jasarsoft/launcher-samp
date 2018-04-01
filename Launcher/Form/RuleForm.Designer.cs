#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Jasarsoft.Launcher.SAMP
{
    partial class RuleForm
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
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.textRule = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboRule = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboRule)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(320, 96);
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // textRule
            // 
            this.textRule.BackColor = System.Drawing.Color.White;
            this.textRule.BeforeTouchSize = new System.Drawing.Size(320, 96);
            this.textRule.BorderColor = System.Drawing.Color.Gainsboro;
            this.textRule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRule.FocusBorderColor = System.Drawing.Color.DarkCyan;
            this.textRule.ForeColor = System.Drawing.Color.Black;
            this.textRule.Location = new System.Drawing.Point(12, 159);
            this.textRule.MaxLength = 1024;
            this.textRule.Metrocolor = System.Drawing.Color.Gainsboro;
            this.textRule.Multiline = true;
            this.textRule.Name = "textRule";
            this.textRule.ReadOnly = true;
            this.textRule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRule.Size = new System.Drawing.Size(320, 96);
            this.textRule.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.textRule.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonClose.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonClose.BeforeTouchSize = new System.Drawing.Size(320, 59);
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.IsBackStageButton = false;
            this.buttonClose.Location = new System.Drawing.Point(12, 270);
            this.buttonClose.MetroColor = System.Drawing.Color.DarkCyan;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(320, 59);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyle = true;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // comboRule
            // 
            this.comboRule.BackColor = System.Drawing.Color.White;
            this.comboRule.BeforeTouchSize = new System.Drawing.Size(320, 21);
            this.comboRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRule.FlatBorderColor = System.Drawing.Color.LightGray;
            this.comboRule.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboRule.ForeColor = System.Drawing.Color.Black;
            this.comboRule.Location = new System.Drawing.Point(12, 123);
            this.comboRule.MaxDropDownItems = 7;
            this.comboRule.MaxLength = 1024;
            this.comboRule.MetroBorderColor = System.Drawing.Color.Gainsboro;
            this.comboRule.MetroColor = System.Drawing.Color.DarkCyan;
            this.comboRule.Name = "comboRule";
            this.comboRule.Size = new System.Drawing.Size(320, 21);
            this.comboRule.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboRule.TabIndex = 1;
            this.comboRule.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // RuleForm
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
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaptionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(344, 341);
            this.ControlBox = false;
            this.Controls.Add(this.comboRule);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textRule);
            this.Controls.Add(this.pictureLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.DarkCyan;
            this.MinimizeBox = false;
            this.Name = "RuleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAMP Launcher | Rules";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RuleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboRule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textRule;
        private Syncfusion.Windows.Forms.ButtonAdv buttonClose;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboRule;
    }
}