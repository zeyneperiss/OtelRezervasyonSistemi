using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    using MySql.Data.MySqlClient;
    using DataAccessLayer;
    using System;
    using System.Collections.Generic;

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
                return TumMusterileriGetir();
                // Diğer CRUD metotları da burada eklenebilir
            }
        }
    }
}
