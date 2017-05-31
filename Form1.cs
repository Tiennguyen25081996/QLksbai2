using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSanB2.Model;
using System.Data.SqlClient;
using QuanLyKhachSanB2.connection;

namespace QuanLyKhachSanB2
{
    public partial class Form1 : Form
    {
        public static String username="";
        public static String pass="";
        public Form1()
        {
            InitializeComponent();
        }
        string maphonglay;
        public void a()
        {
            PhongMod data = new PhongMod();
            Phong p = new Phong();
            listView1.Items.Clear();
            foreach (DataRow dr in data.filldatasetphong().Rows)
            {
                p.MaLoaiPhong = (string)dr.ItemArray[1];
                p.MaPhong = (string)dr.ItemArray[0];
                p.MaLoaiTinhTrang = (int)dr.ItemArray[2];
                ListViewItem item = new ListViewItem(p.MaPhong);

                if (p.MaLoaiTinhTrang == 1)
                {
                    item.ImageIndex = 0;
                }
                else if (p.MaLoaiTinhTrang == 2)
                {
                    item.ImageIndex = 1;
                }
                else if (p.MaLoaiTinhTrang == 3)
                {
                    item.ImageIndex = 2;
                }

                listView1.Items.Add(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            enable();
            a();    
        }
        Dangnhap dangnhap = null;
        //private string _MaPhong;

        private void DangNhap()
        {
            if (dangnhap == null || dangnhap.IsDisposed)
            {
                dangnhap = new Dangnhap();
            }
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                NguoiDung nd = new NguoiDung();
                String tenDangnhap = dangnhap.lay_TenNguoiDung;
                String matKhau = dangnhap.lay_MatKhau;
                //this.toolStripStatusLabel1.Text = dangNhap.lay_TenNguoiDung;
                SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM NguoiDung where NguoiDung.TenDangNhap =N'" + tenDangnhap.Trim() + " ' ", ketnoi.Getconnection());
                DataTable myTable = new DataTable();
                myAdapter.Fill(myTable);
                nd.TenDangNhap = myTable.Rows[0]["TenDangNhap"].ToString();
                nd.MatKhau = myTable.Rows[0]["MatKhau"].ToString();
                if (nd.MatKhau != matKhau)
                {
                    MessageBox.Show("Sai Mật Khẩu rồi nhé");
                    dangnhap.ShowDialog();
                }
                if (nd.TenDangNhap != tenDangnhap)
                {
                    MessageBox.Show("Không Tồn Tại Tên Đăng Nhập");
                    dangnhap.ShowDialog();
                }
                if(nd.TenDangNhap==tenDangnhap && nd.MatKhau==matKhau)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Form1.username = tenDangnhap;
                    Form1.pass = matKhau;
                    enabledangnhapok();
                }
            }
        }
        private void barbtndangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangNhap();
        }
        public void enable()
        {
            this.barbtndangnhap.Enabled = true;
            this.btndoimk.Enabled = true;
            this.btnloainguoidung.Enabled = false;
            this.btnkhachhang.Enabled = false;
            this.btndichvu.Enabled = true;
            this.btnphong.Enabled = true;
            this.btndsdangkyphong.Enabled = false;
            this.btndsnhantraphong.Enabled = false;
            this.btnhoadon.Enabled = false;
            this.btnthietbi.Enabled = false;
            this.btnloaiphong.Enabled = false;
            this.btnloaidichvu.Enabled = false;
//--------------------------------------------------------------//
            
            this.trảPhòngToolStripMenuItem.Enabled = false;
            this.đăngKýToolStripMenuItem.Enabled = false;
            this.nhậnPhòngToolStripMenuItem.Enabled = false;
            this.sửDụngDịchVụToolStripMenuItem.Enabled = false;
        }
        public void enabledangnhapok()
        {
            this.barbtndangnhap.Enabled = false;
            this.btndoimk.Enabled = true;
            this.btnloainguoidung.Enabled = true;
            this.btnkhachhang.Enabled = true;
            this.btndichvu.Enabled = true;
            this.btnphong.Enabled = true;
            this.btndsdangkyphong.Enabled = true;
            this.btndsnhantraphong.Enabled = true;
            this.btnhoadon.Enabled = true;
            this.btnthietbi.Enabled = true;
            this.btnloaiphong.Enabled = true;
            this.btnloaidichvu.Enabled = true;
            //--------------------------------------------------------------//
            
            this.trảPhòngToolStripMenuItem.Enabled = true;        
            this.đăngKýToolStripMenuItem.Enabled = true;
            this.nhậnPhòngToolStripMenuItem.Enabled = true;
            this.sửDụngDịchVụToolStripMenuItem.Enabled = true;
        }

        private void btnphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DsPhong P = new DsPhong();
            P.ShowDialog();
            a();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void btnloaiphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsLoaiPhong lp = new dsLoaiPhong();
            lp.ShowDialog();
        }

        private void btnloaidichvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Floaidichvu dv = new Floaidichvu();
            dv.ShowDialog();
        }

        private void btnhoadon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fhoadon hd = new Fhoadon();
            hd.ShowDialog();
            a();
        }
        public string maphongdk
        {
            get { return  maphonglay; }
        }
        private void btndsdangkyphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dangkyphong dk = new Dangkyphong();
            dk.ShowDialog();
        }

        private void btndichvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fdichvu dv = new fdichvu();
            dv.ShowDialog();
        }

        private void btnkhachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fkhachhang kh = new fkhachhang();
            kh.ShowDialog();
        }

        private void btndoimk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoiMk dmk = new DoiMk();
            dmk.ShowDialog();

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                maphonglay = listView1.SelectedItems[0].Text;
                var res = new PhongMod().filldatasetphongbyMaPhong(int.Parse(maphonglay));
                int maloaitinhtrang = int.Parse(res.Rows[0].ItemArray[2].ToString());
                if (maloaitinhtrang == 1)
                {
                    dangkyphong2 dkk = new dangkyphong2();
                    dkk.nhanMaPhong = maphongdk;
                    dkk.ShowDialog();
                    a();
                }
                else if (maloaitinhtrang == 2)
                {
                    MessageBox.Show("Phòng" + "---------" + maphonglay + "---------" + "đã đăng ký rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a();
                }
                else if (maloaitinhtrang == 3)
                {
                    MessageBox.Show("Phòng" + "---------" + maphonglay + "---------" + "đã Có Người rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a();
                }
            }
            else
            {
                MessageBox.Show("Bạn Chọn Cái Gì Thế???", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                maphonglay = listView1.SelectedItems[0].Text;
                var res = new PhongMod().filldatasetphongbyMaPhong(int.Parse(maphonglay));
                int maloaitinhtrang = int.Parse(res.Rows[0].ItemArray[2].ToString());
                if (maloaitinhtrang == 1)
                {
                    MessageBox.Show("Phòng" + "---------" + maphonglay + "---------" + "Chưa Nhận Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a();
                }
                else if (maloaitinhtrang == 2)
                {
                    MessageBox.Show("Phòng" + "---------" + maphonglay + "---------" + "Chưa Nhận Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a();
                }
                else if (maloaitinhtrang == 3)
                {
                    Fhoadon hd = new Fhoadon();
                    hd.ShowDialog();
                    a();
                }
            }
            else
            {
                MessageBox.Show("Bạn Chọn Cái Gì Thế???", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnloainguoidung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {

           
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                maphonglay = listView1.SelectedItems[0].Text;
                var res = new PhongMod().filldatasetphongbyMaPhong(int.Parse(maphonglay));
                int maloaitinhtrang = int.Parse(res.Rows[0].ItemArray[2].ToString());
                if (maloaitinhtrang == 1)
                {
                    MessageBox.Show("Phòng" + "---------" + maphonglay + "---------" + "Chưa Nhận Phòng không thể sử dụng DV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a();
                }
                else if (maloaitinhtrang == 2)
                {
                    MessageBox.Show("Phòng" + "---------" + maphonglay + "---------" + "Chưa Nhận Phòng không thể sử dụng DV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a();
                }
                else if (maloaitinhtrang == 3)
                {
                    maphonglay = listView1.SelectedItems[0].Text;
                    Dangkydv dkdv = new Dangkydv();
                    dkdv.nhanMaPhong = maphongdk;
                    dkdv.ShowDialog();
                    a();
                }
            }
            else
            {
                MessageBox.Show("Bạn Chọn Cái Gì Thế???", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                maphonglay = listView1.SelectedItems[0].Text;
                var res = new PhongMod().filldatasetphongbyMaPhong(int.Parse(maphonglay));
                int maloaitinhtrang = int.Parse(res.Rows[0].ItemArray[2].ToString());
                if (maloaitinhtrang == 1)
                {
                    MessageBox.Show("Phòng" + "---------" + maphonglay + "---------" + "Chưa Đăng Ký không thể Nhận Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a();
                }
                else if (maloaitinhtrang == 2)
                {
                    NhanPhong npa = new NhanPhong();
                    maphonglay = listView1.SelectedItems[0].Text;
                    npa.nhanMaPhong = maphongdk;
                    npa.ShowDialog();
                    a();
                 
                }
                else if (maloaitinhtrang == 3)
                {
                    MessageBox.Show("Phòng" + "---------" + maphonglay + "---------" + "Đã Nhận Rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    a();
                }
            }
            else
            {
                MessageBox.Show("Bạn Chọn Cái Gì Thế???", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thietbi tb = new thietbi();
            tb.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachSuDungDV ds = new DanhSachSuDungDV();
            ds.ShowDialog();
            a();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Thongke tk = new Thongke();
            tk.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LienHe lh = new LienHe();
            lh.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Huongdansudung hd = new Huongdansudung();
            hd.ShowDialog();
        }
    }
}

