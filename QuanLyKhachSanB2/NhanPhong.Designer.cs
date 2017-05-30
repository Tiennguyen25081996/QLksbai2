namespace QuanLyKhachSanB2
{
    partial class NhanPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvchitietphieunhanphong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.dtpngaynhan = new System.Windows.Forms.DateTimePicker();
            this.dtpngaytra = new System.Windows.Forms.DateTimePicker();
            this.txtXMND = new System.Windows.Forms.TextBox();
            this.txttenKH = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtManhanphong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.MaNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotenkh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYnHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietphieunhanphong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvchitietphieunhanphong
            // 
            this.dgvchitietphieunhanphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitietphieunhanphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanPhong,
            this.MaPhong2,
            this.MaKhachHang2,
            this.Hotenkh2,
            this.CMND2,
            this.nGAYnHAN,
            this.NgayTra2});
            this.dgvchitietphieunhanphong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvchitietphieunhanphong.Location = new System.Drawing.Point(0, 243);
            this.dgvchitietphieunhanphong.Name = "dgvchitietphieunhanphong";
            this.dgvchitietphieunhanphong.Size = new System.Drawing.Size(751, 242);
            this.dgvchitietphieunhanphong.TabIndex = 3;
            this.dgvchitietphieunhanphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchitietphieunhanphong_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.cmbMaKH);
            this.groupBox1.Controls.Add(this.dtpngaynhan);
            this.groupBox1.Controls.Add(this.dtpngaytra);
            this.groupBox1.Controls.Add(this.txtXMND);
            this.groupBox1.Controls.Add(this.txttenKH);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.txtManhanphong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Nhận Phòng";
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(215, 102);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(140, 21);
            this.cmbMaKH.TabIndex = 17;
            this.cmbMaKH.SelectedValueChanged += new System.EventHandler(this.cmbMaKH_SelectedValueChanged);
            // 
            // dtpngaynhan
            // 
            this.dtpngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynhan.Location = new System.Drawing.Point(425, 69);
            this.dtpngaynhan.Name = "dtpngaynhan";
            this.dtpngaynhan.Size = new System.Drawing.Size(129, 21);
            this.dtpngaynhan.TabIndex = 15;
            // 
            // dtpngaytra
            // 
            this.dtpngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaytra.Location = new System.Drawing.Point(425, 100);
            this.dtpngaytra.Name = "dtpngaytra";
            this.dtpngaytra.Size = new System.Drawing.Size(129, 21);
            this.dtpngaytra.TabIndex = 16;
            // 
            // txtXMND
            // 
            this.txtXMND.Location = new System.Drawing.Point(425, 41);
            this.txtXMND.Name = "txtXMND";
            this.txtXMND.Size = new System.Drawing.Size(129, 21);
            this.txtXMND.TabIndex = 10;
            // 
            // txttenKH
            // 
            this.txttenKH.Location = new System.Drawing.Point(215, 130);
            this.txttenKH.Name = "txttenKH";
            this.txttenKH.Size = new System.Drawing.Size(140, 21);
            this.txttenKH.TabIndex = 11;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(215, 73);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(139, 21);
            this.txtMaPhong.TabIndex = 13;
            // 
            // txtManhanphong
            // 
            this.txtManhanphong.Location = new System.Drawing.Point(215, 46);
            this.txtManhanphong.Name = "txtManhanphong";
            this.txtManhanphong.Size = new System.Drawing.Size(139, 21);
            this.txtManhanphong.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày Trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Nhận";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Phiếu Nhận Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Nhận Phòng";
            // 
            // btnhuy
            // 
            this.btnhuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhuy.ImageUri.Uri = "Recurrence";
            this.btnhuy.Location = new System.Drawing.Point(514, 176);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(92, 61);
            this.btnhuy.TabIndex = 17;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnluu.ImageUri.Uri = "Save";
            this.btnluu.Location = new System.Drawing.Point(413, 176);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(95, 61);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnxoa.ImageUri.Uri = "Cancel";
            this.btnxoa.Location = new System.Drawing.Point(318, 176);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 61);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnsua.ImageUri.Uri = "Edit";
            this.btnsua.Location = new System.Drawing.Point(224, 176);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 61);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.ImageUri.Uri = "Add";
            this.btnthem.Location = new System.Drawing.Point(131, 176);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 61);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "Nhận Phòng";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.ImageUri.Uri = "Refresh";
            this.simpleButton1.Location = new System.Drawing.Point(357, 119);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 43);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // MaNhanPhong
            // 
            this.MaNhanPhong.DataPropertyName = "MaNhanPhong";
            this.MaNhanPhong.FillWeight = 99.57326F;
            this.MaNhanPhong.HeaderText = "Mã Nhận Phòng";
            this.MaNhanPhong.Name = "MaNhanPhong";
            this.MaNhanPhong.Width = 70;
            // 
            // MaPhong2
            // 
            this.MaPhong2.DataPropertyName = "MaPhong";
            this.MaPhong2.FillWeight = 99.75243F;
            this.MaPhong2.HeaderText = "Mã Phòng";
            this.MaPhong2.Name = "MaPhong2";
            this.MaPhong2.Width = 80;
            // 
            // MaKhachHang2
            // 
            this.MaKhachHang2.DataPropertyName = "MaKhachHang";
            this.MaKhachHang2.FillWeight = 99.90612F;
            this.MaKhachHang2.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang2.Name = "MaKhachHang2";
            this.MaKhachHang2.Width = 70;
            // 
            // Hotenkh2
            // 
            this.Hotenkh2.DataPropertyName = "TenKhachHang";
            this.Hotenkh2.FillWeight = 100.0379F;
            this.Hotenkh2.HeaderText = "Họ Tên Khách Hàng";
            this.Hotenkh2.Name = "Hotenkh2";
            this.Hotenkh2.Width = 150;
            // 
            // CMND2
            // 
            this.CMND2.DataPropertyName = "CMND";
            this.CMND2.FillWeight = 100.151F;
            this.CMND2.HeaderText = "CMND";
            this.CMND2.Name = "CMND2";
            this.CMND2.Width = 116;
            // 
            // nGAYnHAN
            // 
            this.nGAYnHAN.DataPropertyName = "NgayNhan";
            this.nGAYnHAN.FillWeight = 100.248F;
            this.nGAYnHAN.HeaderText = "Ngày Nhận";
            this.nGAYnHAN.Name = "nGAYnHAN";
            this.nGAYnHAN.Width = 110;
            // 
            // NgayTra2
            // 
            this.NgayTra2.DataPropertyName = "NgayTraPhong";
            this.NgayTra2.FillWeight = 100.3312F;
            this.NgayTra2.HeaderText = "Ngày Trả Phòng";
            this.NgayTra2.Name = "NgayTra2";
            this.NgayTra2.Width = 110;
            // 
            // NhanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 485);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvchitietphieunhanphong);
            this.Name = "NhanPhong";
            this.Text = "NhanPhong";
            this.Load += new System.EventHandler(this.NhanPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietphieunhanphong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvchitietphieunhanphong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpngaynhan;
        private System.Windows.Forms.DateTimePicker dtpngaytra;
        private System.Windows.Forms.TextBox txtXMND;
        private System.Windows.Forms.TextBox txttenKH;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtManhanphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotenkh2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYnHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra2;
    }
}