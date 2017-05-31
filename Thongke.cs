using QuanLyKhachSanB2.connection;
using QuanLyKhachSanB2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanB2
{
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }
        void hienthi()
        {
            HoaDonMod hd = new HoaDonMod();
            dgvthongke.DataSource = hd.danhsachhoadondathanhtoan();
        }
        private void Thongke_Load(object sender, EventArgs e)
        {
            cmbthang.Enabled = false;
            hienthi();
        }
        void timkiem()
        {
            if (txttimkiem.Text != "")
            {
                HoaDonMod hd = new HoaDonMod();
                dgvthongke.DataSource = hd.timkiemhoadondathanhtoan(txttimkiem.Text);
            }
            else
            {
                hienthi();
            }

        }
        void timkiemtheothang()
        {
            if (cmbthang.Text != "")
            {
                HoaDonMod hd = new HoaDonMod();
                dgvthongke.DataSource = hd.timkiemhoadondathanhtoantheothang(cmbthang.Text);
                var a = hd.tongtientheothang(cmbthang.Text);
                ltongtien.Text = a.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                hienthi();
            }

        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void cmbthang_TextChanged(object sender, EventArgs e)
        {
            timkiemtheothang();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cmbthang.Enabled = true;
                txttimkiem.Enabled = false;
            }
            else
            {
                cmbthang.Enabled = false;
                txttimkiem.Enabled = true;
            }

        }
    }
}
