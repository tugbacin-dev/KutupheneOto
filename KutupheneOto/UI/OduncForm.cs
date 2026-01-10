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
    public partial class OduncForm : Form
    {
        KitapService _kitapServis = new KitapService();
        UyeService _uyeServis = new UyeService();
        OduncService _oduncServis = new OduncService();
       

        public OduncForm()
        {
            InitializeComponent();
        }

        private void OduncForm_Load(object sender, EventArgs e)
        {
            cmbKitaplar.DataSource = _kitapServis.KitaplariGetir();
            cmbKitaplar.DisplayMember = "KitapAd";
            cmbKitaplar.ValueMember = "Id";

            cmbUyeler.DataSource = _uyeServis.UyeleriGetir();
            cmbUyeler.DisplayMember = "Ad";
            cmbUyeler.ValueMember = "Id";
            VerileriYukle();
            Listele();
        
        }

        void VerileriYukle()
        {
            cmbKitaplar.DataSource = _kitapServis.KitaplariGetir();
            cmbKitaplar.DisplayMember = "KitapAd";
            cmbKitaplar.ValueMember = "Id";

            
            cmbUyeler.DataSource = _uyeServis.UyeleriGetir();
            cmbUyeler.DisplayMember = "Ad";
            cmbUyeler.ValueMember = "Id";

            cmbKitaplar.SelectedIndex = -1;
            cmbUyeler.SelectedIndex = -1;
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            try
            {
                Odunc yeniOdunc = new Odunc
                {
                    KitapId = (int)cmbKitaplar.SelectedValue,
                    UyeId = (int)cmbUyeler.SelectedValue,
                    VerilisTarihi = DateTime.Now,
                    IadeTarihi = dtpIadeTarihi.Value,
                    IadeEdildiMi = false
                   
                };

                _oduncServis.KitapOduncVer(yeniOdunc);
                MessageBox.Show("Ödünç verme işlemi başarıyla kaydedildi!");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            Listele();
        }

        void Listele()
        {
            dgvOduncListesi.DataSource = null;
            dgvOduncListesi.DataSource = _oduncServis.OduncListesiGetir();
            if (dgvOduncListesi.Columns["Id"] != null) dgvOduncListesi.Columns["Id"].Visible = false;
            if (dgvOduncListesi.Columns["KitapId"] != null) dgvOduncListesi.Columns["KitapId"].Visible = false;
            if (dgvOduncListesi.Columns["UyeId"] != null) dgvOduncListesi.Columns["UyeId"].Visible = false;
            if (dgvOduncListesi.Columns["IadeEdildiMi"] != null) dgvOduncListesi.Columns["IadeEdildiMi"].Visible = false;

            if (dgvOduncListesi.Columns["KitapAd"] != null) dgvOduncListesi.Columns["KitapAd"].HeaderText = "Kitap Adı";
            if (dgvOduncListesi.Columns["UyeAd"] != null) dgvOduncListesi.Columns["UyeAd"].HeaderText = "Üye Adı";
            if (dgvOduncListesi.Columns["VerilisTarihi"] != null) dgvOduncListesi.Columns["VerilisTarihi"].HeaderText = "Veriliş Tarihi";
            if (dgvOduncListesi.Columns["IadeTarihi"] != null) dgvOduncListesi.Columns["IadeTarihi"].HeaderText = "Teslim Edilecek Tarih";
            dgvOduncListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnOduncVer_Click_1(object sender, EventArgs e)
        {
            if (cmbKitaplar.SelectedIndex != -1 && cmbUyeler.SelectedIndex != -1)
            {
                Odunc yeniOdunc = new Odunc();

                yeniOdunc.KitapId = Convert.ToInt32(cmbKitaplar.SelectedValue);
                yeniOdunc.UyeId = Convert.ToInt32(cmbUyeler.SelectedValue);
                yeniOdunc.VerilisTarihi = DateTime.Now;
                yeniOdunc.IadeTarihi = dtpIadeTarihi.Value;
                yeniOdunc.IadeEdildiMi = false;

                try
                {
                    _oduncServis.KitapOduncVer(yeniOdunc);
                    MessageBox.Show("Ödünç verme işlemi başarıyla kaydedildi!");

                    cmbKitaplar.SelectedIndex = -1;
                    cmbUyeler.SelectedIndex = -1;
                    dtpIadeTarihi.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap ve bir üye seçiniz!");
            }
            Listele();
        }
    }
}