using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DemoTesst
{
    class Lopdungchung
    {
        public Lopdungchung() { }

        private SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DemoTesst\DemoTesst\0865_HoangVoNhuDuc.mdf;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
        
        private void OpenConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            new SqlDataAdapter(sql, GetConnection()).Fill(dt);
            return dt;
            
        }

        public bool ExecuteUpdate(string sql)
        {
            bool check;
            using (SqlConnection conn = GetConnection())
            {
                OpenConnection(conn);
                check = new SqlCommand(sql, conn).ExecuteNonQuery() > 0 ? true : false;
                CloseConnection(conn);
            }
            return check;
        }
    }
}
