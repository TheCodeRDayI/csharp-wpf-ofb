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

namespace OFB.WPF.Konular.Ornekler.Class
{
    /// <summary>
    /// Interaction logic for DortIslem.xaml
    /// </summary>
    public partial class DortIslem : UserControl
    {
        public DortIslem()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double S1 = Convert.ToDouble(textBox.Text);
                double S2 = Convert.ToDouble(textBox_Copy.Text);
                Hesaplar Hesap = new Hesaplar();
                if (radioButton.IsChecked == true)
                    lblCikti.Content = Hesap.Topla(S1, S2).ToString();
                else if (radioButton_Copy.IsChecked == true)
                    lblCikti.Content = Hesap.Cikart(S1, S2).ToString();
                else if (radioButton_Copy1.IsChecked == true)
                    lblCikti.Content = Hesap.Carp(S1, S2).ToString();
                else if (radioButton_Copy2.IsChecked == true)
                    lblCikti.Content = Hesap.Bol(S1, S2).ToString();
                else MessageBox.PopupCenterMessage.Show("Hata", "Lütfen bir seçim yapınız!");
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("class Hesaplar\n{\npublic double Topla(double a, double b)\n{\nreturn a + b;\n}\npublic double Cikart(double a, double b)\n{\nreturn a - b;\n}\npublic double Carp(double a, double b)\n{\nreturn a * b;\n}\npublic double Bol(double a, double b)\n{\nreturn a / b;\n}\n} \n\n\n//Button Click\ndouble S1 = Convert.ToDouble(textBox.Text);\ndouble S2 = Convert.ToDouble(textBox_Copy.Text);\nHesaplar Hesap = new Hesaplar();\nif(radioButton.Checked)\nlblCikti.Text = Hesap.Topla(S1, S2).ToString();\nelse if (radioButton_Copy.Checked)\nlblCikti.Text = Hesap.Cikart(S1, S2).ToString();\nelse if (radioButton_Copy1.Checked)\nlblCikti.Text = Hesap.Carp(S1, S2).ToString();\nelse if (radioButton_Copy2.Checked)\nlblCikti.Text = Hesap.Bol(S1, S2).ToString();\nelse MessageBox.Show(\"Hata\", \"Lütfen bir seçim yapınız!\");");
        }
    }
    class Hesaplar
    {
        public double Topla(double a, double b)
        {
            return a + b;
        }
        public double Cikart(double a, double b)
        {
            return a - b;
        }
        public double Carp(double a, double b)
        {
            return a * b;
        }
        public double Bol(double a, double b)
        {
            return a / b;
        }
    }
}
