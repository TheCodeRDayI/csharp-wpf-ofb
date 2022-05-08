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
    /// Interaction logic for CarpimTablo.xaml
    /// </summary>
    public partial class CarpimTablo : UserControl
    {
        public CarpimTablo()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int i = 1, sonuc = 1;
            listBox.Items.Clear();
            ComboBoxItem typeItem = (ComboBoxItem)comboBox.SelectedItem;
            string value = typeItem.Content.ToString();
            int secim = Convert.ToInt32(value);
            do
            {
                sonuc = secim * i;
                listBox.Items.Add(secim + " x " + i + " = " + sonuc);
                i++;
            } while (i <= 10);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int i = 1, sonuc = 1;\nlistBox1.Items.Clear();\nint c = Convert.ToInt32(comboBox1.SelectedItem);\ndo\n{\nsonuc = c * i;\nlistBox1.Items.Add(c + \" X \" + i + \" = \" + sonuc);\ni++;\n} while (i <= 10) ; ");
        }
    }
}
