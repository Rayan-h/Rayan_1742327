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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CoBDays.Items.Add("Sunday");
            CoBDays.Items.Add("Monday");
            CoBDays.Items.Add("Tuesday");
            CoBDays.Items.Add("Wdnesday");
            CoBDays.Items.Add("Thursday");
            CoBDays.Items.Add("Friday");
            CoBDays.Items.Add("Saturday");
        }

        private void BtnShowMethod1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CoBDays.Text);
        }

        private void BtnShowMethod2_Click(object sender, EventArgs e)
        {
            string itemText = CoBDays.GetItemText(CoBDays.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void BtnRemoveLastItem_Click(object sender, EventArgs e)
        {
            if (CoBDays.Items.Count >= 1) 
            {
                CoBDays.Items.RemoveAt(CoBDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }

        private void BtnRemove2ndItem_Click(object sender, EventArgs e)
        {
            if (CoBDays.Items.Count >= 2)
            {
                CoBDays.Items.RemoveAt(CoBDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CoBDays.Items.RemoveAt(1);
        }

        private void BtnRemoveByName_Click(object sender, EventArgs e)
        {
            CoBDays.Items.Remove("Friday");
        }

        private void BtnBackCombo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
