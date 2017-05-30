using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
    public class HoaDonMod
    {
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public void delete(HoaDon p)
        {
            HoaDon ph = db.HoaDons.Find(p.MaHoaDon);
            db.HoaDons.Remove(ph);
            db.SaveChanges();
        }
        public void insert1(HoaDon phong)
        {
            HoaDon p = new HoaDon();
            p.MaKhachHang = phong.MaKhachHang;
            p.MaNhanPhong = phong.MaNhanPhong;
            p.NhanVienLap = phong.NhanVienLap;
            p.NgayLap = phong.NgayLap;
            db.HoaDons.Add(p);
            db.SaveChanges();
        }
        public void UpdateTongTien(HoaDon hd)
        {
            HoaDon p = db.HoaDons.SingleOrDefault(x => x.MaHoaDon == hd.MaHoaDon);
            p.MaKhachHang = hd.MaKhachHang;
            p.TongTien = hd.TongTien;
            p.NgayLap = hd.NgayLap;
            p.MaNhanPhong = hd.MaNhanPhong;
            db.SaveChanges();
        }
        public void Update(HoaDon phong)
        {
            HoaDon p = db.HoaDons.SingleOrDefault(x => x.MaHoaDon == phong.MaHoaDon);
            p.MaKhachHang = phong.MaKhachHang;
            p.MaNhanPhong = phong.MaNhanPhong;
            p.NhanVienLap = phong.NhanVienLap;
            db.SaveChanges();
        }
        public DataTable tinhtongtiendichvu(int a)
        {
            return ketnoi.FillDataTable("select sum(b.DonGia*a.SoLuong) as tongtiendichvu from DanhSachSuDungDichVu a, DichVu b where  a.MaDichVu = b.MaDichVu and a.MaNhanPhong =" +a+"");
        }
    }
}
