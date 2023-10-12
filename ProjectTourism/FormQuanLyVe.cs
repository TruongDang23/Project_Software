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
        private string IDTour;
        private DateTime date;
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

        private void StatictisQuantity(string IDTour,DateTime date)
        {
            try
            {
                this.lblNow.Text = tasks.CountTickets(IDTour, date).Rows[0][0].ToString();
                this.lblMax.Text = tasks.CountTickets(IDTour, date).Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            this.IDTour = this.cbbListTour.Text;
            this.date = this.dt_Itinerary.Value;
            StatisticsTickets(this.IDTour, this.date);
            StatictisQuantity(this.IDTour, this.date);
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = this.dgvTicket.CurrentCell.RowIndex;
            this.txtName.Text = dgvTicket.Rows[n].Cells[3].Value.ToString();
            this.txtCCCD.Text = dgvTicket.Rows[n].Cells[2].Value.ToString();
            this.txtSDT.Text = dgvTicket.Rows[n].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int n = this.dgvTicket.CurrentCell.RowIndex;
            string IDTour = this.dgvTicket.Rows[n].Cells[0].Value.ToString();
            string CCCD = this.dgvTicket.Rows[n].Cells[2].Value.ToString();
            DateTime startDay = Convert.ToDateTime(this.dgvTicket.Rows[n].Cells[1].Value.ToString());
            tasks.DeletePassenger(IDTour,startDay,CCCD);
            StatisticsTickets(this.IDTour, this.date);
            StatictisQuantity(this.IDTour, this.date);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string CCCD = this.txtCCCD.Text;
            string name = this.txtName.Text;
            string sdt = this.txtSDT.Text;
            tasks.AddPassenger(this.IDTour, this.date, CCCD, name, sdt);
            StatisticsTickets(this.IDTour, this.date);
            StatictisQuantity(this.IDTour, this.date);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string cccd = this.txtCCCD.Text;
            string name = this.txtName.Text;
            string sdt = this.txtSDT.Text;
            try
            {
                this.dgvTicket.DataSource = tasks.FindPassenger(name, cccd, sdt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
