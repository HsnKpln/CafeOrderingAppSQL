using CafeOrderingApp.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.Models
{
    public class Kategori:BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string? Aciklama { get; set; }
        public byte[]? Fotograf { get; set; }
        public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
        public override string ToString()
        {
            return Ad;
        }
    }
}
