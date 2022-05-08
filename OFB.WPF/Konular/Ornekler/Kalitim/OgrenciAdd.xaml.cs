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
    /// Interaction logic for OgrenciAdd.xaml
    /// </summary>
    public partial class OgrenciAdd : UserControl
    {
        public OgrenciAdd()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VeriCekSinif veriler = new VeriCekSinif();
                veriler._ad = textBox.Text;
                veriler._soyad = textBox_Copy.Text;
                veriler._yas = textBox_Copy1.Text;
                veriler._meslek = textBox_Copy2.Text;
                listBox.Items.Add(veriler.Birlestir().ToString());

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("class MyDefaultClass\n{\nstring ad, soyad, yas, meslek;\npublic string _ad\n{\nset { ad = value; }\nget { return ad; }\n}\npublic string _soyad\n{\nset { soyad = value; }\nget { return soyad; }\n}\npublic string _yas\n{\nset { yas = value; }\nget { return yas; }\n}\npublic string _meslek\n{\nset { meslek = value; }\nget { return meslek; }\n}\n}\nclass VeriCekSinif : MyDefaultClass\n{\npublic string Birlestir()\n{\nreturn \"Ad: \" + _ad + \" Soyad: \" + _soyad + \" Yaş: \" + _yas + \" Meslek: \" + _meslek;\n}\n}\n\n\n//Button Click\nVeriCekSinif veriler = new VeriCekSinif();\nveriler._ad = textBox.Text;\nveriler._soyad = textBox_Copy.Text;\nveriler._yas = textBox_Copy1.Text;\nveriler._meslek = textBox_Copy2.Text;\nlistBox.Items.Add(veriler.Birlestir().ToString());");
        }
    }
    class MyDefaultClass
    {
        string ad, soyad, yas, meslek;
        public string _ad
        {
            set { ad = value; }
            get { return ad; }
        }
        public string _soyad
        {
            set { soyad = value; }
            get { return soyad; }
        }
        public string _yas
        {
            set { yas = value; }
            get { return yas; }
        }
        public string _meslek
        {
            set { meslek = value; }
            get { return meslek; }
        }
    }
    class VeriCekSinif : MyDefaultClass
    {
        public string Birlestir()
        {
            return "Ad: " + _ad + " Soyad: " + _soyad + " Yaş: " + _yas + " Meslek: " + _meslek;
        }
    }
}
