using ProjectTourism.BSLayer;
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
        private BLUser tasks = new BLUser();
        private string MaTaiKhoan;
        private string MaChuyenDi;
        private DateTime NgayBatDau;
        private int SoLuong;
        private string CCCD;

        public FormBoxNhieuNguoi(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau, int soLuong, string CCCD)
        {
            InitializeComponent();
            this.MaTaiKhoan = maTaiKhoan;
            this.MaChuyenDi = maChuyenDi;
            this.NgayBatDau = ngayBatDau;
            this.SoLuong = soLuong;
            this.CCCD = CCCD;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            FormNhieuNguoiDi formNhieuNguoiDi = new FormNhieuNguoiDi(this.MaTaiKhoan, this.MaChuyenDi, this.NgayBatDau, this.SoLuong, this.CCCD);
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
