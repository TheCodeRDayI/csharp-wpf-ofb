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
    /// Interaction logic for Random8.xaml
    /// </summary>
    public partial class Random8 : UserControl
    {
        public Random8()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            Random rnd = new Random();
            int sayac = 0, randomsayimiz;
            do
            {
                randomsayimiz = rnd.Next(0, 50);
                sayac++;
                listBox.Items.Add(sayac + ") " + randomsayimiz);

            } while (randomsayimiz != 8);
            MessageBox.PopupCenterMessage.Show("Bulundu", "8 sayısı " + sayac + ". aşamada bulundu.");
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("listBox.Items.Clear();\nRandom rnd = new Random();\nint sayac = 0, randomsayimiz;\ndo\n{\nrandomsayimiz = rnd.Next(0, 50);\nsayac++;\nlistBox.Items.Add(sayac + \") \" + randomsayimiz);\n} while (randomsayimiz != 8) ;\nMessageBox.Show(\"Bulundu\", \"8 sayısı \" + sayac + \". aşamada bulundu.\"); ");
        }
    }
}
