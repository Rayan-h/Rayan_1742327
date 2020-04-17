namespace Rayan_hanafi_1742327_Lab_work1
{
    partial class FrmRandom
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
            this.BtnGenerateRColor = new System.Windows.Forms.Button();
            this.Lblrgb = new System.Windows.Forms.Label();
            this.BtnRandomNumber = new System.Windows.Forms.Button();
            this.BtnBackRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerateRColor
            // 
            this.BtnGenerateRColor.Location = new System.Drawing.Point(78, 33);
            this.BtnGenerateRColor.Name = "BtnGenerateRColor";
            this.BtnGenerateRColor.Size = new System.Drawing.Size(414, 74);
            this.BtnGenerateRColor.TabIndex = 0;
            this.BtnGenerateRColor.Text = "Generate RandomColor";
            this.BtnGenerateRColor.UseVisualStyleBackColor = true;
            this.BtnGenerateRColor.Click += new System.EventHandler(this.BtnGenerateRColor_Click);
            // 
            // Lblrgb
            // 
            this.Lblrgb.AutoSize = true;
            this.Lblrgb.Location = new System.Drawing.Point(247, 153);
            this.Lblrgb.Name = "Lblrgb";
            this.Lblrgb.Size = new System.Drawing.Size(39, 17);
            this.Lblrgb.TabIndex = 1;
            this.Lblrgb.Text = "r-g-b";
            // 
            // BtnRandomNumber
            // 
            this.BtnRandomNumber.Location = new System.Drawing.Point(329, 227);
            this.BtnRandomNumber.Name = "BtnRandomNumber";
            this.BtnRandomNumber.Size = new System.Drawing.Size(181, 44);
            this.BtnRandomNumber.TabIndex = 2;
            this.BtnRandomNumber.Text = "Random Number";
            this.BtnRandomNumber.UseVisualStyleBackColor = true;
            this.BtnRandomNumber.Click += new System.EventHandler(this.BtnRandomNumber_Click);
            // 
            // BtnBackRandom
            // 
            this.BtnBackRandom.Location = new System.Drawing.Point(51, 231);
            this.BtnBackRandom.Name = "BtnBackRandom";
            this.BtnBackRandom.Size = new System.Drawing.Size(125, 40);
            this.BtnBackRandom.TabIndex = 3;
            this.BtnBackRandom.Text = "Back";
            this.BtnBackRandom.UseVisualStyleBackColor = true;
            this.BtnBackRandom.Click += new System.EventHandler(this.BtnBackRandom_Click);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rayan_hanafi_1742327_Lab_work1.Properties.Resources.تنزيل__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 328);
            this.Controls.Add(this.BtnBackRandom);
            this.Controls.Add(this.BtnRandomNumber);
            this.Controls.Add(this.Lblrgb);
            this.Controls.Add(this.BtnGenerateRColor);
            this.Name = "FrmRandom";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerateRColor;
        private System.Windows.Forms.Label Lblrgb;
        private System.Windows.Forms.Button BtnRandomNumber;
        private System.Windows.Forms.Button BtnBackRandom;
    }
}