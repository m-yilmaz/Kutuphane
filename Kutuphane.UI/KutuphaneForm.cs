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
    public partial class KutuphaneForm : Form
    {
        private readonly Kullanici _girisYapanKullanici;
        private KutuphaneYoneticisi kutuphaneYoneticisi = new KutuphaneYoneticisi();
        private BindingList<Kitap> blKitaplar;
        public KutuphaneForm(Kullanici girisYapanKullanici)
        {
            InitializeComponent();
            VerileriOku();
            blKitaplar = new BindingList<Kitap>(kutuphaneYoneticisi.Kitaplar);
            dgvKitaplar.DataSource = blKitaplar;
            _girisYapanKullanici = girisYapanKullanici;
            cboTurler.Items.Add("Hepsi");
            cboTurler.Items.AddRange(Enum.GetValues(typeof(KitapTuruEnum)).Cast<object>().ToArray());
            cboTurler.SelectedIndex = 0;

        }

        private void tsmHesabim_Click(object sender, EventArgs e)
        {
            HesabimForm hf = new HesabimForm(_girisYapanKullanici,kutuphaneYoneticisi);
            hf.ShowDialog();
        }

        private void tsmBagisYap_Click(object sender, EventArgs e)
        {
            BagisForm bf = new BagisForm(kutuphaneYoneticisi);
            bf.ShowDialog();
            VerileriGuncelle();
        }

        private void VerileriGuncelle()
        {
            VerileriOku();
            dgvKitaplar.DataSource = null;
            blKitaplar = new BindingList<Kitap>(kutuphaneYoneticisi.Kitaplar);
            dgvKitaplar.DataSource = blKitaplar;
            // dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Basım Tarihi";
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].HeaderText = "Yazar Ad";
            dgvKitaplar.Columns[5].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[6].HeaderText = "Açıklama";

        }

        private void tsmCikisYap_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("kitaplar.json");
                kutuphaneYoneticisi.Kitaplar = JsonConvert.DeserializeObject<List<Kitap>>(json);
            }
            catch (Exception)
            {
                kutuphaneYoneticisi.Kitaplar = new List<Kitap>();
            }
        }

        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            // TODO: ContextMenuStrip
            if (e.Button == MouseButtons.Right)
            {
                int position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    contextMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true;// sağ click yaptığım satırı seç
                }
            }
        }

        private void tsmiKitapImha_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0) return;
            Kitap k1 = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
            blKitaplar.Remove(k1);
        }

        private void KutuphaneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(kutuphaneYoneticisi.Kitaplar);
            File.WriteAllText("kitaplar.json", json);
        }

        private void tsmiKitapAl_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0) return;
            Kitap k1 = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
            blKitaplar.Remove(k1);
            _girisYapanKullanici.OduncAlinanKitaplar.Add(k1);
            k1.OduncAlinmaTarihi = DateTime.Now;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (cboTurler.SelectedIndex == 0)
            {
                string arananKitap = txtArama.Text;
                List<Kitap> yeniListe = blKitaplar.Where(x => x.Ad == txtArama.Text).ToList();
                BindingList<Kitap> blYeniListe = new BindingList<Kitap>(yeniListe);
                dgvKitaplar.DataSource = null;
                dgvKitaplar.DataSource = blYeniListe;
            }
            else
            {
                string arananKitap = txtArama.Text;
                KitapTuruEnum tur = (KitapTuruEnum)cboTurler.SelectedItem;
                List<Kitap> yeniListe = blKitaplar.Where(x => x.KitapTuru == tur && x.Ad == txtArama.Text).ToList();
                BindingList<Kitap> blYeniListe = new BindingList<Kitap>(yeniListe);
                dgvKitaplar.DataSource = null;
                dgvKitaplar.DataSource = blYeniListe;
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtArama.Text = "";
            cboTurler.SelectedIndex = 0;
            VerileriGuncelle();
        }

        private void tsmKaydet_Click(object sender, EventArgs e)
        {
            VerileriKaydet();
        }
    }
}
