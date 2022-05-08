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
    /// Interaction logic for DiziyeRandomEleman.xaml
    /// </summary>
    public partial class DiziyeRandomEleman : UserControl
    {
        public DiziyeRandomEleman()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int[] dizi = new int[5];
            for (int i = 0; i < 5; i++)
            {
                dizi[i] = rnd.Next(0, 101);
                listBox.Items.Add(dizi[i]);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("  Random rnd = new Random();\nint[] dizi = new int[5];\nfor(int i = 0; i < 5; i++)\n{\ndizi[i] = rnd.Next(0, 101);\nlistBox.Items.Add(dizi[i]);\n}");
        }
    }
}
