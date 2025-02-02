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

        // Constructor - sınıf oluşturulduğunda çalışır
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

        // Oda güncelleme metodu
        public bool OdaGuncelle(Oda oda)
        {
            try
            {
                using (var conn = dbConnection.GetConnection())
                {
                    string query = "UPDATE Odalar SET OdaNumarasi=@odaNo, OdaTipi=@tip, Fiyat=@fiyat, Durum=@durum WHERE OdaID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Parametreleri güvenli bir şekilde ekliyoruz
                    cmd.Parameters.AddWithValue("@odaNo", oda.OdaNumarasi);
                    cmd.Parameters.AddWithValue("@tip", oda.OdaTipi);
                    cmd.Parameters.AddWithValue("@fiyat", oda.Fiyat);
                    cmd.Parameters.AddWithValue("@durum", oda.Durum);
                    cmd.Parameters.AddWithValue("@id", oda.OdaID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // Oda silme metodu
        public bool OdaSil(int odaID)
        {
            try
            {
                using (var conn = dbConnection.GetConnection())
                {
                    string query = "DELETE FROM Odalar WHERE OdaID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", odaID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // Belirli bir odayı ID'ye göre getirme metodu
        public Oda OdaGetir(int odaID)
        {
            try
            {
                using (var conn = dbConnection.GetConnection())
                {
                    string query = "SELECT * FROM Odalar WHERE OdaID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", odaID);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Oda
                            {
                                OdaID = Convert.ToInt32(reader["OdaID"]),
                                OdaNumarasi = reader["OdaNumarasi"].ToString(),
                                OdaTipi = reader["OdaTipi"].ToString(),
                                Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                                Durum = Convert.ToBoolean(reader["Durum"])
                            };
                        }
                    }
                }
            }
            catch
            {
                // Hata durumunda null döndürüyoruz
            }
            return null;
        }

        // Oda durumunu güncelleme metodu (boş/dolu)
        public bool OdaDurumuGuncelle(int odaID, bool yeniDurum)
        {
            try
            {
                using (var conn = dbConnection.GetConnection())
                {
                    string query = "UPDATE Odalar SET Durum=@durum WHERE OdaID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@durum", yeniDurum);
                    cmd.Parameters.AddWithValue("@id", odaID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
