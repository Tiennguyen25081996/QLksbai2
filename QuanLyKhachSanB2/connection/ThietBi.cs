namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThietBi")]
    public partial class ThietBi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaThietBi { get; set; }

        [StringLength(50)]
        public string TenThietBi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaLoaiPhong { get; set; }

        public int? SoLuong { get; set; }
    }
}
