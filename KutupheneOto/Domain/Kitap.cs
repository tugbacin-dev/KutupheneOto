using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutupheneOto.Domain
{
    public class Kitap
    {
        
        public int Id { get; set; }
        public string KitapAd { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public int StokAdedi { get; set; }
    }
}
