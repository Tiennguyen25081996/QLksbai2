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
    public partial class DanhSachSuDungDV : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachSuDungDV()
        {
            InitializeComponent();
        }
        int plag = 0;
        public static string maphong;
        string manhanphong;
        public string nhanMaPhong
        {
            set { maphong = value; }
        }
        void timmanhanphongtumaphong()
        {
            var a = new ChiTietPhieuNhanPhongMod().FillDataSet_spgetMaNhanPhongbyMaPhong(int.Parse(maphong));
            manhanphong = a.Rows[0].ItemArray[0].ToString();
            txtmanhanphong.Text = manhanphong;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            clear();
            txtMaSDDV.Enabled = false;
            plag = 1;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtmanhanphong.Text = manhanphong;
        }
        void clear()
        {
            txtMaSDDV.Text = "";
            txtmanhanphong.Text = "";
            cmbMaDV.Text = "";
            txtSoLuong.Text = "";
        }
        void Binding()
        {
            string MaSDDV = "";
            MaSDDV = "" + dgvdsSuDungDV.CurrentRow.Cells[0].Value;
            string MaNhanPhong = "";
            MaNhanPhong = "" + dgvdsSuDungDV.CurrentRow.Cells[1].Value;          
            string MaDV = "";
            MaDV = "" + dgvdsSuDungDV.CurrentRow.Cells[2].Value;
            string sl = "";
            sl = "" + dgvdsSuDungDV.CurrentRow.Cells[3].Value;
            ///////////////////////////////////////////////////////////////////////////////////
            txtMaSDDV.Text = MaSDDV;
            txtmanhanphong.Text = MaDV;
            cmbMaDV.Text = MaNhanPhong;
            txtSoLuong.Text = sl;
        }
        public void hienthidssudungdichvu()
        {
            loadcontrolMadv();
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            DanhSachSuDungDVMod dv = new DanhSachSuDungDVMod();
            dgvdsSuDungDV.DataSource = dv.FillDataSet_spgetDSSDDV();
            Binding();
        }
        private void DanhSachSuDungDV_Load(object sender, EventArgs e)
        {
            hienthidssudungdichvu();
            loadcontrolMadv();
            timmanhanphongtumaphong();
            txtMaSDDV.Enabled = false;
        }

        private void dgvdsSuDungDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Binding();
            plag = 2;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            txtMaSDDV.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DanhSachSuDungDichVu sdv = new DanhSachSuDungDichVu();
                sdv.MaSuDungDV = int.Parse(txtMaSDDV.Text);
                new DanhSachSuDungDVMod().delete(sdv);
                MessageBox.Show("Xóa Thành Công");
            }
            DanhSachSuDungDV_Load(sender, e);
        }
        void loadcontrolMadv()
        {
            DichVuMod lp = new DichVuMod();
            cmbMaDV.DataSource = lp.FillDataSet_spgetMaNhanPhong();
            cmbMaDV.ValueMember = "MaDichVu";
            cmbMaDV.DisplayMember = "MaDichVu";
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            if (plag == 1)
            {
                DanhSachSuDungDichVu sdv = new DanhSachSuDungDichVu();
                sdv.MaDichVu = cmbMaDV.Text;
                if(int.Parse(txtSoLuong.Text) > 10)
                {
                    MessageBox.Show("không được nhập quá 10 dịch vụ", "thông báo", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else
                {
                    sdv.SoLuong = int.Parse(txtSoLuong.Text);
                    sdv.MaNhanPhong = int.Parse(txtmanhanphong.Text);
                    new DanhSachSuDungDVMod().insert(sdv);
                    MessageBox.Show("Thêm Mới Thành Công!!!", "Thông Báo");
                }       
               
            }
            else
            {
                if (plag == 2)
                {
                    DanhSachSuDungDichVu sdv = new DanhSachSuDungDichVu();
                    sdv.MaSuDungDV = int.Parse(txtMaSDDV.Text);
                    sdv.MaDichVu = cmbMaDV.Text;
                    if (int.Parse(txtSoLuong.Text) > 10)
                    {
                        MessageBox.Show("không được nhập quá 10 dịch vụ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        sdv.SoLuong = int.Parse(txtSoLuong.Text);
                        sdv.MaNhanPhong = int.Parse(txtmanhanphong.Text);
                        new DanhSachSuDungDVMod().Update(sdv);
                        MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    }                    
                    DanhSachSuDungDV_Load(sender, e);
                }
            }
            hienthidssudungdichvu();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = true;
            DanhSachSuDungDV_Load(sender, e);
        }
    }
}