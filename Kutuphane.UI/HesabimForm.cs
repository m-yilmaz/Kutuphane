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
        private readonly Kullanici _aktifKullanici;
        private readonly KutuphaneYoneticisi _kutuphaneDb;
        public HesabimForm(Kullanici aktifKullanici, KutuphaneYoneticisi kutuphaneDb)
        {
            InitializeComponent();
            _aktifKullanici = aktifKullanici;
            _kutuphaneDb = kutuphaneDb;
            KullaniciBilgileriniYukle();
            Yenile();
        }

        private void KullaniciBilgileriniYukle()
        {
            lblId.Text = _aktifKullanici.Id.ToString();
            lblAdSoyad.Text = _aktifKullanici.AdSoyad;
            lblKullaniciAdi.Text = _aktifKullanici.KullaniciAdi;
            lblParola.Text = _aktifKullanici.Parola;
        }
        private void Yenile()
        {
            dgvOduncAlinanKitap.DataSource = null;
            dgvOduncAlinanKitap.DataSource = _aktifKullanici.OduncAlinanKitaplar != null ? _aktifKullanici.OduncAlinanKitaplar : null;
            dgvOduncAlinanKitap.Columns[0].Visible = true;
            dgvOduncAlinanKitap.Columns[1].HeaderText = "Kitap Adı";
            dgvOduncAlinanKitap.Columns[2].Visible = false;
            dgvOduncAlinanKitap.Columns[3].HeaderText = "Kitap Türü";
            dgvOduncAlinanKitap.Columns[4].Visible = false;
            dgvOduncAlinanKitap.Columns[5].Visible = false;
            dgvOduncAlinanKitap.Columns[6].Visible = false;
            dgvOduncAlinanKitap.Columns[7].HeaderText = "Ödünç Alınma Tarihi";
            dgvOduncAlinanKitap.Columns[8].HeaderText = "Son Teslim Tarihi";
        }
        private void btnKitapTeslimEt_Click(object sender, EventArgs e)
        {
            Kitap teslimEdilenKitap = (Kitap)(dgvOduncAlinanKitap.SelectedRows[0].DataBoundItem);
            if (dtpSonTeslimTarihi.Value <= teslimEdilenKitap.TeslimTarihi.Value)
                _kutuphaneDb.KitapTeslimEt(teslimEdilenKitap, _aktifKullanici);
            else
            {
                MessageBox.Show("Kitabın son teslim tarihinden sonra teslim edildi ! Lütfen ceza almamak için son teslim tarihine uyunuz !");
                _kutuphaneDb.KitapTeslimEt(teslimEdilenKitap, _aktifKullanici);
            }
            Yenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //TODO Şifre değişikliği
        }
    }
}
