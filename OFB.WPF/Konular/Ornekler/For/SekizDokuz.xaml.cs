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
    /// Interaction logic for SekizDokuz.xaml
    /// </summary>
    public partial class SekizDokuz : UserControl
    {
        public SekizDokuz()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int aralik1 = Convert.ToInt32(textBox.Text);
                int aralik2 = Convert.ToInt32(textBox_Copy.Text);
                for (int i = aralik1; i < aralik2; i++)
                {
                    if (i % 8 == 0 && i % 9 == 0)
                    {
                        listBox.Items.Add(i);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int aralik1 = Convert.ToInt32(textBox.Text);\nint aralik2 = Convert.ToInt32(textBox_Copy.Text);\nfor(int i = aralik1; i < aralik2; i++)\n{\nif(i % 8 == 0 && i % 9 == 0)\n{\nlistBox.Items.Add(i);\n}\n}");
        }
    }
}
