namespace QuanLyKhachSanB2
{
    partial class dangkyphong2
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
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.datengaynhan = new DevExpress.XtraEditors.DateEdit();
            this.datengaydangky = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtmaphieuthue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.datengaynhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaynhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaydangky.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaydangky.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphieuthue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnthem.ImageUri.Uri = "Add";
            this.btnthem.Location = new System.Drawing.Point(119, 131);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(92, 61);
            this.btnthem.TabIndex = 83;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datengaynhan
            // 
            this.datengaynhan.EditValue = null;
            this.datengaynhan.Location = new System.Drawing.Point(344, 92);
            this.datengaynhan.Name = "datengaynhan";
            this.datengaynhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datengaynhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datengaynhan.Size = new System.Drawing.Size(100, 20);
            this.datengaynhan.TabIndex = 81;
            // 
            // datengaydangky
            // 
            this.datengaydangky.EditValue = null;
            this.datengaydangky.Location = new System.Drawing.Point(344, 67);
            this.datengaydangky.Name = "datengaydangky";
            this.datengaydangky.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datengaydangky.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datengaydangky.Size = new System.Drawing.Size(100, 20);
            this.datengaydangky.TabIndex = 82;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(135, 94);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 79;
            // 
            // txtmaphieuthue
            // 
            this.txtmaphieuthue.Location = new System.Drawing.Point(135, 68);
            this.txtmaphieuthue.Name = "txtmaphieuthue";
            this.txtmaphieuthue.Size = new System.Drawing.Size(100, 20);
            this.txtmaphieuthue.TabIndex = 80;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(63, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 75;
            this.labelControl4.Text = "Mã Phòng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(285, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 76;
            this.labelControl3.Text = "Ngày Nhận";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(268, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 77;
            this.labelControl2.Text = "Ngày Đăng Ký";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 78;
            this.labelControl1.Text = "Mã Phiếu Thuê";
            // 
            // btnhuy
            // 
            this.btnhuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnhuy.ImageUri.Uri = "Recurrence";
            this.btnhuy.Location = new System.Drawing.Point(318, 131);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(92, 61);
            this.btnhuy.TabIndex = 71;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnluu.ImageUri.Uri = "Save";
            this.btnluu.Location = new System.Drawing.Point(217, 131);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(95, 61);
            this.btnluu.TabIndex = 72;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(197, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(146, 23);
            this.labelControl5.TabIndex = 70;
            this.labelControl5.Text = "Đăng Ký Phòng";
            // 
            // dangkyphong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 205);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.datengaynhan);
            this.Controls.Add(this.datengaydangky);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtmaphieuthue);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.labelControl5);
            this.Name = "dangkyphong2";
            this.Text = "Đăng Ký Phòng";
            this.Load += new System.EventHandler(this.dangkyphong2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datengaynhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaynhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaydangky.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datengaydangky.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaphieuthue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.DateEdit datengaynhan;
        private DevExpress.XtraEditors.DateEdit datengaydangky;
        private DevExpress.XtraEditors.TextEdit txtMaPhong;
        private DevExpress.XtraEditors.TextEdit txtmaphieuthue;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}