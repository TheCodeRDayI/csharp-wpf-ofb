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
    /// Interaction logic for OgrenciIndirim.xaml
    /// </summary>
    public partial class OgrenciIndirim : UserControl
    {
        public OgrenciIndirim()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double fiyat = Convert.ToDouble(textBox.Text);
                if (checkBox_Copy1.IsChecked == true)
                {
                    double indirim = fiyat;
                    indirim /= 100;
                    indirim *= 15;
                    listBox.Items.Add("Ücretiniz: " + (fiyat-indirim));
                }
                else
                {
                    listBox.Items.Add("Ücretiniz: " + fiyat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("double fiyat = Convert.ToDouble(textBox.Text);\nif(checkBox1.Checked == true)\n{\ndouble indirim = fiyat;\nindirim /= 100;\nindirim *= 15;\nlistBox.Items.Add(\"Ücretiniz: \" + (fiyat - indirim));\n}\nelse\n{\nlistBox.Items.Add(\"Ücretiniz: \" + fiyat);\n}");
        }
    }
}
