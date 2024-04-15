using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_11.Entities.Db
{
    public class PayPlanAddDb
    {
        public int? ozet_bimno { get; set; }
        public string? aktifpasif { get; set; }
        public string? yuzde { get; set; }
        public string? odemesekli { get; set; }
        public string? bilgisayaradi_k { get; set; }
        public DateTime? kayittarihi_d { get; set; }
        public string? kaydeden { get; set; }
        public string? sirketkodu { get; set; }

    }
}
