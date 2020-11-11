namespace QLNS_NHOM
{
    partial class Frm_Luong
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngaysinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayvaolam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tencv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenpb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hsl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tienphucap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tongnhan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(13, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1163, 522);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.manv,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.ngayvaolam,
            this.tencv,
            this.tenpb,
            this.lcb,
            this.hsl,
            this.tienphucap,
            this.tongnhan});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // manv
            // 
            this.manv.Caption = "Mã nhân viên";
            this.manv.FieldName = "manv";
            this.manv.MinWidth = 25;
            this.manv.Name = "manv";
            this.manv.Visible = true;
            this.manv.VisibleIndex = 0;
            this.manv.Width = 97;
            // 
            // hoten
            // 
            this.hoten.Caption = "Tên nhân viên";
            this.hoten.FieldName = "hoten";
            this.hoten.MinWidth = 25;
            this.hoten.Name = "hoten";
            this.hoten.Visible = true;
            this.hoten.VisibleIndex = 1;
            this.hoten.Width = 98;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Caption = "Ngày sinh";
            this.ngaysinh.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.ngaysinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngaysinh.FieldName = "ngaysinh";
            this.ngaysinh.MinWidth = 25;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Visible = true;
            this.ngaysinh.VisibleIndex = 3;
            this.ngaysinh.Width = 116;
            // 
            // gioitinh
            // 
            this.gioitinh.Caption = "Giới tính";
            this.gioitinh.FieldName = "gioitinh";
            this.gioitinh.MinWidth = 25;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Visible = true;
            this.gioitinh.VisibleIndex = 2;
            this.gioitinh.Width = 77;
            // 
            // ngayvaolam
            // 
            this.ngayvaolam.Caption = "Ngày vào làm";
            this.ngayvaolam.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.ngayvaolam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngayvaolam.FieldName = "ngayvaolam";
            this.ngayvaolam.MinWidth = 25;
            this.ngayvaolam.Name = "ngayvaolam";
            this.ngayvaolam.Visible = true;
            this.ngayvaolam.VisibleIndex = 4;
            this.ngayvaolam.Width = 109;
            // 
            // tencv
            // 
            this.tencv.Caption = "Chức vụ";
            this.tencv.FieldName = "tencv";
            this.tencv.MinWidth = 25;
            this.tencv.Name = "tencv";
            this.tencv.Visible = true;
            this.tencv.VisibleIndex = 5;
            this.tencv.Width = 94;
            // 
            // tenpb
            // 
            this.tenpb.Caption = "Phòng ban";
            this.tenpb.FieldName = "tenpb";
            this.tenpb.MinWidth = 25;
            this.tenpb.Name = "tenpb";
            this.tenpb.Visible = true;
            this.tenpb.VisibleIndex = 6;
            this.tenpb.Width = 96;
            // 
            // lcb
            // 
            this.lcb.Caption = "Lương cơ bản";
            this.lcb.FieldName = "luongcb";
            this.lcb.MinWidth = 25;
            this.lcb.Name = "lcb";
            this.lcb.Visible = true;
            this.lcb.VisibleIndex = 7;
            this.lcb.Width = 98;
            // 
            // hsl
            // 
            this.hsl.Caption = "Hệ số lương";
            this.hsl.FieldName = "hsl";
            this.hsl.MinWidth = 25;
            this.hsl.Name = "hsl";
            this.hsl.Visible = true;
            this.hsl.VisibleIndex = 8;
            this.hsl.Width = 90;
            // 
            // tienphucap
            // 
            this.tienphucap.Caption = "Phụ cấp";
            this.tienphucap.FieldName = "tienphucap";
            this.tienphucap.MinWidth = 25;
            this.tienphucap.Name = "tienphucap";
            this.tienphucap.Visible = true;
            this.tienphucap.VisibleIndex = 9;
            this.tienphucap.Width = 80;
            // 
            // tongnhan
            // 
            this.tongnhan.Caption = "Tổng nhận";
            this.tongnhan.FieldName = "tongnhan";
            this.tongnhan.MinWidth = 25;
            this.tongnhan.Name = "tongnhan";
            this.tongnhan.Visible = true;
            this.tongnhan.VisibleIndex = 10;
            this.tongnhan.Width = 178;
            // 
            // Frm_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 558);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Luong";
            this.Text = "Frm_Luong";
            this.Load += new System.EventHandler(this.Frm_Luong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn manv;
        private DevExpress.XtraGrid.Columns.GridColumn hoten;
        private DevExpress.XtraGrid.Columns.GridColumn ngaysinh;
        private DevExpress.XtraGrid.Columns.GridColumn gioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn ngayvaolam;
        private DevExpress.XtraGrid.Columns.GridColumn tencv;
        private DevExpress.XtraGrid.Columns.GridColumn tenpb;
        private DevExpress.XtraGrid.Columns.GridColumn lcb;
        private DevExpress.XtraGrid.Columns.GridColumn hsl;
        private DevExpress.XtraGrid.Columns.GridColumn tienphucap;
        private DevExpress.XtraGrid.Columns.GridColumn tongnhan;
    }
}