using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;

namespace OFB.Data.Araclar
{
    public class EmailSender
    {
        public static bool MailGonder(string Email, string Konu, string Icerik)
        {
            try
            {
                SmtpClient server = new SmtpClient();
                MailMessage mesaj = new MailMessage();
                server.Credentials = new System.Net.NetworkCredential("****************", "*********");
                server.Port = 587;
                server.Host = "smtp.gmail.com";
                server.EnableSsl = true;
                mesaj.To.Add(Email);
                mesaj.From = new MailAddress("csharpofb@gmail.com");
                mesaj.Subject = Konu;
                mesaj.Body = Icerik + "\n\n[  -   CODER CONTACT   -  ] \n| Ömer Faruk Bacaksız \n| +90 537 299 13 22 \n| Turkey, Konya";
                server.Send(mesaj);

                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
    }
}
