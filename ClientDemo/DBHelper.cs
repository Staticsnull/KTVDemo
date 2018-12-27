using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClientDemo
{
    public class DBHelper
    {
        //Data Source=.; Initial Catalog=MyKTV;User ID=sa;Pwd=123456
        //private static String conString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private static String conString = "Data Source=.; Initial Catalog=MyKTV;User ID=sa;Pwd=123456";
        private static SqlConnection conn;
        public static SqlConnection Connection
        {
            get
            {
                if(null == conn)
                {
                    conn = new SqlConnection(conString);
                }
                return conn;
            }
        }

        public static void Open()
        {
            if(Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
            if(Connection.State == System.Data.ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        public static void Close()
        {
            if(Connection.State == System.Data.ConnectionState.Open || Connection.State == System.Data.ConnectionState.Broken)
            {
                Connection.Close();
            }
        }
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                return command.ExecuteScalar();
            }
        }
        public static DataTable GetTable(String sql)
        {
            try
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, Connection);
                adapter.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static SqlDataReader ExecuteReader(String sql)
        {
            try
            {
                Open();
                SqlCommand command = new SqlCommand(sql, Connection);
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int ExecuteNonQuery(String sql)
        {
            try
            {
                Open();
                SqlCommand command = new SqlCommand(sql, Connection);
                return command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}
