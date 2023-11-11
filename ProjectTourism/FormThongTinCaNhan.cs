﻿using ProjectTourism.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ProjectTourism
{
    public partial class FormThongTinCaNhan : Form
    {
        private BLSystem blSystem = new BLSystem();
        private string err = "";
        private string matk;
        public FormThongTinCaNhan(string matk)
        {
            InitializeComponent();
            this.matk = matk;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hovaten=txtHoVaTen.Text;
            string sdt=txtSoDienThoai.Text;
            string diachi=txtDiaChi.Text;
            string email=txtemail.Text;
            try
            {          
                
                    DialogResult check;
                    check = MessageBox.Show("Do you want to add ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        blSystem.AddThongTin(this.matk,hovaten, sdt, diachi, email, ref err);
                        MessageBox.Show("Added Successfully!");
                        FormDNhap form = new FormDNhap();
                        form.ShowDialog();
                        this.Close();
                    }
            }
            catch (SqlException)
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}