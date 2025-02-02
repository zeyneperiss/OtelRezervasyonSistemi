using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class OdaDAL
    {
        // Yeni oda ekleme metodu
        public bool OdaEkle(Oda oda)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    // SQL sorgumuzda oda bilgilerini parametre olarak ekliyoruz
                    string query = "INSERT INTO Odalar (OdaNumarasi, OdaTipi, Fiyat, Durum) VALUES (@OdaNumarasi, @OdaTipi, @Fiyat, @Durum)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Parametreleri güvenli bir şekilde ekliyoruz
                        cmd.Parameters.AddWithValue("@OdaNumarasi", oda.OdaNumarasi);
                        cmd.Parameters.AddWithValue("@OdaTipi", oda.OdaTipi);
                        cmd.Parameters.AddWithValue("@Fiyat", oda.Fiyat);
                        cmd.Parameters.AddWithValue("@Durum", oda.Durum);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Oda eklenirken hata oluştu: " + ex.Message);
            }
        }

        // Tüm odaları listeleme metodu
        public List<Oda> TumOdalariGetir()
        {
            List<Oda> odalar = new List<Oda>();

            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Odalar";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Her bir oda kaydını listeye ekliyoruz
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
                throw new Exception("Odalar listelenirken hata oluştu: " + ex.Message);
            }

            return odalar;
        }

        // Oda güncelleme metodu
        public bool OdaGuncelle(Oda oda)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "UPDATE Odalar SET OdaNumarasi=@OdaNumarasi, OdaTipi=@OdaTipi, Fiyat=@Fiyat, Durum=@Durum WHERE OdaID=@OdaID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@OdaNumarasi", oda.OdaNumarasi);
                        cmd.Parameters.AddWithValue("@OdaTipi", oda.OdaTipi);
                        cmd.Parameters.AddWithValue("@Fiyat", oda.Fiyat);
                        cmd.Parameters.AddWithValue("@Durum", oda.Durum);
                        cmd.Parameters.AddWithValue("@OdaID", oda.OdaID);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Oda güncellenirken hata oluştu: " + ex.Message);
            }
        }

        // Oda silme metodu
        public bool OdaSil(int odaID)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Odalar WHERE OdaID=@OdaID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@OdaID", odaID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Oda silinirken hata oluştu: " + ex.Message);
            }
        }
    }
}