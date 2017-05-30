namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuThuePhong")]
    public partial class ChiTietPhieuThuePhong
    {
        [Key]
        public int MaPhieuThue { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public DateTime? NgayNhan { get; set; }
    }
}
