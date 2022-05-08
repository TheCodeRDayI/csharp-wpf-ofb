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
    /// Interaction logic for UcgeninDurumu.xaml
    /// </summary>
    public partial class UcgeninDurumu : UserControl
    {
        public UcgeninDurumu()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            UcgeninDurumClass _UcgenClass = new UcgeninDurumClass();
            lblCikti.Content = _UcgenClass.Durum(Convert.ToInt32(textBox.Text), Convert.ToInt32(textBox_Copy.Text), Convert.ToInt32(textBox_Copy1.Text)).ToString();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("class UcgeninDurumClass\n{\npublic string Durum(int a, int b, int c)\n{\nstring ReturnMessage;\nif(a == b && b == c && a == c) ReturnMessage = \"Eşkenar Üçgen\";\nelse if (a != b && b != c && a != c) ReturnMessage = \"Çokgen Üçgen\";\nelse ReturnMessage = \"İkizkenar Üçgen\";\nreturn ReturnMessage;\n}\n}\n\n\n//Button Click\nUcgeninDurumClass _UcgenClass = new UcgeninDurumClass();\nlblCikti.Text = _UcgenClass.Durum(Convert.ToInt32(textBox.Text), Convert.ToInt32(textBox_Copy.Text), Convert.ToInt32(textBox_Copy1.Text)).ToString(); ");
        }
    }
    class UcgeninDurumClass
    {
        public string Durum(int a, int b, int c)
        {
            string ReturnMessage;
            if (a == b && b == c && a == c) ReturnMessage = "Eşkenar Üçgen";
            else if (a != b && b != c && a != c) ReturnMessage = "Çokgen Üçgen";
            else ReturnMessage = "İkizkenar Üçgen";
            return ReturnMessage;
        }
    }
}
