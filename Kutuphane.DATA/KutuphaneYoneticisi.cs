using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DATA
{
    public class KutuphaneYoneticisi
    {
        public KutuphaneYoneticisi()
        {
            Kitaplar = new List<Kitap>();
        }

        public List<Kitap> Kitaplar { get; set; }
        public void KitapBagisYap(Kitap kitap, int adet=1)
        {
            for (int i = 0; i < adet; i++)
            {
                Kitaplar.Add(kitap);
            }
        }
        public void KitapImhaEt()
        {

        }
        public void KitapOduncAl()
        {

        }




    }
}
