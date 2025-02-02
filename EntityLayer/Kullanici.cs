using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Kullanici
    {
        // Her kullanıcının benzersiz kimlik numarası
        public int KullaniciID { get; set; }

        // Kullanıcının gerçek adı
        public string Ad { get; set; }

        // Kullanıcının soyadı
        public string Soyad { get; set; }

        // Sisteme giriş için kullanılacak kullanıcı adı
        public string KullaniciAdi { get; set; }

        // Kullanıcının şifresi
        public string Sifre { get; set; }

        // Kullanıcının sistemdeki rolü (Admin, Personel gibi)
        public string Rol { get; set; }

        // Kullanıcının aktif olup olmadığı
        public bool AktifMi { get; set; }
    }
}
