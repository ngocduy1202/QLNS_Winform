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
    public partial class Frm_DuAn : DevExpress.XtraEditors.XtraForm
    {
        Tool tool = new Tool();
        public Frm_DuAn()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tb_mada.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mada").ToString();
            tb_tenda.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tenda").ToString();
            tb_kp.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "kinhphi").ToString();
            rtb_mota.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mota").ToString();
        }

        private void Frm_DuAn_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            gridControl1.DataSource = tool.getData("select * from DUAN");
            cbo_nv.DataSource = tool.getData("select * from NHANVIEN");
            cbo_nv.DisplayMember = "hoten";
            cbo_nv.ValueMember = "manv";
            cbo_da.DataSource = tool.getData("select * from DUAN");
            cbo_da.DisplayMember = "tenda";
            cbo_da.ValueMember = "mada";
            gridControl2.DataSource = tool.getData("select DUAN.mada, DUAN.tenda, count(PHANCONG.manv) as tongsonv from NHANVIEN, DUAN, PHANCONG where NHANVIEN.manv = PHANCONG.manv and DUAN.mada = PHANCONG.mada group by DUAN.mada, DUAN.tenda");
            gridControl3.DataSource = tool.getData("select PHANCONG.mada, DUAN.tenda, PHANCONG.manv, NHANVIEN.hoten, NHANVIEN.sdt, tencv, tenpb from DUAN, CHUCVU, NHANVIEN,PHONGBAN, PHANCONG where NHANVIEN.manv = PHANCONG.manv and NHANVIEN.mapb = PHONGBAN.mapb and NHANVIEN.macv = CHUCVU.macv and DUAN.mada = PHANCONG.mada");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tool.UpdateData("insert into DUAN values('" + tb_mada.Text + "','" + tb_tenda.Text + "','" + tb_kp.Text + "','" + rtb_mota.Text + "')");
            loadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            tool.UpdateData("update DUAN set tenda = '" + tb_tenda.Text + "', kinhphi = '" + tb_kp.Text + "', mota = '" + rtb_mota.Text + "' where mada = '" + tb_mada.Text + "'");

            loadData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn xoá? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tool.UpdateData("delete from DUAN where mada = '" + tb_mada.Text + "'");
                loadData();
            }
        }

        private void btn_addnv_Click(object sender, EventArgs e)
        {
            tool.UpdateData("insert into PHANCONG values('" + cbo_da.SelectedValue.ToString() + "', '" + cbo_nv.SelectedValue.ToString() + "')");
            loadData();
        }

        private void btn_delnv_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xoá ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tool.UpdateData("delete from PHANCONG where mada = '" + cbo_da.SelectedValue.ToString() + "' and manv = '" + cbo_nv.SelectedValue.ToString() + "'");
                loadData();
            }
           
        }       
    }
}