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
    public partial class BagisForm : Form
    {
        private readonly KutuphaneYoneticisi _data;
        Kitap yeniKitap;
        public BagisForm(KutuphaneYoneticisi data)
        {
            InitializeComponent();
            cboKitapTuru.DataSource = Enum.GetValues(typeof(KitapTuruEnum));
            _data = data;
        }
        private void VerileriYaz()
        {
            string json = JsonConvert.SerializeObject(_data.Kitaplar);
            File.WriteAllText("kitaplar.json", json);
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            KitapBilgileriniAl();
            BosAlanVeKayitKontrol((int)nudAdet.Value);
        }

        private void BosAlanVeKayitKontrol(int adet)
        {
            if (!string.IsNullOrEmpty(txtAciklama.Text) && !string.IsNullOrEmpty(txtKitapAdi.Text) && !string.IsNullOrEmpty(txtYazarAdi.Text))
            {
                _data.KitapBagisYap(yeniKitap,adet);
                VerileriYaz();
                DialogResult dr = MessageBox.Show("Kitap Eklendi, Yeni kitap eklemek istiyor musunuz ?", "Kitap Kayıt Durum Ekranı", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    Temizle();
                else
                    Close();
            }
            else
                MessageBox.Show("Lütfen Boş alanları doldurunuz!");
        }

        private void KitapBilgileriniAl()
        {
            for (int i = 0; i < (int)nudAdet.Value; i++)
            {
                yeniKitap = new Kitap()
                {
                    KitapTuru = (KitapTuruEnum)cboKitapTuru.SelectedItem,
                    SayfaSayisi = (int)nudSayfaSayisi.Value,
                    BasimTarihi = dtpBasimTarihi.Value,
                    Ad = txtKitapAdi.Text,
                    YazarAd = txtYazarAdi.Text,
                    Aciklama = txtAciklama.Text
                };
            }
        }

        private void Temizle()
        {
            txtAciklama.Clear();
            txtKitapAdi.Clear();
            txtYazarAdi.Clear();
            nudAdet.Value = 1;
            nudSayfaSayisi.Value = 1;
            dtpBasimTarihi.Value = DateTime.Now;
        }
    }
}
