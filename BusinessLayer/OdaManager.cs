using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using MySql.Data.MySqlClient;

namespace BusinessLayer
{
    public class OdaManager
    {
        // Veritabanı bağlantısını başlatıyoruz
        private DbConnection dbConnection;

        public OdaManager()
        {
            dbConnection = new DbConnection();
        }

        // Yeni oda ekleme metodu
        public bool OdaEkle(Oda oda)
        {
            try
            {
                using (var conn = dbConnection.GetConnection())
                {
                    string query = "INSERT INTO Odalar (OdaNumarasi, OdaTipi, Fiyat, Durum) VALUES (@odaNo, @tip, @fiyat, @durum)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Parametreleri güvenli bir şekilde ekliyoruz
                    cmd.Parameters.AddWithValue("@odaNo", oda.OdaNumarasi);
                    cmd.Parameters.AddWithValue("@tip", oda.OdaTipi);
                    cmd.Parameters.AddWithValue("@fiyat", oda.Fiyat);
                    cmd.Parameters.AddWithValue("@durum", oda.Durum);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Mevcut odaları listeleme metodu
        public List<Oda> TumOdalariGetir()
        {
            List<Oda> odalar = new List<Oda>();
            try
            {
                using (var conn = dbConnection.GetConnection())
                {
                    string query = "SELECT * FROM Odalar";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odalar.Add(new Oda
                            {
                                OdaID = Convert.ToInt32(reader["OdaID"]),
                                OdaNumarasi = reader["OdaNumarasi"].ToString(),
                                OdaTipi = reader["OdaTipi"].ToString(),
                                Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                                Durum = Convert.ToBoolean(reader["Durum"])
                            });
                        }
                    }
                }
            }
            catch
            {
                // Hata durumunda boş liste döndürüyoruz
            }
            return odalar;
        }
    }
}
