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
        private string err = "";
        public FormDK()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

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
            string email = txtEmail.Text;
            string ten=txtTen.Text;
            string sdt = txtSoDienThoai.Text;
            string diachi = txtDiaChi.Text;

            try
            {
                if (blSystem.ExistAccount(tk) == false)
                {
                    DialogResult check;
                    check = MessageBox.Show("Do you want to add this Account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        blSystem.AddUser(tk, mk, email,ten, diachi,sdt, ref err);
                        MessageBox.Show("Added Successfully!");

                        FormDNhap form = new FormDNhap();
                        form.ShowDialog();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Account/Email is exist!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (SqlException)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
