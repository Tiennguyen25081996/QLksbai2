using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
   public class LoaiPhongMod
    {
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public  DataTable FillDataSet_spgetMaloaiPhong()
        {          
               return ketnoi.FillDataTable("select * from LoaiPhong");
        }
        public DataTable FillDataSet_spgetallbymaloaiphong(String a)
        {
            return ketnoi.FillDataTable("select * from LoaiPhong where MaLoaiPhong like'"+a+"'");
        }
        public DataTable FillDataSet_spgethehe()
        {
            return ketnoi.FillDataTable("select HoaDon.MaHoaDon,HoaDon.NhanVienLap,HoaDon.NgayLap,ChiTietPhieuNhanPhong.MaKhachHang,Phong.MaPhong,KhachHang.TenKhachHang,ChiTietPhieuNhanPhong.NgayNhan,HoaDon.MaNhanPhong,ChiTietPhieuNhanPhong.NgayTraPhong,LoaiPhong.DonGiaTheoNgay,DanhSachSuDungDichVu.MaSuDungDV,DanhSachSuDungDichVu.SoLuong,DichVu.DonGia from HoaDon join KhachHang ON KhachHang.MaKhachHang = HoaDon.MaKhachHang Left join ChiTietPhieuNhanPhong on ChiTietPhieuNhanPhong.MaNhanPhong = HoaDon.MaNhanPhong join Phong on Phong.MaPhong = ChiTietPhieuNhanPhong.MaPhong join LoaiPhong on LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong Left Outer join DanhSachSuDungDichVu on DanhSachSuDungDichVu.MaNhanPhong = HoaDon.MaNhanPhong Left Outer join DichVu on DichVu.MaDichVu = DanhSachSuDungDichVu.MaDichVu");
        }
        public void delete(LoaiPhong p)
        {
            LoaiPhong ph = db.LoaiPhongs.Find(p.MaLoaiPhong);
            db.LoaiPhongs.Remove(ph);
            db.SaveChanges();
        }
        public void insert(LoaiPhong phong)
        {
            LoaiPhong p = new LoaiPhong();
            p.MaLoaiPhong = phong.MaLoaiPhong;
            p.TenLoaiPhong = phong.TenLoaiPhong;
            p.DonGiaTheoNgay = phong.DonGiaTheoNgay;
            db.LoaiPhongs.Add(p);
            db.SaveChanges();
        }
        public void Update(LoaiPhong phong)
        {
            LoaiPhong p = db.LoaiPhongs.SingleOrDefault(x => x.MaLoaiPhong == phong.MaLoaiPhong);
            p.MaLoaiPhong = phong.MaLoaiPhong;
            p.TenLoaiPhong = phong.TenLoaiPhong;
            p.DonGiaTheoNgay = phong.DonGiaTheoNgay;
            db.SaveChanges();
        }
    }
}
