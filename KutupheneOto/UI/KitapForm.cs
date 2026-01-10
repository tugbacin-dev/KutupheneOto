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
        private string kullaniciYetki;
        public KitapForm(string yetki)
        {
            InitializeComponent();
            this.kullaniciYetki = yetki;
        }

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

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            try
            {
                int seciliId = int.Parse(dgvKitaplar.CurrentRow.Cells["Id"].Value.ToString());

                DialogResult onay = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    _servis.KitapSil(seciliId);

                    MessageBox.Show("Kitap başarıyla silindi!");
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı tablodan seçin! Hata: " + ex.Message);
            }
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap k = new Kitap();
                k.Id = int.Parse(dgvKitaplar.CurrentRow.Cells["Id"].Value.ToString());
                k.KitapAd = txtKitapAd.Text.Trim();
                k.Yazar = txtYazar.Text.Trim();
                k.SayfaSayisi = int.Parse(txtSayfa.Text);
                k.StokAdedi = int.Parse(txtStok.Text);

                _servis.KitapGuncelle(k);
                MessageBox.Show("Kitap bilgileri güncellendi!");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapAd.Text = dgvKitaplar.CurrentRow.Cells[1].Value.ToString();
            txtYazar.Text = dgvKitaplar.CurrentRow.Cells[2].Value.ToString();
            txtSayfa.Text = dgvKitaplar.CurrentRow.Cells[3].Value.ToString();
            txtStok.Text = dgvKitaplar.CurrentRow.Cells[4].Value.ToString();
        }

    }
    
}
