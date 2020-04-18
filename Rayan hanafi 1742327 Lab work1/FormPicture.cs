using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayan_hanafi_1742327_Lab_work1
{
    public partial class FrmPicture : Form
    {
       Assembly _assembly; 
        Stream _imageStream;
        public FrmPicture()
        {
            InitializeComponent();
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {

            try
            {

                PictureBox1.Image = Image.FromFile("C:\\Users\\Rayan\\Desktop\\study\\A+.png");
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }
        }
        private void FrmPicture_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly(); 
            _imageStream = _assembly.GetManifestResourceStream("Rayan_hanafi_1742327_Lab_work1.Resources.A+.jpg");
        }

        private void BtnImageFromRe_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox1.Image = Image.FromStream(_imageStream);
            }
            catch
            {
                MessageBox.Show("Error creating image from resource!");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBackpicture_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
