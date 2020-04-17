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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void RBtnRed1_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnRed1.Checked == true)

                RBtnRed1.ForeColor = Color.FromArgb(255, 0, 0);
            else

                RBtnRed1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RBtnGreen1_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnGreen1.Checked == true)

                RBtnGreen1.ForeColor = Color.FromArgb(0, 255, 0);
            else

                RBtnGreen1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RBtnBlue1_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnBlue1.Checked == true)

                RBtnBlue1.ForeColor = Color.FromArgb(0, 0, 255);
            else

                RBtnBlue1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RBtnYellow1_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnYellow1.Checked == true)

                RBtnYellow1.ForeColor = Color.FromArgb(255, 255, 0);
            else

                RBtnYellow1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RBtnRed1.ForeColor = Color.FromArgb(0, 0, 0);
            RBtnGreen1.ForeColor = Color.FromArgb(0, 0, 0);
            RBtnBlue1.ForeColor = Color.FromArgb(0, 0, 0);
            RBtnYellow1.ForeColor = Color.FromArgb(0, 0, 0);

            RBtnRed1.Checked = false;
            RBtnBlue1.Checked = false;
            RBtnGreen1.Checked = false;
            RBtnYellow1.Checked = false;

            RBtnRed2.ForeColor = Color.FromArgb(0, 0, 0);
            RBtnGreen2.ForeColor = Color.FromArgb(0, 0, 0);
            RBtnBlue2.ForeColor = Color.FromArgb(0, 0, 0);
            RBtnYellow2.ForeColor = Color.FromArgb(0, 0, 0);

            RBtnRed2.Checked = false;
            RBtnBlue2.Checked = false;
            RBtnGreen2.Checked = false;
            RBtnYellow2.Checked = false;
        }

        private void RBtnRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnRed2.Checked == true)

                RBtnRed2.ForeColor = Color.FromArgb(255, 0, 0);
            else

                RBtnRed2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RBtnGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnGreen2.Checked == true)

                RBtnGreen2.ForeColor = Color.FromArgb(0, 255, 0);
            else

                RBtnGreen2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RBtnBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnBlue2.Checked == true)

                RBtnBlue2.ForeColor = Color.FromArgb(0, 0, 255);
            else

                RBtnBlue2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RBtnYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnYellow2.Checked == true)

                RBtnYellow2.ForeColor = Color.FromArgb(255, 255, 0);
            else

                RBtnYellow2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnBackRadio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
