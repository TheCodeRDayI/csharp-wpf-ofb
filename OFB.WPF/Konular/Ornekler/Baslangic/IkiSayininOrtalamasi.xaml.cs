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

namespace OFB.WPF.Konular.Ornekler.Baslangic
{
    /// <summary>
    /// Interaction logic for IkiSayininOrtalamasi.xaml
    /// </summary>
    public partial class IkiSayininOrtalamasi : UserControl
    {
        public IkiSayininOrtalamasi()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double sayi1 = Convert.ToDouble(textBox.Text);
                double sayi2 = Convert.ToDouble(textBox_Copy.Text);
                lblCikti.Content = "Ortalama: " + ((sayi1 + sayi2) / 2).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata",ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("double sayi1 = Convert.ToDouble(textBox.Text); \ndouble sayi2 = Convert.ToDouble(textBox_Copy.Text); \nlblCikti.Content = \"Ortalama: \" + ((sayi1 + sayi2) / 2).ToString(); ");
        }
    }
}
