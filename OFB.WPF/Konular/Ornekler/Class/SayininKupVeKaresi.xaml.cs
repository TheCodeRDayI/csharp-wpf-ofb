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

namespace OFB.WPF.Konular.Ornekler.Class
{
    /// <summary>
    /// Interaction logic for SayininKupVeKaresi.xaml
    /// </summary>
    public partial class SayininKupVeKaresi : UserControl
    {
        public SayininKupVeKaresi()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int yourNumber = Convert.ToInt32(textBox.Text);
                Sayilar sayi = new Sayilar();
                lblCikti.Content = "Sayının Karesi: " + sayi.kare(yourNumber).ToString() + " - Sayının Küpü: " + sayi.kup(yourNumber).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata",ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("class Sayilar\n{\npublic int kare(int x)\n{\nreturn x * x;\n}\npublic int kup(int y)\n{\nreturn y * y * y;\n}\n}\n\n\n//Button Click\nint yourNumber = Convert.ToInt32(textBox.Text);\nSayilar sayi = new Sayilar();\nlblCikti.Text = \"Sayının Karesi: \" + sayi.kare(yourNumber).ToString() + \" - Sayının Küpü: \" + sayi.kup(yourNumber).ToString();");
        }
    }
    class Sayilar
    {
        public int kare(int x)
        {
            return x * x;
        }
        public int kup(int y)
        {
            return y * y * y;
        }
    }
}
