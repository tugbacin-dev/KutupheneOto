using KutupheneOto.Domain;
using KutupheneOto.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutupheneOto.UI
{
    public partial class KitapForm : Form
    {
        KitapService _servis = new KitapService();
        public KitapForm()
        {
            InitializeComponent();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap k = new Kitap();
                k.KitapAd = txtKitapAd.Text;
                k.Yazar = txtYazar.Text;
                k.SayfaSayisi = int.Parse(txtSayfa.Text);
                k.StokAdedi = int.Parse(txtStok.Text);

                KitapService servis = new KitapService();
                servis.KitapEkle(k);

                MessageBox.Show("Kitap başarıyla veritabanına kaydedildi!"); Listele();
                txtKitapAd.Clear();
                txtYazar.Clear();
                txtSayfa.Clear();
                txtStok.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        void Listele()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = _servis.KitaplariGetir();
        }
    }
}
