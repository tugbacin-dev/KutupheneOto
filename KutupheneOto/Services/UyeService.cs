using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutupheneOto.DAO;      
using KutupheneOto.Domain;  
using System.Collections.Generic;

namespace KutupheneOto.Services
{
    public class UyeService
    {
        private UyeDao _uyeDao = new UyeDao();

        public void UyeEkle(Uye u)
        {
            if (!string.IsNullOrEmpty(u.Ad) && !string.IsNullOrEmpty(u.Soyad))
            {
                _uyeDao.Ekle(u);
            }
            else
            {
                throw new Exception("Üye adı ve soyadı boş bırakılamaz!");
            }
        }

        public void UyeSil(int id)
        {
            _uyeDao.UyeSil(id);
        }

        public void UyeGuncelle(Uye u)
        {
            _uyeDao.UyeGuncelle(u);
        }

        public List<Uye> UyeleriGetir()
        {
            return _uyeDao.TumunuGetir();
        }
    }
}