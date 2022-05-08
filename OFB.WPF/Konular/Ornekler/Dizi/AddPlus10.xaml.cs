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
    /// Interaction logic for AddPlus10.xaml
    /// </summary>
    public partial class AddPlus10 : UserControl
    {
        public AddPlus10()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int[] sayilar = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(0, 101);
                listBox.Items.Add(sayilar[i]);
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] += 10;
                listBox_Copy.Items.Add(sayilar[i]);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int[] sayilar = new int[10];\nRandom rnd = new Random();\nfor(int i = 0; i < sayilar.Length; i++)\n{\nsayilar[i] = rnd.Next(0, 101);\nlistBox.Items.Add(sayilar[i]);\n}\nfor(int i = 0; i < sayilar.Length; i++)\n{\nsayilar[i] += 10;\nlistBox_Copy.Items.Add(sayilar[i]);\n}");
        }
    }
}
