using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
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
                select new
                {
                    MaChuyenDi = g.Key.MaChuyenDi,
                    NgayBatDau = g.Key.NgayBatDau,
                    SoLuongNow = g.Count()
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
                    SoLuongMax = cd.SoLuong
                };

            var datas =
                from i in information
                join lp in list_passenger
                on new { i.MaChuyenDi, i.NgayBatDau } equals new { lp.MaChuyenDi, lp.NgayBatDau } into g
                from lp in g.DefaultIfEmpty()
                where i.NgayBatDau >= fromdate && i.NgayBatDau <= todate
                select new
                {
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

            if (not_eligible == false)
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
            DataTable dt = new DataTable();
            var datas =
                from cd in entity.ChuyenDis
                select cd.MaChuyenDi;
            dt.Columns.Add("Mã Tour", typeof(string));
            foreach (var data in datas)
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

        public DataTable LoadTickets(string IDTour, DateTime date)
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
            foreach (var data in datas)
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
                dt.Rows.Add(data.MaHDV, data.Ten, data.SDT, data.Email);
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
                dt.Rows.Add(data.MaChuyenDi, data.TenChuyenDi, data.HinhThuc, data.HanhTrinh, data.SoNgayDi, data.Gia, data.SoLuong, data.ChiTiet);
            }
            return dt;
        }
        public DataTable Load_dgvQLDanhGia()
        {
            DataTable dt = new DataTable();
            var datas =
                from cd in entity.DanhGias
                select new { cd.MaChuyenDi, cd.MaTaiKhoan, cd.Sao, cd.BinhLuan };

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
        public DataTable Load_dgv_Idtour()
        {
            DataTable dt = new DataTable();
            var datas = from lt in entity.LichTrinhs
                        select new { lt.MaChuyenDi, lt.NgayBatDau, lt.MaHDV };
            dt.Columns.Add("Mã Chuyến Đi", typeof(string));
            dt.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            dt.Columns.Add("Mã HDV", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi, data.NgayBatDau, data.MaHDV);
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
        public DataTable FilterRate(string IDTour)
        {
            DataTable dt = new DataTable();
            var datas = from cd in entity.DanhGias
                        where cd.MaChuyenDi == IDTour
                        select new { cd.MaChuyenDi, cd.MaTaiKhoan, cd.Sao, cd.BinhLuan };

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
        public void Update_LichTrinh(string MaChuyenDi, DateTime NgayBatDau, string MaHDV)
        {
            var tpQuery = entity.LichTrinhs.SingleOrDefault(lt => lt.MaChuyenDi == MaChuyenDi &&
            lt.NgayBatDau.Year == NgayBatDau.Year && lt.NgayBatDau.Month == NgayBatDau.Month && lt.NgayBatDau.Day == NgayBatDau.Day);

            if (tpQuery != null)
            {
                tpQuery.MaChuyenDi = MaChuyenDi;
                tpQuery.NgayBatDau = NgayBatDau;
                tpQuery.MaHDV = MaHDV;
                entity.SaveChanges();
            }
        }
        public void Huy_PhanCong(string MaChuyenDi, DateTime NgayBatDau)
        {
            var tpQuery = entity.LichTrinhs.SingleOrDefault(lt => lt.MaChuyenDi == MaChuyenDi &&
            lt.NgayBatDau.Year == NgayBatDau.Year && lt.NgayBatDau.Month == NgayBatDau.Month && lt.NgayBatDau.Day == NgayBatDau.Day);

            if (tpQuery != null)
            {
                tpQuery.MaChuyenDi = MaChuyenDi;
                tpQuery.NgayBatDau = NgayBatDau;
                tpQuery.MaHDV = null;
                entity.SaveChanges();
            }
        }
        public DataTable LichTrinhHD(string MaHDV)
        {
            DataTable dt = new DataTable();
            var datas = from lt in entity.LichTrinhs
                        where lt.MaHDV == MaHDV
                        select new { lt.MaChuyenDi, lt.NgayBatDau, lt.MaHDV };
            dt.Columns.Add("Mã Chuyến Đi", typeof(string));
            dt.Columns.Add("NgayBatDau", typeof(DateTime));
            dt.Columns.Add("Mã HDV", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi, data.NgayBatDau, data.MaHDV);
            }
            return dt;
        }
        public void Delete(string MaChuyenDi)
        {

            var danhSachDuKhachToRemove = entity.DanhSachDuKhaches.Where(x => x.MaChuyenDi == MaChuyenDi).ToList();
            entity.DanhSachDuKhaches.RemoveRange(danhSachDuKhachToRemove);

            var danhSachDangKiToRemove = entity.DanhSachDangKies.Where(x => x.MaChuyenDi == MaChuyenDi).ToList();
            entity.DanhSachDangKies.RemoveRange(danhSachDangKiToRemove);

            var YeuCauToRemove = entity.YeuCaus.Where(x => x.MaChuyenDi == MaChuyenDi).ToList();
            entity.YeuCaus.RemoveRange(YeuCauToRemove);

            var DanhGiaToRemove = entity.DanhGias.Where(x => x.MaChuyenDi == MaChuyenDi).ToList();
            entity.DanhGias.RemoveRange(DanhGiaToRemove);

            var LichTrinhToRemove = entity.LichTrinhs.Where(x => x.MaChuyenDi == MaChuyenDi).ToList();
            entity.LichTrinhs.RemoveRange(LichTrinhToRemove);

            var ChuyenDiToRemove = entity.ChuyenDis.Where(x => x.MaChuyenDi == MaChuyenDi).ToList();
            entity.ChuyenDis.RemoveRange(ChuyenDiToRemove);

            entity.SaveChanges();
        }
        public void Update_Tour(string MaTour, string TenTour, string HinhThuc, string HanhTrinh, int SoNgayDi, string Gia, int SoLuong)
        {
            var tpQuery = (from idtour in entity.ChuyenDis
                           where idtour.MaChuyenDi == MaTour
                           select idtour).SingleOrDefault();

            if (tpQuery != null)
            {
                tpQuery.TenChuyenDi = TenTour;
                tpQuery.HinhThuc = HinhThuc;
                tpQuery.HanhTrinh = HanhTrinh;
                tpQuery.SoNgayDi = SoNgayDi;
                tpQuery.Gia = Gia;
                tpQuery.SoLuong = SoLuong;
                entity.SaveChanges();
            }
        }
        public DataTable GetAllDataAccount()
        {
            DataTable dt = new DataTable();
            var datas = from tk in entity.TaiKhoans
                        select new { tk.TenDangNhap, tk.MatKhau, tk.MaTaiKhoan };
            dt.Columns.Add("Tên đăng nhập", typeof(string));
            dt.Columns.Add("Mật khẩu", typeof(string));
            dt.Columns.Add("Mã tài khoản", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.TenDangNhap, data.MatKhau, data.MaTaiKhoan);
            }
            return dt;
        }
        public DataTable GetDataPersonal(string matk)
        {
            DataTable dt = new DataTable();
            var datas = from per in entity.ThongTinCaNhans
                        where per.MaTaiKhoan == matk
                        select new { per.MaTaiKhoan, per.Ten, per.SDT, per.DiaChi, per.Email };
            dt.Columns.Add("Mã tài khoản", typeof(string));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            dt.Columns.Add("Địa chỉ", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaTaiKhoan, data.Ten, data.SDT, data.DiaChi, data.Email);
            }
            return dt;
        }
        public DataTable GetDataJoinTour(string matk)
        {
            DataTable dt = new DataTable();
            var datas = from per in entity.DanhSachDangKies
                        where per.MaTaiKhoan == matk
                        select new { per.MaTaiKhoan, per.MaChuyenDi, per.NgayBatDau, per.SoLuong, per.TrangThai };
            dt.Columns.Add("Mã tài khoản", typeof(string));
            dt.Columns.Add("Mã chuyến đi", typeof(string));
            dt.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            dt.Columns.Add("Số Lượng", typeof(int));
            dt.Columns.Add("Trạng thái", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaTaiKhoan, data.MaChuyenDi, data.NgayBatDau, data.SoLuong, data.TrangThai);
            }
            return dt;
        }
        public void AddAccount(string tentk, string mk, string matk)
        {
            TaiKhoan new_acc = new TaiKhoan();

            new_acc.TenDangNhap = tentk;
            new_acc.MatKhau = mk;
            new_acc.MaTaiKhoan = matk;


            entity.TaiKhoans.Add(new_acc);
            entity.SaveChanges();
        }
        public bool Is_Account_Exist(string tendn)
        {
            var acc = (from tk in entity.TaiKhoans
                       where tk.TenDangNhap == tendn
                       select tk).SingleOrDefault();
            if (acc == null) { return  false; }
            return true;
        }
        public void AddInfoPersonal(string matk, string ten, string sdt, string diachi, string email)
        {
            ThongTinCaNhan new_tt = new ThongTinCaNhan();

            new_tt.MaTaiKhoan = matk;
            new_tt.Ten = ten;
            new_tt.SDT = sdt;
            new_tt.DiaChi = diachi;
            new_tt.Email = email;


            entity.ThongTinCaNhans.Add(new_tt);
            entity.SaveChanges();
        }
        public void UpdateInfoPersonal(string matk, string ten, string sdt, string diachi, string email)
        {
            var tpQuery = (from info_per in entity.ThongTinCaNhans
                           where info_per.MaTaiKhoan == matk
                           select info_per).SingleOrDefault();

            if (tpQuery != null)
            {
                tpQuery.Ten = ten;
                tpQuery.SDT = sdt;
                tpQuery.DiaChi = diachi;
                tpQuery.Email = email;
                entity.SaveChanges();
            }
        }
        public void DeleteAccount(string tentk, string matk)
        {
            ThongTinCaNhan ttcn = entity.ThongTinCaNhans.Where(x => x.MaTaiKhoan == matk).FirstOrDefault<ThongTinCaNhan>();
            entity.ThongTinCaNhans.Remove(ttcn);
            entity.SaveChanges();

            TaiKhoan tk = entity.TaiKhoans.Where(x => x.TenDangNhap == tentk).FirstOrDefault<TaiKhoan>();
            entity.TaiKhoans.Remove(tk);
            entity.SaveChanges();
        }
        public string GetNewIdAccount()
        {
            int[] id_num = { 0, 0, 1 };
            while (true)
            {
                string matk = "U" + id_num[0].ToString() + id_num[1].ToString() + id_num[2].ToString();
                var tpQuery = (from info_per in entity.ThongTinCaNhans
                               where info_per.MaTaiKhoan == matk
                               select info_per).SingleOrDefault();
                if (tpQuery != null)
                {
                    id_num[2] = id_num[2] + 1;
                    id_num[1] = id_num[1] + id_num[2] / 10;
                    id_num[0] = id_num[0] + id_num[1] / 10;

                    id_num[2] = id_num[2] % 10;
                    id_num[1] = id_num[1] % 10;
                    id_num[0] = id_num[0] % 10;
                }
                else { break; }
            }
            return "U" + id_num[0].ToString() + id_num[1].ToString() + id_num[2].ToString();
        }
        public DataTable GetAllDataCustomer()
        {
            DataTable dt = new DataTable();
            var datas = from per in entity.DanhSachDuKhaches
                        select new { per.MaChuyenDi, per.NgayBatDau, per.CCCD, per.Ten, per.SDT };
            dt.Columns.Add("Mã chuyến đi", typeof(string));
            dt.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            dt.Columns.Add("CCCD", typeof(string));
            dt.Columns.Add("Tên du khách", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi, data.NgayBatDau, data.CCCD, data.Ten, data.SDT);
            }
            return dt;
        }
        public DataTable FillterCustomer_IDTour()
        {
            DataTable dt = new DataTable();
            var datas = (from per in entity.DanhSachDuKhaches
                         select new { per.MaChuyenDi }).Distinct();
            dt.Columns.Add("Mã chuyến đi", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi);
            }
            return dt;
        }
        public DataTable FillterCustomer_Date()
        {
            DataTable dt = new DataTable();
            var datas = (from per in entity.DanhSachDuKhaches
                         select new { per.NgayBatDau }).Distinct();
            dt.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.NgayBatDau);
            }
            return dt;
        }
        public DataTable FillterCustomer_Date_Follow_ID(string id)
        {
            DataTable dt = new DataTable();
            var datas = (from per in entity.DanhSachDuKhaches
                         where per.MaChuyenDi == id
                         select new { per.NgayBatDau }).Distinct();
            dt.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.NgayBatDau);
            }
            return dt;
        }
        public DataTable FillterCustomer_CCCD()
        {
            DataTable dt = new DataTable();
            var datas = (from per in entity.DanhSachDuKhaches
                         select new { per.CCCD }).Distinct();
            dt.Columns.Add("CCCD", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.CCCD);
            }
            return dt;
        }
        public DataTable FillterCustomer_Ten()
        {
            DataTable dt = new DataTable();
            var datas = (from per in entity.DanhSachDuKhaches
                         select new { per.Ten }).Distinct();
            dt.Columns.Add("Tên", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.Ten);
            }
            return dt;
        }
        public DataTable Fillter_Customer(bool att1, bool att2, bool att3, bool att4, string ma, DateTime date, string cccd, string ten)
        {
            DataTable dt = new DataTable();
            var datas = (from per in entity.DanhSachDuKhaches
                         where (per.MaChuyenDi == ma || !att1) && (per.NgayBatDau ==date || !att2) 
                                && (per.CCCD == cccd || !att3) && (per.Ten == ten || !att4)
                         select new { per.MaChuyenDi, per.NgayBatDau, per.CCCD, per.Ten, per.SDT });

            dt.Columns.Add("Mã chuyến đi", typeof(string));
            dt.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            dt.Columns.Add("CCCD", typeof(string));
            dt.Columns.Add("Tên du khách", typeof(string));
            dt.Columns.Add("SDT", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaChuyenDi, data.NgayBatDau, data.CCCD, data.Ten, data.SDT);
            }
            return dt;
        }
        public void AddCustomer(string ma, DateTime date, string cccd, string ten, string sdt)
        {
            DanhSachDuKhach new_dk = new DanhSachDuKhach();

            new_dk.MaChuyenDi = ma;
            new_dk.NgayBatDau = date;
            new_dk.CCCD = cccd;
            new_dk.Ten = ten;
            new_dk.SDT = sdt;

            entity.DanhSachDuKhaches.Add(new_dk);
            entity.SaveChanges();
        }
        public bool Is_Customer_Exist(string id, DateTime ngaydi, string cccd)
        {
            var acc = (from tk in entity.DanhSachDuKhaches
                       where tk.MaChuyenDi == id && tk.NgayBatDau == ngaydi && tk.CCCD == cccd
                       select tk).SingleOrDefault();
            if (acc == null) { return false; }
            return true;
        }
        public void UpdateCustomer(string ma, DateTime date, string cccd, string ten, string sdt)
        {
            var tpQuery = (from info_cus in entity.DanhSachDuKhaches
                           where info_cus.MaChuyenDi == ma && info_cus.NgayBatDau == date && info_cus.CCCD == cccd
                           select info_cus).SingleOrDefault();

            if (tpQuery != null)
            {
                tpQuery.Ten = ten;
                tpQuery.SDT = sdt;
                entity.SaveChanges();
            }
        }
        public void DeleteCustomer(string ma, DateTime ngay, string cccd)
        {
            DanhSachDuKhach dk = entity.DanhSachDuKhaches.Where(x => x.MaChuyenDi == ma && x.NgayBatDau == ngay && x.CCCD == cccd).FirstOrDefault<DanhSachDuKhach>();
            entity.DanhSachDuKhaches.Remove(dk);
            entity.SaveChanges();
        }
        public int Count_Customer(string ma, DateTime ngaydi)
        {
            var tpQuery = (from info_cus in entity.DanhSachDuKhaches
                           where info_cus.MaChuyenDi == ma && info_cus.NgayBatDau == ngaydi
                           select info_cus);
            int count = 0;
            foreach (var info_cus in tpQuery)
            {
                count++;
            }
            return count;
        }
        public DataTable GetDataRequest()
        {
            DataTable dt = new DataTable();
            var datas = from req in entity.YeuCaus
                        select new { req.MaTaiKhoan, req.MaChuyenDi, req.NgayBatDau, req.SoLuong};
            dt.Columns.Add("Mã tài khoản", typeof(string));
            dt.Columns.Add("Mã chuyến đi", typeof(string));
            dt.Columns.Add("Ngày bắt đầu", typeof(DateTime));
            dt.Columns.Add("Số lượng", typeof(int));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.MaTaiKhoan, data.MaChuyenDi,data.NgayBatDau, data.SoLuong);
            }
            return dt;
        }
        public void DeleteRequest(string matk, string macd, DateTime ngaydi)
        {
            YeuCau yc = entity.YeuCaus.Where(x => x.MaTaiKhoan == matk && x.MaChuyenDi == macd && x.NgayBatDau == ngaydi).FirstOrDefault<YeuCau>();
            entity.YeuCaus.Remove(yc);
            entity.SaveChanges();
        }
        public DataTable GetDataUsername()
        {
            DataTable dt = new DataTable();
            var datas = from tk in entity.TaiKhoans
                        select new { tk.TenDangNhap };
            dt.Columns.Add("Tên người dùng", typeof(string));
            foreach (var data in datas)
            {
                dt.Rows.Add(data.TenDangNhap);
            }
            return dt;
        }
        public string GetIDAccount(string username)
        {
            var datas = (from tk in entity.TaiKhoans
                         where tk.TenDangNhap == username
                         select tk.MaTaiKhoan).SingleOrDefault();
            return datas;
        }
        public string GetEmail(string matk)
        {
            var datas = (from tk in entity.ThongTinCaNhans
                         where tk.MaTaiKhoan == matk
                         select tk.Email ).SingleOrDefault();
            return datas;
        }
    }   
}
