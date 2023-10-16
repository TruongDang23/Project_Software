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
    public partial class FormQuanLyTaiKhoan : Form
    {
        private BLManager bl = new BLManager();
        private enum Modify
        {
            Khong,
            Them,
            Sua
        }
        private Modify state;
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            state = Modify.Khong;
            ChangeStateModify();
        }
        private void ResetTextPnlAccount()
        {
            tb_modify_tendn.ResetText();
            tb_modify_mk.ResetText();
        }
        private void ResetTextPnlInfo()
        {
            tb_ten.ResetText();
            tb_sdt.ResetText();
            tb_diachi.ResetText();
            tb_email.ResetText();
        }
        private void ChangeStateModify()
        {
            if (state == Modify.Khong || state == Modify.Them) {
                ResetTextPnlAccount();
                ResetTextPnlInfo();
                pnl_change_account.Enabled = state == Modify.Khong? false:true;
                pnl_change_info.Enabled = state == Modify.Khong ? false : true;
            }
            else {
                pnl_change_account.Enabled = false;
                pnl_change_info.Enabled = true;
            }
        }
        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_dataacc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv_dataacc.AutoResizeColumns();
                dgv_dataacc.AllowUserToResizeColumns = false;
                dgv_dataacc.AllowUserToOrderColumns = false;
                dgv_dataacc.DataSource = bl.GetAllDataAccount();
                dgv_dataacc.Columns["Mật khẩu"].Visible = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung!");
            }
        }

        private void dgv_dataacc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_dataacc.CurrentCell.RowIndex;
            if (r < dgv_dataacc.Rows.Count - 1 && r >= 0)
            {
                DataTable data_per = bl.GetDataPersonal(dgv_dataacc.Rows[r].Cells[2].Value.ToString());
                DataRow row_data = data_per.Rows[0];
                lb_value_ten.Text = row_data[1].ToString();
                lb_value_sdt.Text = row_data[2].ToString();
                lb_value_diachi.Text = row_data[3].ToString();
                lb_value_email.Text = row_data[4].ToString();

                try
                {
                    dgv_dangky.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dgv_dangky.AutoResizeColumns();
                    dgv_dangky.AllowUserToResizeColumns = false;
                    dgv_dangky.AllowUserToOrderColumns = false;
                    dgv_dangky.DataSource = bl.GetDataJoinTour(dgv_dataacc.Rows[r].Cells[2].Value.ToString());
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung!");
                }
                if (state == Modify.Sua)
                {
                    tb_modify_tendn.Text = dgv_dataacc.Rows[r].Cells[0].Value.ToString();
                    tb_modify_mk.Text = dgv_dataacc.Rows[r].Cells[1].Value.ToString();

                    tb_ten.Text = row_data[1].ToString();
                    tb_sdt.Text = row_data[2].ToString();
                    tb_diachi.Text = row_data[3].ToString();
                    tb_email.Text = row_data[4].ToString();
                }
            }
        }

        private void btn_accthem_Click(object sender, EventArgs e)
        {
            state = Modify.Them;
            ChangeStateModify();
        }

        private void btn_accsua_Click(object sender, EventArgs e)
        {
            state = Modify.Sua;
            ChangeStateModify();
        }

        private void btn_accxoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            state = Modify.Khong;
            ChangeStateModify();
        }
    }
}
