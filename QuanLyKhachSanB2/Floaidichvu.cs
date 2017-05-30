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

namespace QuanLyKhachSanB2
{
    public partial class Floaidichvu : DevExpress.XtraEditors.XtraForm
    {
        public Floaidichvu()
        {
            InitializeComponent();
        }
        int i = 0;
        private void enable(bool t)
        {
            button1.Enabled = t;
            button2.Enabled = t;
            button3.Enabled = t;
            button4.Enabled =!t;
            button5.Enabled = !t;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            enable(false);
            textBox1.Text = "";
            textBox2.Text = "";
            i = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Trim().Equals("")) {
                enable(false);
                i = 2;
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn GÌ");
            }
        }

        private void Floaidichvu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoaiDVMod.getAllLoaiDV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enable(true);
            if (i == 1)
            {
                //them
                LoaiDVMod.insertLoaiDV(textBox1.Text, textBox2.Text);
            }
            if (i == 2)
            {
                //sua
                LoaiDVMod.updateLoaiDV(textBox1.Text, textBox2.Text);
            }
            dataGridView1.DataSource = LoaiDVMod.getAllLoaiDV();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enable(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Trim().Equals(""))
            {
              //  enable(false);
                try
                {
                    DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        LoaiDVMod.deleteLoaiDV(textBox1.Text);
                        MessageBox.Show("Xóa Thành Công");
                        dataGridView1.DataSource = LoaiDVMod.getAllLoaiDV();
                    }
 
                }
                catch
                {
                    MessageBox.Show("Mã Loại DV Không Hợp Lệ");
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Gì");
            }
            i = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = dataGridView1.CurrentRow.Cells;
            textBox1.Text = cells[0].Value.ToString();
            textBox2.Text = cells[1].Value.ToString();
        }
    }
}