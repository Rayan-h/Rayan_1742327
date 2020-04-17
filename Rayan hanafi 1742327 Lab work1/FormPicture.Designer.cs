namespace Rayan_hanafi_1742327_Lab_work1
{
    partial class FrmPicture
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLoadImage = new System.Windows.Forms.Button();
            this.BtnImageFromRe = new System.Windows.Forms.Button();
            this.BtnBackpicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(227, 118);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(296, 234);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnLoadImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadImage.Location = new System.Drawing.Point(163, 29);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(199, 62);
            this.BtnLoadImage.TabIndex = 1;
            this.BtnLoadImage.Text = "Load Image";
            this.BtnLoadImage.UseVisualStyleBackColor = false;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // BtnImageFromRe
            // 
            this.BtnImageFromRe.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnImageFromRe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImageFromRe.Location = new System.Drawing.Point(368, 29);
            this.BtnImageFromRe.Name = "BtnImageFromRe";
            this.BtnImageFromRe.Size = new System.Drawing.Size(199, 62);
            this.BtnImageFromRe.TabIndex = 2;
            this.BtnImageFromRe.Text = "Load Image From Resource";
            this.BtnImageFromRe.UseVisualStyleBackColor = false;
            this.BtnImageFromRe.Click += new System.EventHandler(this.BtnImageFromRe_Click);
            // 
            // BtnBackpicture
            // 
            this.BtnBackpicture.BackColor = System.Drawing.Color.Teal;
            this.BtnBackpicture.Location = new System.Drawing.Point(34, 368);
            this.BtnBackpicture.Name = "BtnBackpicture";
            this.BtnBackpicture.Size = new System.Drawing.Size(113, 46);
            this.BtnBackpicture.TabIndex = 3;
            this.BtnBackpicture.Text = "Back";
            this.BtnBackpicture.UseVisualStyleBackColor = false;
            this.BtnBackpicture.Click += new System.EventHandler(this.BtnBackpicture_Click);
            // 
            // FrmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rayan_hanafi_1742327_Lab_work1.Properties.Resources._55434;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.BtnBackpicture);
            this.Controls.Add(this.BtnImageFromRe);
            this.Controls.Add(this.BtnLoadImage);
            this.Controls.Add(this.PictureBox1);
            this.Name = "FrmPicture";
            this.Text = "Picture";
            this.Load += new System.EventHandler(this.FrmPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button BtnLoadImage;
        private System.Windows.Forms.Button BtnImageFromRe;
        private System.Windows.Forms.Button BtnBackpicture;
    }
}