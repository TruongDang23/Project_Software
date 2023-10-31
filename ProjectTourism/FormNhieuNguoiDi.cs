using ProjectTourism.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectTourism
{
    public partial class FormNhieuNguoiDi : Form
    {
        private BLUser tasks = new BLUser();
        private string maTaiKhoan;
        private string maChuyenDi;
        private DateTime ngayBatDau;
        private int soLuong;
        private int dem = 0;

        public FormNhieuNguoiDi(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau, int soLuong)
        {
            InitializeComponent();
            this.maTaiKhoan = maTaiKhoan;
            this.maChuyenDi = maChuyenDi;
            this.ngayBatDau = ngayBatDau;
            this.soLuong = soLuong;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string ten = tb_HoVaTen.Text;
            string cccd = tb_CCCD.Text; 
            string sdt = tbSDT.Text;
            string[] row = {ten, sdt, cccd};
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                if(kiemTraCCCDDataGridview(cccd))
                {
                    MessageBox.Show("Du khách này đã được được ký!");
                    ResetData();
                }
                else
                {
                    dtgv_DanhSachNguoiDi.Rows.Add(row);
                    ResetData();
                    dem += 1;
                    if (dem == soLuong)
                        btn_Them.Enabled = false;
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_DanhSachNguoiDi.SelectedCells.Count > 0)
            {
                dtgv_DanhSachNguoiDi.Rows.RemoveAt(dtgv_DanhSachNguoiDi.SelectedCells[0].RowIndex);
                dem -= 1;
                btn_Them.Enabled = true;
            }
            else
                MessageBox.Show("Không có du khách nào được chọn!");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (kiemTraCCCDDataGridview(tb_CCCD.Text))
            {
                MessageBox.Show("Du khách này đã được được ký!");
                ResetData();
            }    
            else
            {
                dtgv_DanhSachNguoiDi.Rows[dtgv_DanhSachNguoiDi.CurrentRow.Index].Cells[0].Value = tb_HoVaTen.Text;
                dtgv_DanhSachNguoiDi.Rows[dtgv_DanhSachNguoiDi.CurrentRow.Index].Cells[1].Value = tbSDT.Text;
                dtgv_DanhSachNguoiDi.Rows[dtgv_DanhSachNguoiDi.CurrentRow.Index].Cells[2].Value = tb_CCCD.Text;
            }
        }

        private void ResetData()
        {
            tb_HoVaTen.ResetText();
            tb_CCCD.ResetText();
            tbSDT.ResetText();
            tb_HoVaTen.Focus();
        }

        private bool kiemTraCCCDDataGridview(string CCCD)
        {
            string cccdMoi = tb_CCCD.Text; 
            bool isDuplicate = false;

            foreach (DataGridViewRow row in dtgv_DanhSachNguoiDi.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == cccdMoi)
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate)
                return true;
            else
                return false;
        }

        private void dtgv_DanhSachNguoiDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgv_DanhSachNguoiDi.CurrentCell.RowIndex;
            if (dtgv_DanhSachNguoiDi.Rows.Count >0)
            {
                tb_HoVaTen.Text = dtgv_DanhSachNguoiDi.Rows[r].Cells[0].Value.ToString();
                tbSDT.Text = dtgv_DanhSachNguoiDi.Rows[r].Cells[1].Value.ToString();
                tb_CCCD.Text = dtgv_DanhSachNguoiDi.Rows[r].Cells[2].Value.ToString();
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgv_DanhSachNguoiDi.Rows)
            {
                if (!row.IsNewRow)
                {
                    string ten = row.Cells["HoTen"].Value.ToString();
                    string cccd = row.Cells["ccd"].Value.ToString();
                    string sdt = row.Cells["SDT"].Value.ToString();

                    tasks.ThemDuKhachDK(this.maChuyenDi, this.ngayBatDau,cccd,ten,sdt);
                }
            }
            try
            {
                tasks.ThemDanhSachDK(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau, this.soLuong, "Chưa thanh toán");
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã đặt chuyến đi này rồi");
                return;
            }
            FormBoxThanhToan formBoxThanhToan = new FormBoxThanhToan(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau, this.soLuong);
            this.Hide();
            formBoxThanhToan.ShowDialog();
            Close();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FormDatChuyenDi formDatChuyenDi = new FormDatChuyenDi(this.maTaiKhoan, this.maChuyenDi, this.ngayBatDau);
            this.Hide();
            formDatChuyenDi.ShowDialog();
            Close();
        }
    }
}
