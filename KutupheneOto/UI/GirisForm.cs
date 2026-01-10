using KutupheneOto.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace KutupheneOto.UI
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullanici.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection baglanti = Veritabani.BaglantiAl())
                {
                    string sorgu = "SELECT * FROM kullanicilar WHERE kullanici_ad=@ad AND sifre=@sifre";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@ad", txtKullanici.Text);
                    komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    baglanti.Open();
                    MySqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        string yetki = oku["rol"].ToString();
                        AnaForm ana = new AnaForm(yetki);
                        ana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSifre.Clear();
                        txtKullanici.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}