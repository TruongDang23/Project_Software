using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectTourism.BSLayer
{
    internal class BLUser
    {
        private software2023Entities entity = new software2023Entities();
        public BLUser() { }

        public DataTable LayChiTietChuyenDi(string maChuyenDi, DateTime ngayBatDau)
        {
            DataTable dt = new DataTable();
            var chuyendi = from cd in entity.ChuyenDis
                           join lt in entity.LichTrinhs on cd.MaChuyenDi equals lt.MaChuyenDi
                           join dg in entity.DanhGias on cd.MaChuyenDi equals dg.MaChuyenDi
                           where cd.MaChuyenDi == maChuyenDi && lt.NgayBatDau == ngayBatDau
                           select new { cd.TenChuyenDi, cd.HanhTrinh, cd.HinhThuc, cd.SoNgayDi, cd.SoLuong, cd.Gia, dg.Sao, lt.NgayBatDau, cd.ChiTiet };
            dt.Columns.Add("TenChuyenDi", typeof(string));
            dt.Columns.Add("HanhTrinh", typeof(string));
            dt.Columns.Add("HinhThuc", typeof(string));
            dt.Columns.Add("SoNgayDi", typeof(int));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("Gia", typeof(string));
            dt.Columns.Add("Sao", typeof(int));
            dt.Columns.Add("NgayBatDau", typeof(DateTime));
            dt.Columns.Add("ChiTiet", typeof(string));

            foreach (var ct in chuyendi)
            {
                dt.Rows.Add(ct.TenChuyenDi, ct.HanhTrinh, ct.HinhThuc, ct.SoNgayDi, ct.SoLuong, ct.Gia, ct.Sao, ct.NgayBatDau, ct.ChiTiet);
            }
            return dt;
        }

        public void ThemDuKhachDK(string maChuyenDi, DateTime ngayBatDau, string cCCD, string ten, string sDT)
        {
            DanhSachDuKhach dukhach = new DanhSachDuKhach();

            dukhach.MaChuyenDi = maChuyenDi;
            dukhach.NgayBatDau = ngayBatDau;
            dukhach.CCCD = cCCD;
            dukhach.Ten = ten;
            dukhach.SDT = sDT;

            entity.DanhSachDuKhaches.Add(dukhach);
            entity.SaveChanges();
        }

        public void ThemDanhSachDK(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau, int soLuong, string trangThai)
        {
            DanhSachDangKy dky = new DanhSachDangKy();

            dky.MaTaiKhoan = maTaiKhoan;
            dky.MaChuyenDi = maChuyenDi;
            dky.NgayBatDau = ngayBatDau;
            dky.SoLuong = soLuong;
            dky.TrangThai = trangThai;

            var tpQuery = (from dk in entity.DanhSachDangKies
                           where dk.MaTaiKhoan == maTaiKhoan && dk.MaChuyenDi == maChuyenDi && dk.NgayBatDau == ngayBatDau
                           select dk).SingleOrDefault();

            if(tpQuery == null)
            {
                entity.DanhSachDangKies.Add(dky);
                entity.SaveChanges();
            }
            else
            {
                tpQuery.SoLuong = tpQuery.SoLuong + soLuong;
                entity.SaveChanges();
            }
        }

        public void ThemDanhSachDKy(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau, int soLuong, string trangThai)
        {
            DanhSachDangKy dky = new DanhSachDangKy();
            LichTrinh lt = new LichTrinh();

            dky.MaTaiKhoan = maTaiKhoan;
            dky.MaChuyenDi = maChuyenDi;
            dky.NgayBatDau = ngayBatDau;
            dky.SoLuong = soLuong;
            dky.TrangThai = trangThai;

            lt.MaChuyenDi = maChuyenDi;
            lt.NgayBatDau = ngayBatDau;
            lt.MaHDV = null;

            entity.LichTrinhs.Add(lt);
            entity.DanhSachDangKies.Add(dky);
            entity.SaveChanges();
        }


        public void XoaDanhSachDK(string maTaiKhoan, string maChuyenDi, DateTime ngayBatDau)
        {
            DanhSachDangKy dk = new DanhSachDangKy
            {
                MaTaiKhoan = maTaiKhoan,
                MaChuyenDi = maChuyenDi,
                NgayBatDau = ngayBatDau,
            };

            entity.DanhSachDangKies.Attach(dk);
            entity.DanhSachDangKies.Remove(dk);
            entity.SaveChanges();
        }

        public void XoaDuKhachDK(string maChuyenDi, DateTime ngayBatDau, string cCCD)
        {
            DanhSachDuKhach dk = new DanhSachDuKhach
            {
                MaChuyenDi = maChuyenDi,
                NgayBatDau = ngayBatDau,
                CCCD = cCCD,
            };

            entity.DanhSachDuKhaches.Attach(dk);
            entity.DanhSachDuKhaches.Remove(dk);
            entity.SaveChanges();
        }

        public int SoTienThanhToan(string maChuyenDi, DateTime ngayBatDau, int soLuong)
        {
            int gia = 0;
            var chuyendi = from cd in entity.ChuyenDis
                           where cd.MaChuyenDi == maChuyenDi
                           select new { cd.Gia };
            foreach (var ct in chuyendi)
            {
                gia = (int)ct.Gia;
            }
            return gia * soLuong;
        }

        public DataTable DanhSachDanhGia(string MaChuyenDi, DateTime NgayBatDau)
        {
            DataTable dt = new DataTable();
            // Gộp hai bảng ThongTinCaNhan và DanhGia, để lấy các cột Ten, BinhLuan, Sao với điều kiện là hai bảng có cùng MaTaiKhoan
            var danhgia = from dg in entity.DanhGias
                          join tk in entity.TaiKhoans on dg.MaTaiKhoan equals tk.MaTaiKhoan
                          join tt in entity.ThongTinCaNhans on tk.MaTaiKhoan equals tt.MaTaiKhoan
                          where dg.MaTaiKhoan == tk.MaTaiKhoan && tk.MaTaiKhoan == tt.MaTaiKhoan
                          select new { tt.Ten, dg.BinhLuan, dg.Sao };
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("BinhLuan", typeof(string));
            dt.Columns.Add("Sao", typeof(int));

            foreach (var ct in danhgia)
            {
                dt.Rows.Add(ct.Ten, ct.BinhLuan, ct.Sao);
            }
            return dt;
        }

        public void ThemDanhGia(string maTaiKhoan, string maChuyenDi, string binhLuan, int sao)
        {
            DanhGia dg = new DanhGia();

            dg.MaTaiKhoan = maTaiKhoan;
            dg.MaChuyenDi = maChuyenDi;
            dg.BinhLuan = binhLuan;
            dg.Sao = sao;

            entity.DanhGias.Add(dg);
            entity.SaveChanges();
        }

        public DataTable Load_dgvDSChuyenDi()
        {
            DataTable dt = new DataTable();

            var average_star = from dg in entity.DanhGias
                               group dg by new { dg.MaChuyenDi } into g
                               select new
                               {
                                   MaChuyenDi = g.Key.MaChuyenDi,
                                   Sao = g.Average(dg => dg.Sao)
                               };

            var chuyendi = from cd in entity.ChuyenDis
                           join lt in entity.LichTrinhs on cd.MaChuyenDi equals lt.MaChuyenDi
                           join avg_s in average_star on cd.MaChuyenDi equals avg_s.MaChuyenDi
                           where cd.MaChuyenDi == lt.MaChuyenDi && cd.MaChuyenDi == avg_s.MaChuyenDi
                           select new { cd.MaChuyenDi, cd.TenChuyenDi, cd.HanhTrinh, lt.NgayBatDau, cd.SoNgayDi, cd.SoLuong, cd.Gia, avg_s.Sao };

            dt.Columns.Add("Mã Tour", typeof(string));
            dt.Columns.Add("Tên Tour", typeof(string));
            dt.Columns.Add("Hành Trình", typeof(string));
            dt.Columns.Add("Khởi Hành", typeof(string));
            dt.Columns.Add("Số Ngày Đi", typeof(int));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số sao", typeof(string));

            foreach (var data in chuyendi)
            {
                dt.Rows.Add(data.MaChuyenDi, data.TenChuyenDi, data.HanhTrinh, data.NgayBatDau, data.SoNgayDi, data.SoLuong, data.Gia, data.Sao);
            }
            return dt;
        }

        public DataTable FindTour(string dest, DateTime start, int price, int rate)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Tour", typeof(string));
            dt.Columns.Add("Tên Tour", typeof(string));
            dt.Columns.Add("Hành Trình", typeof(string));
            dt.Columns.Add("Khởi Hành", typeof(DateTime));
            dt.Columns.Add("Số Ngày Đi", typeof(int));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Columns.Add("Giá", typeof(int));
            dt.Columns.Add("Số sao", typeof(Double));


            var average_star = from dg in entity.DanhGias
                               group dg by new { dg.MaChuyenDi } into g
                               select new
                               {
                                   MaChuyenDi = g.Key.MaChuyenDi,
                                   Sao = g.Average(dg => dg.Sao)
                               };

            var chuyendi = from cd in entity.ChuyenDis
                           join lt in entity.LichTrinhs on cd.MaChuyenDi equals lt.MaChuyenDi
                           join avg_s in average_star on cd.MaChuyenDi equals avg_s.MaChuyenDi
                           where cd.MaChuyenDi == lt.MaChuyenDi && cd.MaChuyenDi == avg_s.MaChuyenDi
                           select new { 
                               cd.MaChuyenDi, 
                               cd.TenChuyenDi, 
                               cd.HanhTrinh, 
                               lt.NgayBatDau, 
                               cd.SoNgayDi, 
                               cd.SoLuong, 
                               cd.Gia,
                               avg_s.Sao };

            if (!string.IsNullOrEmpty(dest))
            {
                chuyendi = chuyendi.Where(cd => cd.HanhTrinh.Contains(dest));
            }

            if (rate != 0)
            {
                chuyendi = chuyendi.Where(avg_s => avg_s.Sao <= rate);
            }

            if (start != new DateTime(1000,1,1))
            {
                chuyendi = chuyendi.Where(lt => start.Day == lt.NgayBatDau.Day && start.Month == lt.NgayBatDau.Month && start.Year == lt.NgayBatDau.Year);
            }

            if (price != 0)
            {
                chuyendi = chuyendi.Where(cd => cd.Gia <= price);
            }

            foreach (var data in chuyendi)
            {
                dt.Rows.Add(data.MaChuyenDi, data.TenChuyenDi, data.HanhTrinh, data.NgayBatDau, data.SoNgayDi, data.SoLuong, data.Gia, data.Sao);
            }
            return dt;
        }
    }
}
