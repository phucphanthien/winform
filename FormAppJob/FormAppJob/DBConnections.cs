using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppJob
{
    internal class DBConnections
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable Load()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM Job");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtJob = new DataTable();
                adapter.Fill(dtJob);
                /// gvHsinh = name cua data gridview
                return dtJob;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public void ThucThi(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                MessageBox.Show(sqlStr);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thuc thi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
