using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTourism.BSLayer;
namespace ProjectTourism
{
    public partial class FormQuanLyLichTrinh : Form
    {
        private BLManager tasks = new BLManager();
        public FormQuanLyLichTrinh()
        {
            InitializeComponent();
        }

        private void FormQuanLyLichTrinh_Load(object sender, EventArgs e)
        {
            LoadItinerary(DateTime.Now.Date, DateTime.Now.Date.AddMonths(1));
            this.cbb_AddTours.DataSource = tasks.LoadTours();
            this.cbb_AddTours.DisplayMember = "Mã Tour";
            this.cbb_FindTours.DataSource = tasks.LoadTours();
            this.cbb_FindTours.DisplayMember = "Mã Tour";
            this.cbb_FindGuides.DataSource = tasks.LoadGuides();
            this.cbb_FindGuides.DisplayMember = "Mã Hướng dẫn viên";
        }
        
        private void LoadItinerary(DateTime from, DateTime to)
        {
            try
            {
                dgv_Tours.DataSource = tasks.LoadItinerary(from, to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadItinerary(string idTour, string idGuide, int quantity, bool not_eligible)
        {
            try
            {
                dgv_Tours.DataSource = tasks.FilterData(idTour, idGuide, quantity, not_eligible);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            LoadItinerary(this.monthCalendar.SelectionRange.Start, this.monthCalendar.SelectionRange.End);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string maChuyenDi = this.cbb_AddTours.Text;
            DateTime ngayBD = this.dt_AddTour.Value;
            tasks.AddItinerary(maChuyenDi, ngayBD);
            LoadItinerary(DateTime.Now.Date, DateTime.Now.Date.AddMonths(1));
        }

        private void btn_FindTour_Click(object sender, EventArgs e)
        {
            string idTour = this.cbb_FindTours.Text;
            string idGuide = this.cbb_FindGuides.Text;
            int quantity = Convert.ToInt32(this.numeric_Quantity.Value);
            bool not_eligible = (this.cb_NotEligible.Checked) ? true : false;
            LoadItinerary(idTour, idGuide, quantity, not_eligible);
        }

        private void dgv_Tours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = this.dgv_Tours.CurrentCell.RowIndex;
            DataTable nametype = tasks.GetNameOfTour(dgv_Tours.Rows[n].Cells[0].Value.ToString());
            this.lbl_IDTour.Text = dgv_Tours.Rows[n].Cells[0].Value.ToString();
            this.dt_InfoTour.Value = DateTime.Parse(dgv_Tours.Rows[n].Cells[1].Value.ToString());
            this.lbl_NameTour.Text = nametype.Rows[0][0].ToString();
            this.lbl_Type.Text = nametype.Rows[1][0].ToString();
            this.lbl_Quantity.Text = dgv_Tours.Rows[n].Cells[4].Value.ToString();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            int n = this.dgv_Tours.CurrentCell.RowIndex;
            string IDTour = dgv_Tours.Rows[n].Cells[0].Value.ToString();
            DateTime StartDay = DateTime.Parse(dgv_Tours.Rows[n].Cells[1].Value.ToString());
            tasks.DeleteItinerary(IDTour, StartDay);
            LoadItinerary(DateTime.Now.Date, DateTime.Now.Date.AddMonths(1));
        }
    }
}
