using ProjectTourism.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTourism
{
    public partial class FormChuyenDi : Form
    {
        private BLUser tasks = new BLUser();
        private string MaChuyenDi;
        private DateTime NgayBatDau;
        private string MaTaiKhoan;
        public FormChuyenDi(string mataikhoan)
        {
            this.MaTaiKhoan= mataikhoan;
            InitializeComponent();
        }

        private void LoadDSChuyenDi_dgv()
        {
            try
            {
                dgv_DSChuyenDi.DataSource = tasks.Load_dgvDSChuyenDi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormChuyenDi_Load(object sender, EventArgs e)
        {
            LoadDSChuyenDi_dgv();
        }
    }
}
