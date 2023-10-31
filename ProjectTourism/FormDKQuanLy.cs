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
    public partial class FormDKQuanLy : Form
    {
        private BLSystem blSystem = new BLSystem();
        private string err = "";
        public FormDKQuanLy()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            FormDNhap formLogin = new FormDNhap();
            this.Hide();
            formLogin.ShowDialog();
            Close();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string nhaplaimk = txtNhapLaiMatKhau.Text;
            string mataotk = txtMaTaoTaiKhoan.Text;
            try
            {
                if (blSystem.IsExist(tk) == false)
                {
                    DialogResult check;
                    check = MessageBox.Show("Do you want to add this Account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        blSystem.AddQuanLy(tk, mk, nhaplaimk, mataotk, ref err);
                        MessageBox.Show("Added Successfully!");
                        FormDNhap form = new FormDNhap();
                        form.ShowDialog();
                        this.Close();
                    }
                }
            }



            catch (SqlException)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtNhapLaiMatKhau.PasswordChar = '\0';
                txtMaTaoTaiKhoan.PasswordChar = '\0';
            }
            else { txtMatKhau.PasswordChar = '*'; txtNhapLaiMatKhau.PasswordChar = '*';txtMaTaoTaiKhoan.PasswordChar = '*'; }
        }
    }
}
