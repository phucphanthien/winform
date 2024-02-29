using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppJob
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            Application.Run(new DangKy());
            Application.Run(new DN_HoSo());
            Application.Run(new UV_HoSo());
            Application.Run(new QuenMK());
            
        }
    }
}
