namespace QuanLyKhachSanB2
{
    partial class DsPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DsPhong));
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dgvdsphong = new System.Windows.Forms.DataGridView();
            this.txtmaphong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbmaloaitinhtrang = new System.Windows.Forms.ComboBox();
            this.btnxemloaiphong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.cmbghichu = new System.Windows.Forms.ComboBox();
            this.cmbmaloaiphong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = -1;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // dgvdsphong
            // 
            this.dgvdsphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsphong.Location = new System.Drawing.Point(3, 192);
            this.dgvdsphong.Name = "dgvdsphong";
            this.dgvdsphong.Size = new System.Drawing.Size(573, 259);
            this.dgvdsphong.TabIndex = 0;
            this.dgvdsphong.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdsphong_CellMouseClick);
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(129, 55);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(100, 20);
            this.txtmaphong.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(76, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã Phòng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(54, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã Loại Phòng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(342, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ghi Chú";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(294, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Mã Loại Tình Trạng";
            // 
            // cmbmaloaitinhtrang
            // 
            this.cmbmaloaitinhtrang.FormattingEnabled = true;
            this.cmbmaloaitinhtrang.Location = new System.Drawing.Point(390, 55);
            this.cmbmaloaitinhtrang.Name = "cmbmaloaitinhtrang";
            this.cmbmaloaitinhtrang.Size = new System.Drawing.Size(121, 21);
            this.cmbmaloaitinhtrang.TabIndex = 3;
            // 
            // btnxemloaiphong
            // 
            this.btnxemloaiphong.Image = ((System.Drawing.Image)(resources.GetObject("btnxemloaiphong.Image")));
            this.btnxemloaiphong.Location = new System.Drawing.Point(233, 69);
            this.btnxemloaiphong.Name = "btnxemloaiphong";
            this.btnxemloaiphong.Size = new System.Drawing.Size(53, 44);
            this.btnxemloaiphong.TabIndex = 4;
            this.btnxemloaiphong.Click += new System.EventHandler(this.btnxemloaiphong_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(155, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(246, 23);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Chi Tiết Danh Sách Phòng";
            // 
            // btnhuy
            // 
            this.btnhuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhuy.ImageUri.Uri = "Recurrence";
            this.btnhuy.Location = new System.Drawing.Point(435, 125);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(92, 61);
            this.btnhuy.TabIndex = 12;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnluu.ImageUri.Uri = "Save";
            this.btnluu.Location = new System.Drawing.Point(334, 125);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(95, 61);
            this.btnluu.TabIndex = 13;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnxoa.ImageUri.Uri = "Cancel";
            this.btnxoa.Location = new System.Drawing.Point(239, 125);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 61);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnsua.ImageUri.Uri = "Edit";
            this.btnsua.Location = new System.Drawing.Point(145, 125);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 61);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.ImageUri.Uri = "Add";
            this.btnthem.Location = new System.Drawing.Point(52, 125);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 61);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // cmbghichu
            // 
            this.cmbghichu.FormattingEnabled = true;
            this.cmbghichu.Location = new System.Drawing.Point(390, 85);
            this.cmbghichu.Name = "cmbghichu";
            this.cmbghichu.Size = new System.Drawing.Size(121, 21);
            this.cmbghichu.TabIndex = 3;
            // 
            // cmbmaloaiphong
            // 
            this.cmbmaloaiphong.FormattingEnabled = true;
            this.cmbmaloaiphong.Location = new System.Drawing.Point(129, 82);
            this.cmbmaloaiphong.Name = "cmbmaloaiphong";
            this.cmbmaloaiphong.Size = new System.Drawing.Size(98, 21);
            this.cmbmaloaiphong.TabIndex = 3;
            // 
            // DsPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 451);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnxemloaiphong);
            this.Controls.Add(this.cmbmaloaiphong);
            this.Controls.Add(this.cmbghichu);
            this.Controls.Add(this.cmbmaloaitinhtrang);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.dgvdsphong);
            this.Name = "DsPhong";
            this.Text = "Danh Sách Phòng";
            this.Load += new System.EventHandler(this.DsPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private System.Windows.Forms.DataGridView dgvdsphong;
        private DevExpress.XtraEditors.TextEdit txtmaphong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cmbmaloaitinhtrang;
        private DevExpress.XtraEditors.SimpleButton btnxemloaiphong;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.ComboBox cmbghichu;
        private System.Windows.Forms.ComboBox cmbmaloaiphong;
    }
}