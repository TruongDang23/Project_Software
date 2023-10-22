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
            Image img = new Bitmap("../../../Details/HaLong001/AnhChiTiet4.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        // Code của btn_LogOut
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            this.Close(); 
            t.Start();  
        }
        public static void OpenLoginForm()
        {
            Application.Run(new FormDNhap()); 
        }
        // Code của btn_LogOut
    }
}
