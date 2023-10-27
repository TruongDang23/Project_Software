using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTourism.BSLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjectTourism
{
    public partial class FormHuongDanVien : Form
    {
        private BLManager bl = new BLManager();
        private enum ChangeInfo
        {
            None,
            Them,
            Sua
        }
        private ChangeInfo changeInfo;
        public FormHuongDanVien()
        {
            InitializeComponent();
            changeInfo = ChangeInfo.None;
        }
        private void FormGuide_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            this.cbb_ID.DataSource = bl.LoadGuides();
            this.cbb_ID.DisplayMember = "Mã Hướng dẫn viên";
            this.cbb_IdGuide.DataSource = bl.LoadGuides();
            this.cbb_IdGuide.DisplayMember = "Mã Hướng dẫn viên";

            // Thêm các ngày cần in đậm và thay đổi màu vào CustomMonthCalendar

            // Thêm CustomMonthCalendar vào Controls của Form hoặc container khác
        }
        private void Highlight()
        {
            DataTable lt = new DataTable();
            string IDGuide_1 = this.cbb_ID.Text;
            lt = bl.LichTrinhHD(IDGuide_1);
            foreach (DataRow row in lt.Rows)
            {
                DateTime rowDateTime = Convert.ToDateTime(row["NgayBatDau"]);
                if (rowDateTime != null) // So sánh theo ngày (bỏ qua phần thời gian)
                {
                    monthCalendar_hdv.AddBoldedDate(rowDateTime.Date);
                }
            }

        }
        private void LoadDataGridView()
        {
            try
            {
                dgv_hdv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv_hdv.AutoResizeColumns();
                dgv_hdv.AllowUserToResizeColumns = true;
                dgv_hdv.AllowUserToOrderColumns = true;
                dgv_hdv.DataSource = bl.LoadDataGuide();


                dgv_Idtour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv_Idtour.AutoResizeColumns();
                dgv_Idtour.AllowUserToResizeColumns = true;
                dgv_Idtour.AllowUserToOrderColumns = true;
                dgv_Idtour.DataSource = bl.Load_dgv_Idtour();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ResetTextbox()
        {
            tb_ID.Enabled = true;
            tb_ID.ResetText();
            tb_email.ResetText();
            tb_ten.ResetText();
            tb_sdt.ResetText();
        }
        private void ChangeEnableButton(bool enable)
        {
            btnThem.Enabled = enable;
            btnThaydoi.Enabled = enable;
            btnXoa.Enabled = enable;
        }

        private void ChangeState_pnlInfo()
        {
            if (changeInfo == ChangeInfo.Them || changeInfo == ChangeInfo.Sua) { 
                pnl_changeinfo.Enabled = true;
                ChangeEnableButton(false);
            } 
            else { pnl_changeinfo.Enabled=false; ChangeEnableButton(true); }
            if (changeInfo == ChangeInfo.Them)
                ResetTextbox();
        }
        private void dgv_hdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_hdv.CurrentCell.RowIndex;
            if (r < dgv_hdv.Rows.Count && r>=0)
            {
                tb_ID.Text = dgv_hdv.Rows[r].Cells[0].Value.ToString();
                tb_ten.Text = dgv_hdv.Rows[r].Cells[1].Value.ToString();
                tb_sdt.Text = dgv_hdv.Rows[r].Cells[2].Value.ToString();
                tb_email.Text = dgv_hdv.Rows[r].Cells[3].Value.ToString();
            }
            else ResetTextbox();
            ChangeState_pnlInfo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            changeInfo = ChangeInfo.Them;
            ChangeState_pnlInfo();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                bl.DeleteDataGuide(tb_ID.Text);
                LoadDataGridView();
            }
        }

        private void btnThaydoi_Click(object sender, EventArgs e)
        {
            changeInfo = ChangeInfo.Sua;
            ChangeState_pnlInfo();
            tb_ID.Enabled = false;
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            changeInfo = ChangeInfo.None;
            ChangeState_pnlInfo();
        }
        private void btn_luutt_Click(object sender, EventArgs e)
        {
            if (changeInfo == ChangeInfo.Them)
            {
                if (!tb_ID.Text.Trim().Equals(""))
                {
                    if (bl.CheckIDGuide(tb_ID.Text))
                    {
                        MessageBox.Show("ID đã tồn tại!");
                        ResetText();
                    }
                    else
                    {
                        bl.AddDataGuide(tb_ID.Text, tb_ten.Text, tb_sdt.Text, tb_email.Text);
                    }
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Nhập ID!");
                    tb_ID.Focus();
                }
            }
            else if (changeInfo == ChangeInfo.Sua)
            {
                if (!tb_ID.Text.Trim().Equals(""))
                {
                    bl.ChangeInfoGuide(tb_ID.Text, tb_ten.Text, tb_sdt.Text, tb_email.Text);
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Chọn ID bạn muốn chỉnh sửa!");
                    tb_ID.Focus();
                }
            }
            changeInfo = ChangeInfo.None;
            ChangeState_pnlInfo();
        }


        private void btn_phancong_Click(object sender, EventArgs e)
        {
            int n = this.dgv_Idtour.CurrentCell.RowIndex;
            string IDTour = dgv_Idtour.Rows[n].Cells[0].Value.ToString();
            DateTime StartDay = DateTime.Parse(dgv_Idtour.Rows[n].Cells[1].Value.ToString());
            string IDGuide = cbb_IdGuide.Text;
            try
            {
                bl.Update_LichTrinh(IDTour, StartDay, IDGuide);
                MessageBox.Show("Phân công thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnhuypc_Click(object sender, EventArgs e)
        {
            int n = this.dgv_Idtour.CurrentCell.RowIndex;
            string IDTour = dgv_Idtour.Rows[n].Cells[0].Value.ToString();
            DateTime StartDay = DateTime.Parse(dgv_Idtour.Rows[n].Cells[1].Value.ToString());
            string IDGuide = cbb_IdGuide.Text;
            try
            {
                bl.Huy_PhanCong(IDTour, StartDay);
                MessageBox.Show("Hủy phân công thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            monthCalendar_hdv.RemoveAllBoldedDates();
            Highlight();
            monthCalendar_hdv.UpdateBoldedDates();
        }
    }
}
