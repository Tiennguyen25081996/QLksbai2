namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiPhong { get; set; }

        public int MaLoaiTinhTrang { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
