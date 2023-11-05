using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTourism.BSLayer;

namespace ProjectTourism
{
    
    public partial class FormQuenMK : Form
    {
        private BLSystem bl = new BLSystem();
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
            string mk = bl.GetMatKhau(txtTenDangNhap.Text);
            if (bl.GetEmail(bl.GetIDAccount(txtTenDangNhap.Text)) == txtMail.Text && bl.ExistAccount(txtTenDangNhap.Text))
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("nckh211103@gmail.com", "owgr culp dizl hvwa");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("nckh211103@gmail.com");
                mailMessage.To.Add(new MailAddress(bl.GetEmail(bl.GetIDAccount(txtTenDangNhap.Text))));
                mailMessage.Subject = "Mail lấy lại mật khẩu";
                mailMessage.Body = "Mật khẩu của bạn là: " + mk;

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
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc email không chính xác !", "Thông báo");
            }
        }

        private void FormQuenMK_Load(object sender, EventArgs e)
        {

        }
    }
}
