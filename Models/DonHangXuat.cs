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
    
    public partial class DonHangXuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHangXuat()
        {
            this.HangDonHangXuats = new HashSet<HangDonHangXuat>();
        }
    
        public string MaDHX { get; set; }
        public string MaKH { get; set; }
        public System.DateTime NgayXuat { get; set; }
        public string GiamGia { get; set; }
        public string KieuGiamGia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangDonHangXuat> HangDonHangXuats { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
