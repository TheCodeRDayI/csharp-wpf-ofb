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

namespace OFB.WPF.Konular.Ornekler.SwitchCase
{
    /// <summary>
    /// Interaction logic for MevsimBulma.xaml
    /// </summary>
    public partial class MevsimBulma : UserControl
    {
        public MevsimBulma()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 11:
                case 0:
                case 1:
                    lblCikti.Content = "Mevsim: Kış";
                    break;
                case 2:
                case 3:
                case 4:
                    lblCikti.Content = "Mevsim: İlkbahar";
                    break;
                case 5:
                case 6:
                case 7:
                    lblCikti.Content = "Mevsim: Yaz";
                    break;
                case 8:
                case 9:
                case 10:
                    lblCikti.Content = "Mevsim: Sonbahar";
                    break;
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("switch (comboBox.SelectedIndex)\n{\ncase 11: case 0: case 1:\nlblCikti.Text = \"Mevsim: Kış\";\nbreak;\ncase 2: case 3: case 4:\nlblCikti.Text = \"Mevsim: İlkbahar\";\nbreak;\ncase 5: case 6: case 7:\nlblCikti.Text = \"Mevsim: Yaz\";\nbreak;\ncase 8: case 9: case 10:\nlblCikti.Text = \"Mevsim: Sonbahar\";\nbreak;\n}");
        }
    }
}
