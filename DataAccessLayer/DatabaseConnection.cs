using System;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class DatabaseConnection
    {
        // MySQL bağlantı dizesi (Bağlantı bilgilerinizi buraya ekleyin)
        private static string connectionString = "Server=172.21.54.253;Database=25_132230089;Uid=25_132230089;Pwd=!nif.ogr89ER;";

        // MySQL bağlantı nesnesi
        private static MySqlConnection connection;

        // Bağlantıyı açan ve döndüren metod
        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;

                
            }
            catch (MySqlException ex) 
            {
                switch (ex.Number)
                {
                    case 0:
                        throw new Exception("Sunucuya bağlanılamadı. Sunucu adresini ve port numarasını kontrol edin.");
                    case 1045:
                        throw new Exception("Kullanıcı adı veya şifre hatalı.");
                    case 1042:
                        throw new Exception("Sunucu adresi bulunamadı.");
                    default:
                        throw new Exception($"Veritabanı bağlantı hatası (Hata No: {ex.Number}): {ex.Message}");
                }
            }
        }

        // Bağlantıyı kapatan metod
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
