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
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerateQuiz03_Click(object sender, EventArgs e)
        {
            CBQuiz03.ResetText();      
            CBQuiz03.Items.Clear();    
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                CBQuiz03.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnResetRC2_Click(object sender, EventArgs e)
        {
            CBQuiz032.ResetText();
            CBQuiz032.Items.Clear();
            RBtnLT5002.Checked = false;
            RBtnGT5002.Checked = false;
        }

        private void BtnResetRC1_Click(object sender, EventArgs e)
        {
            CBQuiz03.ResetText();
            CBQuiz03.Items.Clear();
            BtnLT5001.Checked = false;
            BtnLT5001.Checked = false;
        }

        private void CBQuiz03_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CBQuiz03.Text) > 499)
            {
                BtnGT5001.Checked = true;
            }
            else
            {
                BtnLT5001.Checked = true;
            }
        }

        private void BtnGenerateQuiz032_Click(object sender, EventArgs e)
        {
            CBQuiz032.ResetText();
            CBQuiz032.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                CBQuiz032.Items.Add(r.Next(10, 99));
            }
        }

        private void CBQuiz032_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CBQuiz032.Text) > 49)
            {
                RBtnGT5002.Checked = true;
            }
            else
            {
                RBtnLT5002.Checked = true;
            }
        }

        private void BtnBackRandomCombo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
