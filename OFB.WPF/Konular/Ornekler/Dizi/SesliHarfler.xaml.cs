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

namespace OFB.WPF.Konular.Ornekler.Dizi
{
    /// <summary>
    /// Interaction logic for SesliHarfler.xaml
    /// </summary>
    public partial class SesliHarfler : UserControl
    {
        public SesliHarfler()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            char[] chr = { 'A', 'E', 'I', 'İ', 'U', 'Ü', 'O', 'Ö', 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            byte sayac = 0;
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                for (int h = 0; h < chr.Length; h++)
                {
                    if (textBox.Text[i] == chr[h])
                        sayac++;
                }
            }
            lblCikti.Content = "Toplam Sesli Harf: " + sayac.ToString();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("char[] chr = { 'A', 'E', 'I', 'İ', 'U', 'Ü', 'O', 'Ö', 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };\nbyte sayac = 0;\nfor(int i = 0; i < textBox.Text.Length; i++)\n{\nfor(int h = 0; h < chr.Length; h++)\n{\nif(textBox.Text[i] == chr[h])\nsayac++;\n}\n}\nlblCikti.Text = \"Toplam Sesli Harf: \" + sayac.ToString();");
        }
    }
}
