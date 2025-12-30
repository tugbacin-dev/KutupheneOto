using MySql.Data.MySqlClient;
using KutupheneOto.Domain;
using System;
using System.Collections.Generic;

namespace KutupheneOto.DAO
{
    public class KitapDao
    {
        public void Ekle(Kitap kitap)
        {
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {

                string sorgu = "INSERT INTO kitaplar (kitap_ad, yazar, sayfa_sayisi, stok_adedi) VALUES (@ad, @yazar, @sayfa, @stok)";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", kitap.KitapAd);
                komut.Parameters.AddWithValue("@yazar", kitap.Yazar);
                komut.Parameters.AddWithValue("@sayfa", kitap.SayfaSayisi);
                komut.Parameters.AddWithValue("@stok", kitap.StokAdedi);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }

        public List<Kitap> TumunuGetir()
        {
            List<Kitap> liste = new List<Kitap>();
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {
                string sorgu = "SELECT * FROM kitaplar";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                baglanti.Open();
                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {
                        Kitap k = new Kitap();
                        k.Id = Convert.ToInt32(oku["id"]);
                        k.KitapAd = oku["kitap_ad"].ToString();
                        k.Yazar = oku["yazar"].ToString();
                        k.SayfaSayisi = Convert.ToInt32(oku["sayfa_sayisi"]);
                        k.StokAdedi = Convert.ToInt32(oku["stok_adedi"]);
                        liste.Add(k);
                    }
                }
            }
            return liste;
        }
    }
}