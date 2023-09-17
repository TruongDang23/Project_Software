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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "../../../Details/HaLong001/AnhChiTiet2.jpg";
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
