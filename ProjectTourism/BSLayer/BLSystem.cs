using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTourism.BSLayer
{
    internal class BLSystem
    {
        private software2023Entities entity = new software2023Entities();
        public BLSystem() { }

        public string GetMaTaiKhoan(string tendangnhap, string matkhau)
        {
            var id = (from tk in entity.TaiKhoans
                      where tk.TenDangNhap == tendangnhap && tk.MatKhau == matkhau
                      select tk.MaTaiKhoan).FirstOrDefault();
            return id.ToString();
        }

        public bool GetDangNhapQuanLy(string tendangnhap, string matkhau)
        {
            var tkComp = (from tk in entity.TaiKhoans
                          where tk.TenDangNhap == tendangnhap && tk.MatKhau == matkhau && tk.MaTaiKhoan.Substring(0, 1) == "M"
                          select tk).FirstOrDefault();
            return tkComp != null;
        }

        public bool GetDangNhapNguoiDung(string tendangnhap, string matkhau)
        {
            var tkEmp = (from tk in entity.TaiKhoans
                         where tk.TenDangNhap == tendangnhap && tk.MatKhau == matkhau && tk.MaTaiKhoan.Substring(0, 1) == "U"
                         select tk).FirstOrDefault();
            return tkEmp != null;
        }

        public string GetMatKhau(string tendangnhap, string Email)
        {
            var pass = (from tk in entity.TaiKhoans
                        join ttcn in entity.ThongTinCaNhans on tk.MaTaiKhoan equals ttcn.MaTaiKhoan
                        where tk.TenDangNhap == tendangnhap && ttcn.Email == Email
                        select tk.MatKhau).FirstOrDefault();
            return pass;
        }

        public bool AddNguoiDung(string tk, string mk, string nhaplaimk, ref string err)
        {
            if (mk == nhaplaimk)
            {
                long id = DemNguoiDung() + 1;
                TaiKhoan taikhoan = new TaiKhoan()
                {
                    TenDangNhap = tk,
                    MatKhau = mk,
                    MaTaiKhoan = TaiKhoanMoi(id),
                };

                entity.TaiKhoans.Add(taikhoan);
                entity.SaveChanges();
                return true;
            }
            else { return false; }
            
        }
        
        public string TaiKhoanMoi(long id)
        {
            string mataikhoan;
            if (id < 10)
            {
                mataikhoan="U00"+id.ToString();
            }
            else if (id >= 10 || id < 100)
            {
                mataikhoan = "U0" + id.ToString();
            }
            else
            {
                mataikhoan = "U" + id.ToString();
            }

            return mataikhoan;

        }

        public bool AddThongTin(string hovaten, string sdt, string diachi, string email, ref string err)
        {
            
                long id = DemNguoiDung() + 1;
                ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan()
                {
                    MaTaiKhoan = TaiKhoanMoi(id),
                    Ten=hovaten,
                    SDT=sdt,
                    DiaChi=diachi,
                    Email=email,
                    
                };

                entity.ThongTinCaNhans.Add(thongTinCaNhan);
                entity.SaveChanges();
                return true;
        }

        public long DemNguoiDung()
        {
            var user = (from tk in entity.TaiKhoans
                       where tk.MaTaiKhoan.Substring(0, 1) == "U"
                       select tk.MaTaiKhoan).Count();
            return user;
        }

        public bool ExistAccount(string UserName)
        {
            var acc = (from tk in entity.TaiKhoans
                       where tk.TenDangNhap == UserName 
                       select tk).FirstOrDefault();
            if (acc != null)
                return true;
            return false;
        }
    }
}
