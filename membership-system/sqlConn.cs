using System;
using System.Data.SqlClient;

namespace membership_system
{
    class SqlConn
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\gitRepo\membership-system\membership-system-db.mdf;Integrated Security=True; Connect Timeout=30");
        public SqlConnection sqlConnection
        {
            get { return conn;  }
        }

        public string connectionString
        {
            get { return conn.ConnectionString; }
        }

        public void open()
        {
            try
            {
                conn.Open();

            }
            catch (Exception e)
            {

            }
        }

        public void close()
        {
            try
            {
                conn.Close();

            }
            catch (Exception e)
            {

            }
        }
    }
}
