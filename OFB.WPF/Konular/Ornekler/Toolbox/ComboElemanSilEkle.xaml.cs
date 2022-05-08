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

namespace OFB.WPF.Konular.Ornekler.Toolbox
{
    /// <summary>
    /// Interaction logic for ComboElemanSilEkle.xaml
    /// </summary>
    public partial class ComboElemanSilEkle : UserControl
    {
        public ComboElemanSilEkle()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Add(textBox.Text);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Clear();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("//Add Button \n\ncomboBox.Items.Add(textBox.Text);\n\n\n//Clear Button\n\ncomboBox.Items.Clear();");
        }
    }
}
