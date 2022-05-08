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
    /// Interaction logic for Toplama.xaml
    /// </summary>
    public partial class Toplama : UserControl
    {
        public Toplama()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox.Text);
                int toplam = 0;
                int kosul = 1;
                while (kosul <= sayi)
                {
                    toplam += kosul;
                    kosul++;
                }
                lblCikti.Content = "Toplam: " + toplam.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int sayi = Convert.ToInt32(textBox.Text);\nint toplam = 0;\nint kosul = 1;\nwhile(kosul <= sayi)\n{\ntoplam += kosul;\nkosul++;\n}\nlblCikti.Text = \"Toplam: \" + toplam.ToString(); ");
        }
    }
}
