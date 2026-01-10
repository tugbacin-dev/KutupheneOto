using KutupheneOto.DAO;
using KutupheneOto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutupheneOto.Services
{
    internal class OduncService
    {

        private OduncDao _oduncDao = new OduncDao();

        public void KitapOduncVer(Odunc o) => _oduncDao.OduncKaydet(o);
        public List<Odunc> OduncListesiGetir() => _oduncDao.TumunuGetir();
        public void KitapIadeAl(int oduncId) => _oduncDao.IadeOnayla(oduncId);
    }

}
