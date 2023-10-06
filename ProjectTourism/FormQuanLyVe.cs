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

namespace ProjectTourism
{
    public partial class FormQuanLyVe : Form
    {
        private BLManager tasks = new BLManager();
        public FormQuanLyVe()
        {
            InitializeComponent();
        }

        private void FormQuanLyVe_Load(object sender, EventArgs e)
        {
            this.cbbListTour.DataSource = tasks.LoadTours();
            this.cbbListTour.DisplayMember = "Mã Tour";
        }

        private void StatisticsTickets(string IDTour,DateTime date)
        {
            try
            {
                this.dgvTicket.DataSource = tasks.LoadTickets(IDTour, date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            string IDTour = this.cbbListTour.Text;
            DateTime date = this.dt_Itinerary.Value;
            StatisticsTickets(IDTour,date);
        }
    }
}
