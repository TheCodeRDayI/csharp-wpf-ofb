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
    /// Interaction logic for DegerYollama.xaml
    /// </summary>
    public partial class DegerYollama : UserControl
    {
        public DegerYollama()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MyClass _Class = new MyClass();
            _Class.Ad = textBox.Text;
            _Class.Soyad = textBox_Copy.Text;
            _Class.Yas = textBox_Copy1.Text;
            _Class.Duzenle();
            listBox.Items.Add(_Class.Yeni);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("class MyClass\n{\npublic string Ad;\npublic string Soyad;\npublic string Yas;\npublic string Yeni;\npublic void Duzenle()\n{\nYeni = \"Adınız: \" + Ad + \" Soyadınız: \" + Soyad + \" Yaşınız: \" + Yas;\n}\n}\n\n\n//Button Click\nMyClass _Class = new MyClass();\n_Class.Ad = textBox.Text;\n_Class.Soyad = textBox_Copy.Text;\n_Class.Yas = textBox_Copy1.Text;\n_Class.Duzenle();\nlistBox.Items.Add(_Class.Yeni); ");
        }
    }
    class MyClass
    {
        public string Ad;
        public string Soyad;
        public string Yas;
        public string Yeni;

        public void Duzenle()
        {
            Yeni = "Adınız: " + Ad + " Soyadınız: " + Soyad + " Yaşınız: " + Yas;
        }
    }
}
