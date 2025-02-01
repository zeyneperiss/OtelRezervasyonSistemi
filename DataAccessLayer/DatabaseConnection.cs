using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    using System;
    using MySql.Data.MySqlClient;

    namespace DataAccessLayer
    {
        public class DatabaseConnection
        {
            private static string connectionString = "Server=localhost:3306;Database=25_132230089;Uid=25_132230089;Pwd=!nif.ogr89ER;";

            public static MySqlConnection GetConnection()
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();
                    return connection;
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanı bağlantısı kurulamadı: " + ex.Message);
                }
            }
        }
    }
}
