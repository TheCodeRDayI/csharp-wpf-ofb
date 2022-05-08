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
    /// Interaction logic for BuyukHarf.xaml
    /// </summary>
    public partial class BuyukHarf : UserControl
    {
        public BuyukHarf()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MyDelegate dg = new MyDelegate(Buyult);
            lblCikti.Content= dg(textBox.Text);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("delegate string MyDelegate(string veri);\nstring Buyult(string a)\n{\nreturn a.ToUpper();\n}\n\n\n//Button Click\nMyDelegate dg = new MyDelegate(Buyult);\nlblCikti.Text = dg(textBox.Text);");
        }
        delegate string MyDelegate(string veri);
        string Buyult(string a)
        {
            return a.ToUpper();
        }
    }
}
