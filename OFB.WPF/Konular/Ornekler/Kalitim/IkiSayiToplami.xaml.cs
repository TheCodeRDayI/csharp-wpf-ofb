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

namespace OFB.WPF.Konular.Ornekler.Kalitim
{
    /// <summary>
    /// Interaction logic for IkiSayiToplami.xaml
    /// </summary>
    public partial class IkiSayiToplami : UserControl
    {
        public IkiSayiToplami()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToplamaClass myClass = new ToplamaClass();
                myClass._Sayi1 = Convert.ToInt32(textBox.Text);
                myClass._Sayi2 = Convert.ToInt32(textBox_Copy.Text);
                lblCikti.Content = "Sayılarınızın Toplamı: " + myClass.Toplama().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("class TemelClass\n{\nint sayi1, sayi2;\npublic int _Sayi1\n{\nset { sayi1 = value; }\nget { return sayi1; }\n}\npublic int _Sayi2\n{\nset { sayi2 = value; }\nget { return sayi2; }\n}\n}\nclass ToplamaClass : TemelClass\n{\npublic int Toplama()\n{\nreturn _Sayi1 + _Sayi2;\n}\n}\n\n\n//Button Click\nToplamaClass myClass = new ToplamaClass();\nmyClass._Sayi1 = Convert.ToInt32(textBox.Text);\nmyClass._Sayi2 = Convert.ToInt32(textBox_Copy.Text);\nlblCikti.Text = \"Sayılarınızın Toplamı: \" + myClass.Toplama().ToString();");
        }
    }
    class TemelClass
    {
        int sayi1, sayi2;
        public int _Sayi1
        {
            set { sayi1 = value; }
            get { return sayi1; }
        }
        public int _Sayi2
        {
            set { sayi2 = value; }
            get { return sayi2; }
        }
    }
    class ToplamaClass : TemelClass
    {
        public int Toplama()
        {
            return _Sayi1 + _Sayi2;
        }
    }
}
