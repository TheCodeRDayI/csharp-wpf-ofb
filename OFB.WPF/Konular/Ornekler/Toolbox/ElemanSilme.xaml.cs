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
    /// Interaction logic for ElemanSilme.xaml
    /// </summary>
    public partial class ElemanSilme : UserControl
    {
        public ElemanSilme()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("merhaba");
            listBox.Items.Add("beni siler misin");
            listBox.Items.Add("1881");
            listBox.Items.Add("visual studio");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Remove(textBox.Text);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("listBox.Items.Remove(textBox.Text);");
        }
    }
}
