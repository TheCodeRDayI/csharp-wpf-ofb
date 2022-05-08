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

namespace OFB.WPF.Konular.Ornekler.For
{
    /// <summary>
    /// Interaction logic for Alfabe.xaml
    /// </summary>
    public partial class Alfabe : UserControl
    {
        public Alfabe()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                listBox.Items.Add(i);
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            listBox_Copy.Items.Clear();
            for (char i = 'Z'; i >= 'A'; i--)
            {
                listBox_Copy.Items.Add(i);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("//A'dan Z'ye \n\nlistBox.Items.Clear();\nfor (char i = 'A'; i <= 'Z'; i++)\n{\nlistBox.Items.Add(i);\n} \n\n//Z'den A'ya \n\n\nlistBox_Copy.Items.Clear();\nfor(char i = 'Z'; i >= 'A'; i--)\n{\nlistBox_Copy.Items.Add(i);\n}");
        }
    }
}
