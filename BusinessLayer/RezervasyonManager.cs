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
    public class RezervasyonManager
    {
        private DatabaseConnection DatabaseConnection;

        public RezervasyonManager()
        {
            DatabaseConnection = new DatabaseConnection();
        }

        // Yeni rezervasyon oluşturma metodu
        public bool RezervasyonEkle(Rezervasyon rezervasyon)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Rezervasyonlar (MusteriID, OdaID, GirisTarihi, CikisTarihi, ToplamFiyat, Durum) " +
                                  "VALUES (@musteriId, @odaId, @giris, @cikis, @toplamFiyat, @durum)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@musteriId", rezervasyon.MusteriID);
                        cmd.Parameters.AddWithValue("@odaId", rezervasyon.OdaID);
                        cmd.Parameters.AddWithValue("@giris", rezervasyon.GirisTarihi);
                        cmd.Parameters.AddWithValue("@cikis", rezervasyon.CikisTarihi);
                        cmd.Parameters.AddWithValue("@toplamFiyat", rezervasyon.ToplamFiyat);
                        cmd.Parameters.AddWithValue("@durum", rezervasyon.Durum);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rezervasyon eklenirken hata: {ex.Message}");
                return false;
            }
        }

        // Mevcut rezervasyonları listeleme metodu
        public List<Rezervasyon> TumRezervasyonlariGetir()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    // SQL sorgusunu güncelliyoruz. CASE WHEN yapısı, duruma göre farklı metinler döndürür
                    string query = @"SELECT R.*, 
                           M.Ad AS MusteriAdi, 
                           O.OdaNumarasi,
                           CASE 
                                WHEN R.Durum = 1 THEN 'Aktif'
                                ELSE 'İptal Edildi'
                           END AS DurumText
                           FROM Rezervasyonlar R 
                           JOIN Musteriler M ON R.MusteriID = M.MusteriID 
                           JOIN Odalar O ON R.OdaID = O.OdaID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rezervasyonlar.Add(new Rezervasyon
                                {
                                    RezervasyonID = Convert.ToInt32(reader["RezervasyonID"]),
                                    MusteriID = Convert.ToInt32(reader["MusteriID"]),
                                    OdaID = Convert.ToInt32(reader["OdaID"]),
                                    GirisTarihi = Convert.ToDateTime(reader["GirisTarihi"]),
                                    CikisTarihi = Convert.ToDateTime(reader["CikisTarihi"]),
                                    Durum = Convert.ToBoolean(reader["Durum"]),
                                    DurumText = reader["DurumText"].ToString(),  // Yeni alan
                                    MusteriAdi = reader["MusteriAdi"].ToString(),
                                    OdaNumarasi = reader["OdaNumarasi"].ToString()
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
            return rezervasyonlar;
        }

        public bool RezervasyonIptal(int rezervasyonID)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    // Önce rezervasyonun oda bilgisini alalım
                    string getOdaIDQuery = "SELECT OdaID FROM Rezervasyonlar WHERE RezervasyonID = @rezervasyonID";
                    int odaID;

                    using (MySqlCommand cmd = new MySqlCommand(getOdaIDQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);
                        odaID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Rezervasyonu iptal et (durumunu false yap)
                    string updateRezervasyonQuery = "UPDATE Rezervasyonlar SET Durum = false WHERE RezervasyonID = @rezervasyonID";
                    using (MySqlCommand cmd = new MySqlCommand(updateRezervasyonQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);
                        cmd.ExecuteNonQuery();
                    }

                    // Odayı tekrar müsait yap
                    string updateOdaQuery = "UPDATE Odalar SET Durum = true WHERE OdaID = @odaID";
                    using (MySqlCommand cmd = new MySqlCommand(updateOdaQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@odaID", odaID);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rezervasyon iptal edilirken hata oluştu: {ex.Message}");
                return false;
            }
        }
    }
}
