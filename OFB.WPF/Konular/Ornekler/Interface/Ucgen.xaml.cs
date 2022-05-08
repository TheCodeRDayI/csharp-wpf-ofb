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
    /// Interaction logic for Ucgen.xaml
    /// </summary>
    public partial class Ucgen : UserControl
    {
        public Ucgen()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ThisIsMyClass sinif = new ThisIsMyClass();
                sinif.s1 = Convert.ToInt32(textBox.Text);
                sinif.s2 = Convert.ToInt32(textBox_Copy.Text);
                lblCikti.Content = "3. Açı: " + sinif.Bul().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata",ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("public interface Iucgen\n{\nint s1 { get; set; }\nint s2 { get; set; }\n}\nclass ThisIsMyClass : Iucgen\n{\nint S1, S2;\npublic int s1\n{\nset { S1 = value; }\nget { return S1; }\n}\npublic int s2\n{\nset { S2 = value; }\nget { return S2; }\n}\npublic int Bul()\n{\nreturn 180 - (S1 + S2);\n}\n}\n\n\n//Button Click\nThisIsMyClass sinif = new ThisIsMyClass();\nsinif.s1 = Convert.ToInt32(textBox.Text);\nsinif.s2 = Convert.ToInt32(textBox_Copy.Text);\nlblCikti.Text = \"3. Açı: \" + sinif.Bul().ToString();");

    }
    }
    public interface Iucgen
    {
        int s1 { get; set; }
        int s2 { get; set; }
    }
    class ThisIsMyClass : Iucgen
    {
        int S1, S2;
        public int s1
        {
            set { S1 = value; }
            get { return S1; }
        }
        public int s2
        {
            set { S2 = value; }
            get { return S2; }
        }
        public int Bul()
        {
            return 180 - (S1 + S2);
        }
    }
}
