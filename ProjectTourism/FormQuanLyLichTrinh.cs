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
            LoadItinerary(DateTime.Now, DateTime.Now.AddMonths(1));
            this.cbb_AddTours.DataSource = tasks.LoadTours();
            this.cbb_AddTours.DisplayMember = "Mã Tour";
            this.cbb_FindTours.DataSource = tasks.LoadTours();
            this.cbb_FindTours.DisplayMember = "Mã Tour";
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

        private void btn_Find_Click(object sender, EventArgs e)
        {
            LoadItinerary(this.monthCalendar.SelectionRange.Start, this.monthCalendar.SelectionRange.End);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string maChuyenDi = this.cbb_AddTours.Text;
            DateTime ngayBD = this.dt_AddTour.Value;
            tasks.AddItinerary(maChuyenDi, ngayBD);
            LoadItinerary(DateTime.Now, DateTime.Now.AddMonths(1));
        }
    }
}
