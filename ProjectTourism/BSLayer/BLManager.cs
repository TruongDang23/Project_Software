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
                select new {
                    MaChuyenDi = g.Key.MaChuyenDi,
                    NgayBatDau = g.Key.NgayBatDau,
                    SoLuongNow = g.Count()
                };

            var information =
                from l in entity.LichTrinhs
                join cd in entity.ChuyenDis
                on l.MaChuyenDi equals cd.MaChuyenDi
                select new {
                    MaChuyenDi = l.MaChuyenDi,
                    NgayBatDau = l.NgayBatDau,
                    MaHDV = l.MaHDV,
                    SoLuongMax = cd.SoLuong
                };

            var datas =
                from i in information
                join lp in list_passenger
                on new { i.MaChuyenDi, i.NgayBatDau } equals new { lp.MaChuyenDi, lp.NgayBatDau } into g
                from lp in g.DefaultIfEmpty()
                where i.NgayBatDau >= fromdate && i.NgayBatDau <= todate
                select new {
                    i.MaChuyenDi,
                    i.NgayBatDau,
                    MaHDV = i.MaHDV ?? "",
                    SoLuongNow = (int?)lp.SoLuongNow ?? 0,
                    i.SoLuongMax
                };

            dt.Columns.Add("Mã Tour");
            dt.Columns.Add("Ngày khởi hành");
            dt.Columns.Add("Mã hướng dẫn viên");
            dt.Columns.Add("Số lượng đã đăng ký");
            dt.Columns.Add("Số lượng tối đa");

            foreach (var data in datas)
            {
                dt.Rows.Add(
                    data.MaChuyenDi,
                    data.NgayBatDau,
                    data.MaHDV,
                    data.SoLuongNow,
                    data.SoLuongMax 
                    ); 
            }
            return dt;
        }

        public DataTable FilterData(string idTour, string idGuide, int quantity, bool not_eligible)
        {
            DataTable dt = new DataTable();

            var list_passenger =
                from dk in entity.DanhSachDuKhaches
                group dk by new { dk.MaChuyenDi, dk.NgayBatDau } into g
                select new {
                    MaChuyenDi = g.Key.MaChuyenDi,
                    NgayBatDau = g.Key.NgayBatDau,
                    SoLuongHienTai = g.Count()
                };

            var information =
                from l in entity.LichTrinhs
                join cd in entity.ChuyenDis
                on l.MaChuyenDi equals cd.MaChuyenDi
                select new {
                    MaChuyenDi = l.MaChuyenDi,
                    NgayBatDau = l.NgayBatDau,
                    MaHDV = l.MaHDV,
                    SoLuongToiDa = cd.SoLuong };

            var datas =
                from i in information
                join lp in list_passenger
                on new { i.MaChuyenDi, i.NgayBatDau } equals new { lp.MaChuyenDi, lp.NgayBatDau } into g
                from lp in g.DefaultIfEmpty()
                where i.SoLuongToiDa <= quantity

                select new {
                    i.MaChuyenDi,
                    i.NgayBatDau,
                    MaHDV = i.MaHDV ?? "",
                    SoLuongHienTai = (int?)lp.SoLuongHienTai ?? 0,
                    i.SoLuongToiDa
                };

            if (!string.IsNullOrEmpty(idTour))
            {
                datas = datas.Where(i => i.MaChuyenDi == idTour);
            }

            if (!string.IsNullOrEmpty(idGuide))
            {
                datas = datas.Where(i => i.MaHDV == idGuide);
            }

            if (not_eligible == true)
            {
                datas = datas.Where(i => i.SoLuongToiDa * 0.5 > i.SoLuongHienTai
                                    || i.SoLuongHienTai == (int?)i.SoLuongHienTai
                                    || i.MaHDV == "");
            }

            if(not_eligible == false)
            {
                datas = datas.Where(i => i.SoLuongToiDa * 0.5 <= i.SoLuongHienTai);
            }

            dt.Columns.Add("Mã Tour");
            dt.Columns.Add("Ngày khởi hành");
            dt.Columns.Add("Mã hướng dẫn viên");
            dt.Columns.Add("Số lượng đã đăng ký");
            dt.Columns.Add("Số lượng tối đa");

            foreach (var data in datas)
            {
                dt.Rows.Add(
                    data.MaChuyenDi,
                    data.NgayBatDau,
                    data.MaHDV,
                    data.SoLuongHienTai,
                    data.SoLuongToiDa
                    );
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

        public DataTable LoadGuides()
        {
            DataTable dt = new DataTable();
            var datas =
                from hdv in entity.HuongDanViens
                select hdv.MaHDV;
            dt.Columns.Add("Mã Hướng dẫn viên", typeof(string));
            foreach (var data in datas)
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

        public void DeleteItinerary(string IDTour, DateTime StartDay)
        {
            LichTrinh lt = new LichTrinh
            {
                MaChuyenDi = IDTour,
                NgayBatDau = StartDay
            };

            entity.LichTrinhs.Attach(lt);
            entity.LichTrinhs.Remove(lt);
            entity.SaveChanges();
        }

        public DataTable GetNameOfTour(string IDTour)
        {
            var datas = from t in entity.ChuyenDis
                    where t.MaChuyenDi == IDTour
                    select new { t.TenChuyenDi, t.HinhThuc };

            DataTable n = new DataTable();
            n.Columns.Add("Ten", typeof(string));
            n.Columns.Add("HinhThuc", typeof(string));

            foreach (var data in datas)
            {
                n.Rows.Add(data.TenChuyenDi);
                n.Rows.Add(data.HinhThuc);
            }
            return n;
        }

        public DataTable LoadTickets (string IDTour,DateTime date)
        {
            var datas = from sub in entity.DanhSachDangKies
                        where sub.MaChuyenDi == IDTour && sub.NgayBatDau.Day == date.Day && 
                        sub.NgayBatDau.Month == date.Month && sub.NgayBatDau.Year == date.Year
                        select new { sub.MaChuyenDi, sub.MaTaiKhoan, sub.NgayBatDau, sub.SoLuong, sub.TrangThai };

            DataTable n = new DataTable();
            n.Columns.Add("Mã Chuyến Đi", typeof(string));
            n.Columns.Add("Mã Tài Khoản", typeof(string));
            n.Columns.Add("Ngày khởi hành", typeof(DateTime));
            n.Columns.Add("Số lượng đăng ký", typeof(int));
            n.Columns.Add("Trạng Thái", typeof(string));

            foreach (var data in datas)
            {
                n.Rows.Add(
                    data.MaChuyenDi,
                    data.MaTaiKhoan,
                    data.NgayBatDau,
                    data.SoLuong,
                    data.TrangThai
                    );
            }

            return n;
        }
        public DataTable LoadDataGuide()
        {
            DataTable dt = new DataTable();
            var datas =
                from hdv in entity.HuongDanViens
                select hdv;
            dt.Columns.Add("Mã Hướng dẫn viên", typeof(string));
            dt.Columns.Add("Tên Hướng dẫn viên", typeof(string));
            dt.Columns.Add("Số Điện Thoại", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaHDV, data.Ten, data.SDT,data.Email);
            }
            return dt;
        }
        public bool CheckIDGuide(string MaHDV)
        {
            var tpQuery = (from hdv in entity.HuongDanViens
                           where hdv.MaHDV == MaHDV
                           select hdv).SingleOrDefault();
            if (tpQuery != null)
                return true;
            return false;
        }
        public void DeleteDataGuide(string MaHDV)
        {
            HuongDanVien hdv = new HuongDanVien();
            hdv.MaHDV = MaHDV;
            entity.HuongDanViens.Attach(hdv);
            entity.HuongDanViens.Remove(hdv);
            entity.SaveChanges();
        }
        public void AddDataGuide(string MaHDV, string Ten, string sdt, string email)
        {
            HuongDanVien hdv = new HuongDanVien();
            hdv.MaHDV = MaHDV;
            hdv.Ten = Ten;
            hdv.SDT = sdt;
            hdv.Email = email;

            entity.HuongDanViens.Add(hdv);
            entity.SaveChanges();
        }
        public DataTable Load_dgvQLTour()
        {
            DataTable dt = new DataTable();
            var datas =
                from cd in entity.ChuyenDis
                select new { cd.MaChuyenDi, cd.TenChuyenDi, cd.HinhThuc, cd.HanhTrinh, cd.SoNgayDi, cd.Gia, cd.SoLuong, cd.ChiTiet };

            dt.Columns.Add("Mã Tour", typeof(string));
            dt.Columns.Add("Tên Tour", typeof(string));
            dt.Columns.Add("Hình Thức", typeof(string));
            dt.Columns.Add("Hành Trình", typeof(string));
            dt.Columns.Add("Số Ngày Đi", typeof(int));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Columns.Add("Chi Tiết", typeof(string));

            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi, data.TenChuyenDi, data.HinhThuc, data.HanhTrinh, data.SoNgayDi, data.Gia, data.SoLuong, data.ChiTiet) ;
            }
            return dt;
        }
    }
}
