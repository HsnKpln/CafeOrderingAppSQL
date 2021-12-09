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
    public class Urun:BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public byte[]? Fotograf { get; set; }
        public int KategoriId { get; set; }

        [ForeignKey(nameof(KategoriId))]
        public Kategori Kategori { get; set; }
        public override string ToString()
        {
            return $"{Ad} - {Fiyat:c2}";
        }

    }
}
