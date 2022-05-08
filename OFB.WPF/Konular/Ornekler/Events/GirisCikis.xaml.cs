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

namespace OFB.WPF.Konular.Ornekler.Events
{
    /// <summary>
    /// Interaction logic for GirisCikis.xaml
    /// </summary>
    public partial class GirisCikis : UserControl
    {
        public GirisCikis()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.PopupCenterMessage.Show("Hoşgeldin", "Merhaba, Programa Hoşgeldiniz!");
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("//FromLoad Event\nMessageBox.Show(\"Hoşgeldin\", \"Merhaba, Programa Hoşgeldiniz!\"); ");
        }
    }
}
