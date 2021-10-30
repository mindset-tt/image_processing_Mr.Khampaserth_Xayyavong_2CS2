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
    public partial class GetPixel : Form
    {
        public GetPixel()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Color clr = bmp.GetPixel(e.X, e.Y);
            label1.Text = "R: " + clr.R.ToString();
            label2.Text = "G: " + clr.G.ToString();
            label3.Text = "B: " + clr.B.ToString();
        }
    }
}
