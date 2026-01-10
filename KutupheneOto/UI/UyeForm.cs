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
        private string kullaniciYetki;

        public UyeForm(string yetki)
        {
            InitializeComponent();
            this.kullaniciYetki = yetki;
        }

        UyeService _uyeService = new UyeService();
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
                    UyelikTarihi = DateTime.Now 
                };

                _uyeService.UyeEkle(yeniUye );
                MessageBox.Show("Üye kaydı başarıyla oluşturuldu!");

                Listele(); 
                Temizle(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        void Listele()
        {
            dgvUyeler.DataSource = null;
            dgvUyeler.DataSource = _uyeService.UyeleriGetir();
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();
        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
            txtAd.Text = dgvUyeler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvUyeler.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dgvUyeler.CurrentRow.Cells[3].Value.ToString();
            txtEposta.Text = dgvUyeler.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
        
            try
            {
                Uye u = new Uye();
                u.Id = int.Parse(dgvUyeler.CurrentRow.Cells[0].Value.ToString()); // id hücresi
                u.Ad = txtAd.Text;
                u.Soyad = txtSoyad.Text;
                u.Telefon = txtTelefon.Text;
                u.Eposta = txtEposta.Text;

                _uyeService.UyeGuncelle(u);
                MessageBox.Show("Üye bilgileri başarıyla güncellendi.");
                Listele(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = int.Parse(dgvUyeler.CurrentRow.Cells[0].Value.ToString());

                _uyeService.UyeSil(id);
                MessageBox.Show("Üye başarıyla silindi.");
                Listele(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi tablodan seçin! Hata: " + ex.Message);
            }
        }
    }
    
}
