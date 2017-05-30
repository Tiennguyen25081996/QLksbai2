namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hehe")]
    public partial class hehe
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNhanPhong { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaPhong { get; set; }

        public DateTime? NgayNhan { get; set; }

        public DateTime? NgayTraPhong { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string MaLoaiPhong { get; set; }

        public decimal? DonGiaTheoNgay { get; set; }

        public decimal? TongTien { get; set; }
    }
}
