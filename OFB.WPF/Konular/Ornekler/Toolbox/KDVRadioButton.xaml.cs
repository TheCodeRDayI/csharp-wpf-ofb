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

namespace OFB.WPF.Konular.Ornekler.Toolbox
{
    /// <summary>
    /// Interaction logic for KDVRadioButton.xaml
    /// </summary>
    public partial class KDVRadioButton : UserControl
    {
        public KDVRadioButton()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double ucret = Convert.ToDouble(textBox.Text);
                if (radioButton.IsChecked == true)
                    lblCikti.Content = "Son Fiyat: " + (ucret + (ucret * 8 / 100)).ToString();
                else if (radioButton_Copy1.IsChecked == true)
                    lblCikti.Content = "Son Fiyat: " + (ucret + (ucret * 18 / 100)).ToString();
                else
                    lblCikti.Content = "Son Fiyat: " + ucret.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("radioButton.Checked == true)\nlblCikti.Text = \"Son Fiyat: \" + (ucret + (ucret * 8 / 100)).ToString();\nelse if (radioButton_Copy1.Checked == true)\nlblCikti.Text = \"Son Fiyat: \" + (ucret + (ucret * 18 / 100)).ToString();\nelse\nlblCikti.Text = \"Son Fiyat: \" + ucret.ToString();");
            
        }
    }
}
