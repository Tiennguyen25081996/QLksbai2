namespace QuanLyKhachSanB2
{
    partial class Dangkyphong
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.dgvchitietphieuthuephong = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtmaphieuthue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.datengaydangky = new DevExpress.XtraEditors.DateEdit();
            this.datengaynhan = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietphieuthuephong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphieuthue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaydangky.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaydangky.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaynhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaynhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(220, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(146, 23);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Đăng Ký Phòng";
            // 
            // btnhuy
            // 
            this.btnhuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhuy.ImageUri.Uri = "Recurrence";
            this.btnhuy.Location = new System.Drawing.Point(428, 118);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(92, 61);
            this.btnhuy.TabIndex = 7;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnluu.ImageUri.Uri = "Save";
            this.btnluu.Location = new System.Drawing.Point(327, 118);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(95, 61);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnxoa.ImageUri.Uri = "Cancel";
            this.btnxoa.Location = new System.Drawing.Point(232, 118);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 61);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnsua.ImageUri.Uri = "Edit";
            this.btnsua.Location = new System.Drawing.Point(138, 118);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 61);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dgvchitietphieuthuephong
            // 
            this.dgvchitietphieuthuephong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitietphieuthuephong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvchitietphieuthuephong.Location = new System.Drawing.Point(0, 188);
            this.dgvchitietphieuthuephong.Name = "dgvchitietphieuthuephong";
            this.dgvchitietphieuthuephong.Size = new System.Drawing.Size(565, 254);
            this.dgvchitietphieuthuephong.TabIndex = 12;
            this.dgvchitietphieuthuephong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchitietphieuthuephong_CellClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(65, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Mã Phiếu Thuê";
            // 
            // txtmaphieuthue
            // 
            this.txtmaphieuthue.Location = new System.Drawing.Point(158, 58);
            this.txtmaphieuthue.Name = "txtmaphieuthue";
            this.txtmaphieuthue.Size = new System.Drawing.Size(100, 20);
            this.txtmaphieuthue.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(291, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Ngày Đăng Ký";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(308, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Ngày Nhận";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(86, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Mã Phòng";
            // 
            // datengaydangky
            // 
            this.datengaydangky.EditValue = null;
            this.datengaydangky.Location = new System.Drawing.Point(367, 57);
            this.datengaydangky.Name = "datengaydangky";
            this.datengaydangky.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datengaydangky.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datengaydangky.Size = new System.Drawing.Size(100, 20);
            this.datengaydangky.TabIndex = 16;
            // 
            // datengaynhan
            // 
            this.datengaynhan.EditValue = null;
            this.datengaynhan.Location = new System.Drawing.Point(367, 82);
            this.datengaynhan.Name = "datengaynhan";
            this.datengaynhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datengaynhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datengaynhan.Size = new System.Drawing.Size(100, 20);
            this.datengaynhan.TabIndex = 16;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(158, 84);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 14;
            // 
            // btnthem
            // 
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.ImageUri.Uri = "Add";
            this.btnthem.Location = new System.Drawing.Point(41, 118);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(92, 61);
            this.btnthem.TabIndex = 69;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Dangkyphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 442);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.datengaynhan);
            this.Controls.Add(this.datengaydangky);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtmaphieuthue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvchitietphieuthuephong);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.labelControl5);
            this.Name = "Dangkyphong";
            this.Text = "Đăng Ký Phòng";
            this.Load += new System.EventHandler(this.Dangkyphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitietphieuthuephong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphieuthue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaydangky.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaydangky.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaynhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaynhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private System.Windows.Forms.DataGridView dgvchitietphieuthuephong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtmaphieuthue;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit datengaydangky;
        private DevExpress.XtraEditors.DateEdit datengaynhan;
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        private DevExpress.XtraEditors.SimpleButton btnthem;
    }
}