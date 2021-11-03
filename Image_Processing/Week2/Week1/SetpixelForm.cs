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
    public partial class SetpixelForm : Form
    {
        public SetpixelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap srcBitmap = new Bitmap(pictureBox1.Image);
            for (int x = 10; x < 120; x++)
            {
                srcBitmap.SetPixel(x, 10, Color.Red);
            }

            pictureBox1.Image = srcBitmap;
        }
    }
}
