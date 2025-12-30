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
    public partial class UyeForm : Form
    {
        KitapService _servis = new KitapService();
        public UyeForm()
        {
            InitializeComponent();
        }

        private void UyeForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnUyeKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kutuların boş olup olmadığını basitçe kontrol edelim
                if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
                {
                    MessageBox.Show("Ad ve Soyad alanları zorunludur!");
                    return;
                }

                Uye yeniUye = new Uye
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Eposta = txtEposta.Text,
                    UyelikTarihi = DateTime.Now // Şu anki tarihi otomatik atıyoruz
                };

                _servis.UyeEkle(yeniUye);
                MessageBox.Show("Üye kaydı başarıyla oluşturuldu!");

                Listele(); // Tabloyu güncelle
                Temizle(); // Kutuları boşalt
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        void Listele()
        {
            dgvUyeler.DataSource = null;
            dgvUyeler.DataSource = _servis.UyeleriGetir();
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
        }


    }
}
