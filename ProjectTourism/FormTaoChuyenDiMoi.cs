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
    public partial class FormTaoChuyenDiMoi : Form
    {
        private BLUser tasks = new BLUser();
        private string MaTaiKhoan;
        private DateTime NgayBatDau;
        private string MaChuyenDi;

        public FormTaoChuyenDiMoi()
        {
            InitializeComponent();
            //MaTaiKhoan = maTaiKhoan;
            //MaChuyenDi = maChuyenDi;
            //NgayBatDau = ngayBatDau;
        }
        public FormTaoChuyenDiMoi(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau)
        {
            InitializeComponent();
            this.MaTaiKhoan = maTaiKhoan;
            this.MaChuyenDi = maChuyenDi;
            this.NgayBatDau = ngayBatDau;
        }

        private void FormTaoChuyenDiMoi_Load(object sender, EventArgs e)
        {
            dateTimePicker_KhoiHanh.MinDate = DateTime.Now;
            tb_SoLuong.Text = "2";
        }

        private void btn_GuiYeuCau_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateTimePicker_KhoiHanh.Value;
            int soLuong = int.Parse(tb_SoLuong.Text);
            tasks.ThemDanhSachDKy(this.MaTaiKhoan, this.MaChuyenDi, ngayBatDau, soLuong, "ChuaDuyet");
            MessageBox.Show("Đã gửi yêu cầu thành công!");

            FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.MaTaiKhoan, this.MaChuyenDi, this.NgayBatDau);
            this.Hide();
            formChiTietChuyenDi.ShowDialog();
            this.Close();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.MaTaiKhoan, this.MaChuyenDi, this.NgayBatDau);
            this.Hide();
            formChiTietChuyenDi.ShowDialog();
            this.Close();
        }
    }
}
