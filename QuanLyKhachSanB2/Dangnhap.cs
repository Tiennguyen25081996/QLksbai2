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

namespace QuanLyKhachSanB2
{
    public partial class Dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        private String m_TenNguoiDung;
        public String lay_TenNguoiDung
        {
            get { return m_TenNguoiDung; }
            set { m_TenNguoiDung = value; }
        }
        private String m_MatKhau;
        public String lay_MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
        private void Dangnhap_Load(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.txttendangnhap.Focus();
            m_TenNguoiDung = this.txttendangnhap.Text;
            m_MatKhau = this.txtmatkhau.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}