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
    public partial class dsLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public dsLoaiPhong()
        {
            InitializeComponent();
        }
        int plag = 0;
        private void dsLoaiPhong_Load(object sender, EventArgs e)
        {
            LoaiPhongMod p = new LoaiPhongMod();
            dgvloaiphong.DataSource = p.FillDataSet_spgetMaloaiPhong();
            Binding();
        }
        void clear()
        {
            txtmaloaiphong.Text = "";
            txttenloaiphong.Text = "";
            txtgiatien.Text = "";
            
        }
        void Binding()
        {
            string maloaiphong = "";
            maloaiphong = "" + dgvloaiphong.CurrentRow.Cells[0].Value;
            string tenloaiphong = "";
            tenloaiphong = "" + dgvloaiphong.CurrentRow.Cells[1].Value;
            string giatien = "";
            giatien = "" + dgvloaiphong.CurrentRow.Cells[2].Value;


            txtmaloaiphong.Text = maloaiphong;
            txttenloaiphong.Text = tenloaiphong;
            txtgiatien.Text = giatien;
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
            txtmaloaiphong.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LoaiPhong delete = new LoaiPhong();
                delete.MaLoaiPhong = txtmaloaiphong.Text;
                new LoaiPhongMod().delete(delete);
                MessageBox.Show("Xóa Thành Công");
            }
            dsLoaiPhong_Load(sender, e);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            if (plag == 1)
            {
                LoaiPhong Ojphong = new LoaiPhong();
                Ojphong.MaLoaiPhong = txtmaloaiphong.Text;
                Ojphong.TenLoaiPhong = txttenloaiphong.Text;
                Ojphong.DonGiaTheoNgay = int.Parse(txtgiatien.Text);
                new LoaiPhongMod().insert(Ojphong);
                MessageBox.Show("Thêm Mới Thành Công!!!", "Thông Báo");
            }
            else
            {
                if (plag == 2)
                {
                    LoaiPhong a = new LoaiPhong();
                    a.MaLoaiPhong = txtmaloaiphong.Text;
                    a.TenLoaiPhong = txttenloaiphong.Text;
                    a.DonGiaTheoNgay = int.Parse(txtgiatien.Text);
                    new LoaiPhongMod().Update(a);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    dsLoaiPhong_Load(sender, e);
                }
            }
            dsLoaiPhong_Load(sender, e);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmaloaiphong.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = true;
            dsLoaiPhong_Load(sender, e);
        }

        private void dgvloaiphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }
    }
}