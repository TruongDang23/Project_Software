using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTourism.BSLayer;

namespace ProjectTourism
{
    public partial class FormDatChuyenDi : Form
    {
        private BLUser tasks = new BLUser();
        private string maChuyenDi;
        private DateTime ngayBatDau;
        private string maTaiKhoan;
        private int soLuong;

        public FormDatChuyenDi(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau)
        {
            InitializeComponent();
            this.maChuyenDi = maChuyenDi;
            this.ngayBatDau = ngayBatDau;
            this.maTaiKhoan = maTaiKhoan;
            btn_Dien.Enabled = false;
            Loadata();
        }

        private void Loadata()
        {
            DataTable dt = new DataTable();
            dt = tasks.LayChiTietChuyenDi(this.maChuyenDi, this.ngayBatDau);
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
                string ten = this.tb_HoVaTen.Text;
                string cccd = this.tb_CCCD.Text;
                string sdt = this.tb_SDT.Text;
                soLuong = Int32.Parse(this.tb_SoLuongNguoi.Text);
                if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(this.tb_SoLuongNguoi.Text) || this.tb_SoLuongNguoi.Text == "0")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                }
                else
                {
                    if(this.soLuong == 1)
                    {
                        tasks.ThemDuKhachDK(this.maChuyenDi, this.ngayBatDau, cccd, ten, sdt);
                        tasks.ThemDanhSachDK(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau, this.soLuong, "Chưa thanh toán");
                        ResetData();
                        FormBoxThanhToan formBoxThanhToan = new FormBoxThanhToan(this.maTaiKhoan,this.maChuyenDi,this.ngayBatDau,this.soLuong);
                        this.Hide();
                        formBoxThanhToan.ShowDialog();
                        Close();
                    }
                    else 
                    {
                        MessageBox.Show("Vui lòng chọn ĐIỀN để điền thông tin cho nhiều du khách");
                        btn_Dien.Enabled = true;
                    }
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void ResetData()
        {
            tb_CCCD.ResetText();
            tb_SDT.ResetText();
            tb_HoVaTen.ResetText();
            tb_SoLuongNguoi.ResetText();
        }

        private void btn_Dien_Click(object sender, EventArgs e)
        {
            FormBoxNhieuNguoi formBoxNhieuNguoi = new FormBoxNhieuNguoi(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau, this.soLuong);
            this.Hide();
            formBoxNhieuNguoi.ShowDialog();
            Close();
            btn_Dien.Enabled=false;
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FormChiTietChuyenDi formChiTietChuyenDi = new FormChiTietChuyenDi(this.maTaiKhoan,this.maChuyenDi,this.ngayBatDau);
            this.Hide();
            formChiTietChuyenDi.ShowDialog(); 
            Close();
        }

    }
}
