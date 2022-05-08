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

namespace OFB.WPF.Konular.Ornekler.Events
{
    /// <summary>
    /// Interaction logic for TextboxChange.xaml
    /// </summary>
    public partial class TextboxChange : UserControl
    {
        public TextboxChange()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblCikti.Content = textBox.Text;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("private void textBox_TextChanged(object sender, TextChangedEventArgs e)\n{\nlblCikti.Text = textBox.Text;\n}\n");
        }
    }
}
