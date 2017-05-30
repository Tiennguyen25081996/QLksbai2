using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
   public class TinhTrangMod
    {
 //       QuanlykhacsanDBcontext db = new QuanlykhacsanDBcontext();
        public DataTable FillDataSet_spgetMaloaiTinhTrang()
        {
            return ketnoi.FillDataTable("select * from TinhTrang");
        }
    }
}
