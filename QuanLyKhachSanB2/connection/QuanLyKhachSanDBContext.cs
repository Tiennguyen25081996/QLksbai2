namespace QuanLyKhachSanB2.connection
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyKhachSanDBContext : DbContext
    {
        public QuanLyKhachSanDBContext()
            : base("name=QuanLyKhachSanDBContext")
        {
        }

        public virtual DbSet<ChiTietPhieuNhanPhong> ChiTietPhieuNhanPhongs { get; set; }
        public virtual DbSet<ChiTietPhieuThuePhong> ChiTietPhieuThuePhongs { get; set; }
        public virtual DbSet<DanhSachSuDungDichVu> DanhSachSuDungDichVus { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public virtual DbSet<LoaiNguoiDung> LoaiNguoiDungs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<ThietBi> ThietBis { get; set; }
        public virtual DbSet<TinhTrang> TinhTrangs { get; set; }
        public virtual DbSet<hehe> hehes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuNhanPhong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuThuePhong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachSuDungDichVu>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaLoaiDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNhanPhong)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DienThoai)
                .IsFixedLength();

            modelBuilder.Entity<LoaiDichVu>()
                .Property(e => e.MaLoaiDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.MaLoaiPhong)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.DonGiaTheoNgay)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SĐT)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaLoaiPhong)
                .IsUnicode(false);

            modelBuilder.Entity<ThietBi>()
                .Property(e => e.MaThietBi)
                .IsUnicode(false);

            modelBuilder.Entity<ThietBi>()
                .Property(e => e.MaLoaiPhong)
                .IsUnicode(false);

            modelBuilder.Entity<TinhTrang>()
                .Property(e => e.MaLoaiTinhTrang)
                .IsUnicode(false);

            modelBuilder.Entity<hehe>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<hehe>()
                .Property(e => e.MaLoaiPhong)
                .IsUnicode(false);

            modelBuilder.Entity<hehe>()
                .Property(e => e.DonGiaTheoNgay)
                .HasPrecision(18, 0);

            modelBuilder.Entity<hehe>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);
        }
    }
}
