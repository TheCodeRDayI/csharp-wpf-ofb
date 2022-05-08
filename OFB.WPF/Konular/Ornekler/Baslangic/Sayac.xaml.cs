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
    /// Interaction logic for Sayac.xaml
    /// </summary>
    public partial class Sayac : UserControl
    {
        public Sayac()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            lblCikti.Content = (sayac++).ToString();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            lblCikti.Content = (sayac--).ToString();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int sayac = 0; \n\n//Arttır Button\nlblCikti.Text = (sayac++).ToString();\n//Azalt Button\nlblCikti.Text = (sayac--).ToString();");
        }
    }
}
