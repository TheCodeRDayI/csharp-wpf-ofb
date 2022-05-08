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
    /// Interaction logic for DortIslemRadiobutton.xaml
    /// </summary>
    public partial class DortIslemRadiobutton : UserControl
    {
        public DortIslemRadiobutton()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double s1 = Convert.ToDouble(textBox.Text);
                double s2 = Convert.ToDouble(textBox_Copy.Text);
                double Sonuc = 0;
                if (radioButton.IsChecked == true)
                    Sonuc = s1 + s2;
                else if (radioButton_Copy.IsChecked == true)
                    Sonuc = s1 - s2;
                else if (radioButton_Copy1.IsChecked == true)
                    Sonuc = s1 * s2;
                else if (radioButton_Copy2.IsChecked == true)
                    Sonuc = s1 / s2;
                else
                    MessageBox.PopupCenterMessage.Show("Hata", "Lütfen bir işlem seçiniz!");
                lblCikti.Content = Sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("double s1 = Convert.ToDouble(textBox.Text);\ndouble s2 = Convert.ToDouble(textBox_Copy.Text);\ndouble Sonuc = 0;\nif(radioButton.Checked  == true)\nSonuc = s1 + s2;\nelse if (radioButton_Copy.Checked  == true)\nSonuc = s1 - s2;\nelse if (radioButton_Copy1.Checked  == true)\nSonuc = s1 * s2;\nelse if (radioButton_Copy2.Checked  == true)\nSonuc = s1 / s2;\nelse\nMessageBox.Show(\"Hata\", \"Lütfen bir işlem seçiniz!\");\nlblCikti.Text = Sonuc.ToString(); ");
        }
    }
}
