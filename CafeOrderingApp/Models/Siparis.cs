using CafeOrderingApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class Siparis:BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get ; set ; }
        public Urun Urun { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public Masa Masa { get; set; }
        public decimal AraToplam { get => Adet * Fiyat; }
        
    }
}
