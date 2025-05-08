using Onion.Core.Layer.Abstracts;
using Onion.Core.Layer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Core.Layer.Entities
{
    public class Kategori : IEntity
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }


        // IEntity interface'inden gelen özellikler
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }
     
        
        // Navigation property
        public ICollection<Urun>? Urunler { get; set; }
    }
}
