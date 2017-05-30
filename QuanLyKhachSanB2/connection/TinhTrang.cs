namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinhTrang")]
    public partial class TinhTrang
    {
        [Key]
        [StringLength(10)]
        public string MaLoaiTinhTrang { get; set; }

        [StringLength(50)]
        public string TenLoaiTinhTrang { get; set; }
    }
}
