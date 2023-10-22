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
using static System.Windows.Forms.AxHost;

namespace ProjectTourism
{
    enum Modify
    {
        them,
        sua,
        none
    }
    public partial class FormQuanLyHanhKhach : Form
    {
        private BLManager bl= new BLManager();
        private DataTable data_cus = new DataTable();
        private DanhSachDuKhach dukhack = new DanhSachDuKhach();
        private bool starting = true;
        Modify Modify;
        public FormQuanLyHanhKhach()
        {
            InitializeComponent();
            Enable_Info_text(false);
            Modify = Modify.none;
        }
        private void Enable_Info_text(bool state)
        {
            tb_id.Enabled = state;
            dtp_ngaydi.Enabled = state;
            tb_cccd.Enabled = state;
            tb_ten.Enabled = state;
            tb_sdt.Enabled = state;

            pnl_save.Enabled = state;
        }
        private void Reset_Text()
        {
            tb_id.ResetText();
            tb_cccd.ResetText();
            tb_ten.ResetText();
            tb_sdt.ResetText();

            dtp_ngaydi.ResetText();
        }

        private void LoadData()
        {
            try
            {
                dgv_hanhkhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv_hanhkhach.AllowUserToResizeColumns = false;
                dgv_hanhkhach.AllowUserToOrderColumns = false;
                dgv_hanhkhach.AllowUserToResizeRows = false;
                data_cus = bl.GetAllDataCustomer();
                dgv_hanhkhach.DataSource = data_cus;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung!");
            }
            cbb_idtour.DataSource = bl.FillterCustomer_IDTour();
            this.cbb_idtour.DisplayMember = "Mã chuyến đi";
            cbb_id_tk.DataSource = bl.FillterCustomer_IDTour();
            this.cbb_id_tk.DisplayMember = "Mã chuyến đi";
            cbb_date.DataSource =  bl.FillterCustomer_Date();
            this.cbb_date.DisplayMember = "Ngày bắt đầu";
            cbb_cccd.DataSource = bl.FillterCustomer_CCCD();
            this.cbb_cccd.DisplayMember = "CCCD";
            cbb_ten.DataSource = bl.FillterCustomer_Ten();
            this.cbb_ten.DisplayMember = "Tên";

            cbb_ngaydi_tk.DataSource = bl.FillterCustomer_Date_Follow_ID(cbb_id_tk.Text);
            this.cbb_ngaydi_tk.DisplayMember = "Ngày bắt đầu";
            starting = false;
            Count_Customer(cbb_id_tk.Text, Convert.ToDateTime(cbb_ngaydi_tk.Text));
        }
        private void FormQuanLyHanhKhach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            dt = bl.Fillter_Customer(cb_Id.Checked, cb_ngaydi.Checked, cb_cccd.Checked, cb_ten.Checked,
                cbb_idtour.Text, Convert.ToDateTime(cbb_date.Text), cbb_cccd.Text, cbb_ten.Text);

            try
            {
                dgv_hanhkhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv_hanhkhach.AllowUserToResizeColumns = false;
                dgv_hanhkhach.AllowUserToOrderColumns = false;
                dgv_hanhkhach.AllowUserToResizeRows = false;
                data_cus = bl.GetAllDataCustomer();
                dgv_hanhkhach.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung!");
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_hanhkhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_hanhkhach.CurrentCell.RowIndex;
            if (r < dgv_hanhkhach.Rows.Count - 1 && r >= 0 && Modify != Modify.them)
            {
                tb_id.Text = dukhack.MaChuyenDi = dgv_hanhkhach.Rows[r].Cells[0].Value.ToString();
                dtp_ngaydi.Value = dukhack.NgayBatDau = Convert.ToDateTime(dgv_hanhkhach.Rows[r].Cells[1].Value);
                tb_cccd.Text = dukhack.CCCD = dgv_hanhkhach.Rows[r].Cells[2].Value.ToString();
                tb_ten.Text = dgv_hanhkhach.Rows[r].Cells[3].Value.ToString();
                tb_sdt.Text = dgv_hanhkhach.Rows[r].Cells[4].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Modify = Modify.them;
            Enable_Info_text(true);
            Reset_Text();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Modify = Modify.sua;
            Enable_Info_text(true);
            tb_id.Enabled = false;
            dtp_ngaydi.Enabled = false;
            tb_cccd.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            if (dukhack.MaChuyenDi != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa du khách trong chuyến đi " + dukhack.MaChuyenDi + 
                    ", vào ngày " + dukhack.NgayBatDau + ", CCCD: " + dukhack.CCCD +"?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.DeleteCustomer(dukhack.MaChuyenDi, dukhack.NgayBatDau, dukhack.CCCD);
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn du khách muốn xóa!"); }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Modify = Modify.none;
            Enable_Info_text(false);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Modify == Modify.them)
            {
                if (!tb_id.Text.Trim().Equals("") && !tb_cccd.Text.Trim().Equals(""))
                {
                    if (!bl.Is_Customer_Exist(tb_id.Text, dtp_ngaydi.Value, tb_cccd.Text))
                    {
                        try
                        {
                            bl.AddCustomer(tb_id.Text, dtp_ngaydi.Value, tb_cccd.Text, tb_ten.Text, tb_sdt.Text);
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Không thêm được. Lỗi rồi!!!");
                        }
                        Modify = Modify.none;
                    }
                    else MessageBox.Show("Chuyến đi " + tb_id.Text + " khởi hành ngày " + dtp_ngaydi.Value + "\n"
                                         + "Của du khách CCCD: " + tb_cccd.Text + " đã tồn tại!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập Đầy đủ thông tin!");
                }
            }
            else if (Modify == Modify.sua)
            {
                if (!tb_id.Text.Trim().Equals("") && !tb_cccd.Text.Trim().Equals(""))
                {
                    try
                    {
                        bl.UpdateCustomer(tb_id.Text, dtp_ngaydi.Value, tb_cccd.Text, tb_ten.Text, tb_sdt.Text);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!!!");
                    }
                    Modify = Modify.none;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập Đầy đủ thông tin!");
                }
            }
            LoadData();
            if (Modify == Modify.none)
                Enable_Info_text(false);
        }
        private void Count_Customer(string ma, DateTime  ngaydi)
        {
            tb_kh.Text = (bl.Count_Customer(ma, ngaydi)).ToString();
        }

        private void cbb_id_tk_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!starting)
            {
                Count_Customer(cbb_id_tk.Text, Convert.ToDateTime(cbb_ngaydi_tk.Text));
                cbb_ngaydi_tk.DataSource = bl.FillterCustomer_Date_Follow_ID(cbb_id_tk.Text);
                this.cbb_ngaydi_tk.DisplayMember = "Ngày bắt đầu";
            }
        }

        private void cbb_ngaydi_tk_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!starting)
                Count_Customer(cbb_id_tk.Text, Convert.ToDateTime(cbb_ngaydi_tk.Text));
        }
    }
}
