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
    /// Interaction logic for AlanCevre.xaml
    /// </summary>
    public partial class AlanCevre : UserControl
    {
        public AlanCevre()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Hesaplama islem = new Hesaplama();
                islem._Kisa = Convert.ToInt32(textBox.Text);
                islem._Uzun = Convert.ToInt32(textBox_Copy.Text);
                lblCikti.Content = "Alan: " + islem.Alan().ToString() + " - Çevre: " + islem.Cevre().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("class HesaplamaTemel\n{\nint kisa;\nint uzun;\npublic int _Kisa\n{\nset { kisa = value; }\nget { return kisa; }\n}\npublic int _Uzun\n{\nset { uzun = value; }\nget { return uzun; }\n}\n}\nclass Hesaplama : HesaplamaTemel\n{\npublic int Alan()\n{\nreturn _Uzun * _Kisa;\n}\npublic int Cevre()\n{\nreturn 2 * (_Uzun + _Kisa);\n}\n}\n\n\n//Button Click\nHesaplama islem = new Hesaplama();\nislem._Kisa = Convert.ToInt32(textBox.Text);\nislem._Uzun = Convert.ToInt32(textBox_Copy.Text);\nlblCikti.Text = \"Alan: \" + islem.Alan().ToString() + \" - Çevre: \" + islem.Cevre().ToString();");

        }
    }
    class HesaplamaTemel
    {
        int kisa;
        int uzun;
        public int _Kisa
        {
            set { kisa = value; }
            get { return kisa; }
        }
        public int _Uzun
        {
            set { uzun = value; }
            get { return uzun; }
        }

    }
    class Hesaplama : HesaplamaTemel
    {
        public int Alan()
        {
            return _Uzun * _Kisa;
        }
        public int Cevre()
        {
            return 2 * (_Uzun + _Kisa);
        }
    }
}
