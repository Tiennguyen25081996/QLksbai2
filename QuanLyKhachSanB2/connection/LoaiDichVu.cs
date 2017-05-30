namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiDichVu")]
    public partial class LoaiDichVu
    {
        [Key]
        [StringLength(10)]
        public string MaLoaiDichVu { get; set; }

        [StringLength(50)]
        public string TenLoaiDichVu { get; set; }
    }
}
