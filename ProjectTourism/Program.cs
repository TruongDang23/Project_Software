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
            Application.Run(new FormChiTietChuyenDi("U001", "HaLong002", new DateTime(2023, 04,05)));
            //Application.Run(new FormChiTietChuyenDi("U001", "DaNang001", new DateTime(2023, 02, 05)));
        }
    }
}
