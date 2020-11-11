using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_NHOM
{
    class Tool
    {
        string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ki_1_Nam_4_2020-2021\CS_414_E_Winform\DoAnNhom\QLNS_NHOM\QLNS_NHOM\QLNS.mdf;Integrated Security=True";
        SqlConnection connection;
        private void getConnection()
        {
            connection = new SqlConnection(connect);
            connection.Open();
        }
        private void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public int Count(string sql)
        {
            int kq;
            try
            {
                getConnection();
                SqlCommand command = new SqlCommand(sql, connection);
                kq = (int)command.ExecuteScalar();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }

        public DataTable getData(string sql)
        {
            DataTable table = new DataTable();
            try
            {
                getConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(table);
            }
            catch (Exception)
            {
                table = null;
            }
            finally
            {
                closeConnection();
            }
            return table;
        }
        public int UpdateData(string sql)
        {
            int kq = 0;
            try
            {
                getConnection();
                SqlCommand command = new SqlCommand(sql, connection);
                kq = command.ExecuteNonQuery();
                
            }
            catch(SqlException ex)
            {
                kq = 0;
                MessageBox.Show(ex.ToString());
            }            
            finally { closeConnection(); }
            if (kq >= 1)
            {
                DialogResult dr = MessageBox.Show("Thành công :> ", "Update result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Thất bại, hãy thử lại với value khác :< ", "Update result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return kq;
        }
    }
}

