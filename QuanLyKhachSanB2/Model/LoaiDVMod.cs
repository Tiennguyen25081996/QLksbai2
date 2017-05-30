using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
   public class LoaiDVMod
    {
        public static DataTable getAllLoaiDV()
        {
            return ketnoi.FillDataTable("select * from LoaiDichVu");
        }
        public static void insertLoaiDV(String maLoaiDV,String tenloaiDV)
        {
            ketnoi.ExcuteScalar("insert into LoaiDichVu values('" +maLoaiDV+"', '"+tenloaiDV+"')");
        }
        public static void deleteLoaiDV(String maLoaiDV)
        {
            ketnoi.ExcuteScalar("delete LoaiDichVu where MaLoaiDichVu='" +maLoaiDV+  "'");
        }
        public static void updateLoaiDV(String maLoaiDV,String tenDV)
        {
            ketnoi.ExcuteScalar("update LoaiDichVu set TenLoaiDichVu='"+tenDV+"' where MaLoaiDichVu='"+maLoaiDV+"'");
        }
    }
}
