using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutupheneOto.DAO
{
    public class Veritabani
    {
        private static string connectionString = "Server=172.21.54.253;Database=26_132430019;Uid=26_132430019;Pwd=İnif123.;";
        public static MySqlConnection BaglantiAl()
        {
            return new MySqlConnection(connectionString);
        }
    }

}
