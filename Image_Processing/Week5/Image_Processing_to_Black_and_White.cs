using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;

namespace WindowsFormsApp1.Week5
{
    public partial class Image_Processing_to_Black_and_White : Form
    {
        public Image_Processing_to_Black_and_White()
        {
            InitializeComponent();
        }
        Image<Bgr, byte> imageInput;
        Image<Gray, byte> imageGray;
        Image<Gray, byte> imageBinarize;

        private void Image_Processing_to_Black_and_White_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageInput = new Image<Bgr, byte>(openFile.FileName);
                pictureBox1.Image = imageInput.ToBitmap();
            }
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBox1.Image = imageGray.ToBitmap();

            //binarization Simple Thresolding
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height, new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarize, 100, 255, ThresholdType.Binary);
            pictureBox2.Image = imageBinarize.ToBitmap();
        }

        private void binaryInvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBox1.Image = imageGray.ToBitmap();

            //binarization Simple Thresolding
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height,
                                                  new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarize, 100, 255,
                                 ThresholdType.BinaryInv);
            pictureBox2.Image = imageBinarize.ToBitmap();

        }

        private void oTSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBox1.Image = imageGray.ToBitmap();

            //binarization Simple Thresolding
            imageBinarize = new Image<Gray, byte>(imageGray.Width, imageGray.Height,
                                                  new Gray(0));
            CvInvoke.Threshold(imageGray, imageBinarize, 100, 255,
                                 ThresholdType.Otsu);
            pictureBox2.Image = imageBinarize.ToBitmap();
        }

        private void guassianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBox1.Image = imageGray.ToBitmap();

            //binarization Adaptive Thresolding
            imageBinarize = imageGray.ThresholdAdaptive(new Gray(256.0),
                                 AdaptiveThresholdType.GaussianC,
                                 ThresholdType.Binary, 3, new Gray(0.0));
            pictureBox2.Image = imageBinarize.ToBitmap();
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageGray = imageInput.Convert<Gray, byte>();
            pictureBox1.Image = imageGray.ToBitmap();
            //binarization Adaptive Thresolding
            imageBinarize = imageGray.ThresholdAdaptive(new Gray(256.0),
                                     AdaptiveThresholdType.MeanC,
                                     ThresholdType.Binary, 3, new Gray(0.0));
            pictureBox2.Image = imageBinarize.ToBitmap();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
