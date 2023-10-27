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
    public partial class FormDanhGiaChuyenDi : Form
    {
        BLUser task = new BLUser();
        private string MaChuyenDi;
        private string MaTaiKhoan;
        private DateTime NgayBatDau;
        public FormDanhGiaChuyenDi(string MaChuyenDi, string MaTaiKhoan, DateTime NgayBatDau)
        {
            InitializeComponent();
            this.MaChuyenDi = MaChuyenDi;
            this.MaTaiKhoan = MaTaiKhoan;
            this.NgayBatDau = NgayBatDau;
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = task.DanhSachDanhGia(MaChuyenDi, NgayBatDau);
            dgvCacDanhGia.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.MaChuyenDi, this.MaTaiKhoan, this.NgayBatDau);
            this.Hide();
            formChiTietChuyenDi.ShowDialog();
            this.Close();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            int sao = Int32.Parse(tbSoSao.Text);
            string BinhLuan = rtbNhanXet.Text;
            task.ThemDanhGia(this.MaChuyenDi, this.MaTaiKhoan, BinhLuan, sao);
            MessageBox.Show("Đã gửi đánh giá thành công!");
        }
    }
}
