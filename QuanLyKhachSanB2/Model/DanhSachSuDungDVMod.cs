using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
    public class DanhSachSuDungDVMod
    {
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public DataTable FillDataSet_spgetDSSDDV()
        {
            return ketnoi.FillDataTable("select * from DanhSachSuDungDichVu");
        }
        public DataTable FillDataSet_spgetDSSDDVbyMaNhanPhong(int a)
        {
            return ketnoi.FillDataTable("select * from DanhSachSuDungDichVu where MaNhanPhong = '"+a+"'");
        }
        public void delete(DanhSachSuDungDichVu p)
        {
            DanhSachSuDungDichVu ph = db.DanhSachSuDungDichVus.Find(p.MaSuDungDV);
            db.DanhSachSuDungDichVus.Remove(ph);
            db.SaveChanges();
        }
        public void deleteTHEOmanhanphong(DanhSachSuDungDichVu p)
        {
            DanhSachSuDungDichVu ph = db.DanhSachSuDungDichVus.SingleOrDefault(x=>x.MaNhanPhong.Equals(p.MaNhanPhong));
            db.DanhSachSuDungDichVus.Remove(ph);
            db.SaveChanges();
        }
        public void insert(DanhSachSuDungDichVu phong)
        {
            DanhSachSuDungDichVu p = new DanhSachSuDungDichVu();
            //p.MaSuDungDV = phong.MaSuDungDV;
            p.MaNhanPhong = phong.MaNhanPhong;
            p.MaDichVu = phong.MaDichVu;
            p.SoLuong = phong.SoLuong;
            db.DanhSachSuDungDichVus.Add(p);
            db.SaveChanges();
        }
        public void Update(DanhSachSuDungDichVu phong)
        {
            DanhSachSuDungDichVu p = db.DanhSachSuDungDichVus.SingleOrDefault(x => x.MaSuDungDV == phong.MaSuDungDV);
            p.MaSuDungDV = phong.MaSuDungDV;
            p.MaNhanPhong = phong.MaNhanPhong;
            p.MaDichVu = phong.MaDichVu;
            p.SoLuong = phong.SoLuong;
            db.SaveChanges();
        }
    }
}
