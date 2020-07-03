using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICAFESTORE
{
    static class LayDuLieu
    {
        private static string connect_str = @"Data Source=LAPTOP-PCEQUR9I\SQLEXPRESS;Initial Catalog=CAFE1;Integrated Security=True";

        public static bool Lay_Data(string query, ref DataTable dataTable)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connect_str);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
