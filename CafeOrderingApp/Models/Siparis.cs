using CafeOrderingApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class Siparis:BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get ; set ; }
        
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
       
        public decimal AraToplam { get; set; }
        public bool SiparisDurum { get; set; }

        public DateTime DateTime { get; set; }

        public string DateTimeDay { get; set; }

        public string DateTimeHour { get; set; }

        public int MasaId { get; set; }

        public int UrunId { get; set; }

        [ForeignKey(nameof(MasaId))]
        public Masa Masa { get; set; }

        [ForeignKey(nameof(UrunId))]
        public Urun Urun { get; set; }

        public override string ToString()
        {
            return $"{Urun.Ad} - {AraToplam:c2}";
        }

    }
}
