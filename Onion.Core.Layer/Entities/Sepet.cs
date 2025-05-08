using Onion.Core.Layer.Abstracts;
using Onion.Core.Layer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Core.Layer.Entities
{
    public class Sepet : IEntity
    {
        public int SepetID { get; set; } // unique hale getirilmek için. composite key değil.
        public int UyeID { get; set; }
        public int UrunID { get; set; }
        public int Adet { get; set; }


        // IEntity interface'inden gelen özellikler
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }


        // Navigation properties
        public Uye? Uye { get; set; }
        public Urun? Urun { get; set; }

    }
}
