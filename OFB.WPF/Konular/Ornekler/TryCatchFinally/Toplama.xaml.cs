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

namespace OFB.WPF.Konular.Ornekler.TryCatchFinally
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
                int sayi1 = Convert.ToInt32(textBox.Text);
                int sayi2 = Convert.ToInt32(textBox_Copy.Text);
                lblCikti.Content = "Toplam: " + (sayi1 + sayi2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
            finally
            {
                textBox.Text = "";
                textBox_Copy.Text = "";
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("try\n{\nint sayi1 = Convert.ToInt32(textBox.Text);\nint sayi2 = Convert.ToInt32(textBox_Copy.Text);\nlblCikti.Text = \"Toplam: \" + (sayi1 + sayi2).ToString();\n}\ncatch(Exception ex)\n{\nMessageBox.Show(\"Hata\", ex.Message);\n}\nfinally\n{\ntextBox.Text = \"\";\ntextBox_Copy.Text = \"\";\n}");
        }
    }
}
