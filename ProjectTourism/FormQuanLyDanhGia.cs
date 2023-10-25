using ProjectTourism.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjectTourism
{
    public partial class FormQuanLyDanhGia : Form
    {
        private BLManager tasks = new BLManager();
        public FormQuanLyDanhGia()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDanhGia_dgv()
        {
            try
            {

                dgvQLDanhGia.DataSource = tasks.Load_dgvQLDanhGia();
                dgvQLDanhGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvQLDanhGia.AutoResizeColumns();
                dgvQLDanhGia.AllowUserToResizeColumns = true;
                dgvQLDanhGia.AllowUserToOrderColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormQuanLyDanhGia_Load(object sender, EventArgs e)
        {
            this.cbbMaTour.DataSource = tasks.LoadTours();
            this.cbbMaTour.DisplayMember = "Mã Tour";
            LoadDanhGia_dgv();
        }

        private void btnAVGRate_Click(object sender, EventArgs e)
        {
            string IDTour = this.cbbMaTour.Text;
            MessageBox.Show("Số Sao Trung Bình Của Mã Tour " + IDTour + ":" + tasks.AvgRate(IDTour));
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string IDTour = this.cbbMaTour.Text;
            dgvQLDanhGia.DataSource = tasks.FilterRate(IDTour);
        }
    }
}
