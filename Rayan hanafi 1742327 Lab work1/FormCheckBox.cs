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
    public partial class FrmCheckBox : Form
    {
        public FrmCheckBox()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (CBCoffee.Checked == true)
            {
                msg = CBCoffee.Text;
            }
            if (CbDonut.Checked == true)
            {
                msg = msg + CbDonut.Text;
            }
            if (CBBrownie.Checked == true)
            {
                msg = msg + CBBrownie.Text;
            }

            if (msg.Length == 0)
            {
                msg = "nothing selected";
            }
            MessageBox.Show(msg);
        }

        private void BtnBackCheckBox_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
