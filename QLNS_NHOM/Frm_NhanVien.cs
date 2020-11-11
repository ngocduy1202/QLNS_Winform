using DevExpress.Charts.Native;
using DevExpress.DataAccess.Sql;
using DevExpress.DataProcessing;
using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_NHOM
{
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }
        Tool tool = new Tool();


        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet3.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLNSDataSet3.NHANVIEN);
            // TODO: This line of code loads data into the 'qLNSDataSet2.PHUCAP' table. You can move, or remove it, as needed.
            this.pHUCAPTableAdapter.Fill(this.qLNSDataSet2.PHUCAP);
            // TODO: This line of code loads data into the 'qLNSDataSet1.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.qLNSDataSet1.CHUCVU);
            // TODO: This line of code loads data into the 'qLNSDataSet.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.qLNSDataSet.PHONGBAN);
            loadData();
        }

        private void loadData()
        {            
            gridControl1.DataSource = tool.getData("select * from NHANVIEN");
            gridControl2.DataSource = tool.getData("select hoten, NHANVIEN.sdt, tencv, tenpb from NHANVIEN, CHUCVU, PHONGBAN where NHANVIEN.mapb = PHONGBAN.mapb and NHANVIEN.macv = CHUCVU.macv and manv = '" + tb_manv.Text + "'");
        }

        private void btn_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = tb_manv.Text;
            string hoten = tb_hoten.Text;
            string sdt = tb_sdt.Text;
            DateTime ns = DateTime.Parse(dtp_ns.Value.ToLongDateString());
            DateTime nvl = DateTime.Parse(dtp_nvl.Value.ToLongDateString());
            string gt = cbo_gt.Text;
            string mapb = cbo_pb.SelectedValue.ToString();
            string macv = cbo_cv.SelectedValue.ToString();
            string mapc = cbo_pc.SelectedValue.ToString();
            string avt = tb_avt.Text;
            pictureBox1.Image.Save(@"E:\Ki_1_Nam_4_2020-2021\CS_414_E_Winform\DoAnNhom\QLNS_NHOM\QLNS_NHOM\Image\" + tb_avt.Text);
            tool.UpdateData("insert into NHANVIEN values('" + manv + "','" + hoten + "','" + ns + "','" + sdt + "'," +
                "'" + gt + "','" + nvl + "','" + mapb + "','" + macv + "','" + mapc + "','" + avt + "')");
            loadData();
        }       

        private void btn_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = tb_manv.Text;
            string hoten = tb_hoten.Text;
            string sdt = tb_sdt.Text;
            DateTime ns = DateTime.Parse(dtp_ns.Value.ToLongDateString());
            DateTime nvl = DateTime.Parse(dtp_nvl.Value.ToLongDateString());
            string gt = cbo_gt.Text;
            string mapb = cbo_pb.Text;
            string macv = cbo_cv.Text;
            string mapc = cbo_pc.Text;
            string avt = tb_avt.Text;
            tool.UpdateData("update NHANVIEN set hoten ='" + hoten + "', ngaysinh ='" + ns + "', sdt ='" + sdt + "'," +
                " gioitinh = '" + gt + "', ngayvaolam = '" + nvl + "', mapb = '" + mapb + "', macv = '" + macv + "', mapc ='" + mapc + "',anh = '"+avt+"' where manv = '" + manv + "'");
            loadData();
        }

        private void btn_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = tb_manv.Text;
            DialogResult dr = MessageBox.Show("Bạn muốn xoá nhân viên này? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                tool.UpdateData("delete from NHANVIEN where manv = '" + manv + "'");
                File.Delete(@"E:\Ki_1_Nam_4_2020-2021\CS_414_E_Winform\DoAnNhom\QLNS_NHOM\QLNS_NHOM\Image\" + tb_avt.Text);
                loadData();
            }            
        }

        private void btnb_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_detal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(tb_manv.Text == "" || tb_manv.Text == null)
            {
                MessageBox.Show("Chưa chọn nhân viên để xem chi tiết !!!");
            }
            else
            {
                if (Application.OpenForms["Frm_NVDetail"] == null)
                {
                    Frm_NVDetail f = new Frm_NVDetail(tb_manv.Text);
                    f.Show();
                }
                else
                {
                    Application.OpenForms["Frm_NVDetail"].Activate();
                }
            }
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tb_manv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "manv").ToString();
            gridControl2.DataSource = tool.getData("select hoten, NHANVIEN.sdt, tencv, tenpb from NHANVIEN, CHUCVU, PHONGBAN where NHANVIEN.mapb = PHONGBAN.mapb and NHANVIEN.macv = CHUCVU.macv and manv = '" + tb_manv.Text + "'");
            tb_hoten.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "hoten").ToString();
            tb_sdt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "sdt").ToString();
            cbo_gt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "gioitinh").ToString();
            cbo_pb.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mapb").ToString();
            cbo_cv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "macv").ToString();
            cbo_pc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mapc").ToString();
            dtp_ns.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ngaysinh").ToString();
            dtp_nvl.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ngayvaolam").ToString();
            tb_avt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "anh").ToString();
            pictureBox1.ImageLocation = @"E:\Ki_1_Nam_4_2020-2021\CS_414_E_Winform\DoAnNhom\QLNS_NHOM\QLNS_NHOM\Image\" + tb_avt.Text;
        }

        private void btn_avt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select picture";
            open.Filter = "JPG|*.jpg|PNG|*.png|Tất cả|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }                
        }
    }
}
