using Kutuphane.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI
{
    public partial class HesabimForm : Form
    {
        private Kullanici _kullanici;
        BindingList<Kitap> blKitaplar;
        private KutuphaneYoneticisi _db;
        public HesabimForm(Kullanici kullanici,KutuphaneYoneticisi db)
        {
            
            InitializeComponent();
            _kullanici = kullanici;
            _db = db;
            KullaniciBilgileriniYukle();
            blKitaplar = new BindingList<Kitap>(_kullanici.OduncAlinanKitaplar);
            dgvOduncAlinanKitap.DataSource = blKitaplar;
        }

        private void KullaniciBilgileriniYukle()
        {
            lblId.Text = _kullanici.Id.ToString();
            lblAdSoyad.Text = _kullanici.AdSoyad;
            lblKullaniciAdi.Text = _kullanici.KullaniciAdi;
            lblParola.Text = _kullanici.Parola;
        }

        private void Yenile()
        {
            dgvOduncAlinanKitap.DataSource = null;
            dgvOduncAlinanKitap.DataSource = blKitaplar;
        }
        private void btnKitapTeslimEt_Click(object sender, EventArgs e)
        {
            Kitap teslimEdilenKitap =  (Kitap)dgvOduncAlinanKitap.SelectedRows[0].DataBoundItem;
            _kullanici.OduncAlinanKitaplar.Remove(teslimEdilenKitap);
            _db.Kitaplar.Add(teslimEdilenKitap);
        }

        private void dgvOduncAlinanKitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Kitap teslimEdilenKitap = (Kitap)dgvOduncAlinanKitap.SelectedRows[0].DataBoundItem;
            DateTime oat =teslimEdilenKitap.OduncAlinmaTarihi.Value;
            DateTime onBesGunEkli = oat.AddSeconds(15);
            dtpSonTeslimTarihi.Value = onBesGunEkli;
            if (DateTime.Now > onBesGunEkli)
            {
                MessageBox.Show("Kitabın Teslim Süresi Gecikti!");
            }
        }
    }
}
