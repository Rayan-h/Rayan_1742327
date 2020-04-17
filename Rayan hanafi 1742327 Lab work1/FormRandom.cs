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
    public partial class FrmRandom : Form
    {
        Random y = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void BtnGenerateRColor_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);

            Lblrgb.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" +
                Convert.ToString(b);
            BtnGenerateRColor.BackColor = Color.FromArgb(r, g, b);
        }

        private void BtnRandomNumber_Click(object sender, EventArgs e)
        {
            BtnRandomNumber.Text = Convert.ToString(y.Next(1, 10));
        }

        private void BtnBackRandom_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
