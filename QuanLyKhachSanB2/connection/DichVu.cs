namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [Key]
        [StringLength(10)]
        public string MaDichVu { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiDichVu { get; set; }

        public decimal? DonGia { get; set; }
    }
}
