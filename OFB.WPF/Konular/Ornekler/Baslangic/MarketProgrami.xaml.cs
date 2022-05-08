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
    /// Interaction logic for MarketProgrami.xaml
    /// </summary>
    public partial class MarketProgrami : UserControl
    {
        public MarketProgrami()
        {
            InitializeComponent();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("double urun1 = Convert.ToDouble(txt1.Text) * Convert.ToDouble(txt4.Text);\ndouble urun2 = Convert.ToDouble(txt2.Text) * Convert.ToDouble(txt5.Text);\ndouble urun3 = Convert.ToDouble(txt3.Text) * Convert.ToDouble(txt6.Text);\ndouble toplam = urun1 + urun2 + urun3;\ndouble kdv = toplam * 0.18;\nlblAra.Text = \"Ara Toplam: \" + toplam.ToString();\nlblKdv.Text = \"KDV (%18): \" + kdv.ToString();\nlblGenelToplam.Text = \"Genel Toplam: \" + (toplam + kdv).ToString()+\" TRY\"; ");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double urun1 = Convert.ToDouble(txt1.Text) * Convert.ToDouble(txt4.Text);
                double urun2 = Convert.ToDouble(txt2.Text) * Convert.ToDouble(txt5.Text);
                double urun3 = Convert.ToDouble(txt3.Text) * Convert.ToDouble(txt6.Text);
                double toplam = urun1 + urun2 + urun3;
                double kdv = toplam * 0.18;
                lblAra.Content = "Ara Toplam: " + toplam.ToString();
                lblKdv.Content = "KDV (%18): " + kdv.ToString();
                lblGenelToplam.Content = "Genel Toplam: " + (toplam + kdv).ToString() + " TRY";
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }
    }
}
