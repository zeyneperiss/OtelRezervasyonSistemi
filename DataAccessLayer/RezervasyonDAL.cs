using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class RezervasyonDAL
    {
        public bool RezervasyonEkle(Rezervasyon rezervasyon)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Rezervasyonlar (MusteriID, OdaID, GirisTarihi, CikisTarihi, ToplamFiyat, Durum) " +
                                 "VALUES (@musteriID, @odaID, @girisTarihi, @cikisTarihi, @toplamFiyat, @durum)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@musteriID", rezervasyon.MusteriID);
                        cmd.Parameters.AddWithValue("@odaID", rezervasyon.OdaID);
                        cmd.Parameters.AddWithValue("@girisTarihi", rezervasyon.GirisTarihi);
                        cmd.Parameters.AddWithValue("@cikisTarihi", rezervasyon.CikisTarihi);
                        cmd.Parameters.AddWithValue("@toplamFiyat", rezervasyon.ToplamFiyat);
                        cmd.Parameters.AddWithValue("@durum", rezervasyon.Durum);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon eklenirken hata: " + ex.Message);
            }
        }

        public List<Rezervasyon> TumRezervasyonlariGetir()
        {
            var rezervasyonlar = new List<Rezervasyon>();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Rezervasyonlar";
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
                                    ToplamFiyat = Convert.ToDecimal(reader["ToplamFiyat"]),
                                    Durum = Convert.ToBoolean(reader["Durum"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyonlar listelenirken hata: " + ex.Message);
            }
            return rezervasyonlar;
        }
    }
}
