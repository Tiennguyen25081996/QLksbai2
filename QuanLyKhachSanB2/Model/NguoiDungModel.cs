
using QuanLyKhachSanB2.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanB2.Model
{
    public class NguoiDungModel
    {
        public void UpdateMk(String username,String pass)
        {
            ketnoi.ExcuteScalar("update Nguoidung set MatKhau='" + pass+ "' where TenDangNhap='" + username+"' ");
        }

    }
}
