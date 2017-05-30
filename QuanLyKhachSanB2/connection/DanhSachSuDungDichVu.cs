namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhSachSuDungDichVu")]
    public partial class DanhSachSuDungDichVu
    {
        [Key]
        public int MaSuDungDV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDichVu { get; set; }

        public int MaNhanPhong { get; set; }

        public int? SoLuong { get; set; }
    }
}
