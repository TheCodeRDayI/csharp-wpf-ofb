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
    /// Interaction logic for Kare.xaml
    /// </summary>
    public partial class Kare : UserControl
    {
        public Kare()
        {
            InitializeComponent();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int a = 1;\nwhile(a <= 5)\n{\nint b = 2;\nwhile(b <= 15)\n{\nlblCikti.Text += \" * \";\nb++;\n}\nlblCikti.Text += \"\\n\";\na++;\n}");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int a = 1;
            while (a <= 5)
            {
                int b = 2;
                while (b <= 15)
                {
                    lblCikti.Content += "*";
                    b++;
                }
                lblCikti.Content += "\n";
                a++;
            }
        }
    }
}
