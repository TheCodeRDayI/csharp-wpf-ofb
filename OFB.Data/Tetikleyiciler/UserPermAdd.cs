using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace OFB.Data.Tetikleyiciler
{
    public class UserPermAdd
    {

        public static Task UserAdd(string K_Adi)
        {
            return Task.Run(() =>
            {
                try
                {
                    Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();
                    using (Baglanti.Baglanti())
                    {
                        var query = "INSERT INTO ofb_kullaniciyetkileri (K_Adi,Admin,KonuOrnek,Programlar,Oyunlar) VALUES ('" + K_Adi.Trim() + "','False','True','True','True')";
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
