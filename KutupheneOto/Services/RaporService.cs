using KutupheneOto.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutupheneOto.Services
{
    public class RaporService
    {
        RaporDao raporDao = new RaporDao();

        public DataTable RaporuGetir(string tip)
        {
            return raporDao.GetReportData(tip);
        }
    }
}