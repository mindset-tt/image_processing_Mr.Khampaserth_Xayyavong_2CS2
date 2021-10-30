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
    public partial class Get_Setpixel : Form
    {
        public Get_Setpixel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ສ້າງ object Bitmap ຈາກ PictureBox1
            Bitmap srcBitmap = new Bitmap(pictureBox1.Image);

            //ສ້າງ object Bitmap ເປົ່າທີ່ມີຂະໜາດ 100x50
            Bitmap dstBitmap = new Bitmap(240, 230);

            for (int x = 265; x < 505; x++)
            {
                for (int y = 190; y < 420; y++)
                {
                    dstBitmap.SetPixel(x - 265, y - 190, srcBitmap.GetPixel(x, y));
                }
            }
            //ສະແດງຄ່າ Bitmap ອອກມາທີ່ PictureBox2
            pictureBox2.Image = dstBitmap;

        }
    }
}
