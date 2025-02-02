using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class KullaniciManager
    {
        // KullaniciDAL sınıfından bir örnek oluştur
        private readonly KullaniciDAL _kullaniciDal;

        // Constructor - sınıf oluşturulduğunda çalışır
        public KullaniciManager()
        {
            _kullaniciDal = new KullaniciDAL();
        }

        // Kullanıcı girişi için metot
        public Kullanici KullaniciGiris(string kullaniciAdi, string sifre)
        {
            try
            {
                // Temel kontroller
                if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
                {
                    throw new Exception("Kullanıcı adı ve şifre boş olamaz!");
                }

                // Kullanıcı adı ve şifre minimum uzunluk kontrolü
                if (kullaniciAdi.Length < 3 || sifre.Length < 3)
                {
                    throw new Exception("Kullanıcı adı ve şifre en az 3 karakter olmalıdır!");
                }

                // Veritabanı kontrolü için KullaniciDAL'ı kullan
                var kullanici = _kullaniciDal.KullaniciDogrula(kullaniciAdi, sifre);

                // Kullanıcı bulunamadıysa
                if (kullanici == null)
                {
                    throw new Exception("Kullanıcı adı veya şifre hatalı!");
                }

                // Kullanıcı bulunduysa geri döndür
                return kullanici;
            }
            catch (Exception ex)
            {
                // Hata durumunda bu hatayı yukarı fırlat
                throw new Exception("Giriş işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }

        // İleride eklenecek diğer kullanıcı işlemleri için metotlar buraya gelecek
        // Örneğin: KullaniciEkle, KullaniciGuncelle, KullaniciSil gibi
    }
}
