#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Jasarsoft.Launcher.SAMP
{
    partial class CheckForm
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
            this.progressLoad = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.labelName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.progressLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // progressLoad
            // 
            this.progressLoad.BackGradientEndColor = System.Drawing.Color.Gainsboro;
            this.progressLoad.BackGradientStartColor = System.Drawing.Color.Gainsboro;
            this.progressLoad.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.progressLoad.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressLoad.BackSegments = false;
            this.progressLoad.BackTubeEndColor = System.Drawing.Color.Gainsboro;
            this.progressLoad.BackTubeStartColor = System.Drawing.Color.Gainsboro;
            this.progressLoad.BorderColor = System.Drawing.Color.DarkCyan;
            this.progressLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressLoad.CustomText = null;
            this.progressLoad.CustomWaitingRender = false;
            this.progressLoad.FontColor = System.Drawing.Color.WhiteSmoke;
            this.progressLoad.ForegroundImage = null;
            this.progressLoad.GradientEndColor = System.Drawing.Color.Teal;
            this.progressLoad.GradientStartColor = System.Drawing.Color.Aqua;
            this.progressLoad.Location = new System.Drawing.Point(12, 148);
            this.progressLoad.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressLoad.Name = "progressLoad";
            this.progressLoad.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.progressLoad.SegmentWidth = 10;
            this.progressLoad.Size = new System.Drawing.Size(320, 23);
            this.progressLoad.Step = 1;
            this.progressLoad.TabIndex = 2;
            this.progressLoad.ThemesEnabled = false;
            this.progressLoad.TubeEndColor = System.Drawing.Color.Teal;
            this.progressLoad.TubeStartColor = System.Drawing.Color.Aqua;
            this.progressLoad.WaitingGradientWidth = 320;
            // 
            // labelName
            // 
            this.labelName.AutoSize = false;
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(12, 123);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(320, 22);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "File Name...";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Image = global::Jasarsoft.Launcher.SAMP.Properties.Resources.gtasa_cover;
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(320, 96);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 8;
            this.pictureLogo.TabStop = false;
            // 
            // CheckForm
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
            this.ClientSize = new System.Drawing.Size(344, 183);
            this.ControlBox = false;
            this.Controls.Add(this.progressLoad);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.DarkCyan;
            this.MinimizeBox = false;
            this.Name = "CheckForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAMP Launcher | Checking...";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.progressLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressLoad;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelName;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}