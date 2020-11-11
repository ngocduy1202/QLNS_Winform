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
    public partial class DB : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ki_1_Nam_4_ 2020-2021\CS_414_E_Winform\DoAnNhom\QLNS_NHOM\QLNS_NHOM\QLNS.mdf;Integrated Security=True";
        public DB()
        {
            InitializeComponent();
            string connect1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ki_1_Nam_4_ 2020-2021\CS_414_E_Winform\DoAnNhom\QLNS_NHOM\QLNS_NHOM\QLNS.mdf;Integrated Security=True";
        }

        
    }
}