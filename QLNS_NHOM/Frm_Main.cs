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

namespace QLNS_NHOM
{
    public partial class Frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Main()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void btn_nv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Frm_NhanVien"] == null)
            {
                Frm_NhanVien f = new Frm_NhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["Frm_NhanVien"].Activate();
            }
        }

        private void btn_pb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Frm_PhongBan"] == null)
            {
                Frm_PhongBan f = new Frm_PhongBan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["Frm_PhongBan"].Activate();
            }
        }

        private void btn_cv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Frm_ChucVu"] == null)
            {
                Frm_ChucVu f = new Frm_ChucVu();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["Frm_ChucVu"].Activate();
            }
        }

        private void btn_duan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Frm_DuAn"] == null)
            {
                Frm_DuAn f = new Frm_DuAn();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["Frm_DuAn"].Activate();
            }
        }

        private void btn_pc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Frm_PhuCap"] == null)
            {
                Frm_PhuCap f = new Frm_PhuCap();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["Frm_PhuCap"].Activate();
            }
        }

        private void btn_luong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Frm_Luong"] == null)
            {
                Frm_Luong f = new Frm_Luong();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["Frm_Luong"].Activate();
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = "Made by Duy12cm";
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_db_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Frm_Dashboard"] == null)
            {
                Frm_Dashboard f = new Frm_Dashboard();                
                f.Show();
            }
            else
            {
                Application.OpenForms["Frm_Dashboard"].Activate();
            }
        }
    }
}