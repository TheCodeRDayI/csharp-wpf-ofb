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

namespace OFB.WPF.Konular.Ornekler.For
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
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int faktoriyel = 1;\nint sayi = Convert.ToInt32(textBox.Text);\nfor(int i = 1; i <= sayi; i++)\n{\nfaktoriyel *= i;\n}\nlblCikti.Text = sayi.ToString() + \"! = \" + faktoriyel.ToString(); ");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int faktoriyel = 1;
                int sayi = Convert.ToInt32(textBox.Text);
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i;
                }
                lblCikti.Content = sayi.ToString() + "! = " + faktoriyel.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }
    }
}
