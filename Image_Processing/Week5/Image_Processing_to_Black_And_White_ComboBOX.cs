using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace WindowsFormsApp1.Week5
{
    public partial class Image_Processing_to_Black_And_White_ComboBox : Form
    {
        public Image_Processing_to_Black_And_White_ComboBox()
        {
            InitializeComponent();
        }
        Image<Bgr, byte> imageInput;
        Image<Gray, byte> imageGray;
        Image<Gray, byte> imageBinarize;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageInput = new Image<Bgr, byte>(openFile.FileName);
                imageBox1.Image = imageInput;
                imageGray = imageInput.Convert<Gray, byte>();
                imageBox2.Image = imageGray;
                imageBox3.Image = null;
                comboBox1.SelectedText = "ເລືອກຮູບພາບຂາວດຳ";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                imageBinarize = imageGray.ThresholdBinary(new Gray(150), new Gray(255));
                imageBox3.Image = imageBinarize;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                imageBinarize = imageGray.ThresholdBinaryInv(new Gray(150), new Gray(255));
                imageBox3.Image = imageBinarize;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                imageBinarize = imageGray.ThresholdToZero(new Gray(150));
                imageBox3.Image = imageBinarize;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                imageBinarize = imageGray.ThresholdAdaptive(new Gray(255), AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 7, new Gray(14));
                imageBox3.Image = imageBinarize;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                imageBinarize = imageGray.ThresholdAdaptive(new Gray(255), AdaptiveThresholdType.MeanC, ThresholdType.Binary, 7, new Gray(14));
                imageBox3.Image = imageBinarize;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.Title = "Save Gray Image";
            saveImage.DefaultExt = "*.jpg";
            saveImage.Filter = "Jpeg Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|Bitmap files(*.bmp)|*.bmp|All files (*.*)|*.*";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                imageBinarize.Save(saveImage.FileName);
                MessageBox.Show("Saving Complete");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
