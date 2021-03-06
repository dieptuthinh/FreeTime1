//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeTime1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hang()
        {
            this.HangDonHangNhaps = new HashSet<HangDonHangNhap>();
            this.HangDonHangXuats = new HashSet<HangDonHangXuat>();
        }
    
        public string MaH { get; set; }
        public string MaMH { get; set; }
        public string MaNCC { get; set; }
        public System.DateTime HanSuDung { get; set; }
        public System.DateTime NgayNhap { get; set; }
        public decimal GiaNhap { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangDonHangNhap> HangDonHangNhaps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangDonHangXuat> HangDonHangXuats { get; set; }
        public virtual MauHang MauHang { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
