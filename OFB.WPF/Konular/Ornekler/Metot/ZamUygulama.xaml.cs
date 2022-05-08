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
    /// Interaction logic for ZamUygulama.xaml
    /// </summary>
    public partial class ZamUygulama : UserControl
    {
        public ZamUygulama()
        {
            InitializeComponent();
        }
        private int Gel(int x)
        {
            int y = (2000 * x) / 100;
            return y;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("private int Gel(int x)\n{\nint y = (2000 * x) / 100;\nreturn y;\n}\n\n\n//Button Click\nlblCikti.Text = \"Zamlı fiyatı: \" + (2000 + Gel(Convert.ToInt32(textBox.Text))).ToString();");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblCikti.Content = "Zamlı fiyatı: " + (2000 + Gel(Convert.ToInt32(textBox.Text))).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("HATA",ex.Message);
            }
        }
    }
}
