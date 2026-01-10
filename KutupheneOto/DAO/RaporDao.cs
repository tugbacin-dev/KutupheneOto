using KutupheneOto.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KutupheneOto.DAO
{
    internal class RaporDao
    {
     
        private string connStr = "Server=172.21.54.253;Database=26_132430019;Uid=26_132430019;Pwd=İnif123.;CharSet=utf8;";

        public DataTable GetReportData(string reportType)
        {
            DataTable dt = new DataTable();
            string sql = "";

            switch (reportType)
            {
                case "yaklasan":
                    
                    sql = @"SELECT k.kitap_ad as 'Kitap', CONCAT(u.ad, ' ', u.soyad) as 'Üye', o.verilis_tarihi as 'Veriliş', o.teslim_tarihi as 'Son İade' 
                            FROM odunc_islemleri o 
                            JOIN kitaplar k ON o.kitap_id = k.id 
                            JOIN uyeler u ON o.uye_id = u.id 
                            WHERE o.iade_durumu = 0 AND o.teslim_tarihi <= DATE_ADD(CURDATE(), INTERVAL 3 DAY)";
                    break;

                case "populer":
                    sql = @"SELECT k.kitap_ad as 'Kitap', COUNT(*) as 'Ödünç Sayısı' 
                            FROM odunc_islemleri o 
                            JOIN kitaplar k ON o.kitap_id = k.id 
                            GROUP BY k.kitap_ad ORDER BY COUNT(*) DESC LIMIT 5";
                    break;

                case "gecikmis":
                   
                    sql = @"SELECT k.kitap_ad as 'Kitap', CONCAT(u.ad, ' ', u.soyad) as 'Üye', o.teslim_tarihi as 'Geciken Tarih' 
                            FROM odunc_islemleri o 
                            JOIN kitaplar k ON o.kitap_id = k.id 
                            JOIN uyeler u ON o.uye_id = u.id 
                            WHERE o.iade_durumu = 0 AND o.teslim_tarihi < CURDATE()";
                    break;

                case "aktif":
                    sql = @"SELECT CONCAT(u.ad, ' ', u.soyad) as 'Üye', COUNT(*) as 'Kitap Sayısı' 
                            FROM odunc_islemleri o 
                            JOIN uyeler u ON o.uye_id = u.id 
                            GROUP BY u.id, u.ad, u.soyad ORDER BY COUNT(*) DESC LIMIT 5";
                    break;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    conn.Open();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Hata: " + ex.Message);
                }
            }
            return dt;
        }
    }
}