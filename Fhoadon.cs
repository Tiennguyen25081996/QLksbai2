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
    public partial class Fhoadon : DevExpress.XtraEditors.XtraForm
    {
        public Fhoadon()
        {
            InitializeComponent();
        }
        int plag = 0;

        void clear()
        {
            txtMaHoaDon.Text = "";
            cmbMaNhanPhong.Text = "";
            txtNhanVienLap.Text = "";
            cmbMaKH.Text = "";
            txtmaphong.Text = "";
            txtDonGia.Text = "";
            txttienphong.Text = "";
           
        }
        void loadcontrolMaKhachHang()
        {
            KhachHangMod lp = new KhachHangMod();
            cmbMaKH.DataSource = lp.FillDataSet_spgetall();
            cmbMaKH.ValueMember = "MaKhachHang";
        }
        void loadcontrolMaNhanPhong()
        {
            ChiTietPhieuNhanPhongMod lp = new ChiTietPhieuNhanPhongMod();
            cmbMaNhanPhong.DataSource = lp.FillDataSet_spgetMaNhanPhongcombobox();
            cmbMaNhanPhong.ValueMember = "MaNhanPhong";
        }
        private void Fhoadon_Load(object sender, EventArgs e)
        {
            
            LoaiPhongMod pm = new LoaiPhongMod();
            dgvHoadon.DataSource = pm.FillDataSet_spgethehe();
            loadcontrolMaNhanPhong();
            loadcontrolMaKhachHang();
            btnThanhToan.Enabled = false;
            txtMaSDDV.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;
            txtTongTien.Enabled = false;
            btnsua.Enabled = false;
            txttongtiendv.Enabled = false;
            hienthidsnhanphong();
            Binding();

        }
        void Binding()
        {
            txtMaHoaDon.DataBindings.Clear();
            txtMaHoaDon.DataBindings.Add("text", dgvHoadon.DataSource, "MaHoaDon");
            cmbMaKH.DataBindings.Clear();
            cmbMaKH.DataBindings.Add("text", dgvHoadon.DataSource, "MaKhachHang");
            txtNhanVienLap.DataBindings.Clear();
            txtNhanVienLap.DataBindings.Add("text", dgvHoadon.DataSource, "NhanVienLap");
            cmbMaNhanPhong.DataBindings.Clear();
            cmbMaNhanPhong.DataBindings.Add("text", dgvHoadon.DataSource, "MaNhanPhong");
            txtMaSDDV.DataBindings.Clear();
            txtMaSDDV.DataBindings.Add("text", dgvHoadon.DataSource, "MaSuDungDV");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("text", dgvHoadon.DataSource, "SoLuong");
            dtpNgayNhanPhong.DataBindings.Clear();
            dtpNgayNhanPhong.DataBindings.Add("text", dgvHoadon.DataSource, "NgayNhan");
            dtpNgayTraPhong.DataBindings.Clear();
            dtpNgayTraPhong.DataBindings.Add("text", dgvHoadon.DataSource, "NgayTraPhong");
            txttenKH.DataBindings.Clear();
            txttenKH.DataBindings.Add("text", dgvHoadon.DataSource, "TenKhachHang");
            dtpNgayLap.DataBindings.Clear();
            dtpNgayLap.DataBindings.Add("text", dgvHoadon.DataSource, "NgayLap");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("text", dgvHoadon.DataSource, "DonGia");
            txttienphong.DataBindings.Clear();
            txttienphong.DataBindings.Add("text", dgvHoadon.DataSource, "DonGiaTheoNgay");
            txtmaphong.DataBindings.Clear();
            txtmaphong.DataBindings.Add("text", dgvHoadon.DataSource, "MaPhong");
        }
        void tongtien()
        {
            LoaiPhong lp = new LoaiPhong();
            TimeSpan ts;
            ts = DateTime.Parse(dtpNgayTraPhong.Text) - DateTime.Parse(dtpNgayNhanPhong.Text);
            HoaDonMod hd = new HoaDonMod();
            var ggg = hd.tinhtongtiendichvu(int.Parse(cmbMaNhanPhong.Text));
            txttongtiendv.Text = ggg.Rows[0].ItemArray[0].ToString();
            double tongtien;
            if (txtDonGia == null)
            {
                txtTongTien.Text = (ts.TotalDays * double.Parse(txttienphong.Text)).ToString();
            }
            else
            {
                try
                {
                    tongtien = double.Parse(txttongtiendv.Text) + (ts.TotalDays * double.Parse(txttienphong.Text));
                    txtTongTien.Text = tongtien.ToString();
                }
                catch
                {
                    tongtien =  (ts.TotalDays * double.Parse(txttienphong.Text));
                    txtTongTien.Text = tongtien.ToString();
                }
               
            }

        }

        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
            tongtien();
            btnThanhToan.Enabled = true;
            btnsua.Enabled = true;
            txtmaphong.Enabled = false;
            btnluu.Enabled = false;
        }
        void hienthidsnhanphong()
        {
            ChiTietPhieuNhanPhongMod np = new ChiTietPhieuNhanPhongMod();
            dgvdanhsachphongdanhan.DataSource = np.FillDataSet_spgetMaNhanPhongcombobox();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            Binding();
            plag = 2;
            txttienphong.Enabled = false;
            cmbMaKH.Enabled = false;
            cmbMaNhanPhong.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            txtMaHoaDon.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Phong mp = new Phong();
                mp.MaPhong = txtmaphong.Text;
                mp.MaLoaiTinhTrang = 1;
                mp.GhiChu = "Trống";

                new PhongMod().UpdatephongtheoHD(mp);
                HoaDon deletes = new HoaDon();
                deletes.MaHoaDon = int.Parse(txtMaHoaDon.Text);
                deletes.MaNhanPhong = cmbMaNhanPhong.Text;
                new HoaDonMod().delete(deletes);
                var dem = new DanhSachSuDungDVMod().FillDataSet_spgetDSSDDVbyMaNhanPhong(int.Parse(cmbMaNhanPhong.Text));
                if (dem.Rows.Count > 0)
                {  
                    for(int i=0; i <dem.Rows.Count; i++)
                    {
                        DanhSachSuDungDichVu ds = new DanhSachSuDungDichVu();
                        ds.MaSuDungDV = int.Parse(dem.Rows[i].ItemArray[0].ToString());
                        new DanhSachSuDungDVMod().delete(ds);
                    }                
                }
                MessageBox.Show("Xóa Thành Công");
            }
            Fhoadon_Load(sender, e);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            if (plag == 1)
            {
                ChiTietPhieuNhanPhong p = new ChiTietPhieuNhanPhong();
                var res = new ChiTietPhieuNhanPhongMod().FillDataSet_spgetMaNhanPhongbyID(int.Parse(cmbMaNhanPhong.Text));
                //lấy mã nhận phòng vừa được thêm mới
                //thay đổi mã tình trạng trong bảng Phong từ 1 = 3
                Phong xxx = new Phong();
                xxx.MaPhong = res.Rows[0].ItemArray[1].ToString();
                var a = new PhongMod().listdsphongbyid(int.Parse(xxx.MaPhong));
                xxx.GhiChu = "Có Người";
                xxx.MaLoaiPhong = a.MaLoaiPhong;
                xxx.MaLoaiTinhTrang = 3;
                new PhongMod().UpdatephongtheoHD(xxx);
                ////////////////////////////////////
                HoaDon Ojphong = new HoaDon();
                Ojphong.MaKhachHang =int.Parse( cmbMaKH.Text);
                Ojphong.MaNhanPhong = cmbMaNhanPhong.Text;
                Ojphong.NhanVienLap = txtNhanVienLap.Text;
                Ojphong.NgayLap = DateTime.Parse(dtpNgayLap.Text);
                Ojphong.Trangthai = false;
                new HoaDonMod().insert1(Ojphong);
                 ///////////////////////////////////////             
                ChiTietPhieuNhanPhong pa = new ChiTietPhieuNhanPhong();
                pa.MaNhanPhong = int.Parse(cmbMaNhanPhong.Text);
                pa.MaKhachHang = int.Parse(cmbMaKH.Text);
                pa.MaPhong = txtmaphong.Text;
                pa.HoTenKhachHang = dgvdanhsachphongdanhan.CurrentRow.Cells[3].Value.ToString();
                pa.NgayNhan = DateTime.Parse(dtpNgayNhanPhong.Text);
                pa.NgayTraPhong = DateTime.Parse(dtpNgayTraPhong.Text);
                new ChiTietPhieuNhanPhongMod().Update(pa);               
                MessageBox.Show("Tạo Mới Hóa Đơn Thành Công!!!", "Thông Báo");
            }
            else
            {
                if (plag == 2)
                {
                    if (txtMaHoaDon.Text != null)
                    {
                        ChiTietPhieuNhanPhong p = new ChiTietPhieuNhanPhong();
                        var res =new ChiTietPhieuNhanPhongMod().FillDataSet_spgetMaNhanPhongbyID(int.Parse(cmbMaNhanPhong.Text));
                       //lấy mã nhận phòng vừa được thêm mới
                       //thay đổi mã tình trạng trong bảng Phong từ 1 = 3
                        Phong xxx = new Phong();
                        xxx.MaPhong = res.Rows[0].ItemArray[1].ToString();
                        var a = new PhongMod().listdsphongbyid(int.Parse(xxx.MaPhong));
                        xxx.GhiChu = "Có Người";
                        xxx.MaLoaiPhong = a.MaLoaiPhong;
                        xxx.MaLoaiTinhTrang = 3;
                        new PhongMod().UpdatephongtheoHD(xxx);
                        //tạo mới hóa đơn
                        HoaDon hd = new HoaDon();
                        hd.MaHoaDon = int.Parse(txtMaHoaDon.Text);
                        hd.TongTien = decimal.Parse(txtTongTien.Text);
                        hd.MaKhachHang = int.Parse(cmbMaKH.Text);
                        hd.NgayLap = DateTime.Parse(dtpNgayLap.Text);
                        hd.MaNhanPhong =cmbMaNhanPhong.Text;
                        new HoaDonMod().UpdateTongTien(hd);
                        //lấy mã phòng trước khi thay đổi
                        //thay đổi trong bảng Phòng từ 3=1
                        if (xxx.MaPhong.Equals(txtmaphong))
                        {
                            Phong mp = new Phong();
                            mp.MaPhong = txtmaphong.Text;
                            mp.MaLoaiTinhTrang = 1;
                            mp.GhiChu = "Trống";
                            new PhongMod().UpdatephongtheoHD(mp);
                        }

                        //update chi tiết phiếu nhận phòng
                        p.MaPhong = txtmaphong.Text;
                        p.MaNhanPhong = int.Parse(cmbMaNhanPhong.Text);
                        p.HoTenKhachHang = txttenKH.Text;
                        p.MaKhachHang = int.Parse(cmbMaKH.Text);
                        p.NgayNhan = DateTime.Parse(dtpNgayNhanPhong.Text);
                        p.NgayTraPhong = DateTime.Parse(dtpNgayTraPhong.Text);
                        new ChiTietPhieuNhanPhongMod().Update(p);               
                    }
                    HoaDon pm = new HoaDon();
                    pm.MaHoaDon = int.Parse(txtMaHoaDon.Text);
                    pm.MaKhachHang =int.Parse( cmbMaKH.Text);
                    pm.MaNhanPhong = cmbMaNhanPhong.Text;
                    pm.NhanVienLap = txtNhanVienLap.Text;
                    new HoaDonMod().Update(pm);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    Fhoadon_Load(sender, e);
                }
            }
            Fhoadon_Load(sender, e);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = true;
            Fhoadon_Load(sender, e);
        }
        //tạo mới thuộc tính cho mã nhận phòng
        public string MaNhanPhongchuyen
        {
            get { return cmbMaNhanPhong.Text; }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            plag = 1;
            txtMaHoaDon.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            clear();
        }       
        public int mahoadon
        {
            get { return int.Parse(txtMaHoaDon.Text); }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn thanh toán không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                IN frm = new IN();
                frm.mahd = mahoadon.ToString();
                frm.ShowDialog();
                var dem = new DanhSachSuDungDVMod().FillDataSet_spgetDSSDDVbyMaNhanPhong(int.Parse(cmbMaNhanPhong.Text));
                if (dem.Rows.Count>0)
                {
                    DanhSachSuDungDichVu ds = new DanhSachSuDungDichVu();
                    ds.MaSuDungDV = int.Parse(txtMaSDDV.Text);
                    new DanhSachSuDungDVMod().delete(ds);
                    //updatelai phong tu co nguoi ve trong
                    Phong mp = new Phong();
                    mp.MaPhong = txtmaphong.Text;
                    mp.MaLoaiTinhTrang = 1;
                    mp.GhiChu = "Trống";
                    new PhongMod().UpdatephongtheoHD(mp);
                    ///update lai hd
                    HoaDon pm = new HoaDon();
                    pm.MaHoaDon =int.Parse( txtMaHoaDon.Text);
                    pm.Trangthai = true;
                    pm.NgayLap = DateTime.Now;
                    new HoaDonMod().UpdateTrangThai(pm);
                }
                //updatelai phong tu co nguoi ve trong
                Phong mp1 = new Phong();
                mp1.MaPhong = txtmaphong.Text;
                mp1.MaLoaiTinhTrang = 1;
                mp1.GhiChu = "Trống";
                new PhongMod().UpdatephongtheoHD(mp1);
                ///update lai hd
                HoaDon pm2 = new HoaDon();
                pm2.MaHoaDon = int.Parse(txtMaHoaDon.Text);
                pm2.Trangthai = true;
                pm2.NgayLap = DateTime.Now;
                new HoaDonMod().UpdateTrangThai(pm2);
                MessageBox.Show("Bạn Đã Thanh Toán Thành Công", "Thông Báo");
            }        
            Fhoadon_Load(sender, e);
        }
        void Bingdingds()
        {
            cmbMaKH.DataBindings.Clear();
            cmbMaKH.DataBindings.Add("text", dgvdanhsachphongdanhan.DataSource, "MaKhachHang");
            txtNhanVienLap.DataBindings.Clear();         
            cmbMaNhanPhong.DataBindings.Clear();
            cmbMaNhanPhong.DataBindings.Add("text", dgvdanhsachphongdanhan.DataSource, "MaNhanPhong");
            txtMaSDDV.Text = "";
            txtSoLuong.Text = "";
            txttongtiendv.Text = "";
            txtDonGia.Text = "";
            dtpNgayNhanPhong.DataBindings.Clear();
            dtpNgayNhanPhong.DataBindings.Add("text", dgvdanhsachphongdanhan.DataSource, "NgayNhan");
            txttenKH.DataBindings.Clear();
            txttenKH.DataBindings.Add("text", dgvdanhsachphongdanhan.DataSource, "HoTenKhachHang");
            dtpNgayTraPhong.DataBindings.Clear();
            dtpNgayTraPhong.DataBindings.Add("text", dgvdanhsachphongdanhan.DataSource, "NgayTraPhong");
            dtpNgayLap.Text = DateTime.Now.ToString();      
            txttienphong.DataBindings.Clear();
            txtmaphong.DataBindings.Clear();
            txtmaphong.DataBindings.Add("text", dgvdanhsachphongdanhan.DataSource, "MaPhong");
        }
        void laydongiatheongay()
        {
            PhongMod p = new PhongMod();
            var gg = p.listdsphongbyid(int.Parse(txtmaphong.Text));
            LoaiPhongMod lp = new LoaiPhongMod();
            var dongiatheongay = lp.FillDataSet_spgetallbymaloaiphong(gg.MaLoaiPhong);
            txttienphong.Text = dongiatheongay.Rows[0].ItemArray[2].ToString();
        }
        private void dgvdanhsachphongdanhan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            Bingdingds();
            laydongiatheongay();
        }
    }
}