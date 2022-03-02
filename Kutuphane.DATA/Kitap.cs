using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DATA
{
    public class Kitap
    {
        public Kitap()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Ad { get; set; }
        public DateTime BasimTarihi { get; set; }
        public KitapTuruEnum KitapTuru { get; set; }
        public string YazarAd { get; set; }
        public int SayfaSayisi { get; set; }
        public string Aciklama { get; set; }
        public DateTime? OduncAlinmaTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }

    }
}
