
using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
    public class PhongMod
    {
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public List<Phong> listdsphong()
        {
            return db.Phongs.ToList();
        }
        public List<Phong> listdsphongTrong()
        {
            return db.Phongs.Where(x => x.MaLoaiTinhTrang == 1).ToList();
        }
        public Phong listdsphongbyid(int id)
        {
            return db.Phongs.First(x=>x.MaPhong.Equals(id.ToString()));
        }
        public LoaiPhong listdsloaiphongbyid(string idlp)
        {
            return db.LoaiPhongs.First(x => x.MaLoaiPhong == idlp);
        }
        public void delete(Phong p)
        {
            Phong ph =  db.Phongs.Find(p.MaPhong);
            db.Phongs.Remove(ph);
            db.SaveChanges();
        }
        public void insert(Phong phong)
        {
            Phong p = new Phong();
            p.MaPhong = phong.MaPhong;
            p.MaLoaiPhong = phong.MaLoaiPhong;
            p.MaLoaiTinhTrang = phong.MaLoaiTinhTrang;
            p.GhiChu = phong.GhiChu;
            db.Phongs.Add(p);
            db.SaveChanges();
        }
        public void Update(Phong phong)
        {
            Phong p = db.Phongs.SingleOrDefault(x => x.MaPhong == phong.MaPhong);
            p.GhiChu = phong.GhiChu;
            p.MaPhong = phong.MaPhong;
            p.MaLoaiPhong = phong.MaLoaiPhong;
            p.MaLoaiTinhTrang = phong.MaLoaiTinhTrang;
            db.SaveChanges();
        }
        public void UpdatephongtheoHD(Phong phong)
        {
            Phong p = db.Phongs.SingleOrDefault(x => x.MaPhong == phong.MaPhong);
            p.GhiChu = phong.GhiChu;
            p.MaPhong = phong.MaPhong;
            p.MaLoaiTinhTrang = phong.MaLoaiTinhTrang;
            db.SaveChanges();
        }

        public DataTable filldatasetphong()
        {
            // goi thu tuc dataset 
            return connection.ketnoi.FillDataTable("select * from phong");
        }
    }
}
