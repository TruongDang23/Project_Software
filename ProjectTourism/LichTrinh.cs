//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectTourism
{
    using System;
    using System.Collections.Generic;
    
    public partial class LichTrinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichTrinh()
        {
            this.DanhSachDangKies = new HashSet<DanhSachDangKy>();
            this.DanhSachDuKhaches = new HashSet<DanhSachDuKhach>();
        }
    
        public string MaChuyenDi { get; set; }
        public System.DateTime NgayBatDau { get; set; }
        public string MaHDV { get; set; }
    
        public virtual ChuyenDi ChuyenDi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachDangKy> DanhSachDangKies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachDuKhach> DanhSachDuKhaches { get; set; }
        public virtual HuongDanVien HuongDanVien { get; set; }
    }
}
