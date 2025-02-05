using System;
using System.Collections.Generic;
using EntityLayer;
using DataAccessLayer;
using System.Windows.Forms;
//using DataAccessLayer.DataAccessLayer;

namespace BusinessLayer
{
    public class MusteriManager
    {
        private MusteriDAL musteriDAL;

        public MusteriManager()
        {
            musteriDAL = new MusteriDAL();
        }

        public bool MusteriEkle(Musteri musteri)
        {
            // TC No benzersizliği kontrolü
            if (TcNoKontrol(musteri.TCNo))
            {
                return musteriDAL.MusteriEkle(musteri);
            }
            else
            {
                return false;
            }
        }
        private bool TcNoKontrol(string tcNo)
        {
            // TC No benzersizliği kontrolü için MusteriDAL'daki TumMusterileriGetir() metodunu kullanın
            var musteriler = musteriDAL.TumMusterileriGetir();
            foreach (var m in musteriler)
            {
                if (m.TCNo == tcNo)
                    return false;
            }
            return true;
        }

        public List<Musteri> TumMusterileriGetir()
        {
            // Veri erişim katmanından tüm müşterileri getir
            return musteriDAL.TumMusterileriGetir();
        }

        // Diğer iş mantığı metotları buraya eklenebilir
    }
}
