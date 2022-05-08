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

namespace OFB.WPF.Konular.Ornekler.IfElse
{
    /// <summary>
    /// Interaction logic for SayiNegatifPozitif.xaml
    /// </summary>
    public partial class SayiNegatifPozitif : UserControl
    {
        public SayiNegatifPozitif()
        {
            InitializeComponent();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            //kod
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int sayi = Convert.ToInt32(textBox.Text);\nif(sayi > 0) lblCikti.Text = \"Sayınız Pozitif\";\nelse if (sayi < 0) lblCikti.Text = \"Sayınız Negatif\";\nelse lblCikti.Text = \"Sayınız Tanımsız\"; ");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox.Text);
                if (sayi > 0) lblCikti.Content = "Sayınız Pozitif";
                else if (sayi < 0) lblCikti.Content = "Sayınız Negatif";
                else lblCikti.Content = "Sayınız Tanımsız";
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata",ex.Message);
            }
        }
    }
}
