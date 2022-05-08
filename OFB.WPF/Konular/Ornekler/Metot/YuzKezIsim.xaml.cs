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

namespace OFB.WPF.Konular.Ornekler.Metot
{
    /// <summary>
    /// Interaction logic for YuzKezIsim.xaml
    /// </summary>
    public partial class YuzKezIsim : UserControl
    {
        public YuzKezIsim()
        {
            InitializeComponent();
        }

        private void Yazdir()
        {
            for (int i = 1; i < 101; i++)
            {
                listBox.Items.Add(i + ") " + textBox.Text);
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Yazdir();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("private void Yazdir()\n{\nfor(int i = 1; i < 101; i++)\n{\nlistBox.Items.Add(i + \") \" + textBox.Text);\n}\n}\n\n\n//Button Click \nYazdir();");
        }
    }
}
