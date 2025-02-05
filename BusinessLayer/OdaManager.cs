using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class OdaManager
    {
        // Veritabanı bağlantısını başlatıyoruz
        

        // Constructor - sınıf oluşturulduğunda çalışır
        

        // Yeni oda ekleme metodu
        public bool OdaEkle(Oda oda)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Odalar (OdaNumarasi, OdaTipi, Fiyat, Durum) VALUES (@odaNo, @tip, @fiyat, @durum)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@odaNo", oda.OdaNumarasi);
                        cmd.Parameters.AddWithValue("@tip", oda.OdaTipi);
                        cmd.Parameters.AddWithValue("@fiyat", oda.Fiyat);
                        cmd.Parameters.AddWithValue("@durum", oda.Durum);

                        return cmd.ExecuteNonQuery() > 0; // conn.Open() satırını kaldırdık
                    }
                }
            }
            //catch (MySqlException ex)
            //{
            //    System.Windows.Forms.MessageBox.Show($"MySQL Hatası: {ex.Number} - {ex.Message}");
            //    return false;
            //}
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                return false;
            }
        }

        // Mevcut odaları listeleme metodu
        public List<Oda> TumOdalariGetir()
        {
            List<Oda> odalar = new List<Oda>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Odalar";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri çekme hatası: {ex.Message}");
            }
            return odalar;
        }

        // Oda güncelleme metodu
        public bool OdaGuncelle(Oda oda)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Odalar SET OdaNumarasi=@odaNo, OdaTipi=@tip, Fiyat=@fiyat, Durum=@durum WHERE OdaID=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@odaNo", oda.OdaNumarasi);
                        cmd.Parameters.AddWithValue("@tip", oda.OdaTipi);
                        cmd.Parameters.AddWithValue("@fiyat", oda.Fiyat);
                        cmd.Parameters.AddWithValue("@durum", oda.Durum);
                        cmd.Parameters.AddWithValue("@id", oda.OdaID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme hatası: {ex.Message}");
                return false;
            }
        }

        // Oda silme metodu
        public bool OdaSil(int odaID)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Odalar WHERE OdaID=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", odaID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Silme hatası: {ex.Message}");
                return false;
            }
        }

        // Belirli bir odayı ID'ye göre getirme metodu
        public Oda OdaGetir(int odaID)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
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
                using (var conn = DatabaseConnection.GetConnection())
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
