using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTourism
{
    public partial class FormDatChuyenDi : Form
    {
        private BLUser tasks = new BLUser();
        private string MaChuyenDi;
        private DateTime NgayBatDau;
        private string MaTaiKhoan;
        {
            InitializeComponent();
            this.MaChuyenDi = MaChuyenDi;
            this.NgayBatDau = NgayBatDau;
        }
    }
}
