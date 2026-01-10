using KutupheneOto.DAO;
using KutupheneOto.Domain;
using System;
using System.Collections.Generic;

namespace KutupheneOto.Services
{
    public class KitapService
    {
        private KitapDao kitapDao = new KitapDao();

        public void KitapGuncelle(Kitap k)
        {
            kitapDao.KitapGuncelle(k);
        }

        public void KitapSil(int id)
        {
            kitapDao.KitapSil(id);
        }

        public void KitapEkle(Kitap k)
        {
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
    }
}