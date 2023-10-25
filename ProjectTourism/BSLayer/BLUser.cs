using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataTable Load_dgvDSChuyenDi()
        {
            DataTable dt = new DataTable();
            var chuyendi = from cd in entity.ChuyenDis
                           join lt in entity.LichTrinhs on cd.MaChuyenDi equals lt.MaChuyenDi
                           join dg in entity.DanhGias on cd.MaChuyenDi equals dg.MaChuyenDi
                           where cd.MaChuyenDi == lt.MaChuyenDi && lt.NgayBatDau == lt.NgayBatDau
                           select new { cd.MaChuyenDi,cd.TenChuyenDi, cd.HanhTrinh, lt.NgayBatDau, cd.SoNgayDi, cd.SoLuong, cd.Gia, dg.Sao };
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
                dt.Rows.Add( data.MaChuyenDi,data.TenChuyenDi, data.HanhTrinh,data.NgayBatDau, data.SoNgayDi, data.SoLuong, data.Gia, data.Sao);
            }
            return dt;
        }
        public DataTable FilterData(string diemden ,DateTime ngaybatdau, string gia, int sao, bool not_eligible)
        {
            DataTable dt = new DataTable();

            var list_passenger =
                from dk in entity.DanhSachDuKhaches
                group dk by new { dk.MaChuyenDi, dk.NgayBatDau } into g
                select new
                {
                    MaChuyenDi = g.Key.MaChuyenDi,
                    NgayBatDau = g.Key.NgayBatDau,
                    SoLuongHienTai = g.Count()
                };

            var information =
                from l in entity.LichTrinhs
                join cd in entity.ChuyenDis
                on l.MaChuyenDi equals cd.MaChuyenDi
                select new
                {
                    MaChuyenDi = l.MaChuyenDi,
                    NgayBatDau = l.NgayBatDau,
                    MaHDV = l.MaHDV,
                    SoLuongToiDa = cd.SoLuong
                };

            var datas =
                from i in information
                join lp in list_passenger
                on new { i.MaChuyenDi, i.NgayBatDau } equals new { lp.MaChuyenDi, lp.NgayBatDau } into g
                from lp in g.DefaultIfEmpty()
                where i.SoLuongToiDa <= quantity

                select new
                {
                    i.MaChuyenDi,
                    i.NgayBatDau,
                    MaHDV = i.MaHDV ?? "",
                    SoLuongHienTai = (int?)lp.SoLuongHienTai ?? 0,
                    i.SoLuongToiDa
                };

            
    }
}
