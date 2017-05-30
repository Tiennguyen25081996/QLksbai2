using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyKhachSanB2.Model
{
    public class ChiTietPhieuNhanPhongMod
    {
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public DataTable FillDataSet_spgetMaNhanPhong()
        {
            return ketnoi.FillDataTable("select * from ChiTietPhieuNhanPhong");
        }
        public DataTable FillDataSet_spgetChitietphieuNhanPhong()
        {
            return ketnoi.FillDataTable("select MaNhanPhong, ChiTietPhieuNhanPhong.MaPhong,KhachHang.TenKhachHang,ChiTietPhieuNhanPhong.MaKhachHang,KhachHang.CMND,ChiTietPhieuNhanPhong.NgayNhan,ChiTietPhieuNhanPhong.NgayTraPhong from ChiTietPhieuNhanPhong join KhachHang on KhachHang.MaKhachHang = ChiTietPhieuNhanPhong.MaKhachHang");
        }  
        public DataTable FillDataSet_spgetMaNhanPhongbyID(int a)
        {
            return ketnoi.FillDataTable("select * from ChiTietPhieuNhanPhong where MaNhanPhong ="+a+"");
        }
        public DataTable FillDataSet_spgetMaNhanPhongbyMaPhong(int a)
        {
            return ketnoi.FillDataTable("select * from ChiTietPhieuNhanPhong where MaPhong ="+a+"");
        }
        public DataTable FillDataSet_spgetMaNhanPhongcombobox()
        {
            return ketnoi.FillDataTable("select * from ChiTietPhieuNhanPhong  WHERE MaNhanPhong NOT IN( SELECT MaNhanPhong FROM HOADON )");
        }
        public void Update(ChiTietPhieuNhanPhong hd)
        {
            ChiTietPhieuNhanPhong p = db.ChiTietPhieuNhanPhongs.SingleOrDefault(x => x.MaNhanPhong==hd.MaNhanPhong);
            p.MaNhanPhong = hd.MaNhanPhong;
            p.MaKhachHang = hd.MaKhachHang;
            p.HoTenKhachHang = hd.HoTenKhachHang;
            p.MaPhong = hd.MaPhong;
            p.NgayNhan = hd.NgayNhan;
            p.NgayTraPhong = hd.NgayTraPhong;
            db.SaveChanges();
        }
        public void Updatetheodangky(ChiTietPhieuNhanPhong hd)
        {
            ChiTietPhieuNhanPhong p = db.ChiTietPhieuNhanPhongs.SingleOrDefault(x => x.MaNhanPhong == hd.MaNhanPhong);
            p.NgayNhan = hd.NgayNhan;
            db.SaveChanges();
        }
        public void delete(ChiTietPhieuNhanPhong p)
        {
            ChiTietPhieuNhanPhong ph = db.ChiTietPhieuNhanPhongs.Find(p.MaNhanPhong);
            db.ChiTietPhieuNhanPhongs.Remove(ph);
            db.SaveChanges();
        }
        public void insert(ChiTietPhieuNhanPhong phong)
        {   
            ChiTietPhieuNhanPhong ph = new ChiTietPhieuNhanPhong();
            ph.MaKhachHang = phong.MaKhachHang;
            ph.CMND = phong.CMND;
            ph.HoTenKhachHang = phong.HoTenKhachHang;
            ph.MaPhong = phong.MaPhong;
            ph.NgayNhan = phong.NgayNhan;
            ph.NgayTraPhong = phong.NgayTraPhong;
            db.ChiTietPhieuNhanPhongs.Add(phong);
            db.SaveChanges();
        }
    }
}
