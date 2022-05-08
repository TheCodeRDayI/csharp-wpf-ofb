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

namespace OFB.WPF.Konular.Ornekler.DoWhile
{
    /// <summary>
    /// Interaction logic for Yirmiser.xaml
    /// </summary>
    public partial class Yirmiser : UserControl
    {
        public Yirmiser()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            do
            {
                listBox.Items.Add(a);
                a += 20;
            } while (a <= 200);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int a = 0;\ndo\n{\nlistBox.Items.Add(a);\na += 20;\n} while (a <= 200); ");
        }
    }
}
