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
    public partial class IN : DevExpress.XtraEditors.XtraForm
    {
        public IN()
        {
            InitializeComponent();
        }
        public string mahd
        {
            set { txtmahd.Text = value; }
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            txtmahd.Enabled = false;
            RPINHD cr = new RPINHD();
            cr.SetParameterValue("@MaHoaDon", txtmahd.Text);
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = cr;
        }
    }
}