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
    [Table("Katlar")]
    public class Kat:BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Ad { get; set; }
        public int Sira { get; set; }
        public string Kod { get; set; }
        public ICollection<Masa> Masalar { get; set; } = new HashSet<Masa>();
        public override string ToString() => $"{Ad}";
        
    }
}
