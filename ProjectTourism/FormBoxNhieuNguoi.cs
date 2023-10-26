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
        private string maTaiKhoan;
        private string maChuyenDi;
        private DateTime ngayBatDau;
        private int soLuong;

        public FormBoxNhieuNguoi(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau, int soLuong)
        {
            InitializeComponent();
            this.maTaiKhoan = maTaiKhoan;
            this.maChuyenDi = maChuyenDi;
            this.ngayBatDau = ngayBatDau;
            this.soLuong = soLuong;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            FormNhieuNguoiDi formNhieuNguoiDi = new FormNhieuNguoiDi(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau, this.soLuong);
            this.Hide();
            formNhieuNguoiDi.ShowDialog();
            Close();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FormDatChuyenDi formDatChuyenDi = new FormDatChuyenDi(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau); 
            this.Hide();
            formDatChuyenDi.ShowDialog();
            Close();
        }
    }
}
