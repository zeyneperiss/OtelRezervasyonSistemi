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
    public class RezervasyonManager
    {
        private DbConnection dbConnection;

        public RezervasyonManager()
        {
            dbConnection = new DbConnection();
        }

        // Yeni rezervasyon oluşturma metodu
        public bool RezervasyonEkle(Rezervasyon rezervasyon)
        {
            try
            {
                using (var conn = dbConnection.GetConnection())
                {
                    string query = "INSERT INTO Rezervasyonlar (MusteriID, OdaID, GirisTarihi, CikisTarihi, Durum) " +
                                 "VALUES (@musteriId, @odaId, @giris, @cikis, @durum)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@musteriId", rezervasyon.MusteriID);
                    cmd.Parameters.AddWithValue("@odaId", rezervasyon.OdaID);
                    cmd.Parameters.AddWithValue("@giris", rezervasyon.GirisTarihi);
                    cmd.Parameters.AddWithValue("@cikis", rezervasyon.CikisTarihi);
                    cmd.Parameters.AddWithValue("@durum", rezervasyon.Durum);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Odanın durumunu güncelleme
                    string updateQuery = "UPDATE Odalar SET Durum = 0 WHERE OdaID = @odaId";
                    cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@odaId", rezervasyon.OdaID);
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Mevcut rezervasyonları listeleme metodu
        public List<Rezervasyon> TumRezervasyonlariGetir()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            try
            {
                using (var conn = dbConnection.GetConnection())
                {
                    string query = "SELECT * FROM Rezervasyonlar";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    conn.Open();
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
                                Durum = reader["Durum"].ToString()
                            });
                        }
                    }
                }
            }
            catch
            {
                // Hata durumunda boş liste döndürüyoruz
            }
            return rezervasyonlar;
        }
    }
}
