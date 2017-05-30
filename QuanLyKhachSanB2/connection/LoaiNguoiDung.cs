namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiNguoiDung")]
    public partial class LoaiNguoiDung
    {
        [Key]
        [Column("LoaiNguoiDung")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoaiNguoiDung1 { get; set; }

        [StringLength(50)]
        public string TenLoaiNguoiDung { get; set; }
    }
}
