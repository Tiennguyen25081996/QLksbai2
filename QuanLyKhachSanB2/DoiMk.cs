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
    public partial class DoiMk : DevExpress.XtraEditors.XtraForm
    {
        public DoiMk()
        {
            InitializeComponent();
        }

        private void txtmkcu_TextChanged(object sender, EventArgs e)
        {
            if (!txtmkcu.Text.Equals(Form1.pass))
            {
                labelControl4.Text = "Sai mat khau";
                txtmkmoi.Enabled = false;
                txtnhaplaiMK.Enabled = false;
            }
            else
            {
                labelControl4.Text = "*";
                txtmkmoi.Enabled = true;
                txtnhaplaiMK.Enabled = true;
            }
        }

        private void txtmkmoi_TextChanged(object sender, EventArgs e)
        {
            if (txtmkmoi.Text.Trim().Equals(""))
            {
                labelControl6.Text = "Chưa nhập gì";
            }
            else
            {
                labelControl6.Text = "*";
            }
        }

        private void txtnhaplaiMK_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtnhaplaiMK_TextChanged(object sender, EventArgs e)
        {
            if (txtmkmoi.Text.Equals(txtnhaplaiMK.Text))
            {
                labelControl5.Text = "*";
                btnLuu.Enabled = true;
            }
            else
            {
                labelControl5.Text = "Sai rồi";
                btnLuu.Enabled = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            (new NguoiDungModel()).UpdateMk(Form1.username, txtnhaplaiMK.Text);
            Form1.pass = txtnhaplaiMK.Text;
            MessageBox.Show("OK");
            this.Close();
        }
    }
}