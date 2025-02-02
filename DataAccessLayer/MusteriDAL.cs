using MySql.Data.MySqlClient;
using EntityLayer;
using System;
using System.Collections.Generic;
//using DataAccessLayer.DataAccessLayer;

namespace DataAccessLayer
{
    public class MusteriDAL
    {
        // Müşteri Ekleme
        public bool MusteriEkle(Musteri musteri)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "INSERT INTO Musteriler (Ad, Soyad, TCNo, Telefon, Email) VALUES (@Ad, @Soyad, @TCNo, @Telefon, @Email)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ad", musteri.Ad);
                        cmd.Parameters.AddWithValue("@Soyad", musteri.Soyad);
                        cmd.Parameters.AddWithValue("@TCNo", musteri.TCNo);
                        cmd.Parameters.AddWithValue("@Telefon", musteri.Telefon);
                        cmd.Parameters.AddWithValue("@Email", musteri.Email);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri eklenirken hata oluştu: " + ex.Message);
            }
        }

        // Tüm Müşterileri Listeleme
        public List<Musteri> TumMusterileriGetir()
        {
            List<Musteri> musteriler = new List<Musteri>();

            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Musteriler";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                musteriler.Add(new Musteri
                                {
                                    MusteriID = Convert.ToInt32(reader["MusteriID"]),
                                    Ad = reader["Ad"].ToString(),
                                    Soyad = reader["Soyad"].ToString(),
                                    TCNo = reader["TCNo"].ToString(),
                                    Telefon = reader["Telefon"].ToString(),
                                    Email = reader["Email"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteriler listelenirken hata oluştu: " + ex.Message);
            }

            return musteriler;
        }

        // Müşteri Güncelleme
        public bool MusteriGuncelle(Musteri musteri)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Musteriler SET Ad=@Ad, Soyad=@Soyad, Telefon=@Telefon, Email=@Email WHERE MusteriID=@MusteriID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ad", musteri.Ad);
                        cmd.Parameters.AddWithValue("@Soyad", musteri.Soyad);
                        cmd.Parameters.AddWithValue("@Telefon", musteri.Telefon);
                        cmd.Parameters.AddWithValue("@Email", musteri.Email);
                        cmd.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri güncellenirken hata oluştu: " + ex.Message);
            }
        }

        // Müşteri Silme
        public bool MusteriSil(int musteriID)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Musteriler WHERE MusteriID=@MusteriID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", musteriID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri silinirken hata oluştu: " + ex.Message);
            }
        }
    }
}