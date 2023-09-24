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
    public partial class FormDK : Form
    {
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
