namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }

        [StringLength(50)]
        public string NhanVienLap { get; set; }

        public int MaKhachHang { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNhanPhong { get; set; }

        public decimal? TongTien { get; set; }

        public DateTime? NgayLap { get; set; }
    }
}
