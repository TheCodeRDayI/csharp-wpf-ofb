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

namespace OFB.WPF.Konular.Ornekler.Interface
{
    /// <summary>
    /// Interaction logic for IkiSayiOrtalama.xaml
    /// </summary>
    public partial class IkiSayiOrtalama : UserControl
    {
        public IkiSayiOrtalama()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrtalamaClass sinif = new OrtalamaClass();
                lblCikti.Content = sinif.ortalama(Convert.ToInt32(textBox.Text), Convert.ToInt32(textBox_Copy.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("public interface Iort\n{\nint ortalama(int a, int b);\n}\nclass OrtalamaClass : Iort\n{\npublic int ortalama(int a, int b)\n{\nreturn(a + b) / 2;\n}\n}\n\n\n//Button Click\nOrtalamaClass sinif = new OrtalamaClass();\nlblCikti.Text = sinif.ortalama(Convert.ToInt32(textBox.Text), Convert.ToInt32(textBox_Copy.Text)).ToString();");

        }
    }

    public interface Iort
    {
        int ortalama(int a, int b);
    }
    class OrtalamaClass : Iort
    {
        public int ortalama(int a, int b)
        {
            return (a + b) / 2;
        }

    }
}
