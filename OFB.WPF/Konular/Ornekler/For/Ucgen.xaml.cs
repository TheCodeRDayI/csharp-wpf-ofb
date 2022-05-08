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

namespace OFB.WPF.Konular.Ornekler.For
{
    /// <summary>
    /// Interaction logic for Ucgen.xaml
    /// </summary>
    public partial class Ucgen : UserControl
    {
        public Ucgen()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string star = "";
            for (int i = 0; i <= 10; i++)
            {
                star += "*";
                listBox.Items.Add(star);

            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("string star = \"\";\nfor (int i = 0; i <= 10; i++)\n{\nstar += \"*\";\nlistBox.Items.Add(star);\n}");
        }
    }
}
