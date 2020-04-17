namespace Rayan_hanafi_1742327_Lab_work1
{
    partial class FrmCheckBox
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.CBCoffee = new System.Windows.Forms.CheckBox();
            this.CbDonut = new System.Windows.Forms.CheckBox();
            this.CBBrownie = new System.Windows.Forms.CheckBox();
            this.BtnBackCheckBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(50, 22);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(152, 51);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // CBCoffee
            // 
            this.CBCoffee.AutoSize = true;
            this.CBCoffee.BackColor = System.Drawing.Color.Goldenrod;
            this.CBCoffee.Location = new System.Drawing.Point(47, 99);
            this.CBCoffee.Name = "CBCoffee";
            this.CBCoffee.Size = new System.Drawing.Size(71, 21);
            this.CBCoffee.TabIndex = 1;
            this.CBCoffee.Text = "Coffee";
            this.CBCoffee.UseVisualStyleBackColor = false;
            // 
            // CbDonut
            // 
            this.CbDonut.AutoSize = true;
            this.CbDonut.BackColor = System.Drawing.Color.Khaki;
            this.CbDonut.Location = new System.Drawing.Point(50, 142);
            this.CbDonut.Name = "CbDonut";
            this.CbDonut.Size = new System.Drawing.Size(68, 21);
            this.CbDonut.TabIndex = 2;
            this.CbDonut.Text = "Donut";
            this.CbDonut.UseVisualStyleBackColor = false;
            // 
            // CBBrownie
            // 
            this.CBBrownie.AutoSize = true;
            this.CBBrownie.BackColor = System.Drawing.Color.Sienna;
            this.CBBrownie.Location = new System.Drawing.Point(50, 184);
            this.CBBrownie.Name = "CBBrownie";
            this.CBBrownie.Size = new System.Drawing.Size(80, 21);
            this.CBBrownie.TabIndex = 3;
            this.CBBrownie.Text = "Brownie";
            this.CBBrownie.UseVisualStyleBackColor = false;
            // 
            // BtnBackCheckBox
            // 
            this.BtnBackCheckBox.Location = new System.Drawing.Point(224, 224);
            this.BtnBackCheckBox.Name = "BtnBackCheckBox";
            this.BtnBackCheckBox.Size = new System.Drawing.Size(111, 51);
            this.BtnBackCheckBox.TabIndex = 4;
            this.BtnBackCheckBox.Text = "Back";
            this.BtnBackCheckBox.UseVisualStyleBackColor = true;
            this.BtnBackCheckBox.Click += new System.EventHandler(this.BtnBackCheckBox_Click);
            // 
            // FrmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rayan_hanafi_1742327_Lab_work1.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 304);
            this.Controls.Add(this.BtnBackCheckBox);
            this.Controls.Add(this.CBBrownie);
            this.Controls.Add(this.CbDonut);
            this.Controls.Add(this.CBCoffee);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCheckBox";
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.CheckBox CBCoffee;
        private System.Windows.Forms.CheckBox CbDonut;
        private System.Windows.Forms.CheckBox CBBrownie;
        private System.Windows.Forms.Button BtnBackCheckBox;
    }
}