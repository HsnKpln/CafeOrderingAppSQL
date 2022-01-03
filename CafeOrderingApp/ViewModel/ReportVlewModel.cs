using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrderingApp.ViewModel
{
    public class ReportVlewModel
    {
        public string MasaIsmi { get; set; }
        public string UrunIsmi { get; set; }
        public decimal AraToplam { get; set; }
        public bool SiparisDurum { get; set; }
        public DateTime DateTime { get; set; }
        public string DateTimeDay { get; set; }
        public string DateTimeHour { get; set; }
    }
}
