using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKhachSanB2.connection;
using QuanLyKhachSanB2.Model;

namespace QuanLyKhachSanB2
{
    public partial class dangkyphong2 : DevExpress.XtraEditors.XtraForm
    {
        public dangkyphong2()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtmaphieuthue.Enabled = false;
            datengaydangky.Enabled = false;
            datengaynhan.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            txtmaphieuthue.Enabled = false;
            ChiTietPhieuThuePhong pm = new ChiTietPhieuThuePhong();
            pm.MaPhong = txtMaPhong.Text;
            pm.NgayDangKy = DateTime.Now;
            pm.NgayNhan = DateTime.Now;
            new ChiTietPhieuDangKyMod().insert(pm);
            //update phong đưa mã tình trạng về 2 (đặt)
            Phong xxx = new Phong();
            var a = new PhongMod().listdsphongbyid(int.Parse(txtMaPhong.Text));
            xxx.MaPhong = txtMaPhong.Text;
            xxx.GhiChu = "Đặt";
            xxx.MaLoaiPhong = a.MaLoaiPhong;
            xxx.MaLoaiTinhTrang = 2;
            new PhongMod().Update(xxx);
            MessageBox.Show("Thêm Mới Thành Công!!!", "Thông Báo");
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            btnthem.Enabled = true;
            this.Close();
        }
        public string nhanMaPhong
        {
            set { txtMaPhong.Text = value; }
        }
        private void dangkyphong2_Load(object sender, EventArgs e)
        {
        }
    }
}