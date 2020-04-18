namespace Rayan_hanafi_1742327_Lab_work1
{
    partial class FrmMain
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.GBLogin = new System.Windows.Forms.GroupBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.GbBasicControls = new System.Windows.Forms.GroupBox();
            this.BtnCheckbox = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnPicture = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.GBGraphical = new System.Windows.Forms.GroupBox();
            this.GBMorecontrols = new System.Windows.Forms.GroupBox();
            this.GBLogin.SuspendLayout();
            this.GbBasicControls.SuspendLayout();
            this.GBGraphical.SuspendLayout();
            this.GBMorecontrols.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Green;
            this.BtnLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(44, 253);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(123, 40);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(223, 253);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(123, 40);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LblUsername.Location = new System.Drawing.Point(15, 52);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(97, 24);
            this.LblUsername.TabIndex = 2;
            this.LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(15, 125);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(92, 24);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Password";
            // 
            // GBLogin
            // 
            this.GBLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GBLogin.Controls.Add(this.TxtPassword);
            this.GBLogin.Controls.Add(this.LblPassword);
            this.GBLogin.Controls.Add(this.TxtUsername);
            this.GBLogin.Controls.Add(this.LblUsername);
            this.GBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GBLogin.Location = new System.Drawing.Point(44, 42);
            this.GBLogin.Name = "GBLogin";
            this.GBLogin.Size = new System.Drawing.Size(302, 205);
            this.GBLogin.TabIndex = 4;
            this.GBLogin.TabStop = false;
            this.GBLogin.Text = "Login";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TxtPassword.Location = new System.Drawing.Point(135, 125);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(116, 28);
            this.TxtPassword.TabIndex = 6;
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TxtUsername.Location = new System.Drawing.Point(135, 47);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(116, 28);
            this.TxtUsername.TabIndex = 5;
            // 
            // GbBasicControls
            // 
            this.GbBasicControls.Controls.Add(this.BtnCheckbox);
            this.GbBasicControls.Controls.Add(this.BtnRadio);
            this.GbBasicControls.Controls.Add(this.BtnCombo);
            this.GbBasicControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbBasicControls.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GbBasicControls.Location = new System.Drawing.Point(413, 42);
            this.GbBasicControls.Name = "GbBasicControls";
            this.GbBasicControls.Size = new System.Drawing.Size(283, 153);
            this.GbBasicControls.TabIndex = 5;
            this.GbBasicControls.TabStop = false;
            this.GbBasicControls.Text = "Basic Controls";
            // 
            // BtnCheckbox
            // 
            this.BtnCheckbox.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCheckbox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCheckbox.Location = new System.Drawing.Point(149, 34);
            this.BtnCheckbox.Name = "BtnCheckbox";
            this.BtnCheckbox.Size = new System.Drawing.Size(128, 44);
            this.BtnCheckbox.TabIndex = 11;
            this.BtnCheckbox.Text = "Check box";
            this.BtnCheckbox.UseVisualStyleBackColor = false;
            this.BtnCheckbox.Click += new System.EventHandler(this.BtnCheckbox_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRadio.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRadio.Location = new System.Drawing.Point(6, 34);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(128, 44);
            this.BtnRadio.TabIndex = 6;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCombo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCombo.Location = new System.Drawing.Point(78, 88);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(128, 44);
            this.BtnCombo.TabIndex = 7;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnRandomCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRandomCombo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandomCombo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRandomCombo.Location = new System.Drawing.Point(26, 89);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(232, 60);
            this.BtnRandomCombo.TabIndex = 8;
            this.BtnRandomCombo.Text = "Random Combo";
            this.BtnRandomCombo.UseVisualStyleBackColor = false;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnPicture
            // 
            this.BtnPicture.BackColor = System.Drawing.Color.Gold;
            this.BtnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPicture.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnPicture.Location = new System.Drawing.Point(67, 43);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(133, 56);
            this.BtnPicture.TabIndex = 9;
            this.BtnPicture.Text = "Picture";
            this.BtnPicture.UseVisualStyleBackColor = false;
            this.BtnPicture.Click += new System.EventHandler(this.BtnPicture_Click);
            // 
            // BtnRandom
            // 
            this.BtnRandom.BackColor = System.Drawing.Color.DimGray;
            this.BtnRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRandom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnRandom.Location = new System.Drawing.Point(72, 34);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(128, 44);
            this.BtnRandom.TabIndex = 10;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = false;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // GBGraphical
            // 
            this.GBGraphical.Controls.Add(this.BtnPicture);
            this.GBGraphical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBGraphical.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GBGraphical.Location = new System.Drawing.Point(430, 226);
            this.GBGraphical.Name = "GBGraphical";
            this.GBGraphical.Size = new System.Drawing.Size(260, 123);
            this.GBGraphical.TabIndex = 11;
            this.GBGraphical.TabStop = false;
            this.GBGraphical.Text = "Graphical";
            // 
            // GBMorecontrols
            // 
            this.GBMorecontrols.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GBMorecontrols.Controls.Add(this.BtnRandom);
            this.GBMorecontrols.Controls.Add(this.BtnRandomCombo);
            this.GBMorecontrols.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBMorecontrols.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GBMorecontrols.Location = new System.Drawing.Point(844, 42);
            this.GBMorecontrols.Name = "GBMorecontrols";
            this.GBMorecontrols.Size = new System.Drawing.Size(276, 176);
            this.GBMorecontrols.TabIndex = 12;
            this.GBMorecontrols.TabStop = false;
            this.GBMorecontrols.Text = "More Controls";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::Rayan_hanafi_1742327_Lab_work1.Properties.Resources.تنزيل__1_;
            this.ClientSize = new System.Drawing.Size(1556, 450);
            this.Controls.Add(this.GBMorecontrols);
            this.Controls.Add(this.GBGraphical);
            this.Controls.Add(this.GbBasicControls);
            this.Controls.Add(this.GBLogin);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.GBLogin.ResumeLayout(false);
            this.GBLogin.PerformLayout();
            this.GbBasicControls.ResumeLayout(false);
            this.GBGraphical.ResumeLayout(false);
            this.GBMorecontrols.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.GroupBox GBLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.GroupBox GbBasicControls;
        private System.Windows.Forms.Button BtnCheckbox;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.GroupBox GBGraphical;
        private System.Windows.Forms.GroupBox GBMorecontrols;
    }
}

