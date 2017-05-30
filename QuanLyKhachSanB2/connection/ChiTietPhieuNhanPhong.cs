namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhanPhong")]
    public partial class ChiTietPhieuNhanPhong
    {
        [Key]
        public int MaNhanPhong { get; set; }

        [StringLength(10)]
        public string MaPhong { get; set; }

        public int? MaKhachHang { get; set; }

        [StringLength(50)]
        public string HoTenKhachHang { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        public DateTime? NgayNhan { get; set; }

        public DateTime? NgayTraPhong { get; set; }
    }
}
