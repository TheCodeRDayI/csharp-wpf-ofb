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
    /// Interaction logic for IsimYazdirma.xaml
    /// </summary>
    public partial class IsimYazdirma : UserControl
    {
        public IsimYazdirma()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listBox.Items.Clear();
                int dongu = Convert.ToInt32(textBox_Copy.Text);
                for (int i = 1; i <= dongu; i++)
                {
                    listBox.Items.Add(i + ") " + textBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("listBox.Items.Clear();\nint dongu = Convert.ToInt32(textBox_Copy.Text);\nfor(int i = 1; i <= dongu; i++)\n{\nlistBox.Items.Add(i + \") \" + textBox.Text);\n}");
        }
    }
}
