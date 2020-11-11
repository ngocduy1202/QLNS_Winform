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
    public partial class Frm_Luong : DevExpress.XtraEditors.XtraForm
    {
        Tool tool = new Tool();
        public Frm_Luong()
        {
            InitializeComponent();
        }

        private void Frm_Luong_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            gridControl1.DataSource = tool.getData("select manv, hoten,gioitinh, ngaysinh, ngayvaolam, tencv, tenpb, luongcb, hsl, tienphucap, (luongcb*hsl + tienphucap) as tongnhan from NHANVIEN, CHUCVU, PHONGBAN, PHUCAP where NHANVIEN.macv = CHUCVU.macv and NHANVIEN.mapb = PHONGBAN.mapb and NHANVIEN.mapc = PHUCAP.mapc");
        }
    }
}