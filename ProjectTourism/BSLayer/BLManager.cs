using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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
            var datas = from sub in entity.DanhSachDuKhaches
                        where sub.MaChuyenDi == IDTour && sub.NgayBatDau.Day == date.Day && 
                        sub.NgayBatDau.Month == date.Month && sub.NgayBatDau.Year == date.Year
                        select new { sub.MaChuyenDi, sub.NgayBatDau, sub.CCCD, sub.Ten, sub.SDT };

            DataTable n = new DataTable();
            n.Columns.Add("Mã Chuyến Đi", typeof(string));
            n.Columns.Add("Ngày khởi hành", typeof(string));
            n.Columns.Add("CCCD", typeof(string));
            n.Columns.Add("Tên Du khách", typeof(string));
            n.Columns.Add("Số điện thoại", typeof(string));

            foreach (var data in datas)
            {
                n.Rows.Add(
                    data.MaChuyenDi,
                    data.NgayBatDau,
                    data.CCCD,
                    data.Ten,
                    data.SDT
                    );
            }

            return n;
        }

        public DataTable CountTickets(string IDTour, DateTime date)
        {
            DataTable dt = new DataTable();
            var subscriber = from dk in entity.DanhSachDuKhaches
                             group dk by new { dk.MaChuyenDi, dk.NgayBatDau } into g
                             select new
                             {
                                 MaChuyenDi = g.Key.MaChuyenDi,
                                 NgayBatDau = g.Key.NgayBatDau,
                                 SoLuongHienTai = g.Count()
                             };

            var datas = from sub in subscriber
                        join cd in entity.ChuyenDis on sub.MaChuyenDi equals cd.MaChuyenDi
                        where sub.MaChuyenDi == IDTour && sub.NgayBatDau.Day == date.Day && sub.NgayBatDau.Month == date.Month
                        && sub.NgayBatDau.Year == date.Year
                        select new
                        {
                            sub.SoLuongHienTai,
                            cd.SoLuong
                        };

            dt.Columns.Add("Số lượng hiện tại", typeof(string));
            dt.Columns.Add("Số lượng tối đa", typeof(string));
            foreach(var data in datas)
            {
                dt.Rows.Add(data.SoLuongHienTai, data.SoLuong);
            }

            return dt;
        }

        public void DeletePassenger(string iDTour, DateTime startDay, string CCCD)
        {
            DanhSachDuKhach dk = new DanhSachDuKhach
            {
                MaChuyenDi = iDTour,
                NgayBatDau = startDay,
                CCCD = CCCD,
            };

            entity.DanhSachDuKhaches.Attach(dk);
            entity.DanhSachDuKhaches.Remove(dk);
            entity.SaveChanges();
        }

        public void AddPassenger(string iDTour, DateTime startDay, string CCCD, string name, string sdt)
        {
            DanhSachDuKhach dk = new DanhSachDuKhach();
            dk.MaChuyenDi = iDTour;
            dk.NgayBatDau = startDay;
            dk.CCCD = CCCD;
            dk.Ten = name;
            dk.SDT = sdt;

            entity.DanhSachDuKhaches.Add(dk);
            entity.SaveChanges();
        }

        public DataTable FindPassenger(string name, string cccd, string sdt)
        {
            var pass = from dk in entity.DanhSachDuKhaches
                       select new { dk.Ten, dk.CCCD, dk.SDT };

            if (!string.IsNullOrEmpty(name))
            {
                pass = pass.Where(p => p.Ten == name);
            }

            if (!string.IsNullOrEmpty(cccd))
            {
                pass = pass.Where(p => p.CCCD == cccd);
            }

            if (!string.IsNullOrEmpty(sdt))
            {
                pass = pass.Where(p => p.SDT == sdt);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Tên du khách", typeof(string));
            dt.Columns.Add("CCCD", typeof(string));
            dt.Columns.Add("Số điện thoại", typeof(string));
            foreach (var p in pass)
            {
                dt.Rows.Add(p.Ten, p.CCCD, p.SDT);
            }

            return dt;
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
            HuongDanVien hdv = entity.HuongDanViens.Where(x => x.MaHDV == MaHDV).Single<HuongDanVien>();
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
        public void ChangeInfoGuide(string MaHDV, string Ten, string sdt, string email)
        {
            var tpQuery = (from hdv in entity.HuongDanViens
                           where hdv.MaHDV == MaHDV
                           select hdv).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.Ten = Ten;
                tpQuery.SDT = sdt;
                tpQuery.Email = email;
                entity.SaveChanges();
            }
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
        public DataTable Load_dgvQLDanhGia()
        {
            DataTable dt = new DataTable();
            var datas =
                from cd in entity.DanhGias
                select new { cd.MaChuyenDi, cd.MaTaiKhoan, cd.Sao, cd.BinhLuan};

            dt.Columns.Add("Mã Tour", typeof(string));
            dt.Columns.Add("Mã Tài Khoản", typeof(string));
            dt.Columns.Add("Số Sao", typeof(int));
            dt.Columns.Add("Bình Luận", typeof(string));


            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi, data.MaTaiKhoan, data.Sao, data.BinhLuan);
            }
            return dt;
        }
        public void Add_QLTour(string iDTour, string TenTour, string HinhThuc, string HanhTrinh, int SoNgayDi, string Gia, int SoLuong, string ChiTiet)
        {
            ChuyenDi new_tour = new ChuyenDi();

            new_tour.MaChuyenDi = iDTour;
            new_tour.TenChuyenDi = TenTour;
            new_tour.HinhThuc = HinhThuc;
            new_tour.HanhTrinh = HanhTrinh;
            new_tour.SoNgayDi = SoNgayDi;
            new_tour.Gia = Gia;
            new_tour.SoLuong = SoLuong;
            new_tour.ChiTiet = ChiTiet;

            entity.ChuyenDis.Add(new_tour);
            entity.SaveChanges();
        }
        public void Delete_QlTour(string iDTour)
        {
            ChuyenDi Tour = new ChuyenDi
            {
                MaChuyenDi = iDTour 
            };

            entity.ChuyenDis.Attach(Tour);
            entity.ChuyenDis.Remove(Tour);
            entity.SaveChanges();
        }
        public DataTable FilterRate(string IDTour)
        {
            DataTable dt = new DataTable();
            var datas = from cd in entity.DanhGias
                        where cd.MaChuyenDi == IDTour
                        select  new { cd.MaChuyenDi, cd.MaTaiKhoan, cd.Sao, cd.BinhLuan };

            dt.Columns.Add("Mã Tour", typeof(string));
            dt.Columns.Add("Mã Tài Khoản", typeof(string));
            dt.Columns.Add("Số Sao", typeof(int));
            dt.Columns.Add("Bình Luận", typeof(string));


            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi, data.MaTaiKhoan, data.Sao, data.BinhLuan);
            }
            return dt;

        }
        public string AvgRate(string IDTour)
        {
            var rate = (from cd in entity.DanhGias
                             where cd.MaChuyenDi == IDTour
                             select cd.Sao).Average();
            return rate.ToString();
        }
    }
}
