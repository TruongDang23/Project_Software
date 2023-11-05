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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.MaChuyenDi, this.MaTaiKhoan, this.NgayBatDau);
            this.Hide();
            formChiTietChuyenDi.ShowDialog();
            this.Close();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            int sao;
            string BinhLuan = rtbNhanXet.Text;

            try
            {
                sao = Int32.Parse(tbSoSao.Text);
                if (sao < 1 || sao > 5)
                {
                    MessageBox.Show("Số sao phải từ 1 đến 5!");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số sao phải là số!");
                return;
            }

            if (string.IsNullOrWhiteSpace(BinhLuan))
            {
                MessageBox.Show("Vui lòng nhập nhận xét!");
                return;
            }

            try
            {
                task.ThemDanhGia(this.MaChuyenDi, this.MaTaiKhoan, BinhLuan, sao);
                MessageBox.Show("Đã gửi đánh giá thành công!");
            }
            catch
            {
                
                MessageBox.Show("Bạn đã đánh giá chuyến đi rồi!");
            }
        }
    }
}
