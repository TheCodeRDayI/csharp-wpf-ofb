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
    /// Interaction logic for SayiTekCift.xaml
    /// </summary>
    public partial class SayiTekCift : UserControl
    {
        public SayiTekCift()
        {
            InitializeComponent();
        }

        private void SayiDurum(int gelenSayi)
        {
            listBox.Items.Clear();
            if (gelenSayi % 2 == 0)
                listBox.Items.Add("Sayınız Çift");
            else
                listBox.Items.Add("Sayınız Tek");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SayiDurum(Convert.ToInt32(textBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("private void SayiDurum(int gelenSayi)\n{\nlistBox.Items.Clear();\nif(gelenSayi % 2 == 0)\nlistBox.Items.Add(\"Sayınız Çift\");\nelse\nlistBox.Items.Add(\"Sayınız Tek\");\n}\n\n\n//Button Click\nSayiDurum(Convert.ToInt32(textBox.Text));");
        }
    }
}
