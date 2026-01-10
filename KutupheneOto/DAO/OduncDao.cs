using MySql.Data.MySqlClient;
using KutupheneOto.Domain;
using System;
using System.Collections.Generic;

namespace KutupheneOto.DAO
{
    public class OduncDao
    {
        public void OduncKaydet(Odunc odunc)
        {
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {
                string sorgu = "INSERT INTO odunc_islemleri (kitap_id, uye_id, verilis_tarihi, teslim_tarihi, iade_durumu) " +
                               "VALUES (@kId, @uId, @vTarih, @tTarih, @durum)";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kId", odunc.KitapId);
                komut.Parameters.AddWithValue("@uId", odunc.UyeId);
                komut.Parameters.AddWithValue("@vTarih", odunc.VerilisTarihi);
                komut.Parameters.AddWithValue("@tTarih", odunc.IadeTarihi);
                komut.Parameters.AddWithValue("@durum", odunc.IadeEdildiMi);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }

     
        public void IadeOnayla(int id)
        {
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {
              
                string sorgu = "UPDATE odunc_islemleri SET iade_durumu = 1, teslim_tarihi = @bugun WHERE id = @id";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@bugun", DateTime.Now);
                komut.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                komut.ExecuteNonQuery();
            }
        }

        public List<Odunc> TumunuGetir()
        {
            List<Odunc> liste = new List<Odunc>();
            using (MySqlConnection baglanti = Veritabani.BaglantiAl())
            {
                string sorgu = @"SELECT o.*, k.kitap_ad, u.ad 
                         FROM odunc_islemleri o
                         INNER JOIN kitaplar k ON o.kitap_id = k.id
                         INNER JOIN uyeler u ON o.uye_id = u.id";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                baglanti.Open();
                using (MySqlDataReader oku = komut.ExecuteReader())
                {
                    while (oku.Read())
                    {
                        Odunc o = new Odunc();
                        o.Id = Convert.ToInt32(oku["id"]);
                        o.KitapId = Convert.ToInt32(oku["kitap_id"]);
                        o.UyeId = Convert.ToInt32(oku["uye_id"]);
                        o.VerilisTarihi = Convert.ToDateTime(oku["verilis_tarihi"]);

                        if (oku["teslim_tarihi"] != DBNull.Value)
                        {
                            o.IadeTarihi = Convert.ToDateTime(oku["teslim_tarihi"]);
                        }

                        o.IadeEdildiMi = Convert.ToBoolean(oku["iade_durumu"]);
                        o.KitapAd = oku["kitap_ad"].ToString();
                        o.UyeAd = oku["ad"].ToString();

                        liste.Add(o);
                    }
                }
            }
            return liste;
        }
    }
}