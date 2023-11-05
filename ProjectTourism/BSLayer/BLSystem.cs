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

        public bool AddNguoiDung(string tk, string mk, string nhaplaimk,string matk, ref string err)
        {
            if (mk == nhaplaimk)
            {
                
                TaiKhoan taikhoan = new TaiKhoan()
                {
                    TenDangNhap = tk,
                    MatKhau = mk,
                    MaTaiKhoan = matk,
                };

                entity.TaiKhoans.Add(taikhoan);
                entity.SaveChanges();
                return true;
            }
            else { return false; }
            
        }
        public bool AddQuanLy(string tk, string mk, string nhaplaimk,string mataotk, ref string err)
        {
            string mataotaikhoan = "software2023";
            if (mk == nhaplaimk && mataotk==mataotaikhoan)
            {
                
                TaiKhoan taikhoan = new TaiKhoan()
                {
                    TenDangNhap = tk,
                    MatKhau = mk,
                    MaTaiKhoan = TaiKhoanMoiQuanLy(),
                };

                entity.TaiKhoans.Add(taikhoan);
                entity.SaveChanges();
                return true;
            }
            else { return false; }

        }
        
        public bool AddThongTin(string matk,string hovaten, string sdt, string diachi, string email, ref string err)
        { 
                ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan()
                {
                    MaTaiKhoan = matk,
                    Ten=hovaten,
                    SDT=sdt,
                    DiaChi=diachi,
                    Email=email,
                    
                };

                entity.ThongTinCaNhans.Add(thongTinCaNhan);
                entity.SaveChanges();
                return true;
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
        public bool IsExist(string id)
        {
            var acc = (from tk in entity.TaiKhoans
                       where tk.TenDangNhap == id 
                       select tk).SingleOrDefault();
            if (acc == null) { return false; }
            return true;
        }
        public string TaiKhoanMoiQuanLy()
        {
            int[] id_num = { 0, 0, 1 };
            while (true)
            {
                string matk = "M" + id_num[0].ToString() + id_num[1].ToString() + id_num[2].ToString();
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
            return "M" + id_num[0].ToString() + id_num[1].ToString() + id_num[2].ToString();
        }
        public string TaiKhoanMoiNguoiDung()
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
                         select tk.Email).SingleOrDefault();
            return datas;
        }
    }
}
