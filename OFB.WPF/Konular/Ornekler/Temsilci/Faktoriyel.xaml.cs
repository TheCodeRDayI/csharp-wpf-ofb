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

namespace OFB.WPF.Konular.Ornekler.Temsilci
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyDelegate dg = new MyDelegate(Hesapla);
                lblCikti.Content = "Cevap: "+dg(Convert.ToInt32(textBox.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("delegate int MyDelegate(int a);\nint Hesapla(int sayi)\n{\nint f = 1;\nfor(int i = 1; i <= sayi; i++)\n{\nf *= i;\n}\nreturn f;\n}\n\n\n//Button Click\nMyDelegate dg = new MyDelegate(Hesapla);\nlblCikti.Text = \"Cevap: \" + dg(Convert.ToInt32(textBox.Text)).ToString();");
        }
        delegate int MyDelegate(int a);
        int Hesapla(int sayi)
        {
            int f = 1;
            for (int i = 1; i <= sayi; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}
