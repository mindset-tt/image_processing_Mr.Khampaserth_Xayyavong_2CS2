using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GrayScale_Black_and_White_and_Invert : Form
    {
        public GrayScale_Black_and_White_and_Invert()
        {
            InitializeComponent();
        }
        Bitmap pict_C;
        Bitmap pict_O = (Bitmap)Image.FromFile("C:/Users/khamp/Documents/Image_processing/image_processing/Image_Processing/image/118331381_324241168628900_3775018869720072343_n.png");

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
    }
}
