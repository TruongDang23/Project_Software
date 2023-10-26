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
        public string GetID(string UserName, string Pass)
        {
            var id = (from tk in entity.TaiKhoans
                      where tk.TenDangNhap == UserName && tk.MatKhau == Pass
                      select tk.MaTaiKhoan).FirstOrDefault();
            return id.ToString();
        }

        public bool GetLoginMag(string UserName, string Pass)
        {
            var tkComp = (from tk in entity.TaiKhoans
                          where tk.TenDangNhap == UserName && tk.MatKhau == Pass && tk.MaTaiKhoan.Substring(0, 1) == "M"
                          select tk).FirstOrDefault();
            return tkComp != null;
        }

        public bool GetLoginUser(string UserName, string Pass)
        {
            var tkEmp = (from tk in entity.TaiKhoans
                         where tk.TenDangNhap == UserName && tk.MatKhau == Pass && tk.MaTaiKhoan.Substring(0, 1) == "U"
                         select tk).FirstOrDefault();
            return tkEmp != null;
        }

        public string GetPass(string UserName, string Email)
        {
            var pass = (from tk in entity.TaiKhoans
                        join ttcn in entity.ThongTinCaNhans on tk.MaTaiKhoan equals ttcn.MaTaiKhoan
                        where tk.TenDangNhap == UserName && ttcn.Email == Email
                        select tk.MatKhau).FirstOrDefault();
            return pass;
        }

        public bool AddUser(string tk, string mk, string nhaplaimk, ref string err)
        {
            if (mk == nhaplaimk)
            {
                long id = CountUser() + 1;
                TaiKhoan taikhoan = new TaiKhoan()
                {
                    TenDangNhap = tk,
                    MatKhau = mk,
                    MaTaiKhoan = "U" + id.ToString(),
                };

                entity.TaiKhoans.Add(taikhoan);
                entity.SaveChanges();
                return true;
            }
            else { return false; }
            
        }

        public bool AddThongTin(string hovaten, string sdt, string diachi, string email, ref string err)
        {
            
                long id = CountUser() + 1;
                ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan()
                {
                    MaTaiKhoan = "U" + id.ToString(),
                    Ten=hovaten,
                    SDT=sdt,
                    DiaChi=diachi,
                    Email=email,
                    
                };

                entity.ThongTinCaNhans.Add(thongTinCaNhan);
                entity.SaveChanges();
                return true;
        }

        public long CountUser()
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
