using KutupheneOto.DAO;
using KutupheneOto.Domain;
using System;
using System.Collections.Generic;

namespace KutupheneOto.Services
{
    public class KitapService
    {
        private KitapDao kitapDao = new KitapDao();
        private UyeDao uyeDao = new UyeDao();
        private OduncDao oduncDao = new OduncDao();

        // KİTAP İŞLEMLERİ
        public void KitapEkle(Kitap k)
        {
            // ISBN kontrolü kaldırıldı, sadece Kitap Adı kontrol ediliyor
            if (!string.IsNullOrEmpty(k.KitapAd))
            {
                kitapDao.Ekle(k);
            }
            else
            {
                throw new Exception("Kitap adı boş bırakılamaz!");
            }
        }

        public List<Kitap> KitaplariGetir()
        {
            return kitapDao.TumunuGetir();
        }

        // ÜYE İŞLEMLERİ
        public void UyeEkle(Uye u)
        {
            if (!string.IsNullOrEmpty(u.Ad) && !string.IsNullOrEmpty(u.Soyad))
            {
                uyeDao.Ekle(u);
            }
            else
            {
                throw new Exception("Üye adı ve soyadı boş bırakılamaz!");
            }
        }

        public List<Uye> UyeleriGetir()
        {
            return uyeDao.TumunuGetir();
        }

        // ÖDÜNÇ İŞLEMLERİ
        public void KitapOduncVer(Odunc o)
        {
            // Burada basitçe kaydediyoruz, ileride "stok kontrolü" eklenebilir
            oduncDao.OduncKaydet(o);
        }

        public List<Odunc> OduncListesiGetir()
        {
            return oduncDao.TumunuGetir();
        }
    }
}