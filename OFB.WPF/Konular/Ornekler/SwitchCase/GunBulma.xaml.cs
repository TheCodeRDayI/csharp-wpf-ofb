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
    /// Interaction logic for GunBulma.xaml
    /// </summary>
    public partial class GunBulma : UserControl
    {
        public GunBulma()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int gun = (int)DateTime.Now.DayOfWeek;
                switch (gun)
                {
                    case 1:
                        lblCikti.Content = "Bugün Pazartesi";
                        break;
                    case 2:
                        lblCikti.Content = "Bugün Salı";
                        break;
                    case 3:
                        lblCikti.Content = "Bugün Çarşamba";
                        break;
                    case 4:
                        lblCikti.Content = "Bugün Perşembe";
                        break;
                    case 5:
                        lblCikti.Content = "Bugün Cuma";
                        break;
                    case 6:
                        lblCikti.Content = "Bugün Cumartesi";
                        break;
                    case 7:
                        lblCikti.Content = "Bugün Pazar";
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("switch (gun)\n{\ncase 1: lblCikti.Text = \"Bugün Pazartesi\";\nbreak;\ncase 2: lblCikti.Text = \"Bugün Salı\";\nbreak;\ncase 3: lblCikti.Text = \"Bugün Çarşamba\";\nbreak;\ncase 4: lblCikti.Text = \"Bugün Perşembe\";\nbreak;\ncase 5: lblCikti.Text = \"Bugün Cuma\";\nbreak;\ncase 6: lblCikti.Text = \"Bugün Cumartesi\";\nbreak;\ncase 7: lblCikti.Text = \"Bugün Pazar\";\nbreak;\n}");
        }
    }
}
