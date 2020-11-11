using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_NHOM
{
    public partial class Frm_PhongBan : DevExpress.XtraEditors.XtraForm
    {
        public Frm_PhongBan()
        {
            InitializeComponent();
        }
        Tool tool = new Tool();
        private void Frm_PhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNSDataSet4.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.qLNSDataSet4.PHONGBAN);
            loadData();
        }

        private void loadData()
        {
            gridControl1.DataSource = tool.getData("select * from PHONGBAN");
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string mapb = tb_mapb.Text;
            string tenpb = tb_tenpb.Text;
            string sdt = tb_sdt.Text;
            tool.UpdateData("insert into PHONGBAN values('" + mapb + "','" + tenpb + "','" + sdt + "')");
            loadData();
        }
        

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            tool.UpdateData("update PHONGBAN set tenpb = '" + tb_tenpb.Text + "', sdt = '"+tb_sdt.Text+"' where mapb = '" + tb_mapb.Text + "'");
            loadData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {            
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn xoá? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                tool.UpdateData("delete from PHONGBAN where mapb = '" + tb_mapb.Text + "'");
                loadData();
            }
               
        }

        private void cbo_pb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mapb = cbo_pb1.Text;
            gridControl3.DataSource = tool.getData("select manv, hoten, tencv from NHANVIEN, PHONGBAN, CHUCVU where NHANVIEN.mapb = PHONGBAN.mapb and NHANVIEN.macv = CHUCVU.macv and PHONGBAN.mapb = '" + mapb + "'");
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tb_mapb.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mapb").ToString();
            tb_tenpb.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "tenpb").ToString();
            tb_sdt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "sdt").ToString();           
            
        }        
    }
}
