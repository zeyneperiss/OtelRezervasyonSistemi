using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Fatura
    {
        public int FaturaID { get; set; }
        public int RezervasyonID { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
        public bool OdemeDurumu { get; set; }
        // İlişkili veriler
        public string MusteriAdi { get; set; }
        public string OdaNumarasi { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}
