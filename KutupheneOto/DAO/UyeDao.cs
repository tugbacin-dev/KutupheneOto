using MySql.Data.MySqlClient;
using KutupheneOto.Domain;
using System;
using System.Collections.Generic;

namespace KutupheneOto.DAO
{
    public class UyeDao
    {
        public void UyeSil(int id)
        {
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM uyeler WHERE id=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        public void UyeGuncelle(Uye u)
        {
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {
                baglanti.Open();
                string sorgu = "UPDATE uyeler SET ad=@p1, soyad=@p2, telefon=@p3, eposta=@p4 WHERE id=@p5";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", u.Ad);
                komut.Parameters.AddWithValue("@p2", u.Soyad);
                komut.Parameters.AddWithValue("@p3", u.Telefon);
                komut.Parameters.AddWithValue("@p4", u.Eposta);
                komut.Parameters.AddWithValue("@p5", u.Id);

                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
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