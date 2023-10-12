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
    public partial class FormDatChuyenDi : Form
    {
        private BLUser tasks = new BLUser();
        private string MaChuyenDi;
        private DateTime NgayBatDau;
        private string MaTaiKhoan;

        public FormDatChuyenDi(string MaTaiKhoan, string MaChuyenDi, DateTime NgayBatDau)
        {
            InitializeComponent();
            this.MaChuyenDi = MaChuyenDi;
            this.NgayBatDau = NgayBatDau;
            this.MaTaiKhoan = MaTaiKhoan;
            btn_Dien.Enabled = false;
            Loadata();
        }

        private void Loadata()
        {
            DataTable dt = new DataTable();
            dt = tasks.layChiTietChuyenDi(this.MaChuyenDi, this.NgayBatDau);
            lb_Ten.Text = dt.Rows[0][0].ToString();
            lb_HanhTrinh.Text = dt.Rows[0][1].ToString();
            lb_HinhThuc.Text = dt.Rows[0][2].ToString();
            lb_SoNgayDi.Text = dt.Rows[0][3].ToString();
            lb_NguoiThamGia.Text = dt.Rows[0][4].ToString();
            lb_GiaTrenNguoi.Text = dt.Rows[0][5].ToString();
            lb_SoSao.Text = dt.Rows[0][6].ToString();
            lb_NgayKhoiHanh.Text = dt.Rows[0][7].ToString();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string Ten = this.tb_HoVaTen.Text;
                string CCCD = this.tb_CCCD.Text;
                string SDT = this.tb_SDT.Text;
                int SoLuong = this.tb_SoLuongNguoi.TextLength;
                tasks.ThemDuKhachDK(this.MaChuyenDi,this.NgayBatDau,CCCD,Ten,SDT);
                ResetData();
            }catch(Exception ex) { MessageBox.Show("Chua dien day du thong tin"); }
        }

        private void ResetData()
        {
            tb_CCCD.ResetText();
            tb_SDT.ResetText();
            tb_HoVaTen.ResetText();
            tb_SoLuongNguoi.ResetText();
        }
    }
}
