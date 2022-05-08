using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for RakamRandom.xaml
    /// </summary>
    public partial class RakamRandom : UserControl
    {
        public RakamRandom()
        {
            InitializeComponent();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("//txtRakamEngel_KeyPress\ne.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);\n\n//txtHarfEngel_KeyPress\ne.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar); ");
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^\p{L}+$]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void textBox_Copy_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
