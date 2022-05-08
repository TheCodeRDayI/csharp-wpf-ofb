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

namespace OFB.WPF.Konular.Ornekler.Metot
{
    /// <summary>
    /// Interaction logic for WhoMax.xaml
    /// </summary>
    public partial class WhoMax : UserControl
    {
        public WhoMax()
        {
            InitializeComponent();
        }

        private void WhoNumberMax(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
                lblCikti.Content = sayi1 + " büyüktür";
            else if (sayi2 > sayi1)
                lblCikti.Content = sayi2 + " büyüktür";
            else
                lblCikti.Content = "Sayılar eşittir";
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WhoNumberMax(Convert.ToInt32(textBox.Text), Convert.ToInt32(textBox_Copy.Text));
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("private void WhoNumberMax(int sayi1, int sayi2)\n{\nif(sayi1 > sayi2)\nlblCikti.Text = sayi1 + \" büyüktür\";\nelse if (sayi2 > sayi1)\nlblCikti.Text = sayi2 + \" büyüktür\";\nelse\nlblCikti.Text = \"Sayılar eşittir\";\n}\n\n\n//Button Click\nWhoNumberMax(Convert.ToInt32(textBox.Text), Convert.ToInt32(textBox_Copy.Text));");
        }
    }
}
