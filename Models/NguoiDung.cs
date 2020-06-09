namespace FreeTime1.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class NguoiDung
    {
        [Key]
        [Display(Name = "Mã Người Dùng")]
        [StringLength(5)]
        public string MaND { get; set; }
        [Display(Name = "Tài Khoản")]
        [Key]
        public string TaiKhoan { get; set; }
        [Display(Name = "Mật Khẩu")]
        [Key]
        public string MatKhau { get; set; }

        [Display(Name = "Nhập Lại Mật Khẩu")]
        [Key]
        [Compare("MatKhau")]
        [NotMapped]
        public string NhapLaiMatKhau { get; set; }
        [Display(Name = "Chức vụ")]
        [Key]
        public string ChucVu { get; set; }
        [Display(Name = "Họ và Tên")]
        [Key]
        public string HoTen { get; set; }
        [Display(Name = "Số điện thoại")]
        public string SDT { get; set; }
        [Display(Name = "Ảnh")]
        public string Anh { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Giới Tính")]
        public bool GioiTinh { get; set; }
    }
}
