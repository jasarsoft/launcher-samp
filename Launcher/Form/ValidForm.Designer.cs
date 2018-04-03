#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Jasarsoft.Launcher.SAMP
{
    partial class ValidForm
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
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelValid = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.progressValid = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressValid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.Image = global::Jasarsoft.Launcher.SAMP.Properties.Resources.gtasa_cover;
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(320, 96);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 5;
            this.pictureLogo.TabStop = false;
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = false;
            this.labelValid.ForeColor = System.Drawing.Color.Black;
            this.labelValid.Location = new System.Drawing.Point(12, 123);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(320, 22);
            this.labelValid.TabIndex = 1;
            this.labelValid.Text = "File Name...";
            this.labelValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressValid
            // 
            this.progressValid.BackGradientEndColor = System.Drawing.Color.Gainsboro;
            this.progressValid.BackGradientStartColor = System.Drawing.Color.Gainsboro;
            this.progressValid.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.progressValid.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressValid.BackSegments = false;
            this.progressValid.BackTubeEndColor = System.Drawing.Color.Gainsboro;
            this.progressValid.BackTubeStartColor = System.Drawing.Color.Gainsboro;
            this.progressValid.BorderColor = System.Drawing.Color.DarkCyan;
            this.progressValid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressValid.CustomText = null;
            this.progressValid.CustomWaitingRender = false;
            this.progressValid.FontColor = System.Drawing.Color.WhiteSmoke;
            this.progressValid.ForegroundImage = null;
            this.progressValid.GradientEndColor = System.Drawing.Color.Teal;
            this.progressValid.GradientStartColor = System.Drawing.Color.Aqua;
            this.progressValid.Location = new System.Drawing.Point(12, 148);
            this.progressValid.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressValid.Name = "progressValid";
            this.progressValid.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.progressValid.SegmentWidth = 10;
            this.progressValid.Size = new System.Drawing.Size(320, 23);
            this.progressValid.Step = 1;
            this.progressValid.TabIndex = 2;
            this.progressValid.ThemesEnabled = false;
            this.progressValid.TubeEndColor = System.Drawing.Color.Teal;
            this.progressValid.TubeStartColor = System.Drawing.Color.Aqua;
            this.progressValid.WaitingGradientWidth = 320;
            // 
            // ValidForm
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
            this.Controls.Add(this.progressValid);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.pictureLogo);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.DarkCyan;
            this.MinimizeBox = false;
            this.Name = "ValidForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAMP Launcher | Validating...";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressValid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel labelValid;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressValid;
    }
}