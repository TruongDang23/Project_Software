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
    public partial class FormBoxNhieuNguoi : Form
    {
        private string MaTaiKhoan;
        private string MaChuyenDi;
        private DateTime NgayBatDau;
        private int SoLuong;

        public FormBoxNhieuNguoi(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau, int soLuong)
        {
            InitializeComponent();
            MaTaiKhoan = maTaiKhoan;
            MaChuyenDi = maChuyenDi;
            NgayBatDau = ngayBatDau;
            SoLuong = soLuong;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            FormNhieuNguoiDi formNhieuNguoiDi = new FormNhieuNguoiDi(this.MaTaiKhoan,this.MaChuyenDi,this.NgayBatDau,this.SoLuong);
            this.Hide();
            formNhieuNguoiDi.ShowDialog();
            Close();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FormDatChuyenDi formDatChuyenDi = new FormDatChuyenDi(this.MaTaiKhoan, this.MaChuyenDi, this.NgayBatDau);
            this.Hide();
            formDatChuyenDi.ShowDialog();
            Close();
        }
    }
}
