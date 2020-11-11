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
    public partial class Frm_ChucVu : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ChucVu()
        {
            InitializeComponent();
        }
        Tool tool = new Tool();
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tool.UpdateData("insert into CHUCVU values('" + tb_macv.Text + "','" + tb_tencv.Text + "','" + tb_lcb.Text + "','" + tb_hsl.Text + "')");
            loadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            tool.UpdateData("update CHUCVU set tencv = '" + tb_tencv.Text + "', luongcb = '" + tb_lcb.Text + "', hsl ='" + tb_hsl.Text + "' where macv = '" + tb_macv.Text + "'");
            loadData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xoá ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                tool.UpdateData("delete from CHUCVU where macv = '" + tb_macv.Text + "'");
                loadData();
            }
        }

        private void Frm_ChucVu_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            gridControl1.DataSource = tool.getData("select * from CHUCVU");
            cbo_cv.DataSource = tool.getData("select * from CHUCVU");
            cbo_cv.DisplayMember = "tencv";
            cbo_cv.ValueMember = "macv";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tb_macv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "macv").ToString();
            tb_tencv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tencv").ToString();
            tb_hsl.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "hsl").ToString();
            tb_lcb.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "luongcb").ToString();
        }

        private void cbo_cv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string macv = cbo_cv.SelectedValue.ToString();            
            gridControl2.DataSource = tool.getData("select manv, hoten, NHANVIEN.sdt, tenpb from NHANVIEN, CHUCVU, PHONGBAN where NHANVIEN.macv = CHUCVU.macv and NHANVIEN.mapb = PHONGBAN.mapb and CHUCVU.macv ='" + macv + "'");
        }
    }
}