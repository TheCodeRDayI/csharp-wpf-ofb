using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;

namespace OFB.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Control_Anasayfa.xaml
    /// </summary>
    public partial class Control_Anasayfa : UserControl
    {
        OFB.Data.Sql.SqlBaglanti baglanti = new Data.Sql.SqlBaglanti();
        public Control_Anasayfa()
        {
            InitializeComponent();
            label_Copy1.Content = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
            timer.Tick += Timer_Tick;


            if (Data.Kullanici.KullaniciInfo.IsNoLogin != "True")
            {
                using (baglanti.Baglanti())
                {
                    using (MySqlCommand cmd = new MySqlCommand("select count(*) from ofb_kullanicilar", baglanti.Baglanti()))
                    {
                        cmd.Connection.Open();
                        label_Copy3.Content = cmd.ExecuteScalar().ToString();
                        cmd.Connection.Close();
                    }
                    using (MySqlCommand cmd2 = new MySqlCommand("select count(*) from ofb_kullanicilar where K_Online='" + true + "'", baglanti.Baglanti()))
                    {
                        cmd2.Connection.Open();
                        label.Content = cmd2.ExecuteScalar().ToString();
                        cmd2.Connection.Close();

                    }
                    using (MySqlCommand cmd3 = new MySqlCommand("select K_Adi from ofb_kullanicilar Order By Id DESC LIMIT 1", baglanti.Baglanti()))
                    {
                        cmd3.Connection.Open();
                        string nick = cmd3.ExecuteScalar().ToString();
                        if (nick.Length > 16)
                        {
                            label_Copy4.Content = nick.Substring(0, 15) + "...";
                        }
                        else
                            label_Copy4.Content = nick;
                        cmd3.Connection.Close();
                    }

                    using (MySqlCommand cmdAktif = new MySqlCommand("select K_Adi from ofb_kullanicilar where K_Online='" + true + "'", baglanti.Baglanti()))
                    {
                        cmdAktif.Connection.Open();
                        using (MySqlDataReader cmdReader = cmdAktif.ExecuteReader())
                        {
                            while (cmdReader.Read())
                            {
                                listBox.Items.Add(cmdReader["K_Adi"]);
                            }
                        }
                        cmdAktif.Connection.Close();

                    }

                }
            }else
            {
                label_Copy3.Content = "- - -";
                label.Content = "- - -";
                label_Copy4.Content = "- - -";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label_Copy1.Content = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
        }

        DispatcherTimer timer = new DispatcherTimer();
        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            string _Name = (Data.Kullanici.KullaniciInfo.K_AD + " " + Data.Kullanici.KullaniciInfo.K_SOYAD).ToUpper();
            string _UserName = Data.Kullanici.KullaniciInfo.K_ADI;
            string _Eposta = Data.Kullanici.KullaniciInfo.K_EPOSTA;
            string _Tc = Data.Kullanici.KullaniciInfo.K_TC.Substring(0, 2) + "*******" + Data.Kullanici.KullaniciInfo.K_TC.Substring(Data.Kullanici.KullaniciInfo.K_TC.Length - 2);
            string _KayitTarih = Data.Kullanici.KullaniciInfo.K_KAYITTarih;
            string _Local = Dns.GetHostName();
            var host = Dns.GetHostEntry(Dns.GetHostName());
            string _Local2 = "IPv4 Bağlantısı Bulunmamakta!";
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                     _Local2 = ip.ToString();
                }
            }
            var _Public="";
            if (await OFB.Data.Araclar.InternetKontrol.KontrolEt() == true)
            {

                string url = "http://checkip.dyndns.org";
                System.Net.WebRequest req = System.Net.WebRequest.Create(url);
                System.Net.WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string response = sr.ReadToEnd().Trim();
                string[] a = response.Split(':');
                string a2 = a[1].Substring(1);
                string[] a3 = a2.Split('<');
                string a4 = a3[0];
                _Public = a4;
            }else
            {
                _Public = "Gizli İçerik";
            }

            lblUser1.Content = _Name;
            lblUser2.Content = _UserName;
            lblUser3.Content = _Eposta;
            lblUser4.Content = _Tc;
            lblUser5.Content = _KayitTarih;
            lblUser6.Content = _Local;
            lblUser7.Content = _Local2;
            lblUser8.Content = _Public;

        }
    }
}
