using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.ViewModel
{
    public class SiparisViewModel
    {
        public int SiparisId { get; set; }

        public int UrunId { get; set; }

        public string UrunAd { get; set; }

        public int Adet { get; set; }

        public decimal Fiyat { get; set; }

        public decimal AraToplam { get; set; }

        public int MasaId { get; set; }
        public bool SiparisDurum { get; set; }
        public override string ToString()
        {
            return $"{UrunAd}-{AraToplam:c2}";
        }
    }
}
