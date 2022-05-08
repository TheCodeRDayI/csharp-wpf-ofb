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

namespace OFB.WPF.Konular.Ornekler.Baslangic
{
    /// <summary>
    /// Interaction logic for SayininKaresi.xaml
    /// </summary>
    public partial class SayininKaresi : UserControl
    {
        public SayininKaresi()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox.Text);
                lblCikti.Content ="Sayınızın Karesi: "+ (sayi * sayi).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata",ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int sayi = Convert.ToInt32(textBox.Text);\n \nlblCikti.text = \"Sayınızın Karesi: \" + (sayi * sayi).ToString(); ");
        }
    }
}
