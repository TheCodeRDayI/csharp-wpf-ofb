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

namespace OFB.WPF.Konular.Ornekler.Dizi
{
    /// <summary>
    /// Interaction logic for TerseCevir.xaml
    /// </summary>
    public partial class TerseCevir : UserControl
    {
        public TerseCevir()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            lblCikti.Content = "";
            for (int i = textBox.Text.Length - 1; i >= 0; i--)
            {
                lblCikti.Content += textBox.Text[i].ToString();
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("lblCikti.Text = \"\";\nfor (int i = textBox.Text.Length - 1; i >= 0; i--)\n{\nlblCikti.Text += textBox.Text[i].ToString();\n}");
        }
    }
}
