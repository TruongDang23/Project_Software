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
        private string maChuyenDi = "";
        private DateTime ngayBatDau = DateTime.Now;
        private string maTaiKhoan;
        public FormChuyenDi(string mataikhoan)
        {
            this.maTaiKhoan= mataikhoan;
            InitializeComponent();
        }

        private void LoadDSChuyenDi_dgv(DataTable Source)
        {
            try
            {
                dgv_DSChuyenDi.DataSource = Source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormChuyenDi_Load(object sender, EventArgs e)
        {
            LoadDSChuyenDi_dgv(tasks.Load_dgvDSChuyenDi());
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            int r = this.dgv_DSChuyenDi.CurrentCell.RowIndex;
            this.maChuyenDi = dgv_DSChuyenDi.Rows[r].Cells[0].Value.ToString();
            this.ngayBatDau = DateTime.Parse(dgv_DSChuyenDi.Rows[r].Cells[3].Value.ToString());
            FormChiTietChuyenDi ctcd = new FormChiTietChuyenDi(this.maTaiKhoan,this.maChuyenDi,this.ngayBatDau);
            this.Hide();
            ctcd.ShowDialog();
            this.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string destination = tb_DiemDen.Text;
            DateTime startDay = (cbUseDateTime.Checked) ? dateTimePicker_KhoiHanh.Value : new DateTime(1000, 1, 1);
            int price = (tb_Gia.Text == String.Empty) ? 0: int.Parse(tb_Gia.Text);
            int rate = Convert.ToInt32(nudSao.Value);
            LoadDSChuyenDi_dgv(tasks.FindTour(destination,startDay,price,rate));
        }

        private void cbUseDateTime_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker_KhoiHanh.Enabled = (this.dateTimePicker_KhoiHanh.Enabled == false) ? true : false;
        }
    }
}
