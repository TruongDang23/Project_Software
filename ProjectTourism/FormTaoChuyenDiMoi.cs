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
    public partial class FormTaoChuyenDiMoi : Form
    {
        private string MaTaiKhoan;
        private string MaChuyenDi;
        private DateTime NgayBatDau;
        public FormTaoChuyenDiMoi(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau)
        {
            InitializeComponent();
            MaTaiKhoan = maTaiKhoan;
            MaChuyenDi = maChuyenDi;
            NgayBatDau = ngayBatDau;
        }
    }
}
