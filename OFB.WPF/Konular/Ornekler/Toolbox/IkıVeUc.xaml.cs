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
    /// Interaction logic for IkıVeUc.xaml
    /// </summary>
    public partial class IkıVeUc : UserControl
    {
        public IkıVeUc()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 101);
            listBox.Items.Add(random);
            if (random % 2 == 0)
                listBox_Copy.Items.Add("Bölünebilir");
            else
                listBox_Copy.Items.Add("Bölünemez");
            if (random % 3 == 0)
                listBox_Copy1.Items.Add("Bölünebilir");
            else
                listBox_Copy1.Items.Add("Bölünemez");
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("Random rnd = new Random();\nint random = rnd.Next(0, 101);\nlistBox.Items.Add(random);\nif(random % 2 == 0)\nlistBox_Copy.Items.Add(\"Bölünebilir\");\nelse\nlistBox_Copy.Items.Add(\"Bölünemez\");\nif(random % 3 == 0)\nlistBox_Copy1.Items.Add(\"Bölünebilir\");\nelse\nlistBox_Copy1.Items.Add(\"Bölünemez\"); ");
        }
    }
}
