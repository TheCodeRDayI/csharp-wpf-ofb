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
    /// Interaction logic for CheckUrunToplama.xaml
    /// </summary>
    public partial class CheckUrunToplama : UserControl
    {
        public CheckUrunToplama()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int toplam = 0;
                if (checkBox.IsChecked == true)
                    toplam += 1;
                if (checkBox_Copy.IsChecked == true)
                    toplam += 1;
                if (checkBox_Copy1.IsChecked == true)
                    toplam += 4;
                if (checkBox_Copy2.IsChecked == true)
                    toplam += 3;

                listBox.Items.Add("Toplam Tutar: "+toplam);


            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int toplam = 0;\nif(checkBox1.Checked)\n{\ntoplam += 1;\n}\nif(checkBox2.Checked)\n{\ntoplam += 1;\n}\nif(checkBox3.Checked)\n{\ntoplam += 4;\n}\nif(checkBox4.Checked)\n{\ntoplam += 3;\n}\nlistBox1.Items.Add(\"Toplam: \"+toplam);");
        }
    }
}
