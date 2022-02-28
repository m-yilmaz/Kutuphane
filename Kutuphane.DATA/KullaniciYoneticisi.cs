using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DATA
{
    public class KullaniciYoneticisi
    {
        public KullaniciYoneticisi()
        {
            Kullanicilar = new List<Kullanici>();
        }
        public List<Kullanici> Kullanicilar { get; set; }
        public bool KayitOl(Kullanici k1)
        {
            if (!KullaniciVarMi(k1.KullaniciAdi))
            {
                Kullanicilar.Add(k1);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool KullaniciVarMi(string kullaniciAdi)
        {
            Kullanici sonuc = Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi);
            if (sonuc != null)
                return true;
            else
                return false;
        }
        public Kullanici GirisYap(string kullaniciAdi, string parola)
        {
            Kullanici sonuc = Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Parola == parola);
            return sonuc;
        }
    }
}
