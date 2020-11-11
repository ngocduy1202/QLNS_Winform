namespace QLNS_NHOM
{
    partial class Frm_ChucVu
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChucVu));
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.employeesTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.customersTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.macv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tencv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luongcb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hsl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.tb_hsl = new System.Windows.Forms.TextBox();
            this.tb_lcb = new System.Windows.Forms.TextBox();
            this.tb_tencv = new System.Windows.Forms.TextBox();
            this.tb_macv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.customersNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.manv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenpb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_cv = new System.Windows.Forms.ComboBox();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.customersNavigationPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tileBar.MaxId = 3;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 135);
            this.tileBar.MinimumSize = new System.Drawing.Size(117, 135);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(34, 14, 34, 14);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.employeesTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(743, 135);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.employeesTileBarItem);
            this.tileBarGroupTables.Items.Add(this.customersTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // employeesTileBarItem
            // 
            this.employeesTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.employeesTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.employeesTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement1.Text = "Quản lí chức vụ";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.employeesTileBarItem.Elements.Add(tileItemElement1);
            this.employeesTileBarItem.Name = "employeesTileBarItem";
            // 
            // customersTileBarItem
            // 
            this.customersTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement2.Text = "Nhân Viên - CV";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.customersTileBarItem.Elements.Add(tileItemElement2);
            this.customersTileBarItem.Id = 2;
            this.customersTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.customersTileBarItem.Name = "customersTileBarItem";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.customersNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 135);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.employeesNavigationPage,
            this.customersNavigationPage});
            this.navigationFrame.SelectedPage = this.employeesNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(743, 471);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Caption = "employeesNavigationPage";
            this.employeesNavigationPage.Controls.Add(this.gridControl1);
            this.employeesNavigationPage.Controls.Add(this.btn_del);
            this.employeesNavigationPage.Controls.Add(this.btn_edit);
            this.employeesNavigationPage.Controls.Add(this.btn_add);
            this.employeesNavigationPage.Controls.Add(this.tb_hsl);
            this.employeesNavigationPage.Controls.Add(this.tb_lcb);
            this.employeesNavigationPage.Controls.Add(this.tb_tencv);
            this.employeesNavigationPage.Controls.Add(this.tb_macv);
            this.employeesNavigationPage.Controls.Add(this.label4);
            this.employeesNavigationPage.Controls.Add(this.label3);
            this.employeesNavigationPage.Controls.Add(this.label2);
            this.employeesNavigationPage.Controls.Add(this.label1);
            this.employeesNavigationPage.Controls.Add(this.employeesLabelControl);
            this.employeesNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(743, 471);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(51, 237);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(619, 187);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.macv,
            this.tencv,
            this.luongcb,
            this.hsl});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // macv
            // 
            this.macv.Caption = "Mã chức vụ";
            this.macv.FieldName = "macv";
            this.macv.MinWidth = 25;
            this.macv.Name = "macv";
            this.macv.Visible = true;
            this.macv.VisibleIndex = 0;
            this.macv.Width = 94;
            // 
            // tencv
            // 
            this.tencv.Caption = "Tên chức vụ";
            this.tencv.FieldName = "tencv";
            this.tencv.MinWidth = 25;
            this.tencv.Name = "tencv";
            this.tencv.Visible = true;
            this.tencv.VisibleIndex = 1;
            this.tencv.Width = 94;
            // 
            // luongcb
            // 
            this.luongcb.Caption = "Lương cơ bản";
            this.luongcb.FieldName = "luongcb";
            this.luongcb.MinWidth = 25;
            this.luongcb.Name = "luongcb";
            this.luongcb.Visible = true;
            this.luongcb.VisibleIndex = 2;
            this.luongcb.Width = 94;
            // 
            // hsl
            // 
            this.hsl.Caption = "Hệ số lương";
            this.hsl.FieldName = "hsl";
            this.hsl.MinWidth = 25;
            this.hsl.Name = "hsl";
            this.hsl.Visible = true;
            this.hsl.VisibleIndex = 3;
            this.hsl.Width = 94;
            // 
            // btn_del
            // 
            this.btn_del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.ImageOptions.Image")));
            this.btn_del.Location = new System.Drawing.Point(559, 149);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(111, 47);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "Xoá";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(319, 149);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 47);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(51, 149);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 47);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_hsl
            // 
            this.tb_hsl.Location = new System.Drawing.Point(508, 76);
            this.tb_hsl.Name = "tb_hsl";
            this.tb_hsl.Size = new System.Drawing.Size(162, 23);
            this.tb_hsl.TabIndex = 10;
            // 
            // tb_lcb
            // 
            this.tb_lcb.Location = new System.Drawing.Point(508, 37);
            this.tb_lcb.Name = "tb_lcb";
            this.tb_lcb.Size = new System.Drawing.Size(162, 23);
            this.tb_lcb.TabIndex = 9;
            // 
            // tb_tencv
            // 
            this.tb_tencv.Location = new System.Drawing.Point(153, 73);
            this.tb_tencv.Name = "tb_tencv";
            this.tb_tencv.Size = new System.Drawing.Size(162, 23);
            this.tb_tencv.TabIndex = 8;
            // 
            // tb_macv
            // 
            this.tb_macv.Location = new System.Drawing.Point(153, 37);
            this.tb_macv.Name = "tb_macv";
            this.tb_macv.Size = new System.Drawing.Size(162, 23);
            this.tb_macv.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hệ số lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lương cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã chức vụ";
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(743, 471);
            this.employeesLabelControl.TabIndex = 2;
            // 
            // customersNavigationPage
            // 
            this.customersNavigationPage.Caption = "customersNavigationPage";
            this.customersNavigationPage.Controls.Add(this.groupBox1);
            this.customersNavigationPage.Controls.Add(this.label5);
            this.customersNavigationPage.Controls.Add(this.cbo_cv);
            this.customersNavigationPage.Controls.Add(this.customersLabelControl);
            this.customersNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersNavigationPage.Name = "customersNavigationPage";
            this.customersNavigationPage.Size = new System.Drawing.Size(743, 471);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl2);
            this.groupBox1.Location = new System.Drawing.Point(29, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 322);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên ";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(23, 43);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(621, 174);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.manv,
            this.hoten,
            this.sdt,
            this.tenpb});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // manv
            // 
            this.manv.Caption = "Mã nhân viên";
            this.manv.FieldName = "manv";
            this.manv.MinWidth = 25;
            this.manv.Name = "manv";
            this.manv.Visible = true;
            this.manv.VisibleIndex = 0;
            this.manv.Width = 95;
            // 
            // hoten
            // 
            this.hoten.Caption = "Tên nhân viên";
            this.hoten.FieldName = "hoten";
            this.hoten.MinWidth = 25;
            this.hoten.Name = "hoten";
            this.hoten.Visible = true;
            this.hoten.VisibleIndex = 1;
            this.hoten.Width = 163;
            // 
            // sdt
            // 
            this.sdt.Caption = "Số điện thoại";
            this.sdt.FieldName = "sdt";
            this.sdt.MinWidth = 25;
            this.sdt.Name = "sdt";
            this.sdt.Visible = true;
            this.sdt.VisibleIndex = 2;
            this.sdt.Width = 163;
            // 
            // tenpb
            // 
            this.tenpb.Caption = "Phòng ban";
            this.tenpb.FieldName = "tenpb";
            this.tenpb.MinWidth = 25;
            this.tenpb.Name = "tenpb";
            this.tenpb.Visible = true;
            this.tenpb.VisibleIndex = 3;
            this.tenpb.Width = 170;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn chức vụ";
            // 
            // cbo_cv
            // 
            this.cbo_cv.FormattingEnabled = true;
            this.cbo_cv.Location = new System.Drawing.Point(159, 32);
            this.cbo_cv.Name = "cbo_cv";
            this.cbo_cv.Size = new System.Drawing.Size(121, 24);
            this.cbo_cv.TabIndex = 3;
            this.cbo_cv.SelectedIndexChanged += new System.EventHandler(this.cbo_cv_SelectedIndexChanged);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(743, 471);
            this.customersLabelControl.TabIndex = 2;
            // 
            // Frm_ChucVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 606);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_ChucVu";
            this.Load += new System.EventHandler(this.Frm_ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            this.employeesNavigationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.customersNavigationPage.ResumeLayout(false);
            this.customersNavigationPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem employeesTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem customersTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage customersNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private System.Windows.Forms.TextBox tb_hsl;
        private System.Windows.Forms.TextBox tb_lcb;
        private System.Windows.Forms.TextBox tb_tencv;
        private System.Windows.Forms.TextBox tb_macv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn macv;
        private DevExpress.XtraGrid.Columns.GridColumn tencv;
        private DevExpress.XtraGrid.Columns.GridColumn luongcb;
        private DevExpress.XtraGrid.Columns.GridColumn hsl;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn manv;
        private DevExpress.XtraGrid.Columns.GridColumn hoten;
        private DevExpress.XtraGrid.Columns.GridColumn sdt;
        private DevExpress.XtraGrid.Columns.GridColumn tenpb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_cv;
    }
}