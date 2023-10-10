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

namespace ProjectTourism
{
    public partial class FormQuanLyTour : Form
    {
        private BLManager tasks = new BLManager();
        public FormQuanLyTour()
        {
            InitializeComponent();
        }

        private void FormQuanLyTour_Load(object sender, EventArgs e)
        {
            this.txtMaTour.Enabled = false;
            this.txtTenTour.Enabled = false;
            this.txtLoaiHinh.Enabled = false;
            this.txtSoNgayDi.Enabled = false;
            this.txtGiaVe.Enabled = false;
            this.txtDiaDiemNoiTieng.Enabled = false;
            this.btnThem1.Enabled = false;
            this.btnThem2.Enabled = false;
            this.btnThem3.Enabled = false;
            this.btnThem4.Enabled = false;
            this.btnDescrip.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
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
            this.txtMaTour.Text = dgvQLTour.Rows[n].Cells[0].Value.ToString();
            this.txtTenTour.Text = dgvQLTour.Rows[n].Cells[1].Value.ToString();
            this.txtLoaiHinh.Text = dgvQLTour.Rows[n].Cells[2].Value.ToString();
            this.txtSoNgayDi.Text = dgvQLTour.Rows[n].Cells[4].Value.ToString();
            this.txtGiaVe.Text = dgvQLTour.Rows[n].Cells[5].Value.ToString();
            this.txtDiaDiemNoiTieng.Text = dgvQLTour.Rows[n].Cells[3].Value.ToString();
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
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;

                fileName = dlg.FileName;
                MessageBox.Show(fileName);
            }
        }
        private void status_btn()
        {
            this.txtMaTour.Enabled = true;
            this.txtTenTour.Enabled = true;
            this.txtLoaiHinh.Enabled = true;
            this.txtSoNgayDi.Enabled = true;
            this.txtGiaVe.Enabled = true;
            this.txtDiaDiemNoiTieng.Enabled = true;
            this.btnThem1.Enabled = true;
            this.btnThem2.Enabled = true;
            this.btnThem3.Enabled = true;
            this.btnThem4.Enabled = true;
            this.btnDescrip.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem0_Click(object sender, EventArgs e)
        {
            status_btn();
            this.txtMaTour.Text = string.Empty;
            this.txtTenTour.Text = string.Empty;
            this.txtLoaiHinh.Text = string.Empty;
            this.txtSoNgayDi.Text = string.Empty;
            this.txtGiaVe.Text = string.Empty;
            this.txtDiaDiemNoiTieng.Text = string.Empty;

        }
    }
}
