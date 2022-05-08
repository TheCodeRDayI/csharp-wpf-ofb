using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OFB.Data.Sql
{
    public class SqlBaglanti
    {

        public MySqlConnection Baglanti()
        {

            #region My_Local_Connection
            //using (var baglanti = new MySqlConnection("SERVER=localhost;DATABASE=ofb;UID=root;PWD=OKiTHSXxfiqt6GDO;"))
            //{
            //    baglanti.Open();
            //    return baglanti;
            //}
            #endregion

            #region MYSQL_Remote
            //using (var baglanti = new MySqlConnection("SERVER=remotemysql.com;PORT=3306;DATABASE=jl0Z50Ivq2;UID=jl0Z50Ivq2;PWD=ycldsMMxCw;"))
            //{
            //    baglanti.Open();
            //    return baglanti;
            //}
            #endregion

            #region MYSQL_Local
            using (var baglanti = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=ofb;UID=root;PWD=mysql;"))
            {
                baglanti.Open();
                return baglanti;
            }
            #endregion

        }

    }
}
