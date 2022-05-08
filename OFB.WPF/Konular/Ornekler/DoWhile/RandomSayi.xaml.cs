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

namespace OFB.WPF.Konular.Ornekler.DoWhile
{
    /// <summary>
    /// Interaction logic for RandomSayi.xaml
    /// </summary>
    public partial class RandomSayi : UserControl
    {
        public RandomSayi()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            bool durum = false;
            do
            {
                MessageBox.PopupResultMessage.Show("DoWhile Ders", "Sayı Üretilsin Mi ?");
                if (MessageBox.PopupResultMessage.ResultYesOrNo == true) listBox.Items.Add(rnd.Next(0, 999));
                else durum = true;
            } while (durum == false);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("Random rnd = new Random();\nDialogResult soru;\ndo\n{\nsoru = MessageBox.Show(\"Sayı Üretilsin Mi?\", \"\", MessageBoxButtons.YesNo);\nif(soru == DialogResult.Yes)\n{\nlistBox1.Items.Add(rnd.Next(50, 500));\n}\n} while (soru == DialogResult.Yes); ");
        }
    }
}
