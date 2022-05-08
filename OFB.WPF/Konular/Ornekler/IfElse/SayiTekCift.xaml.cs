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

namespace OFB.WPF.Konular.Ornekler.IfElse
{
    /// <summary>
    /// Interaction logic for SayiTekCift.xaml
    /// </summary>
    public partial class SayiTekCift : UserControl
    {
        public SayiTekCift()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox.Text);
                if (sayi % 2 == 0) lblCikti.Content = "Sayınz Çift";
                else lblCikti.Content = "Sayınz Tek";
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int sayi = Convert.ToInt32(textBox.Text);\nif (sayi % 2 == 0) lblCikti.Text = \"Sayınz Çift\";\nelse lblCikti.Text = \"Sayınz Tek\"; ");
        }
    }
}
