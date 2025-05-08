using Onion.Core.Layer.Abstracts;
using Onion.Core.Layer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Core.Layer.Entities
{
    public class Urun : IEntity
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
        public string UrunResmi { get; set; }
        public int StokAdedi { get; set; }
        public int KategoriID { get; set; }



        // IEntity interface'inden gelen özellikler
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public KayitDurumu KayitDurumu { get; set; }



        public Kategori? Kategori { get; set; }
        public ICollection<Sepet>? SepettekiUrunler { get; set; }
    }
}
