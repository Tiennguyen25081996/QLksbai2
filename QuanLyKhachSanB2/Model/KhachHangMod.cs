using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
    public class KhachHangMod
    {
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public DataTable FillDataSet_spgetall()
        {
            return ketnoi.FillDataTable("SELECT * FROM KhachHang");
        }
        public DataTable FillDataSet_spgetallcombobox()
        {
            return ketnoi.FillDataTable("SELECT * FROM ChiTietPhieuNhanPhong WHERE MaKhachHang NOT IN( SELECT MaKhachHang FROM HOADON )");
        }
        public DataTable filltenKhbyMaKH(string a)
        {
            return ketnoi.FillDataTable("select * from KhachHang where KhachHang.MaKhachHang ="+a+"");
        }
        public DataTable timkiem(string a)
        {
            return ketnoi.FillDataTable("select * from KhachHang where KhachHang.TenKhachHang like N'%"+a+"%'");
        }
        public void delete(KhachHang p)
        {
            KhachHang ph = db.KhachHangs.Find(p.MaKhachHang);
            db.KhachHangs.Remove(ph);
            db.SaveChanges();
        }
        public void insert(KhachHang phong)
        {
            KhachHang p = new KhachHang();
            p.MaKhachHang = phong.MaKhachHang;
            p.TenKhachHang = phong.TenKhachHang;
            p.CMND = phong.CMND;
            p.GioiTinh = phong.GioiTinh;
            p.DiaChi = phong.DiaChi;
            p.DienThoai = phong.DienThoai;
            p.QuocTich = phong.QuocTich;
            db.KhachHangs.Add(p);
            db.SaveChanges();
        }
        public void Update(KhachHang phong)
        {
            KhachHang p = db.KhachHangs.SingleOrDefault(x => x.MaKhachHang == phong.MaKhachHang);
            p.MaKhachHang = phong.MaKhachHang;
            p.TenKhachHang = phong.TenKhachHang;
            p.CMND = phong.CMND;
            p.GioiTinh = phong.GioiTinh;
            p.DiaChi = phong.DiaChi;
            p.DienThoai = phong.DienThoai;
            p.QuocTich = phong.QuocTich;
            db.SaveChanges();
        }
    }
}
