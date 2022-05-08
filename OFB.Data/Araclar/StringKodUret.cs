using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFB.Data.Araclar
{
    public class StringKodUret
    {
        #region StringUret

        public static string Uret(byte Basamak)
        {
            Random rastgele = new Random();
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz1234567890";
            string uret = "";
            for (int i = 0; i < Basamak; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            return uret;
        }
        #endregion
    }
}
