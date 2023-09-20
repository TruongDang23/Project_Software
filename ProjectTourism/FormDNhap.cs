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
    }
}
