using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class DbConnection
    {
        private static string connectionString = "Server=172.21.54.253;Database=25_132230089;Uid=25_132230089;Pwd=!nif.ogr89ER;";
        private MySqlConnection connection;
        
        public DbConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
