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
    public partial class NhanPhong : DevExpress.XtraEditors.XtraForm
    {
        public NhanPhong()
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
            ChiTietPhieuNhanPhongMod pm = new ChiTietPhieuNhanPhongMod();
            dgvchitietphieunhanphong.DataSource = pm.FillDataSet_spgetChitietphieuNhanPhong();
        }
        void updatetenKH()
        { 
                KhachHangMod KH = new KhachHangMod();
                var a = KH.filltenKhbyMaKH(cmbMaKH.Text);
                txttenKH.Text = a.Rows[0].ItemArray[1].ToString();        
        }
        void Binding()
        {
            txtManhanphong.DataBindings.Clear();
            txtManhanphong.DataBindings.Add("text", dgvchitietphieunhanphong.DataSource, "MaNhanPhong");
            txtMaPhong.DataBindings.Clear();
            txtMaPhong.DataBindings.Add("text", dgvchitietphieunhanphong.DataSource, "MaPhong");
            txttenKH.DataBindings.Clear();
            txttenKH.DataBindings.Add("text", dgvchitietphieunhanphong.DataSource, "TenKhachHang");
            txtXMND.DataBindings.Clear();
            txtXMND.DataBindings.Add("text", dgvchitietphieunhanphong.DataSource, "CMND");
            cmbMaKH.DataBindings.Clear();
            cmbMaKH.DataBindings.Add("text", dgvchitietphieunhanphong.DataSource, "MaKhachHang");
            dtpngaynhan.DataBindings.Clear();
            dtpngaynhan.DataBindings.Add("text", dgvchitietphieunhanphong.DataSource, "NgayNhan");
            dtpngaytra.DataBindings.Clear();
            dtpngaytra.DataBindings.Add("text", dgvchitietphieunhanphong.DataSource, "NgayTraPhong");

        }
        void loadcontrolMaKhachHang()
        {
            KhachHangMod lp = new KhachHangMod();
            cmbMaKH.DataSource = lp.FillDataSet_spgetall();
            cmbMaKH.ValueMember = "MaKhachHang";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            plag = 1;
            txttenKH.Enabled = false;
            dtpngaynhan.Enabled = false;
            txtXMND.Enabled = false;
            updatetenKH();
            txtManhanphong.Enabled = false;
            btnluu.Enabled = true;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Binding();
            plag = 2;
            btnxoa.Enabled = false;
            txtManhanphong.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            dtpngaynhan.Enabled = false;
           

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

                ChiTietPhieuNhanPhong p = new ChiTietPhieuNhanPhong();              
                p.MaNhanPhong = int.Parse(txtManhanphong.Text);
                new ChiTietPhieuNhanPhongMod().delete(p);
                MessageBox.Show("Xóa Thành Công");
            }
            NhanPhong_Load(sender, e);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            txtManhanphong.Enabled = false;
            if (plag == 1)
            {
                ChiTietPhieuNhanPhong p = new ChiTietPhieuNhanPhong();
                p.MaKhachHang = int.Parse(cmbMaKH.Text);
                p.MaPhong = txtMaPhong.Text;
                p.HoTenKhachHang = txttenKH.Text;
                p.CMND = txtXMND.Text;
                //lấy ngày nhận bên bảng đăng ký theo mã phòng

                var ab = new ChiTietPhieuDangKyMod().filldatasetallbymaphong(int.Parse(txtMaPhong.Text));
                p.NgayNhan = DateTime.Parse(ab.Rows[0].ItemArray[3].ToString());
                p.NgayTraPhong = DateTime.Parse(dtpngaytra.Text);
                new ChiTietPhieuNhanPhongMod().insert(p);

                //update phong đưa mã tình trạng về 3 (Có Người)
                Phong xxx = new Phong();
                var a = new PhongMod().listdsphongbyid(int.Parse(txtMaPhong.Text));
                xxx.MaPhong = txtMaPhong.Text;
                xxx.GhiChu = "Có Người";
                xxx.MaLoaiPhong = a.MaLoaiPhong;
                xxx.MaLoaiTinhTrang = 3;
                new PhongMod().Update(xxx);

                //xoa ben dang ky
                var ag = new ChiTietPhieuDangKyMod().filldatasetallbymaphong(int.Parse(txtMaPhong.Text));
                ChiTietPhieuThuePhong tp = new ChiTietPhieuThuePhong();
                tp.MaPhieuThue =int.Parse( ag.Rows[0].ItemArray[0].ToString());
                new ChiTietPhieuDangKyMod().delete(tp);

                MessageBox.Show("Thêm Mới Thành Công!!!", "Thông Báo");
                NhanPhong_Load(sender, e);
            }
            if (plag == 2)
            {
                ChiTietPhieuNhanPhong p = new ChiTietPhieuNhanPhong();
                p.MaNhanPhong = int.Parse(txtManhanphong.Text);
                p.MaKhachHang = int.Parse(cmbMaKH.Text);
                p.MaPhong = txtMaPhong.Text;
                p.HoTenKhachHang = txttenKH.Text;
                p.CMND = txtXMND.Text;
                p.NgayTraPhong = DateTime.Parse(dtpngaytra.Text);
                new ChiTietPhieuNhanPhongMod().Update(p);
                //xoa ben dang ky
                var ag = new ChiTietPhieuDangKyMod().filldatasetallbymaphong(int.Parse(txtMaPhong.Text));
                ChiTietPhieuThuePhong tp = new ChiTietPhieuThuePhong();
                tp.MaPhieuThue = int.Parse(ag.Rows[0].ItemArray[0].ToString());
                tp.NgayNhan = DateTime.Parse(dtpngaynhan.Text);
                new ChiTietPhieuDangKyMod().Updatengaynhan(tp);
                MessageBox.Show("Sửa Thành Công!!!", "Thông Báo");
                NhanPhong_Load(sender, e);
            }
            NhanPhong_Load(sender, e);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = true;
            NhanPhong_Load(sender, e);
        }

        private void NhanPhong_Load(object sender, EventArgs e)
        {
            txtMaPhong.Enabled = false;
            hienthidanhsach();
            loadcontrolMaKhachHang();
            txtManhanphong.Enabled = false;

        }

        private void cmbMaKH_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvchitietphieunhanphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            updatetenKH();
        }
    }
}