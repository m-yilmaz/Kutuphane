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
    public partial class RegisterForm : Form
    {
        Kullanici kullanici;
        KullaniciYoneticisi _data;
        public RegisterForm(KullaniciYoneticisi data)
        {
            InitializeComponent();
            _data = data;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdSoyad.Text) && !string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text) && txtParolaTekrar.Text == txtParola.Text)
            {
                kullanici = new Kullanici();
                kullanici.AdSoyad = txtAdSoyad.Text;
                kullanici.KullaniciAdi = txtKullaniciAdi.Text;
                kullanici.Parola = txtParola.Text;
                if (_data.KayitOl(kullanici))
                {
                    MessageBox.Show("Kayıt Başarılı, Giriş yapabilirsiniz");
                    string json = JsonConvert.SerializeObject(_data.Kullanicilar);
                    File.WriteAllText("kullanicilar.json", json);
                    Close();
                }
                else
                {
                    MessageBox.Show("Lütfen farklı bir kullanıcı adı giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
            }
        }

        private void txtParolaTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtParola.Text != txtParolaTekrar.Text)
            {
                lblDurum.Text = "Parolalar eşleşmiyor!";
                lblDurum.ForeColor = Color.Red;
                btnYeniKayit.Enabled = false;
            }
            else
            {
                lblDurum.Text = "Parola Geçerli!";
                lblDurum.ForeColor = Color.Green;
                btnYeniKayit.Enabled = true;
            }
        }

    }
}
