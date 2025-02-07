using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Rezervasyon
    {
        public int RezervasyonID { get; set; }
        public int MusteriID { get; set; }
        public int OdaID { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal ToplamFiyat { get; set; }
        public bool Durum { get; set; }  // Aktif/İptal 
        public string MusteriAdi { get; set; }
        public string OdaNumarasi { get; set; }
        public string DurumText { get; set; }  // Durumun metin halini tutacak yeni özellik
        
    }
}
