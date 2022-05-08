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

namespace OFB.WPF.Konular.Ornekler.While
{
    /// <summary>
    /// Interaction logic for Faktoriyel.xaml
    /// </summary>
    public partial class Faktoriyel : UserControl
    {
        public Faktoriyel()
        {
            InitializeComponent();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int sayi = Convert.ToInt32(textBox.Text);\nint whilekosul = 1, faktoriyel = 1;\nwhile(whilekosul <= sayi)\n{\nfaktoriyel *= whilekosul;\nwhilekosul++;\n}\nlblCikti.Text = sayi + \"! = \" + faktoriyel.ToString(); ");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox.Text);
                int whilekosul = 1, faktoriyel = 1;
                while (whilekosul <= sayi)
                {
                    faktoriyel *= whilekosul;
                    whilekosul++;
                }
                lblCikti.Content = sayi + "! = " + faktoriyel.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }
    }
}
