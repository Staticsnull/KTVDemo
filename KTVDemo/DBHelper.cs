using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   KTVDemo
{
    class DBHelper
    {
        private static String conStr = "Data Source=.; Initial Catalog=MyKTV; User ID = sa; Pwd = 123456";
        private static SqlConnection connection;
        /// <summary>
        /// 使用属性封装
        /// </summary>
        public static SqlConnection Connection
        {
            get
            {
                if(null == connection)
                {
                    connection = new SqlConnection(conStr);
                }
                return connection;
            }
        }

        /// <summary>
        /// 打开连接
        /// </summary>
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
        /// <summary>
        /// 关闭连接
        /// </summary>
        public static void Close()
        {
            if(Connection.State == System.Data.ConnectionState.Open || Connection.State == System.Data.ConnectionState.Broken)
            {
                Connection.Close();
            }
        }
        public static SqlDataReader ExecuteReader(String sql)
        {
            try
            {
                Open();
                SqlCommand command = new SqlCommand(sql, Connection);
                return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static DataTable GetTable(String sql)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, Connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
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
                int count = command.ExecuteNonQuery();
                Close();
                return count;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static int ExecuteScalar(String sql)
        {
            try
            {
                Open();
                SqlCommand command = new SqlCommand(sql, Connection);
                int count = Convert.ToInt32(command.ExecuteScalar());
                Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
