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
        public void KitapBagisYap(Kitap kitap, int adet = 1)
        {
            for (int i = 0; i < adet; i++)
            {
                Kitaplar.Add(kitap);
            }
        }
        public void KitapImhaEt(Kitap kitap)
        {
            Kitap imhaEdilecekKitap = Kitaplar.FirstOrDefault(x => x.Id == kitap.Id);
            Kitaplar.Remove(imhaEdilecekKitap);
        }
        public void KitapOduncAl(Kitap kitap, Kullanici kullanici)
        {
            Kitap k1 = Kitaplar.FirstOrDefault(x => x.Id == kitap.Id);
            k1.OduncAlinmaTarihi = DateTime.Now;
            k1.TeslimTarihi = k1.OduncAlinmaTarihi.Value.AddSeconds(15);
            kullanici.OduncAlinanKitaplar.Add(k1);
        }
        public void KitapTeslimEt(Kitap kitap, Kullanici kullanici)
        {
            //kullanıcının odunc alınan kitaplarından silinir, odunc alinma tarihi null yapılır.
            Kitap k1 = Kitaplar.FirstOrDefault(x => x.Id == kitap.Id);
            k1.OduncAlinmaTarihi = null;
            k1.TeslimTarihi = null;
            kullanici.OduncAlinanKitaplar.Remove(k1);
        }



    }
}
