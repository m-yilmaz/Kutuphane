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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class KutuphaneForm : Form
    {

        private readonly Kullanici _aktifKullanici;
        KutuphaneYoneticisi kutuphaneDb;
        public KutuphaneForm(Kullanici akitfKullanici)
        {
            InitializeComponent();
            VerileriOku();
            _aktifKullanici = akitfKullanici;
            cboTurler.Items.Add("Hepsi");
            cboTurler.Items.AddRange(Enum.GetValues(typeof(KitapTuruEnum)).Cast<object>().ToArray());
            cboTurler.SelectedIndex = 0;
            Task.Run(SonTeslimKontrol);
            VerileriGuncelle();
        }
        private void SonTeslimKontrol()
        {
            bool uyari = true;
        BAS:
            while (uyari && _aktifKullanici != null)
            {
                try
                {
                    foreach (Kitap kitap in _aktifKullanici.OduncAlinanKitaplar)
                    {
                        if (DateTime.Now > kitap.TeslimTarihi)
                        {
                            MessageBox.Show($"{kitap.OduncAlinmaTarihi} tarihinde ödünç aldığınız {kitap.Ad} adlı kitabın son teslim tarihi gecikmiştir !");
                            uyari = false;
                        }
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception)
                {
                    goto BAS;
                }
            }
        }


        private void tsmHesabim_Click(object sender, EventArgs e)
        {
            HesabimForm hf = new HesabimForm(_aktifKullanici, kutuphaneDb);

            hf.ShowDialog();
            VerileriGuncelle();
        }
        private void tsmBagisYap_Click(object sender, EventArgs e)
        {
            BagisForm bf = new BagisForm(kutuphaneDb);
            bf.ShowDialog();
            VerileriGuncelle();
        }

        private void tsmCikisYap_Click(object sender, EventArgs e)
        {
            VerileriKaydet();
            Close();
        }

        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    if (_aktifKullanici.KullaniciAdi != "admin")
                    {
                        contextMenuStrip1.Items[1].Visible = false;
                    }
                    contextMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true;// sağ click yaptığım satırı seç
                }
            }
        }
        private void tsmiKitapImha_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0) return;
            Kitap k1 = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
            if (k1.OduncAlinmaTarihi == null)
            {
                kutuphaneDb.KitapImhaEt(k1);
                VerileriGuncelle();
            }
            else
            {
                MessageBox.Show("Bu kitap imha edilemez, Başkası tarafından ödünç alınmış.");
            }
        }
        private void tsmiKitapAl_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0) return;
            Kitap k1 = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;

            if (k1.OduncAlinmaTarihi != null)
            {
                MessageBox.Show(this, "Kitap kullanımda!", "Bilgilendirme");
                return;
            }
            kutuphaneDb.KitapOduncAl(k1, _aktifKullanici);
            Task.Run(SonTeslimKontrol);
            VerileriGuncelle();
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtArama.Text = "";
            cboTurler.SelectedIndex = 0;
            VerileriGuncelle();
        }
        private void VerileriGuncelle()
        {

            dgvKitaplar.DataSource = null;
            if (!string.IsNullOrEmpty(txtArama.Text) && cboTurler.SelectedIndex != 0)
            {
                //iki kriter geçerli
                dgvKitaplar.DataSource = kutuphaneDb.Kitaplar.Where(x => x.Ad.ToLower().Contains(txtArama.Text.ToLower()) && x.KitapTuru == (KitapTuruEnum)cboTurler.SelectedItem).ToList();
            }
            else if (!string.IsNullOrEmpty(txtArama.Text) && cboTurler.SelectedIndex == 0)
                //hepsi içerisinde arama geçerli
                dgvKitaplar.DataSource = kutuphaneDb.Kitaplar.Where(x => x.Ad.ToLower().Contains(txtArama.Text.ToLower())).ToList();
            else if (cboTurler.SelectedIndex != 0)
                //tür kriteri geçerli
                dgvKitaplar.DataSource = kutuphaneDb.Kitaplar.Where(x => x.KitapTuru == (KitapTuruEnum)cboTurler.SelectedItem).ToList();
            else
                dgvKitaplar.DataSource = kutuphaneDb.Kitaplar.ToList();

            dgvKitaplar.Columns[0].Visible = true;//Id kolonunu gizledik.
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Basım Tarihi";
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].HeaderText = "Yazar Ad";
            dgvKitaplar.Columns[5].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[6].HeaderText = "Açıklama";
            dgvKitaplar.Columns[7].Visible = true;//Oduncalinmatarihini gizledik.


        }
        private void tsmKaydet_Click(object sender, EventArgs e)
        {
            VerileriKaydet();
        }
        private void KutuphaneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }
        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(kutuphaneDb);
            File.WriteAllText("kitaplar.json", json);
        }
        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("kitaplar.json");
                kutuphaneDb = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(json);
            }
            catch (Exception)
            {
                kutuphaneDb = new KutuphaneYoneticisi();
            }
        }
    }
}
