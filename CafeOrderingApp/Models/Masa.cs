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
    public class Masa:BaseEntity,IKey<int>
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Sira { get; set; }
        public bool MasaDurumuDoluMu { get; set; } = false;
        [ForeignKey(nameof(katId))]
        public int katId { get; set; }
        public Kat kat { get; set; }
        public override string ToString() => $"{Sira} - {Ad}";
        
    }
}
