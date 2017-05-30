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
using System.Data.Entity;
using QuanLyKhachSanB2.Model;
using QuanLyKhachSanB2.connection;

namespace QuanLyKhachSanB2
{
    public partial class DsPhong : DevExpress.XtraEditors.XtraForm
    {
        public DsPhong()
        {
            InitializeComponent();
        }
        int plag = 0;
        QuanLyKhachSanDBContext db = new QuanLyKhachSanDBContext();
        public void hienthidanhsachphong()
        {
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            PhongMod pm = new PhongMod();      
            dgvdsphong.DataSource = pm.listdsphong();
        }
        private void DsPhong_Load(object sender, EventArgs e)
        {
            hienthidanhsachphong();
            Binding();
            loadcontrolMaloaiPhong();
            loadcontrolMaLoaiTinhTrang();
            loadcontrolGhiChu();
            //PhongMod query = new PhongMod();
            //dgvdsphong.DataSource = query.listdsphong();
        }
        void clear()
        {
            txtmaphong.Text = "";
            cmbmaloaiphong.Text = "";
            cmbghichu.Text = "";
            cmbmaloaitinhtrang.Text = "";
        }
        void Binding()
        {
            string maphong = "";
            maphong = "" + dgvdsphong.CurrentRow.Cells[0].Value;
            string maloaiphong = "";
            maloaiphong = "" + dgvdsphong.CurrentRow.Cells[1].Value;
            //string tenloaiphong = "";
            //tenloaiphong = "" + dgvdsphong.CurrentRow.Cells[2].Value;
            string maloaitinhtrang = "";
            maloaitinhtrang = ""+ dgvdsphong.CurrentRow.Cells[2].Value;
            string ghichu = "";
            ghichu = "" + dgvdsphong.CurrentRow.Cells[3].Value;
            //string giatien = "";
            //giatien = "" + dgvdsphong.CurrentRow.Cells[5].Value;
            txtmaphong.Text = maphong;
            cmbmaloaiphong.Text = maloaiphong;
            cmbmaloaitinhtrang.Text = maloaitinhtrang;
            cmbghichu.Text = ghichu;
        }
        private void btnxemloaiphong_Click(object sender, EventArgs e)
        {
            dsLoaiPhong lp = new dsLoaiPhong();
            lp.ShowDialog();
        }

        private void dgvdsphong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Binding();
        }
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            plag = 1;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            clear();
        }
        void loadcontrolMaloaiPhong()
        {
            LoaiPhongMod lp = new LoaiPhongMod();
            cmbmaloaiphong.DataSource = lp.FillDataSet_spgetMaloaiPhong();
            cmbmaloaiphong.ValueMember = "MaLoaiPhong";
        }
        void loadcontrolMaLoaiTinhTrang()
        {
            TinhTrangMod tr = new TinhTrangMod();
            cmbmaloaitinhtrang.DataSource = tr.FillDataSet_spgetMaloaiTinhTrang();
            cmbmaloaitinhtrang.ValueMember = "MaLoaiTinhTrang";
        }
        void loadcontrolGhiChu()
        {
            TinhTrangMod gc = new TinhTrangMod();
            cmbghichu.DataSource = gc.FillDataSet_spgetMaloaiTinhTrang();
            cmbghichu.DisplayMember = "TenLoaiTinhTrang";
            cmbghichu.ValueMember = "TenLoaiTinhTrang";
        }
        private void btnsua_Click_1(object sender, EventArgs e)
        {
            Binding();
            plag = 2;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            txtmaphong.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Phong delete = new Phong();
                delete.MaPhong = txtmaphong.Text;
                new PhongMod().delete(delete);
                MessageBox.Show("Xóa Thành Công");
            }
            DsPhong_Load(sender, e);
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            if (plag == 1)
            {
                Phong Ojphong = new Phong();
                Ojphong.MaPhong = txtmaphong.Text;
                Ojphong.MaLoaiPhong = cmbmaloaiphong.Text;
                Ojphong.MaLoaiTinhTrang = int.Parse(cmbmaloaitinhtrang.Text);
                Ojphong.GhiChu = cmbghichu.Text;
                new PhongMod().insert(Ojphong);
                MessageBox.Show("Thêm Mới Thành Công!!!", "Thông Báo");
            }
            else
            {
                if (plag == 2)
                {
                    Phong pm = new Phong();
                    pm.MaPhong = txtmaphong.Text;
                    pm.MaLoaiPhong = cmbmaloaiphong.Text;
                    pm.MaLoaiTinhTrang = int.Parse(cmbmaloaitinhtrang.Text);
                    pm.GhiChu = cmbghichu.Text;
                    new PhongMod().Update(pm);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    DsPhong_Load(sender, e);
                }
            }
            hienthidanhsachphong();
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = true;
            DsPhong_Load(sender, e);
        }
    }
}