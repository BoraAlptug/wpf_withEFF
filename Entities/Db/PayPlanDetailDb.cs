using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_11.Entities.Db
{
    public class PayPlanDetailDb
    {
        [Key]
        public int bimno { get; set; }
        public int? ozet_bimno { get; set; }
        public string? grupadi { get; set; }
        public string? aktifpasif { get; set; }
        public string? yuzde { get; set; }
        public string? odemesekli { get; set; }
    }
}
