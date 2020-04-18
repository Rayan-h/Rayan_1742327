using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayan_hanafi_1742327_Lab_work1
{
    public partial class FrmMain : Form
    {
        String username = "Rayan";
        String password = "1234";
        int MaxAttempts = 3;
        int attempt = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            while (attempt <= MaxAttempts)
            {
                if (TxtUsername.Text != username) 
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    return;
                }
                else
                {   // username is correct
                    // so check password			
                    if (TxtPassword.Text != password) 
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login successful");
                        return;
                    }
                }
            }
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckbox_Click(object sender, EventArgs e)
        {
            FrmCheckBox frm = new FrmCheckBox();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCombo_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            FrmPicture frm = new FrmPicture();
            frm.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}