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
    /// Interaction logic for UserLoginIslemi.xaml
    /// </summary>
    public partial class UserLoginIslemi : UserControl
    {
        public UserLoginIslemi()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBox.Text == "admin" && textBox_Copy.Text == "123456")
                    lblCikti.Content = "Başarıyla giriş yaptınız.";
                else
                    lblCikti.Content = "Hatalı giriş. Tekrar Deneyiniz.";
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata",ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("if (textBox.Text == \"admin\" && textBox_Copy.Text == \"123456\") \nlblCikti.Text = \"Başarıyla giriş yaptınız.\";\nelse\nlblCikti.Text = \"Hatalı giriş. Tekrar Deneyiniz.\"; ");
        }
    }
}
