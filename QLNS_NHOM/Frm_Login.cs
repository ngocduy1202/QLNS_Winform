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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ki_1_Nam_4_2020-2021\CS_414_E_Winform\DoAnNhom\QLNS_NHOM\QLNS_NHOM\QLNS.mdf;Integrated Security=True";
        
        private void btn_getidpass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID: admin, pass: admin ", "Thông báo!",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int count = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = tb_tendn.Text;
            string pass = tb_mk.Text;
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();
            string query = "select count(*) from TAIKHOAN where tendn = '" + id + "' and matkhau = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            int kq = (int)cmd.ExecuteScalar();
            if (kq > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_Main f = new Frm_Main();
                f.Show();
                this.Hide();
            }
            else
            {
                count += 1;
                MessageBox.Show("Đăng nhập thất bại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
            if (count == 3)
            {
                MessageBox.Show("Bạn đã đăng nhập thất bại " + count + " lần, exit!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
