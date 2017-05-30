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
    public partial class fkhachhang : DevExpress.XtraEditors.XtraForm
    {
        public fkhachhang()
        {
            InitializeComponent();
        }
        int plag = 0;
        void timkiem()
        {
                KhachHangMod pm = new KhachHangMod();
                dgvkh.DataSource = pm.timkiem(txttimkiem.Text);          
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }
        void clear()
        {
            txttimkiem.Text = "";
            txtMaKH.Text = "";
            txttenKH.Text = "";
            txtCMND.Text = "";
            cmbgioitinh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            cmbquoctich.Text = "";
        }
        void Binding()
        {
            string makhachhang = "";
            makhachhang = "" + dgvkh.CurrentRow.Cells[0].Value;
            string tenkhachhang = "";
            tenkhachhang = "" + dgvkh.CurrentRow.Cells[1].Value;
            string CMND = "";
            CMND = "" + dgvkh.CurrentRow.Cells[2].Value;
            string GioiTinh = "";
            GioiTinh = "" + dgvkh.CurrentRow.Cells[3].Value;
            string DiaChi = "";
            DiaChi = "" + dgvkh.CurrentRow.Cells[4].Value;
            string DienThoai = "";
            DienThoai = "" + dgvkh.CurrentRow.Cells[5].Value;
            string QuocTich = "";
            QuocTich = "" + dgvkh.CurrentRow.Cells[6].Value;

            txtMaKH.Text = makhachhang;
            txttenKH.Text = tenkhachhang;
            txtCMND.Text = CMND;
            cmbgioitinh.Text = GioiTinh;
            cmbquoctich.Text = QuocTich;
            txtdiachi.Text = DiaChi;
            txtsdt.Text = DienThoai;
        }
        void hienthi()
        {
            KhachHangMod pm = new KhachHangMod();
            dgvkh.DataSource = pm.FillDataSet_spgetall();
        }
        private void fkhachhang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            hienthi();
            Binding();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            plag = 1;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Binding();
            plag = 2;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            txtMaKH.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                KhachHang delete = new KhachHang();
                delete.MaKhachHang = int.Parse(txtMaKH.Text);
                new KhachHangMod().delete(delete);
                MessageBox.Show("Xóa Thành Công");
            }
            fkhachhang_Load(sender, e);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            if (plag == 1)
            {
                KhachHang Ojphong = new KhachHang();
                //Ojphong.MaKhachHang = int.Parse(txtMaKH.Text);
                Ojphong.TenKhachHang = txttenKH.Text;
                Ojphong.CMND = txtCMND.Text;
                Ojphong.GioiTinh = cmbgioitinh.Text;
                Ojphong.DiaChi = txtdiachi.Text;
                Ojphong.DienThoai = txtsdt.Text;
                Ojphong.QuocTich = cmbquoctich.Text;

                new KhachHangMod().insert(Ojphong);
                MessageBox.Show("Thêm Mới Thành Công!!!", "Thông Báo");
            }
            else
            {
                if (plag == 2)
                {
                    KhachHang Ojphong = new KhachHang();
                    Ojphong.MaKhachHang = int.Parse(txtMaKH.Text);
                    Ojphong.TenKhachHang = txttenKH.Text;
                    Ojphong.CMND = txtCMND.Text;
                    Ojphong.GioiTinh = cmbgioitinh.Text;
                    Ojphong.DiaChi = txtdiachi.Text;
                    Ojphong.DienThoai = txtsdt.Text;
                    Ojphong.QuocTich = cmbquoctich.Text;
                    new KhachHangMod().Update(Ojphong);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    fkhachhang_Load(sender, e);
                }
            }
            hienthi();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = true;
            fkhachhang_Load(sender, e);
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void cmbquoctich_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}