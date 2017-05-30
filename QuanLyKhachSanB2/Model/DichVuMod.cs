using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
    public class DichVuMod
    {
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public DataTable FillDataSet_spgetMaNhanPhong()
        {
            return ketnoi.FillDataTable("select * from DichVu");
        }
        public DataTable timkiem(string a)
        {
            return ketnoi.FillDataTable("select * from DichVu where MaLoaiDichVu like N'%"+a+"%' ");
        }
        public void delete(DichVu p)
        {
            DichVu ph = db.DichVus.Find(p.MaDichVu);
            db.DichVus.Remove(ph);
            db.SaveChanges();
        }
        public void insert(DichVu phong)
        {
            DichVu p = new DichVu();
            p.MaDichVu = phong.MaDichVu;
            p.MaLoaiDichVu = phong.MaLoaiDichVu;
            p.DonGia = phong.DonGia;
            db.DichVus.Add(p);
            db.SaveChanges();
        }
        public void Update(DichVu phong)
        {
            DichVu p = db.DichVus.SingleOrDefault(x => x.MaDichVu == phong.MaDichVu);
            p.MaDichVu = phong.MaDichVu;
            p.MaLoaiDichVu = phong.MaLoaiDichVu;
            p.DonGia = phong.DonGia;
            db.SaveChanges();
        }
    }
}
