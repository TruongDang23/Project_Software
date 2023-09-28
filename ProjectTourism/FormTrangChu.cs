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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"../../../ProjectTourism/Assets/background1.jpg");
            this.BackgroundImage = myimage;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            FormQuanLyTour tour = new FormQuanLyTour();
            this.Hide();
            tour.ShowDialog();
            this.Show();
        }

        private void btnLichTour_Click(object sender, EventArgs e)
        {
            FormQuanLyLichTrinh lichtour = new FormQuanLyLichTrinh();
            this.Hide();
            lichtour.ShowDialog();
            this.Show();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            FormQuanLyVe ve = new FormQuanLyVe();
            this.Hide();
            ve.ShowDialog();
            this.Show();
        }

        private void btnKHang_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            this.Hide();
            formKhachHang.ShowDialog();
            this.Show();
        }

        private void btnHDV_Click(object sender, EventArgs e)
        {
            FormHuongDanVien formHuongDanVien = new FormHuongDanVien();
            this.Hide();
            formHuongDanVien.ShowDialog();
            this.Show();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            FormQuanLyDanhGia form = new FormQuanLyDanhGia();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
