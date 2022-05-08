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

namespace OFB.WPF.Konular.Ornekler.IfElse
{
    /// <summary>
    /// Interaction logic for Cevirme.xaml
    /// </summary>
    public partial class Cevirme : UserControl
    {
        public Cevirme()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int puan = Convert.ToInt32(textBox.Text);
                if (puan >= 0 && puan < 50)
                    lblCikti.Content = "5'lik Puanınız: 1";
                else if (puan >= 50 && puan < 65)
                    lblCikti.Content = "5'lik Puanınız: 2";
                else if (puan >= 65 && puan < 75)
                    lblCikti.Content = "5'lik Puanınız: 3";
                else if (puan >= 75 && puan < 85)
                    lblCikti.Content = "5'lik Puanınız: 4";
                else if (puan >= 85 && puan < 101)
                    lblCikti.Content = "5'lik Puanınız: 5";
                else lblCikti.Content = "0-100 Arası sayı giriniz.";
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int puan = Convert.ToInt32(textBox.Text);\nif (puan >= 0 && puan < 50)\nlblCikti.Text = \"5'lik Puanınız: 1\";\nelse if (puan >= 50 && puan < 65)\nlblCikti.Text = \"5'lik Puanınız: 2\";\nelse if (puan >= 65 && puan < 75)\nlblCikti.Text = \"5'lik Puanınız: 3\";\nelse if (puan >= 75 && puan < 85)\nlblCikti.Text = \"5'lik Puanınız: 4\";\nelse if (puan >= 85 && puan < 101)\nlblCikti.Text = \"5'lik Puanınız: 5\";\nelse lblCikti.Text = \"0-100 Arası sayı giriniz.\"; ");
        }
    }
}
