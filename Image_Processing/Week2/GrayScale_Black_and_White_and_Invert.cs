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

namespace WindowsFormsApp1
{
    public partial class GrayScale_Black_and_White_and_Invert : Form
    {
        public GrayScale_Black_and_White_and_Invert()
        {
            InitializeComponent();
        }
        Bitmap pict_C;
        Bitmap pict_O;

        public Bitmap ConvertToGrayScale(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        public Bitmap ConvertToGrayScale2(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    //Luminance
                    int nP = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(nP, nP, nP));
                }
            }
            return bmp;
        }

        public Bitmap Thresholding1(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg > t)
                        avg = 255;
                    else avg = 0;

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        public Bitmap powerLaw1(Bitmap source, double R)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int c = int.Parse(textBox2.Text.ToString().Trim());

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color renk = source.GetPixel(x, y);
                    double gd = ((double)R / 20);
                    int sR = (int)(c * Math.Pow((renk.R / 255.0), gd));
                    int sG = (int)(c * Math.Pow((renk.G / 255.0), gd));
                    int sB = (int)(c * Math.Pow((renk.B / 255.0), gd));
                    bmp.SetPixel(x, y, Color.FromArgb(renk.A, sR, sG, sB));
                }
            }
            return bmp;
        }

        public Bitmap LogTransformation(Bitmap source)
        {
            Bitmap log = new Bitmap(source.Width, source.Height);
            int C = int.Parse(textBox4.Text);

            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color renk = source.GetPixel(x, y);
                    int sR = (int)(C * Math.Log10(1 + renk.R));
                    int sG = (int)(C * Math.Log10(1 + renk.G));
                    int sB = (int)(C * Math.Log10(1 + renk.B));
                    log.SetPixel(x, y, Color.FromArgb(renk.A, sR, sG, sB));
                }
            }
            return log;
        }

        public Bitmap Invert(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg == 255)
                        avg = 0;
                    else if (avg == 0)
                        avg = 255;

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        public Bitmap Negative(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int r1, g1, b1;
                    r1 = 255 - (int)(c.R);
                    g1 = 255 - (int)(c.G);
                    b1 = 255 - (int)(c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pict_O;
        }

        private void GrayScale_Black_and_White_and_Invert_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = pict_O;
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = ConvertToGrayScale(pict_C);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Thresholding1(pict_C);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Invert(pict_C);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Negative(pict_C);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = ConvertToGrayScale2(pict_C);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Load Image From File";
            ofd.Filter = "All files (*.*)|*.*|Jpeg Files (*.jpg)|*.jpg|PNG files(*.png)|*.png|Bitmap files(*.bmp)|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pict_O = new Bitmap(ofd.FileName);
                pictureBox1.Image = pict_O;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = powerLaw1(pict_C, double.Parse(textBox3.Text.ToString()));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = LogTransformation(pict_C);
        }
    }
}
