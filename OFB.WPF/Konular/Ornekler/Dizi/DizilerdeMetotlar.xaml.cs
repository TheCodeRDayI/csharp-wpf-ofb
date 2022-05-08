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

namespace OFB.WPF.Konular.Ornekler.Dizi
{
    /// <summary>
    /// Interaction logic for DizilerdeMetotlar.xaml
    /// </summary>
    public partial class DizilerdeMetotlar : UserControl
    {
        public DizilerdeMetotlar()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            listBox_Copy.Items.Clear();
            listBox_Copy1.Items.Clear();
            Random rnd = new Random();
            int[] Sayi = new int[10];
            int rastgele;
            for (int i = 0; i < 10; i++)
            {
                rastgele = rnd.Next(0, 101);
                listBox.Items.Add(rastgele);
                Sayi[i] = rastgele;
            }
            Array.Sort(Sayi);
            for (int i = 0; i < 10; i++)
            {
                listBox_Copy.Items.Add(Sayi[i]);
            }
            Array.Reverse(Sayi);
            for (int i = 0; i < 10; i++)
            {
                listBox_Copy1.Items.Add(Sayi[i]);
            }
            lblMax.Content = "Max Eleman: "+Sayi.Max().ToString();
            lblMin.Content = "Min Eleman: " + Sayi.Min().ToString();
            lblToplam.Content = "Elemanlar Toplamı: " + Sayi.Sum().ToString();
            lblIlk.Content = "Ters Çevrilmiş İlk Eleman: " + Sayi.First().ToString();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("listBox.Items.Clear();\nlistBox_Copy.Items.Clear();\nlistBox_Copy1.Items.Clear();\nRandom rnd = new Random();\nint[] Sayi = new int[10];\nint rastgele;\nfor(int i = 0; i < 10; i++)\n{\nrastgele = rnd.Next(0, 101);\nlistBox.Items.Add(rastgele);\nSayi[i] = rastgele;\n}\nArray.Sort(Sayi);\nfor(int i = 0; i < 10; i++)\n{\nlistBox_Copy.Items.Add(Sayi[i]);\n}\nArray.Reverse(Sayi);\nfor(int i = 0; i < 10; i++)\n{\nlistBox_Copy1.Items.Add(Sayi[i]);\n}\nlblMax.Text = \"Max Eleman: \" + Sayi.Max().ToString();\nlblMin.Text = \"Min Eleman: \" + Sayi.Min().ToString();\nlblToplam.Text = \"Elemanlar Toplamı: \" + Sayi.Sum().ToString();\nlblIlk.Text = \"Ters Çevrilmiş İlk Eleman: \" + Sayi.First().ToString();");
        }
    }
}
