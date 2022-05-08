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
    /// Interaction logic for SayininKuvveti.xaml
    /// </summary>
    public partial class SayininKuvveti : UserControl
    {
        public SayininKuvveti()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox.Text);
                int kuvvet = Convert.ToInt32(textBox_Copy.Text);
                int sonuc = 1;
                for (int i = 1; i <= kuvvet; i++)
                {
                    sonuc *= sayi;
                }
                lblCikti.Content = "Sonuç: " + sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int sayi = Convert.ToInt32(textBox.Text);\nint kuvvet = Convert.ToInt32(textBox_Copy.Text);\nint sonuc = 1;\nfor(int i = 1; i <= kuvvet; i++)\n{\nsonuc *= sayi;\n}\nlblCikti.Text = \"Sonuç: \" + sonuc.ToString(); ");
        }
    }
}
