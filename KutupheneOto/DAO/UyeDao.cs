using MySql.Data.MySqlClient;
using KutupheneOto.Domain;
using System;
using System.Collections.Generic;

namespace KutupheneOto.DAO
{
    public class UyeDao
    {
        public void Ekle(Uye uye)
        {
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {
                string sorgu = "INSERT INTO uyeler (ad, soyad, telefon, eposta, uyelik_tarihi) VALUES (@ad, @soyad, @tel, @mail, @tarih)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", uye.Ad);
                komut.Parameters.AddWithValue("@soyad", uye.Soyad);
                komut.Parameters.AddWithValue("@tel", uye.Telefon);
                komut.Parameters.AddWithValue("@mail", uye.Eposta);
                komut.Parameters.AddWithValue("@tarih", uye.UyelikTarihi);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }

        public List<Uye> TumunuGetir()
        {
            List<Uye> liste = new List<Uye>();
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {
                string sorgu = "SELECT * FROM uyeler";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                baglanti.Open();
                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {
                        Uye u = new Uye();
                        u.Id = Convert.ToInt32(oku["id"]);
                        u.Ad = oku["ad"].ToString();
                        u.Soyad = oku["soyad"].ToString();
                        u.Telefon = oku["telefon"].ToString();
                        u.Eposta = oku["eposta"].ToString();
                        u.UyelikTarihi = Convert.ToDateTime(oku["uyelik_tarihi"]);
                        liste.Add(u);
                    }
                }
            }
            return liste;
        }
    }
}