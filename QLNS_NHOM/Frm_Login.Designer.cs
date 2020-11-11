namespace QLNS_NHOM
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tb_tendn = new System.Windows.Forms.TextBox();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_getidpass = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // tb_tendn
            // 
            this.tb_tendn.Location = new System.Drawing.Point(193, 72);
            this.tb_tendn.Name = "tb_tendn";
            this.tb_tendn.Size = new System.Drawing.Size(168, 22);
            this.tb_tendn.TabIndex = 2;
            // 
            // tb_mk
            // 
            this.tb_mk.Location = new System.Drawing.Point(193, 117);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.PasswordChar = '*';
            this.tb_mk.Size = new System.Drawing.Size(168, 22);
            this.tb_mk.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_login.ImageOptions.SvgImage")));
            this.btn_login.Location = new System.Drawing.Point(218, 169);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 43);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_getidpass
            // 
            this.btn_getidpass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_getidpass.ImageOptions.SvgImage")));
            this.btn_getidpass.Location = new System.Drawing.Point(12, 227);
            this.btn_getidpass.Name = "btn_getidpass";
            this.btn_getidpass.Size = new System.Drawing.Size(140, 40);
            this.btn_getidpass.TabIndex = 5;
            this.btn_getidpass.Text = "Get ID + pass";
            this.btn_getidpass.Click += new System.EventHandler(this.btn_getidpass_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 279);
            this.Controls.Add(this.btn_getidpass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.tb_tendn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox tb_tendn;
        private System.Windows.Forms.TextBox tb_mk;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.SimpleButton btn_getidpass;
    }
}