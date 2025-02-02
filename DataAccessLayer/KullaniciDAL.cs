using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class KullaniciDAL
    {
        // Bu metot, kullanıcı girişi sırasında kullanıcı adı ve şifre kontrolü yapacak
        public Kullanici KullaniciDogrula(string kullaniciAdi, string sifre)
        {
            try
            {
                // Veritabanı bağlantısını oluştur
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    // SQL sorgusunu hazırla - sadece aktif kullanıcıları kontrol et
                    string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@kullaniciAdi AND Sifre=@sifre AND AktifMi=1";

                    // Sorguyu çalıştırmak için komut oluştur
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Parametreleri güvenli bir şekilde ekle
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        // Sorguyu çalıştır ve sonuçları oku
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Eğer bir sonuç bulunduysa
                            if (reader.Read())
                            {
                                // Veritabanından gelen bilgilerle yeni bir Kullanici nesnesi oluştur
                                return new Kullanici
                                {
                                    KullaniciID = Convert.ToInt32(reader["KullaniciID"]),
                                    Ad = reader["Ad"].ToString(),
                                    Soyad = reader["Soyad"].ToString(),
                                    KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                    Rol = reader["Rol"].ToString(),
                                    AktifMi = Convert.ToBoolean(reader["AktifMi"])
                                };
                            }
                        }
                    }
                }
                // Eğer kullanıcı bulunamadıysa null döndür
                return null;
            }
            catch (Exception ex)
            {
                // Hata durumunda anlamlı bir hata mesajı fırlat
                throw new Exception("Kullanıcı doğrulama hatası: " + ex.Message);
            }
        }
    }
}
