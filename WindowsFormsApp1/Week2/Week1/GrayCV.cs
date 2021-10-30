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
    public partial class GrayCV : Form
    {
        public GrayCV()
        {
            InitializeComponent();
        }
        string Picture = "C:/Users/khamp/Documents/Image_processing/image_processing/WindowsFormsApp1/image/1099278.png";
        public Bitmap ConvertToGray(Bitmap source)
        {

            //ສ້າງ object ແລະກຳນົດຂະໜາດຂອງ Bitmap
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avr = (int)((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(x, y, Color.FromArgb(avr, avr, avr));
                }
            }
            //ສົ່ງຄ່າ Bitmap ກັບຄືນອອກໄປ
            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ConvertToGray(new Bitmap(Picture));
        }
    }
}
