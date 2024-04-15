using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_11.Entities.Table
{
    public class musteriteklifleriozet_odemesekli
    {
        [Key]
        public int bimno { get; set; }
        public int? ozet_bimno { get; set; }
        public string? grupadi { get; set; }
        public string? aktifpasif { get; set; }
        public string? yuzde { get; set; }
        public string? odemesekli { get; set; }
        public string? bilgisayaradi_i { get; set; }
        public string? bilgisayaradi_k { get; set; }
        public DateTime? iptaltarihi_d { get; set; }
        public DateTime? kayittarihi_d { get; set; }
        public string? iptaleden { get; set; }
        public string? kaydeden { get; set; }
        public string? sirketkodu { get; set; }
    }
}
