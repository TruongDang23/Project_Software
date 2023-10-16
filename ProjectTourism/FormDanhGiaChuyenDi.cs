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
    public partial class FormDanhGiaChuyenDi : Form
    {
        private string MaChuyenDi;
        private string MaTaiKhoan;
        private DateTime NgayBatDau;
        public FormDanhGiaChuyenDi(string MaChuyenDi, string MaTaiKhoan, DateTime NgayBatDau)
        {
            InitializeComponent();
            this.MaChuyenDi = MaChuyenDi;
            this.MaTaiKhoan = MaTaiKhoan;
            this.NgayBatDau = NgayBatDau;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
