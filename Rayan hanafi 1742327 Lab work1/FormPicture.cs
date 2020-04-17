﻿using System;
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
       Assembly _assembly; // creating an assembly object
        Stream _imageStream;// creating an imagestream object
        public FrmPicture()
        {
            InitializeComponent();
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
            _assembly = Assembly.GetExecutingAssembly(); //set the assembly object
            _imageStream = _assembly.GetManifestResourceStream("Rayan hanafi 1742327 Lab work1.res.Coronavirus-badge-300.png");
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