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
using System.Windows.Shapes;
using System.Xml;

namespace OFB.WPF.Programlar.DovizListesi
{
    /// <summary>
    /// Interaction logic for Dovizler.xaml
    /// </summary>
    public partial class Dovizler : Window
    {
        class Item
        {
            public string birim { get; set; }
            public string name { get; set; }
            public string name2 { get; set; }
            public string buying { get; set; }
            public string selling { get; set; }


        }
        public Dovizler()
        {
            InitializeComponent();
            veriler();
        }

        void veriler()
        {
            try
            {
                string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
                var xmldoc = new XmlDocument();
                xmldoc.Load(bugun);
                DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string USD1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/Unit").InnerXml;
                string USD2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/Isim").InnerXml;
                string USD3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/CurrencyName").InnerXml;
                string USD4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                string USD5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

                string DKK1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='DKK']/Unit").InnerXml;
                string DKK2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='DKK']/Isim").InnerXml;
                string DKK3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='DKK']/CurrencyName").InnerXml;
                string DKK4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='DKK']/BanknoteBuying").InnerXml;
                string DKK5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='DKK']/BanknoteSelling").InnerXml;

                string EUR1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/Unit").InnerXml;
                string EUR2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/Isim").InnerXml;
                string EUR3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/CurrencyName").InnerXml;
                string EUR4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                string EUR5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

                string GBP1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/Unit").InnerXml;
                string GBP2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/Isim").InnerXml;
                string GBP3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/CurrencyName").InnerXml;
                string GBP4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
                string GBP5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

                string NOK1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='NOK']/Unit").InnerXml;
                string NOK2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='NOK']/Isim").InnerXml;
                string NOK3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='NOK']/CurrencyName").InnerXml;
                string NOK4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='NOK']/BanknoteBuying").InnerXml;
                string NOK5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='NOK']/BanknoteSelling").InnerXml;

                string SAR1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/Unit").InnerXml;
                string SAR2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/Isim").InnerXml;
                string SAR3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/CurrencyName").InnerXml;
                string SAR4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/BanknoteBuying").InnerXml;
                string SAR5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/BanknoteSelling").InnerXml;

                string JPY1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/Unit").InnerXml;
                string JPY2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/Isim").InnerXml;
                string JPY3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/CurrencyName").InnerXml;
                string JPY4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/BanknoteBuying").InnerXml;
                string JPY5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/BanknoteSelling").InnerXml;

                string BGN1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='BGN']/Unit").InnerXml;
                string BGN2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='BGN']/Isim").InnerXml;
                string BGN3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='BGN']/CurrencyName").InnerXml;
                string BGN4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='BGN']/ForexBuying").InnerXml;
                string BGN5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='BGN']/ForexSelling").InnerXml;

                string RUB1 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='RUB']/Unit").InnerXml;
                string RUB2 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='RUB']/Isim").InnerXml;
                string RUB3 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='RUB']/CurrencyName").InnerXml;
                string RUB4 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='RUB']/ForexBuying").InnerXml;
                string RUB5 = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='RUB']/ForexSelling").InnerXml;

                dataGrid1.Items.Add(new Item()
                {
                    birim = USD1,
                    name = USD2,
                    name2 = USD3,
                    buying = USD4,
                    selling = USD5
                }); dataGrid1.Items.Add(new Item()
                {
                    birim = DKK1,
                    name = DKK2,
                    name2 = DKK3,
                    buying = DKK4,
                    selling = DKK5
                });
                dataGrid1.Items.Add(new Item()
                {
                    birim = EUR1,
                    name = EUR2,
                    name2 = EUR3,
                    buying = EUR4,
                    selling = EUR5
                }); dataGrid1.Items.Add(new Item()
                {
                    birim = GBP1,
                    name = GBP2,
                    name2 = GBP3,
                    buying = GBP4,
                    selling = GBP5
                }); dataGrid1.Items.Add(new Item()
                {
                    birim = NOK1,
                    name = NOK2,
                    name2 = NOK3,
                    buying = NOK4,
                    selling = NOK5
                }); dataGrid1.Items.Add(new Item()
                {
                    birim = SAR1,
                    name = SAR2,
                    name2 = SAR3,
                    buying = SAR4,
                    selling = SAR5
                }); dataGrid1.Items.Add(new Item()
                {
                    birim = JPY1,
                    name = JPY2,
                    name2 = JPY3,
                    buying = JPY4,
                    selling = JPY5
                }); dataGrid1.Items.Add(new Item()
                {
                    birim = BGN1,
                    name = BGN2,
                    name2 = BGN3,
                    buying = BGN4,
                    selling = BGN5
                }); dataGrid1.Items.Add(new Item()
                {
                    birim = RUB1,
                    name = RUB2,
                    name2 = RUB3,
                    buying = RUB4,
                    selling = RUB5
                });

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenter2Message.Show("HATA", ex.Message);
            }

        }
        private void Window_Closed(object sender, EventArgs e)
        {
            wClose();
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        void wClose()
        {
            _Window.Opacity = 1;
            this.Close();
        }
    }
}
