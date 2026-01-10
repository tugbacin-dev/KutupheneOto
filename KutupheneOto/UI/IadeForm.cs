using KutupheneOto.Domain;
using KutupheneOto.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KutupheneOto.UI
{
    public partial class IadeForm : Form
    {

        OduncService _oduncServis = new OduncService();


        List<Odunc> tumOduncKayitlari;

        public IadeForm()
        {
            InitializeComponent();
        }

        private void IadeForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
            dgvIadeEdilecekler.Columns["Id"].Visible = false;
            dgvIadeEdilecekler.Columns["KitapId"].Visible = false;
            dgvIadeEdilecekler.Columns["UyeId"].Visible = false;
            dgvIadeEdilecekler.Columns["IadeEdildiMi"].Visible = false;

            dgvIadeEdilecekler.Columns["KitapAd"].HeaderText = "Kitap Adı";
            dgvIadeEdilecekler.Columns["UyeAd"].HeaderText = "Üye İsmi";
            dgvIadeEdilecekler.Columns["VerilisTarihi"].HeaderText = "Veriliş Tarihi";
        }


        private void ListeyiYenile()
        {

            tumOduncKayitlari = _oduncServis.OduncListesiGetir().Where(o => o.IadeEdildiMi == false).ToList();
            dgvIadeEdilecekler.DataSource = null;
            dgvIadeEdilecekler.DataSource = tumOduncKayitlari;

        }


        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
        private void Filtrele()
        {
            string uyeKriter = txtUyeAra.Text.ToLower();
            string kitapKriter = txtKitapAra.Text.ToLower();
            var sonuc = tumOduncKayitlari.Where(o =>
                o.UyeId.ToString().Contains(uyeKriter) ||
                o.KitapId.ToString().Contains(kitapKriter)
            ).ToList();

            dgvIadeEdilecekler.DataSource = sonuc;
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            if (dgvIadeEdilecekler.SelectedRows.Count > 0)
            {

                int seciliOduncId = Convert.ToInt32(dgvIadeEdilecekler.SelectedRows[0].Cells["Id"].Value);

                try
                {

                    _oduncServis.KitapIadeAl(seciliOduncId);

                    MessageBox.Show("Kitap iade işlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    ListeyiYenile();
                    txtUyeAra.Clear();
                    txtKitapAra.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen iade edilecek işlemi listeden seçiniz.");
            }
        }

        private void txtUyeAra_TextChanged_1(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void txtKitapAra_TextChanged_1(object sender, EventArgs e)
        {
            AramaYap();
        }
        void AramaYap()
        {
            string uyeFiltre = txtUyeAra.Text.ToLower();
            string kitapFiltre = txtKitapAra.Text.ToLower();

            var tumListe = _oduncServis.OduncListesiGetir().Where(o => o.IadeEdildiMi == false).ToList();

            var filtrelenmis = tumListe.Where(o =>
                (string.IsNullOrEmpty(uyeFiltre) || o.UyeAd.ToLower().Contains(uyeFiltre)) &&
                (string.IsNullOrEmpty(kitapFiltre) || o.KitapAd.ToLower().Contains(kitapFiltre))
            ).ToList();

            dgvIadeEdilecekler.DataSource = filtrelenmis;
        }

        private void btnIadeAl_Click_1(object sender, EventArgs e)
        {
            if (dgvIadeEdilecekler.SelectedRows.Count > 0)
            {
                int oduncId = Convert.ToInt32(dgvIadeEdilecekler.SelectedRows[0].Cells["Id"].Value);

                try
                {
                    _oduncServis.KitapIadeAl(oduncId);
                    MessageBox.Show("İade işlemi başarıyla tamamlandı!");
                    AramaYap(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İade alınırken hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden iade edilecek bir kayıt seçin!");
            }
        }
    }
}
