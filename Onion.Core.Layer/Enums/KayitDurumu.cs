using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Core.Layer.Enums
{
    /// <summary>
    ///  Identity paketini yükledik. Diğer paketleri yüklemedik, şişirmemek için.
    /// </summary>
    public enum KayitDurumu
    {
        Eklendi = 1,
        Guncellendi = 2,
        Silindi = 3
    }
}
