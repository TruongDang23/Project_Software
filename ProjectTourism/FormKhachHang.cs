using ProjectTourism.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTourism
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            
        }

        private void btnquanlytaikhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyTaiKhoan form_taikhoan = new FormQuanLyTaiKhoan();
            form_taikhoan.ShowDialog();
            this.Show();
        }

        private void btnquanlyhanhkhach_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyHanhKhach form_hk = new FormQuanLyHanhKhach();
            form_hk.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyYeuCau form_yc = new FormQuanLyYeuCau();
            form_yc.ShowDialog();
            this.Show();
        }
    }
}
