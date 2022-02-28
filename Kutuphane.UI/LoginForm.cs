using Kutuphane.DATA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class LoginForm : Form
    {
        KullaniciYoneticisi data = new KullaniciYoneticisi();
        public LoginForm()
        {
            InitializeComponent();
            VerileriOku();
        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("kullanicilar.json");
                data.Kullanicilar = JsonConvert.DeserializeObject<List<Kullanici>>(json);
            }
            catch (Exception)
            {
                data.Kullanicilar = new List<Kullanici>();
            }
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm(data);
            rf.ShowDialog();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            
            Kullanici girisYapanKullanici = data.GirisYap(txtKullaniciAdi.Text,txtParola.Text);
            if (girisYapanKullanici != null)
            {
                MessageBox.Show("Giriş Başarılı, Kütüphane ekranı açılıyor...");
                KutuphaneForm kf = new KutuphaneForm(girisYapanKullanici);
                kf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giriş Bilgilerinizi Kontrol ediniz");
            }
        }

        private void VerileriYaz()
        {
            string json = JsonConvert.SerializeObject(data.Kullanicilar);
            File.WriteAllText("kullanicilar.json", json);
        }
    }
}
