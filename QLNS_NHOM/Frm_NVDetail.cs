using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_NHOM
{
    public partial class Frm_NVDetail : Form
    {        
        string mnv;
        Tool tool = new Tool();
        public Frm_NVDetail(string manv)
        {
            InitializeComponent();
            mnv = manv;
        }
              
        private void Frm_NVDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();            
            dt = tool.getData("select NHANVIEN.manv, hoten, NHANVIEN.sdt, gioitinh, ngaysinh, ngayvaolam, tencv, tenpc, tenpb, hsl, luongcb,anh from NHANVIEN, PHUCAP, PHONGBAN, CHUCVU where NHANVIEN.macv = CHUCVU.macv and NHANVIEN.mapc = PHUCAP.mapc and NHANVIEN.mapb = PHONGBAN.mapb and NHANVIEN.manv ='" + mnv + "'");
            tb_manv.Text = dt.Rows[0][0].ToString();
            tb_hoten.Text = dt.Rows[0][1].ToString();
            tb_sdt.Text = dt.Rows[0][2].ToString();
            tb_gioitinh.Text = dt.Rows[0][3].ToString();
            tb_ns.Text = dt.Rows[0][4].ToString();            
            tb_nvl.Text = dt.Rows[0][5].ToString();            
            tb_cv.Text = dt.Rows[0][6].ToString();
            tb_pc.Text = dt.Rows[0][7].ToString();
            tb_pb.Text = dt.Rows[0][8].ToString();
            tb_hsl.Text = dt.Rows[0][9].ToString();
            tb_lcb.Text = dt.Rows[0][10].ToString();
            string avt = dt.Rows[0][11].ToString();
            pictureBox1.ImageLocation = @"E:\Ki_1_Nam_4_2020-2021\CS_414_E_Winform\DoAnNhom\QLNS_NHOM\QLNS_NHOM\Image\" + avt;
        }
    }
}
