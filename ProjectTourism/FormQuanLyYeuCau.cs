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
using System.Net.Mail;
using System.Net;

namespace ProjectTourism
{
    public partial class FormQuanLyYeuCau : Form
    {
        private BLManager bl = new BLManager();
        private YeuCau curr_re = new YeuCau();
        public FormQuanLyYeuCau()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dgv_yeucau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgv_yeucau.AllowUserToResizeColumns = false;
                dgv_yeucau.AllowUserToOrderColumns = false;
                dgv_yeucau.AllowUserToResizeRows = false;
                dgv_yeucau.DataSource = bl.GetDataRequest();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu yêu cầu của khách hàng!");
            }
            cbb_idacc.DataSource = bl.GetDataUsername();
            cbb_idacc.DisplayMember = "Tên người dùng";
        }
        private void FormQuanLyYeuCau_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Reset_Current()
        {
            curr_re.MaTaiKhoan = "";
            curr_re.MaChuyenDi = "";
            curr_re.NgayBatDau = DateTime.Now;
        }
        private void dgv_yeucau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_yeucau.CurrentCell.RowIndex;
            if (r < dgv_yeucau.Rows.Count - 1 && r >= 0)
            {
                curr_re.MaTaiKhoan = dgv_yeucau.Rows[r].Cells[0].Value.ToString();
                curr_re.MaChuyenDi = dgv_yeucau.Rows[r].Cells[1].Value.ToString();
                curr_re.NgayBatDau = Convert.ToDateTime(dgv_yeucau.Rows[r].Cells[2].Value);
            }
            else
            {
                Reset_Current();
            }
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            if (curr_re.MaChuyenDi != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Yêu cầu tạo chuyến đi mới. \n Mã chuyến đi: " + curr_re.MaChuyenDi +
                    "\n Ngày khởi hành: " + curr_re.NgayBatDau + " \n Chấp nhận yêu cầu?", "Yêu cầu tạo chuyến đi",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    bl.AddItinerary(curr_re.MaChuyenDi, curr_re.NgayBatDau);
                    bl.DeleteRequest(curr_re.MaTaiKhoan, curr_re.MaChuyenDi, curr_re.NgayBatDau);
                    Reset_Current();
                    LoadData();
                }
                else if(traloi == DialogResult.No)
                {
                    MessageBox.Show("Hủy thành công.", "Thông báo");
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (curr_re.MaTaiKhoan != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc chắn xóa yêu cầu của " + curr_re.MaTaiKhoan +
                    " muốn tạo chuyến đi " + curr_re.MaChuyenDi + " vào ngày " + curr_re.NgayBatDau + " không?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    bl.DeleteRequest(curr_re.MaTaiKhoan, curr_re.MaChuyenDi, curr_re.NgayBatDau);
                    LoadData();
                }
            }
            else { MessageBox.Show("Bạn chưa chọn yêu cầu để xóa!"); }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com"; 
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true; 
            smtpClient.Credentials = new NetworkCredential("nckh211103@gmail.com", "owgr culp dizl hvwa");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("nckh211103@gmail.com");
            mailMessage.To.Add(new MailAddress(bl.GetEmail(bl.GetIDAccount(cbb_idacc.Text)))); 
            mailMessage.Subject = tb_tieude.Text;
            mailMessage.Body = tb_noidung.Text; 

            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Gửi thành công.", "Thông báo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gửi thất bại... " + ex.Message, "Thông báo");
            }
        }
    }
}
