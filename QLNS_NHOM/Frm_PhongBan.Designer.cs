namespace QLNS_NHOM
{
    partial class Frm_PhongBan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PhongBan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.tb_tenpb = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mapb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenpb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mapb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tencv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbo_pb1 = new System.Windows.Forms.ComboBox();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet4 = new QLNS_NHOM.QLNSDataSet4();
            this.label7 = new System.Windows.Forms.Label();
            this.pHONGBANTableAdapter = new QLNS_NHOM.QLNSDataSet4TableAdapters.PHONGBANTableAdapter();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng Ban";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(23, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_del);
            this.tabPage1.Controls.Add(this.btn_edit);
            this.tabPage1.Controls.Add(this.tb_sdt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.tb_tenpb);
            this.tabPage1.Controls.Add(this.gridControl1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_mapb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh Sách PB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_del.ImageOptions.SvgImage")));
            this.btn_del.Location = new System.Drawing.Point(393, 277);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(110, 42);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "Xoá";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_edit.ImageOptions.SvgImage")));
            this.btn_edit.Location = new System.Drawing.Point(541, 209);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(110, 42);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(525, 142);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(126, 23);
            this.tb_sdt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại";
            // 
            // btn_add
            // 
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(393, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 42);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_tenpb
            // 
            this.tb_tenpb.Location = new System.Drawing.Point(525, 88);
            this.tb_tenpb.Name = "tb_tenpb";
            this.tb_tenpb.Size = new System.Drawing.Size(126, 23);
            this.tb_tenpb.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(18, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(326, 237);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mapb,
            this.tenpb,
            this.sdt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // mapb
            // 
            this.mapb.Caption = "Mã phòng ban";
            this.mapb.FieldName = "mapb";
            this.mapb.MinWidth = 25;
            this.mapb.Name = "mapb";
            this.mapb.OptionsColumn.AllowEdit = false;
            this.mapb.Visible = true;
            this.mapb.VisibleIndex = 0;
            this.mapb.Width = 94;
            // 
            // tenpb
            // 
            this.tenpb.Caption = "Tên phòng ban";
            this.tenpb.FieldName = "tenpb";
            this.tenpb.MinWidth = 25;
            this.tenpb.Name = "tenpb";
            this.tenpb.OptionsColumn.AllowEdit = false;
            this.tenpb.Visible = true;
            this.tenpb.VisibleIndex = 1;
            this.tenpb.Width = 94;
            // 
            // sdt
            // 
            this.sdt.Caption = "Số Điện Thoại";
            this.sdt.FieldName = "sdt";
            this.sdt.MinWidth = 25;
            this.sdt.Name = "sdt";
            this.sdt.OptionsColumn.AllowEdit = false;
            this.sdt.Visible = true;
            this.sdt.VisibleIndex = 2;
            this.sdt.Width = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phòng ban";
            // 
            // tb_mapb
            // 
            this.tb_mapb.Location = new System.Drawing.Point(525, 33);
            this.tb_mapb.Name = "tb_mapb";
            this.tb_mapb.Size = new System.Drawing.Size(126, 23);
            this.tb_mapb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phòng ban";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridControl3);
            this.tabPage3.Controls.Add(this.cbo_pb1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(707, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhân Viên PB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridControl3
            // 
            this.gridControl3.Location = new System.Drawing.Point(23, 72);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(573, 157);
            this.gridControl3.TabIndex = 8;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.manv,
            this.hoten,
            this.tencv});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // manv
            // 
            this.manv.Caption = "Mã Nhân Viên";
            this.manv.FieldName = "manv";
            this.manv.MinWidth = 25;
            this.manv.Name = "manv";
            this.manv.Visible = true;
            this.manv.VisibleIndex = 0;
            this.manv.Width = 94;
            // 
            // hoten
            // 
            this.hoten.Caption = "Tên Nhân Viên";
            this.hoten.FieldName = "hoten";
            this.hoten.MinWidth = 25;
            this.hoten.Name = "hoten";
            this.hoten.Visible = true;
            this.hoten.VisibleIndex = 1;
            this.hoten.Width = 94;
            // 
            // tencv
            // 
            this.tencv.Caption = "Chức Vụ";
            this.tencv.FieldName = "tencv";
            this.tencv.MinWidth = 25;
            this.tencv.Name = "tencv";
            this.tencv.Visible = true;
            this.tencv.VisibleIndex = 2;
            this.tencv.Width = 94;
            // 
            // cbo_pb1
            // 
            this.cbo_pb1.DataSource = this.pHONGBANBindingSource;
            this.cbo_pb1.DisplayMember = "mapb";
            this.cbo_pb1.FormattingEnabled = true;
            this.cbo_pb1.Location = new System.Drawing.Point(151, 22);
            this.cbo_pb1.Name = "cbo_pb1";
            this.cbo_pb1.Size = new System.Drawing.Size(121, 24);
            this.cbo_pb1.TabIndex = 7;
            this.cbo_pb1.ValueMember = "mapb";
            this.cbo_pb1.SelectedIndexChanged += new System.EventHandler(this.cbo_pb1_SelectedIndexChanged);
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.qLNSDataSet4;
            // 
            // qLNSDataSet4
            // 
            this.qLNSDataSet4.DataSetName = "QLNSDataSet4";
            this.qLNSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã phòng ban";
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 477);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Frm_PhongBan.IconOptions.SvgImage")));
            this.Name = "Frm_PhongBan";
            this.Text = "Frm_PhongBan";
            this.Load += new System.EventHandler(this.Frm_PhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_tenpb;
        private System.Windows.Forms.TextBox tb_mapb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn mapb;
        private DevExpress.XtraGrid.Columns.GridColumn tenpb;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.TabPage tabPage3;
        private QLNSDataSet4 qLNSDataSet4;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private QLNSDataSet4TableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn sdt;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn manv;
        private DevExpress.XtraGrid.Columns.GridColumn hoten;
        private DevExpress.XtraGrid.Columns.GridColumn tencv;
        private System.Windows.Forms.ComboBox cbo_pb1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
    }
}