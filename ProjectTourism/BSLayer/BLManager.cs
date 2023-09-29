using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTourism.BSLayer
{
    internal class BLManager
    {
        private software2023Entities entity = new software2023Entities();
        public BLManager() { }

        public DataTable LoadItinerary(DateTime fromdate, DateTime todate)
        {
            DataTable dt = new DataTable();

            var list_passenger =
                from dk in entity.DanhSachDuKhaches
                group dk by new { dk.MaChuyenDi, dk.NgayBatDau } into g
                select new { MaChuyenDi=g.Key.MaChuyenDi, NgayBatDau = g.Key.NgayBatDau, SoLuongNow = g.Count() };

            var information =
                from l in entity.LichTrinhs
                join cd in entity.ChuyenDis
                on l.MaChuyenDi equals cd.MaChuyenDi
                select new { MaChuyenDi = l.MaChuyenDi, NgayBatDau = l.NgayBatDau, MaHDV = l.MaHDV, SoLuongMax = cd.SoLuong };

            var datas =
                from i in information
                join lp in list_passenger
                on new { i.MaChuyenDi, i.NgayBatDau } equals new { lp.MaChuyenDi, lp.NgayBatDau } into g
                from lp in g.DefaultIfEmpty()
                where i.NgayBatDau >= fromdate && i.NgayBatDau <= todate
                select new { i.MaChuyenDi, i.NgayBatDau, i.MaHDV , SoLuongNow = (int?)lp.SoLuongNow ?? 0, i.SoLuongMax };

            dt.Columns.Add("Mã Tour");
            dt.Columns.Add("Ngày khởi hành");
            dt.Columns.Add("Mã hướng dẫn viên");
            dt.Columns.Add("Số lượng đã đăng ký");
            dt.Columns.Add("Số lượng tối đa");

            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi, data.NgayBatDau, data.MaHDV, data.SoLuongNow, data.SoLuongMax) ; 
            }
            return dt;
        }

        public DataTable LoadTours()
        {
            DataTable dt= new DataTable();
            var datas =
                from cd in entity.ChuyenDis
                select cd.MaChuyenDi;
            dt.Columns.Add("Mã Tour", typeof(string));
            foreach ( var data in datas)
            {
                dt.Rows.Add(data);
            }
            return dt;
        }

        public void AddItinerary(string MaChuyenDi, DateTime NgayBD)
        {
            LichTrinh lt = new LichTrinh();
            lt.MaChuyenDi = MaChuyenDi;
            lt.NgayBatDau = NgayBD;

            entity.LichTrinhs.Add(lt);
            entity.SaveChanges();
        }
    }
}
