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
    public partial class FormQuenMK : Form
    {
        public FormQuenMK()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FormDNhap formLogin = new FormDNhap();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            FormMKmoi formNewPass = new FormMKmoi();
            this.Hide();
            formNewPass.ShowDialog();
            Close();
        }

        private void FormQuenMK_Load(object sender, EventArgs e)
        {

        }
    }
}
