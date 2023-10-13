using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTourism.BSLayer;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Collections;

namespace ProjectTourism
{
    public partial class FormQuanLyTour : Form
    {
        private BLManager tasks = new BLManager();
        private string path;
        public FormQuanLyTour()
        {
            InitializeComponent();
        }

        private void FormQuanLyTour_Load(object sender, EventArgs e)
        {
            this.txtMaTour.Enabled = true;
            this.txtTenTour.Enabled = false;
            this.txtLoaiHinh.Enabled = false;
            this.txtSoNgayDi.Enabled = false;
            this.txtGiaVe.Enabled = false;
            this.txtDiaDiemNoiTieng.Enabled = false;
            this.txtSoLuong.Enabled = false;
            this.btnThemBia.Enabled = false;
            this.btnDescrip.Enabled = false;
            LoadTour_dgv();
        }
        private void LoadTour_dgv()
        {
            try
            {
                dgvQLTour.DataSource = tasks.Load_dgvQLTour();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvQLTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = this.dgvQLTour.CurrentCell.RowIndex;
            DataTable nametype = tasks.GetNameOfTour(dgvQLTour.Rows[n].Cells[0].Value.ToString());
            // Panel tạo tour
            // Panel thông tin chi tiết tour
            this.txtMaTourttt.Text = dgvQLTour.Rows[n].Cells[0].Value.ToString();
            this.txtTenTourttt.Text = dgvQLTour.Rows[n].Cells[1].Value.ToString();
            this.txtLoaiHinhttt.Text = dgvQLTour.Rows[n].Cells[2].Value.ToString();
            this.txtSoNgayDittt.Text = dgvQLTour.Rows[n].Cells[4].Value.ToString();
            this.txtGiaVettt.Text = dgvQLTour.Rows[n].Cells[5].Value.ToString();
            this.txtDiaDiemNoiTiengttt.Text = dgvQLTour.Rows[n].Cells[3].Value.ToString();
            // 4 Ảnh 
            string path = dgvQLTour.Rows[n].Cells[7].Value.ToString();
            this.picAnhBia.Image = Image.FromFile(path + "AnhBia.jpg");
            this.picAnhBia.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picAnh1.Image = Image.FromFile(path + "AnhChiTiet1.jpg");
            this.picAnh1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picAnh2.Image = Image.FromFile(path + "AnhChiTiet2.jpg");
            this.picAnh2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picAnh3.Image = Image.FromFile(path + "AnhChiTiet3.jpg");
            this.picAnh3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnDescrip_Click(object sender, EventArgs e)
        {
            OpenFileDialog sourceDialog = new OpenFileDialog();
            sourceDialog.Filter = "Text Files|*.txt";
            sourceDialog.Title = "Select an Text File to Move";

            if (sourceDialog.ShowDialog() == DialogResult.OK)
            {
                // Đường dẫn đến thư mục bạn muốn lưu tệp

                // Kết hợp đường dẫn và tên tệp đích
                string destinationFilePath = Path.Combine(path, "Description.txt");

                try
                {
                    // Đọc dữ liệu từ file nguồn
                    byte[] fileBytes = File.ReadAllBytes(sourceDialog.FileName);

                    // Ghi dữ liệu vào file đích
                    File.WriteAllBytes(destinationFilePath, fileBytes);

                    MessageBox.Show("Thêm Mô Tả Chi Tiết Thành Công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void status_btn()
        {
            this.txtMaTour.Enabled = true;
        }
        private void status_txt()
        {
            this.txtMaTour.Text = String.Empty;
            this.txtTenTour.Text = String.Empty;
            this.txtLoaiHinh.Text = String.Empty;
            this.txtSoNgayDi.Text = String.Empty;
            this.txtGiaVe.Text = String.Empty;
            this.txtDiaDiemNoiTieng.Text = String.Empty;
            this.txtSoLuong.Text = String.Empty;
        }

        private void btnThemBia_Click(object sender, EventArgs e)
        {
            OpenFileDialog sourceDialog = new OpenFileDialog();
            sourceDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            sourceDialog.Title = "Select an Image File to Move";

            if (sourceDialog.ShowDialog() == DialogResult.OK)
            {
                // Đường dẫn đến thư mục bạn muốn lưu tệp

                // Kết hợp đường dẫn và tên tệp đích
                string destinationFilePath = Path.Combine(path, "AnhBia.jpg");

                try
                {
                    // Đọc dữ liệu từ file nguồn
                    byte[] fileBytes = File.ReadAllBytes(sourceDialog.FileName);

                    // Ghi dữ liệu vào file đích
                    File.WriteAllBytes(destinationFilePath, fileBytes);

                    MessageBox.Show("Thêm Ảnh Bìa Thành Công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem0_Click(object sender, EventArgs e)
        {
            status_btn();
            string Ma_Tour = txtMaTour.Text;
            string dirPath = "../../../Details/";
            this.path = dirPath + Ma_Tour + "/";
            bool exist = Directory.Exists(path);
            // Kiểm tra xem đường dẫn thư mục tồn tại không.
            // Nếu không tồn tại, tạo thư mục này.
            if (!exist)
            {
                // Tạo thư mục.
                Directory.CreateDirectory(path);
                MessageBox.Show("Đã tạo thư mục thành công");
                this.txtMaTour.Enabled = false;
                this.txtTenTour.Enabled = true;
                this.txtLoaiHinh.Enabled = true;
                this.txtSoNgayDi.Enabled = true;
                this.txtGiaVe.Enabled = true;
                this.txtSoLuong.Enabled = true;
                this.txtDiaDiemNoiTieng.Enabled = true;
                this.btnThemBia.Enabled = true;
                this.btnDescrip.Enabled = true;
                this.btnLuu.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mã tour đã tồn tại");
            }
        }




        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string IDTour = this.txtMaTour.Text;
                string TenTour = this.txtTenTour.Text;
                string HinhThuc = this.txtLoaiHinh.Text;
                int SoNgayDi = int.Parse(this.txtSoNgayDi.Text);
                string Gia = this.txtGiaVe.Text;
                string HanhTrinh = this.txtDiaDiemNoiTieng.Text;
                int SoLuong = int.Parse(this.txtSoLuong.Text);
                string ChiTiet = path;
                tasks.Add_QLTour(IDTour, TenTour, HinhThuc, HanhTrinh, SoNgayDi, Gia, SoLuong, ChiTiet);
                MessageBox.Show("Lưu thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTour_dgv();
                status_txt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IDTour = this.txtMaTour.Text;
            tasks.Delete_QlTour(IDTour);
        }

        private void btnThemAnh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sourceDialog = new OpenFileDialog();
            sourceDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            sourceDialog.Title = "Select an Image File to Move";

            if (sourceDialog.ShowDialog() == DialogResult.OK)
            {
                // Đường dẫn đến thư mục bạn muốn lưu tệp

                // Kết hợp đường dẫn và tên tệp đích
                string destinationFilePath = Path.Combine(path, "AnhChiTiet1.jpg");

                try
                {
                    // Đọc dữ liệu từ file nguồn
                    byte[] fileBytes = File.ReadAllBytes(sourceDialog.FileName);

                    // Ghi dữ liệu vào file đích
                    File.WriteAllBytes(destinationFilePath, fileBytes);

                    MessageBox.Show("Thêm Ảnh 1 Thành Công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemAnh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog sourceDialog = new OpenFileDialog();
            sourceDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            sourceDialog.Title = "Select an Image File to Move";

            if (sourceDialog.ShowDialog() == DialogResult.OK)
            {
                // Đường dẫn đến thư mục bạn muốn lưu tệp

                // Kết hợp đường dẫn và tên tệp đích
                string destinationFilePath = Path.Combine(path, "AnhChiTiet2.jpg");

                try
                {
                    // Đọc dữ liệu từ file nguồn
                    byte[] fileBytes = File.ReadAllBytes(sourceDialog.FileName);

                    // Ghi dữ liệu vào file đích
                    File.WriteAllBytes(destinationFilePath, fileBytes);

                    MessageBox.Show("Thêm Ảnh 2 Thành Công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemAnh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog sourceDialog = new OpenFileDialog();
            sourceDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            sourceDialog.Title = "Select an Image File to Move";

            if (sourceDialog.ShowDialog() == DialogResult.OK)
            {
                // Đường dẫn đến thư mục bạn muốn lưu tệp

                // Kết hợp đường dẫn và tên tệp đích
                string destinationFilePath = Path.Combine(path, "AnhChiTiet3.jpg");

                try
                {
                    // Đọc dữ liệu từ file nguồn
                    byte[] fileBytes = File.ReadAllBytes(sourceDialog.FileName);

                    // Ghi dữ liệu vào file đích
                    File.WriteAllBytes(destinationFilePath, fileBytes);

                    MessageBox.Show("Thêm Ảnh 3 Thành Công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
