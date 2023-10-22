using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTourism
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
            Application.Run(new FormQuanLyTour());
            //Application.Run(new FormNhieuNguoiDi("U006", "DaNang001", new DateTime(2023, 02, 05), 2, "9999"));
            //Application.Run(new FormBoxThanhToan("U001", "NhaTrang001", new DateTime(2023, 08, 20), 4));
        }
    }
}
