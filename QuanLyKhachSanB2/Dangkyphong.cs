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
using QuanLyKhachSanB2.Model;
using QuanLyKhachSanB2.connection;

namespace QuanLyKhachSanB2
{
    public partial class Dangkyphong : DevExpress.XtraEditors.XtraForm
    {
        public Dangkyphong()
        {
            InitializeComponent();
        }
        int plag = 0;
        public string nhanMaPhong
        {
            set { txtMaPhong.Text = value; }
        }
        public void hienthidanhsach()
        {
            ChiTietPhieuDangKyMod pm = new ChiTietPhieuDangKyMod();
            dgvchitietphieuthuephong.DataSource = pm.filldatasetall();

        }
        private void Dangkyphong_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
            //btnsua.Enabled = false;
            //btnxoa.Enabled = false;
        }
        //void loadcontrolMaPhong()
        //{
        //    PhongMod lp = new PhongMod();
        //    cmbmaphong.DataSource = lp.listdsphongTrong();
        //    cmbmaphong.ValueMember = "MaPhong";
        //}
        void Binding()
        {
            txtmaphieuthue.DataBindings.Clear();
            txtmaphieuthue.DataBindings.Add("text", dgvchitietphieuthuephong.DataSource, "MaPhieuThue");
            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("text", dgvchitietphieuthuephong.DataSource, "MaPhong");
            datengaydangky.DataBindings.Clear();
            datengaydangky.DataBindings.Add("text", dgvchitietphieuthuephong.DataSource, "NgayDangKy");
            datengaynhan.DataBindings.Clear();
            datengaynhan.DataBindings.Add("text", dgvchitietphieuthuephong.DataSource, "NgayNhan");

        }

        private void dgvchitietphieuthuephong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            Binding();
            plag = 2;
            btnxoa.Enabled = false;
            txtmaphieuthue.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            datengaydangky.Enabled = false;
            datengaynhan.Enabled = true;
            txtMaPhong.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //update phong đưa mã tình trạng về 1 (Trống)
                Phong xxx = new Phong();
                var a = new PhongMod().listdsphongbyid(int.Parse(txtMaPhong.Text));
                xxx.MaPhong = txtMaPhong.Text;
                xxx.GhiChu = "Trống";
                xxx.MaLoaiPhong = a.MaLoaiPhong;
                xxx.MaLoaiTinhTrang = 1;
                new PhongMod().Update(xxx);
                //update ngày nhận vào bảng Chi tiết phiếu nhân phòng
                ChiTietPhieuNhanPhong pp = new ChiTietPhieuNhanPhong();
                pp.MaPhong = txtMaPhong.Text;
                pp.NgayNhan = DateTime.Now;
                new ChiTietPhieuNhanPhongMod().Updatetheodangky(pp);
                ChiTietPhieuThuePhong delete = new ChiTietPhieuThuePhong();
                delete.MaPhieuThue =int.Parse( txtmaphieuthue.Text);
                new ChiTietPhieuDangKyMod().delete(delete);
                MessageBox.Show("Xóa Thành Công");
            }
            Dangkyphong_Load(sender, e);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            txtmaphieuthue.Enabled = false;
            if (plag == 1)
            {
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
                Dangkyphong_Load(sender, e);
            }         
            if (plag == 2)
            {
                ChiTietPhieuThuePhong p = new ChiTietPhieuThuePhong();
                p.MaPhieuThue = int.Parse(txtmaphieuthue.Text);
                p.MaPhong = txtMaPhong.Text;
                p.NgayDangKy = DateTime.Now;
                p.NgayNhan = DateTime.Parse(datengaynhan.Text);
                new ChiTietPhieuDangKyMod().Update(p);
                //update lại ngày nhận bên bảng chitietphieunhan
                ChiTietPhieuNhanPhong cnp = new ChiTietPhieuNhanPhong();
                cnp.MaPhong = txtMaPhong.Text;
                cnp.NgayNhan = DateTime.Parse(datengaynhan.Text);
                new ChiTietPhieuNhanPhongMod().Updatetheodangky(cnp);
                MessageBox.Show("Sửa Thành Công", "Thông Báo");
            }
            Dangkyphong_Load(sender, e);
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = true;
            Dangkyphong_Load(sender, e);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            plag = 1;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtmaphieuthue.Enabled = false;
            datengaydangky.Enabled = false;
            datengaynhan.Enabled = false;
           
        }
    }
}