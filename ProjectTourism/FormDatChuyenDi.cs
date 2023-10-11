using ProjectTourism.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTourism
{
    public partial class FormDatChuyenDi : Form
    {
        private BLUser tasks = new BLUser();
        private string MaChuyenDi;
        private DateTime NgayBatDau;
        public FormDatChuyenDi(string MaChuyenDi, DateTime NgayBatDau)
        {
            InitializeComponent();
            this.MaChuyenDi = MaChuyenDi;
            this.NgayBatDau = NgayBatDau;
        }
    }
}
