using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;

namespace OFB.Data.Araclar
{
    public class InternetKontrol
    {
        public static Task<bool> KontrolEt()
        {

            return Task.Run<bool>(() =>
            {
                WebRequest request = WebRequest.Create("http://www.google.com");
                WebResponse response;
                try
                {
                    response = request.GetResponse();
                    response.Close();
                    request = null;
                    return true;
                }
                catch (Exception)
                {
                    request = null;
                    return false;
                }
            });


        }

    }
}





