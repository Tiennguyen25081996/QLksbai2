using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
  public  class ChiTietPhieuDangKyMod
    {
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public DataTable filldatasetall()
        {
            // goi thu tuc dataset 
            //return connection.ketnoi.FillDataTable("select * from ChiTietPhieuThuePhong");
            return connection.ketnoi.FillDataTable("SELECT * FROM ChiTietPhieuThuePhong");
        }
        public DataTable filldatasetallbymaphong(int a)
        {
            return connection.ketnoi.FillDataTable("SELECT * FROM ChiTietPhieuThuePhong where MaPhong ="+a+"");
        }
        public void delete(ChiTietPhieuThuePhong p)
        {
            ChiTietPhieuThuePhong ph = db.ChiTietPhieuThuePhongs.Find(p.MaPhieuThue);
            db.ChiTietPhieuThuePhongs.Remove(ph);
            db.SaveChanges();
        }
        public void Update(ChiTietPhieuThuePhong phong)
        {
            ChiTietPhieuThuePhong p = db.ChiTietPhieuThuePhongs.SingleOrDefault(x => x.MaPhieuThue == phong.MaPhieuThue);
            p.MaPhieuThue = phong.MaPhieuThue;
            p.MaPhong = phong.MaPhong;
            p.NgayDangKy = phong.NgayDangKy;
            p.NgayNhan = phong.NgayNhan;
            db.SaveChanges();
        }
        public void Updatengaynhan(ChiTietPhieuThuePhong phong)
        {
            ChiTietPhieuThuePhong p = db.ChiTietPhieuThuePhongs.SingleOrDefault(x => x.MaPhieuThue == phong.MaPhieuThue);
            p.MaPhieuThue = phong.MaPhieuThue;
            p.NgayNhan = phong.NgayNhan;
            db.SaveChanges();
        }
        public void insert(ChiTietPhieuThuePhong phong)
        {
            ChiTietPhieuThuePhong p = new ChiTietPhieuThuePhong();
            p.MaPhieuThue = phong.MaPhieuThue;
            p.MaPhong = phong.MaPhong;
            p.NgayDangKy = phong.NgayDangKy;
            p.NgayNhan = phong.NgayNhan;
            db.ChiTietPhieuThuePhongs.Add(p);
            db.SaveChanges();
        }
    }
}
