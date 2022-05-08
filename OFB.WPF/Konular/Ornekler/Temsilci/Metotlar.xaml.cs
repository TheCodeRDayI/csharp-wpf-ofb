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

namespace OFB.WPF.Konular.Ornekler.Temsilci
{
    /// <summary>
    /// Interaction logic for Metotlar.xaml
    /// </summary>
    public partial class Metotlar : UserControl
    {
        public Metotlar()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MyDelegate dg = new MyDelegate(Test1);
            //2. Bir Yöntem -> MyDelegate md = Test1;
            dg += Test2;
            dg += Test3;
            dg("Merhaba, Bu metotda delegate kullanıldı.");
        }
        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("delegate void MyDelegate(string a);\nvoid Test1(string a)\n{\nMessageBox.Show(\"Test1 Metot\", a);\n}\nvoid Test2(string a)\n{\nMessageBox.Show(\"Test2 Metot\", a);\n}\nvoid Test3(string a)\n{\nMessageBox.Show(\"Test3 Metot\", a);\n}\n\n\n//Button Click\nMyDelegate dg = new MyDelegate(Test1);\n//2. Bir Yöntem -> MyDelegate md = Test1;\ndg += Test2;\ndg += Test3;\ndg(\"Merhaba, Bu metotda delegate kullanıldı.\");");

        }





        delegate void MyDelegate(string a);
        void Test1(string a)
        {
            MessageBox.PopupCenterMessage.Show("Test1 Metot", a);
        }
        void Test2(string a)
        {
            MessageBox.PopupCenterMessage.Show("Test2 Metot", a);
        }
        void Test3(string a)
        {
            MessageBox.PopupCenterMessage.Show("Test3 Metot", a);
        }
    }
}
