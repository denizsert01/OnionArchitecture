using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Core.Layer.Entities
{
    public class Uye : IdentityUser<int>
    {
        public string Adres { get; set; }

        public ICollection<Sepet>? SepettekiUrunler { get; set; }
    }
}
