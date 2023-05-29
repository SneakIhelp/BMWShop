using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMWShop
{
    internal class database
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-T5QI3N7\\SQLEXPRESS; Initial Catalog = bottg; Integrated Security=SSPI");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        public void closeConnection() 
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
