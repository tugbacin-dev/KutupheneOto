using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutupheneOto.Domain
{
    public class Odunc
    {
        public int Id { get; set; }
        public int KitapId { get; set; } 
        public int UyeId { get; set; }
        public DateTime VerilisTarihi { get; set; } 
        public DateTime IadeTarihi { get; set; }
        public bool IadeEdildiMi { get; set; }
        public string KitapAd { get; set; }
        public string UyeAd { get; set; }
       
    }
}
