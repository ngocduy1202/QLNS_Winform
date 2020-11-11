using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLNS_NHOM
{
    public partial class Frm_PhuCap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_PhuCap()
        {
            InitializeComponent();
        }
        Tool tool = new Tool();
        private void btn_add_ItemClick(object sender, ItemClickEventArgs e)
        {
            tool.UpdateData("insert into PHUCAP values('" + tb_mapc.Text + "','" + tb_tenpc.Text + "','" + tb_tienpc.Text + "')");
            loadData();
        }

        private void btn_edit_ItemClick(object sender, ItemClickEventArgs e)
        {
            tool.UpdateData("update PHUCAP set tenpc = '" + tb_tenpc.Text + "', tienphucap = '" + tb_tienpc.Text + "' where mapc = '" + tb_mapc.Text + "'");
            loadData();
        }

        private void btn_del_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xoá ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tool.UpdateData("delete from PHUCAP where mapc = '" + tb_mapc.Text + "'");
                loadData();
            }
        }

        private void Frm_PhuCap_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            gridControl1.DataSource = tool.getData("select * from PHUCAP");
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tb_mapc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mapc").ToString();
            tb_tenpc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tenpc").ToString();
            tb_tienpc.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tienphucap").ToString();
        }
    }    
}