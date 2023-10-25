using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTourism.BSLayer;

namespace ProjectTourism
{
    public partial class FormChiTietChuyenDi : Form
    {
        private BLUser tasks = new BLUser();
        private string maChuyenDi;
        private DateTime ngayBatDau;
        private string maTaiKhoan;

        public FormChiTietChuyenDi(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau)
        {
            InitializeComponent();
            this.maChuyenDi = maChuyenDi;
            this.ngayBatDau = ngayBatDau;
            this.maTaiKhoan = maTaiKhoan;
        }

        private void FormChiTietChuyenDi_Load(object sender, EventArgs e)
        {
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
            string path = dt.Rows[0][8].ToString();
            string contents = File.ReadAllText(path + "Description.txt");
            rtb_MoTa.Text = contents;

            //Anh mo to
            this.ptb_bia.Image = Image.FromFile(path + "AnhBia.jpg");
            this.ptb_bia.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ptb_1.Image = Image.FromFile(path + "AnhChiTiet1.jpg");
            this.ptb_1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ptb_2.Image = Image.FromFile(path + "AnhChiTiet2.jpg");
            this.ptb_2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ptb_3.Image = Image.FromFile(path + "AnhChiTiet3.jpg");
            this.ptb_3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_Dat_Click(object sender, EventArgs e)
        {
            FormDatChuyenDi formDatChuyenDi = new FormDatChuyenDi(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau);
            this.Hide();
            formDatChuyenDi.ShowDialog();
            Close();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FormChuyenDi formChuyenDi = new FormChuyenDi(maTaiKhoan);
            this.Hide();
            formChuyenDi.ShowDialog();
            Close();
        }

        private void btn_DanhGia_Click(object sender, EventArgs e)
        {
            FormDanhGiaChuyenDi formDanhGiaChuyenDi = new FormDanhGiaChuyenDi(this.maTaiKhoan,this.maChuyenDi,this.ngayBatDau);
            this.Hide();
            formDanhGiaChuyenDi.ShowDialog();
            Close();
        }

        private void btn_Tao_Click(object sender, EventArgs e)
        {
            FormTaoChuyenDiMoi formTaoChuyenDiMoi = new FormTaoChuyenDiMoi(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau);
            this.Hide();
            formTaoChuyenDiMoi.ShowDialog();
            Close();
        }
    }
}
