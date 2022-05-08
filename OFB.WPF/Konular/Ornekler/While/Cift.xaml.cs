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

namespace OFB.WPF.Konular.Ornekler.While
{
    /// <summary>
    /// Interaction logic for Cift.xaml
    /// </summary>
    public partial class Cift : UserControl
    {
        public Cift()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int top = 0, baslangic = 10;
            while (baslangic <= 50)
            {
                top += baslangic;
                baslangic += 2;
            }
            lblCikti.Content = "Toplam: " + top.ToString();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int top = 0, baslangic = 10;\nwhile (baslangic <= 50)\n{\ntop += baslangic;\nbaslangic += 2;\n}\nlblCikti.Text = \"Toplam: \" + top.ToString()");
        }
    }
}
