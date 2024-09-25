using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Minimarketdb
{
    internal class db_connect
    {
        private SqlConnection SqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glkru\OneDrive\Документы\minimarket_db.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
        public void OpenCon()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }
        public void CloseCon()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }

        }
    
    }
}
