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
    public partial class FormDK : Form
    {
        private BLSystem blSystem = new BLSystem();
        private TaiKhoan new_tk = new TaiKhoan();
        public FormDK()
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
            string tk = txtUser.Text;
            string mk = txtPass.Text;
            string nhaplaimk = txtNhapLaiMatKhau.Text;
            string matk = blSystem.TaiKhoanMoiNguoiDung();
            try
            {
                if (blSystem.IsExist(tk) == false)
                {
                    if (mk == nhaplaimk)
                    {
                        DialogResult check;
                        check = MessageBox.Show("Do you want to add this Account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (check == DialogResult.Yes)
                        {
                            new_tk.TenDangNhap = tk;
                            new_tk.MatKhau = mk;
                            new_tk.MaTaiKhoan = matk;
                            MessageBox.Show("Added Successfully!");
                            FormThongTinCaNhan form = new FormThongTinCaNhan(new_tk);
                            this.Hide();
                            form.ShowDialog();
                            this.Close();
                        }
                    }else MessageBox.Show("Mật khẩu không khớp!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Account is exist!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                txtPass.PasswordChar = '\0';
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
            else { txtPass.PasswordChar = '*'; txtNhapLaiMatKhau.PasswordChar = '*'; }
        }
    }
}
