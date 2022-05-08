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
    /// Interaction logic for DiziAylar.xaml
    /// </summary>
    public partial class DiziAylar : UserControl
    {
        public DiziAylar()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string[] ay = new string[] { "OCAK", "ŞUBAT",
"MART", "NİSAN", "MAYIS", "HAZİRAN", "TEMMUZ",
 "AĞUSTOS", "EYLÜL", "EKİM", "KASIM", "ARALIK" };
            for (int i = 0; i < ay.Length; i++)
            {
                listBox.Items.Add(ay[i]);
            }

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("string[] ay = new string[] { \"OCAK\", \"ŞUBAT\",\n\"MART\", \"NİSAN\", \"MAYIS\", \"HAZİRAN\", \"TEMMUZ\",\n\"AĞUSTOS\", \"EYLÜL\", \"EKİM\", \"KASIM\", \"ARALIK\" };\nfor(int i = 0; i < ay.Length; i++)\n{\nlistBox.Items.Add(ay[i]);\n}");
        }
    }
}
