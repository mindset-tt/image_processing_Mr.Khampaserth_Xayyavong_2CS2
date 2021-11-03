using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SetpixelForm());
            Application.Run(new GetPixel());
            Application.Run(new Get_Setpixel());
            Application.Run(new GrayCV());
            Application.Run(new GrayScale_Black_and_White_and_Invert());
        }
    }
}
