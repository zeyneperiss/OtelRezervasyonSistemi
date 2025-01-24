using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Oda
    {
        public int OdaID { get; set; }
        public string OdaNumarasi { get; set; }
        public string OdaTipi { get; set; }
        public decimal Fiyat { get; set; }
        public bool Durum { get; set; }
    }
}
