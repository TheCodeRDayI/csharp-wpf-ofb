using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFB.Data.Araclar
{
    public class Log
    {


        public static Task GelismisLOG(string K_Adi, string LogAbout, string Logs)
        {
            return Task.Run(() =>
            {
                try
                {
                    Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();
                    using (Baglanti.Baglanti())
                    {
                        var query = "INSERT INTO ofb_logs (K_Adi,LogAbout,Log_) VALUES ('" + K_Adi + "','" + LogAbout + "','" + Logs + "')";
                        using (MySqlCommand sqlcmd = new MySqlCommand(query, Baglanti.Baglanti()))
                        {
                            sqlcmd.Connection.Open();
                            sqlcmd.ExecuteNonQuery();
                            sqlcmd.Connection.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
        }
    }
}
