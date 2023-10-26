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
    public partial class FormDNhap : Form
    {
        BLSystem blSystem = new BLSystem();
        public void DangNhapQuanLy(string tk, string mk)
        {

            if (blSystem.GetDangNhapQuanLy(tk, mk))
            {
                FormTrangChu manag = new FormTrangChu();
                manag.ShowDialog();
            }
            else
                MessageBox.Show("Account/Password is incorrect!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void DangNhapNguoiDung(string tk, string mk)
        {
            if (blSystem.GetDangNhapNguoiDung(tk, mk))
            {
                string ID = blSystem.GetMaTaiKhoan(tk, mk);
                FormChuyenDi emp = new FormChuyenDi(ID);
                emp.ShowDialog();
            }
            else
                MessageBox.Show("Account/Password is incorrect!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public FormDNhap()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e) {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e) { }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            FormDK formRegister = new FormDK();
            this.Hide();
            formRegister.ShowDialog();
            Close();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            FormQuenMK formForgotPass = new FormQuenMK();
            this.Hide();
            formForgotPass.ShowDialog();
            Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {

            string tk = txtUser.Text;
            string mk = txtPass.Text;
            if (rdbMag.Checked)
                DangNhapQuanLy(tk, mk);
            else if (rdbUser.Checked)
                DangNhapNguoiDung(tk, mk);
        }
    }
}
