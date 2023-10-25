using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTourism.BSLayer;

namespace ProjectTourism
{
    public partial class FormBoxThanhToan : Form
    {
        BLUser tasks = new BLUser();
        private string MaTaiKhoan;
        private string MaChuyenDi;
        private DateTime NgayBatDau;
        private int SoLuong;
        public FormBoxThanhToan(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau, int soLuong)
        {
            InitializeComponent();
            MaTaiKhoan = maTaiKhoan;
            MaChuyenDi = maChuyenDi;
            NgayBatDau = ngayBatDau;
            SoLuong = soLuong;
            LoadSoTien();
        }
        private void LoadSoTien()
        {
            
            DataTable dt = tasks.layChiTietChuyenDi(this.MaChuyenDi, this.NgayBatDau);
            int gia = int.Parse(dt.Rows[0]["Gia"].ToString());
            int tongTien = gia * SoLuong;
            lb_SoTien.Text = tongTien.ToString();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.MaTaiKhoan, this.MaChuyenDi, this.NgayBatDau);
            this.Hide();
            formChiTietChuyenDi.ShowDialog();
            this.Close();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            tasks.ThemDanhSachDK(this.MaTaiKhoan, this.MaChuyenDi, this.NgayBatDau, this.SoLuong, "ChuaDuyet");
            MessageBox.Show("Đã gửi yêu cầu thành công!");

            FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.MaTaiKhoan, this.MaChuyenDi, this.NgayBatDau);
            this.Hide();
            formChiTietChuyenDi.ShowDialog();
            this.Close();
        }

        private void FormBoxThanhToan_Load(object sender, EventArgs e)
        {
            FormBoxThanhToan formBoxThanhToan = new FormBoxThanhToan(this.MaTaiKhoan, this.MaChuyenDi, this.NgayBatDau, this.SoLuong);
            
        }
    }
}
