﻿using System;
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

        public DataTable layChiTietChuyenDi(string MaChuyenDi, DateTime NgayBatDau)
        {
            DataTable dt = new DataTable();
            var chuyendi = from cd in entity.ChuyenDis
                           join lt in entity.LichTrinhs on cd.MaChuyenDi equals lt.MaChuyenDi
                           join dg in entity.DanhGias on cd.MaChuyenDi equals dg.MaChuyenDi
                           where cd.MaChuyenDi == MaChuyenDi && lt.NgayBatDau == NgayBatDau
                           select new { cd.TenChuyenDi, cd.HanhTrinh, cd.HinhThuc, cd.SoNgayDi, cd.SoLuong, cd.Gia, dg.Sao, lt.NgayBatDau, cd.ChiTiet };
            dt.Columns.Add("TenChuyenDi", typeof(string));
            dt.Columns.Add("HanhTrinh",typeof(string));
            dt.Columns.Add("HinhThuc",typeof(string));
            dt.Columns.Add("SoNgayDi",typeof(int));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("Gia", typeof(string));
            dt.Columns.Add("Sao",typeof (int));
            dt.Columns.Add("NgayBatDau", typeof(DateTime));
            dt.Columns.Add("ChiTiet", typeof(string));

            foreach(var ct in chuyendi)
            {
                dt.Rows.Add(ct.TenChuyenDi, ct.HanhTrinh, ct.HinhThuc, ct.SoNgayDi, ct.SoLuong, ct.Gia, ct.Sao, ct.NgayBatDau, ct.ChiTiet);
            }
            return dt;
        }

        public void ThemDuKhachDK(string MaChuyenDi, DateTime NgayBatDau, string CCCD, string Ten, string SDT)
        {
            DanhSachDuKhach dukhach = new DanhSachDuKhach();

            dukhach.MaChuyenDi = MaChuyenDi;
            dukhach.NgayBatDau = NgayBatDau;
            dukhach.CCCD = CCCD;
            dukhach.Ten = Ten;
            dukhach.SDT = SDT;

            entity.DanhSachDuKhaches.Add(dukhach);
            entity.SaveChanges();
        }

        public void ThemDanhSachDK(string MaTaiKhoan, string MaChuyenDi, DateTime NgayBatDau, int SoLuong, string TrangThai)
        {
            DanhSachDangKy dky = new DanhSachDangKy();

            dky.MaTaiKhoan = MaTaiKhoan;
            dky.MaChuyenDi = MaChuyenDi;
            dky.NgayBatDau = NgayBatDau;
            dky.SoLuong = SoLuong;
            dky.TrangThai = TrangThai;

            entity.DanhSachDangKies.Add(dky);
            entity.SaveChanges();
        }

    }
}
