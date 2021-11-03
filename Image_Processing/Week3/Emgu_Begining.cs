using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
namespace WindowsFormsApp1.Week3
{
    public partial class Emgu_Begining : Form
    {
        public Emgu_Begining()
        {
            InitializeComponent();
        }
        Image<Bgr, Byte> My_Image;
        Image<Gray, Byte> gray_image;

        private void Emgu_Begining_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, Byte>(Openfile.FileName);
                pictureBox1.Image = My_Image.ToBitmap();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Gray Image";
            saveImage.DefaultExt = "*.jpg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|BMP   files(*.bmp)|*.bmp";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                gray_image.Save(saveImage.FileName);
                MessageBox.Show("Saving Complete");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (My_Image != null)
            {
                gray_image = My_Image.Convert<Gray, Byte>();
                pictureBox2.Image = gray_image.ToBitmap();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
               
            }
            else if (pictureBox1.Image != null)
            {
                label1.Text = "X: " + e.X.ToString();
                label2.Text = "Y: " + e.Y.ToString();
                label3.Text = "Value: " + My_Image[e.Y, e.X].ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
