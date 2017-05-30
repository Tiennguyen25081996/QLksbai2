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
    public partial class fdichvu : DevExpress.XtraEditors.XtraForm
    {
        public fdichvu()
        {
            InitializeComponent();
        }
        int plag = 0;
        void timkiem()
        {                    
                DichVuMod pm = new DichVuMod();
                dgvdv.DataSource = pm.timkiem(txttimkiem.Text);
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }
        void clear()
        {
            txttimkiem.Text = "";
            txtmadv.Text = "";
            txtloaidv.Text = "";
            txtdongia.Text = "";
        }
        void Binding()
        {
            string maphong = "";
            maphong = "" + dgvdv.CurrentRow.Cells[0].Value;
            string maloaiphong = "";
            maloaiphong = "" + dgvdv.CurrentRow.Cells[1].Value;
            string maloaitinhtrang = "";
            maloaitinhtrang = "" + dgvdv.CurrentRow.Cells[2].Value;


            txtmadv.Text = maphong;
            txtloaidv.Text = maloaiphong;
            txtdongia.Text = maloaitinhtrang;
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
            txtmadv.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DichVu delete = new DichVu();
                delete.MaDichVu = txtmadv.Text;
                new DichVuMod().delete(delete);
                MessageBox.Show("Xóa Thành Công");
            }
            fdichvu_Load(sender, e);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            if (plag == 1)
            {
                DichVu Ojphong = new DichVu();
                Ojphong.MaDichVu = txtmadv.Text;
                Ojphong.MaLoaiDichVu = txtloaidv.Text;
                Ojphong.DonGia = int.Parse(txtdongia.Text);
                new DichVuMod().insert(Ojphong);
                MessageBox.Show("Thêm Mới Thành Công!!!", "Thông Báo");
            }
            else
            {
                if (plag == 2)
                {
                    DichVu a = new DichVu();
                    a.MaDichVu = txtmadv.Text;
                    a.MaLoaiDichVu = txtloaidv.Text;
                    a.DonGia = int.Parse(txtdongia.Text);
                    new DichVuMod().Update(a);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    fdichvu_Load(sender, e);
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
            fdichvu_Load(sender, e);
        }
        void hienthi()
        {
            DichVuMod pm = new DichVuMod();
            dgvdv.DataSource = pm.FillDataSet_spgetMaNhanPhong();
        }
        private void fdichvu_Load(object sender, EventArgs e)
        {
            hienthi();
            Binding();
        }

        private void dgvdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }
    }
}