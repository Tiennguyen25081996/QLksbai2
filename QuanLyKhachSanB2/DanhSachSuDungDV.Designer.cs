namespace QuanLyKhachSanB2
{
    partial class DanhSachSuDungDV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMaDV = new System.Windows.Forms.ComboBox();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaSDDV = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.dgvdsSuDungDV = new System.Windows.Forms.DataGridView();
            this.MaSuDungDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmanhanphong = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSDDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsSuDungDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanhanphong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaDV);
            this.groupBox1.Controls.Add(this.btnhuy);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtmanhanphong);
            this.groupBox1.Controls.Add(this.txtMaSDDV);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 179);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sử Dụng Dịch Vụ";
            // 
            // cmbMaDV
            // 
            this.cmbMaDV.FormattingEnabled = true;
            this.cmbMaDV.Location = new System.Drawing.Point(454, 71);
            this.cmbMaDV.Name = "cmbMaDV";
            this.cmbMaDV.Size = new System.Drawing.Size(101, 21);
            this.cmbMaDV.TabIndex = 56;
            // 
            // btnhuy
            // 
            this.btnhuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhuy.ImageUri.Uri = "Recurrence";
            this.btnhuy.Location = new System.Drawing.Point(514, 111);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(92, 55);
            this.btnhuy.TabIndex = 51;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnluu.ImageUri.Uri = "Save";
            this.btnluu.Location = new System.Drawing.Point(413, 111);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(95, 55);
            this.btnluu.TabIndex = 52;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnxoa.ImageUri.Uri = "Cancel";
            this.btnxoa.Location = new System.Drawing.Point(318, 111);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 55);
            this.btnxoa.TabIndex = 53;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnsua.ImageUri.Uri = "Edit";
            this.btnsua.Location = new System.Drawing.Point(224, 111);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 55);
            this.btnsua.TabIndex = 54;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.ImageUri.Uri = "Add";
            this.btnthem.Location = new System.Drawing.Point(131, 111);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 55);
            this.btnthem.TabIndex = 55;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtMaSDDV
            // 
            this.txtMaSDDV.Location = new System.Drawing.Point(243, 37);
            this.txtMaSDDV.Name = "txtMaSDDV";
            this.txtMaSDDV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSDDV.TabIndex = 50;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(244, 71);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(96, 20);
            this.txtSoLuong.TabIndex = 49;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(358, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 47;
            this.labelControl2.Text = "Mã Nhận Phòng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(403, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Mã DV";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(163, 44);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(74, 13);
            this.labelControl10.TabIndex = 47;
            this.labelControl10.Text = "Mã Sử Dụng DV";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(176, 73);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 13);
            this.labelControl11.TabIndex = 46;
            this.labelControl11.Text = "Số Lượng DV";
            // 
            // dgvdsSuDungDV
            // 
            this.dgvdsSuDungDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdsSuDungDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsSuDungDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSuDungDV,
            this.MaDichVu,
            this.MaNhanPhong,
            this.SoLuong});
            this.dgvdsSuDungDV.Location = new System.Drawing.Point(16, 197);
            this.dgvdsSuDungDV.Name = "dgvdsSuDungDV";
            this.dgvdsSuDungDV.Size = new System.Drawing.Size(755, 237);
            this.dgvdsSuDungDV.TabIndex = 46;
            this.dgvdsSuDungDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsSuDungDV_CellClick);
            // 
            // MaSuDungDV
            // 
            this.MaSuDungDV.DataPropertyName = "MaSuDungDV";
            this.MaSuDungDV.HeaderText = "Mã Sử Dụng Dịch Vụ";
            this.MaSuDungDV.Name = "MaSuDungDV";
            // 
            // MaDichVu
            // 
            this.MaDichVu.DataPropertyName = "MaDichVu";
            this.MaDichVu.HeaderText = "Mã Dịch Vụ";
            this.MaDichVu.Name = "MaDichVu";
            // 
            // MaNhanPhong
            // 
            this.MaNhanPhong.DataPropertyName = "MaNhanPhong";
            this.MaNhanPhong.HeaderText = "Mã Nhận Phòng";
            this.MaNhanPhong.Name = "MaNhanPhong";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // txtmanhanphong
            // 
            this.txtmanhanphong.Location = new System.Drawing.Point(454, 40);
            this.txtmanhanphong.Name = "txtmanhanphong";
            this.txtmanhanphong.Size = new System.Drawing.Size(100, 20);
            this.txtmanhanphong.TabIndex = 50;
            // 
            // DanhSachSuDungDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 446);
            this.Controls.Add(this.dgvdsSuDungDV);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhSachSuDungDV";
            this.Text = "DanhSachSuDungDV";
            this.Load += new System.EventHandler(this.DanhSachSuDungDV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSDDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsSuDungDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanhanphong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtMaSDDV;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.DataGridView dgvdsSuDungDV;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuDungDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private DevExpress.XtraEditors.TextEdit txtmanhanphong;
    }
}