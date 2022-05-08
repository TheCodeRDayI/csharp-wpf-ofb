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

namespace OFB.WPF.Konular.Ornekler.While
{
    /// <summary>
    /// Interaction logic for Aralikli.xaml
    /// </summary>
    public partial class Aralikli : UserControl
    {
        public Aralikli()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listBox.Items.Clear();
                int aralik = Convert.ToInt32(textBox.Text);
                int kosul = 0;
                while (kosul <= 100)
                {
                    listBox.Items.Add(kosul);
                    kosul += aralik;
                }
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("listBox.Items.Clear();\nint aralik = Convert.ToInt32(textBox.Text);\nint kosul = 0;\nwhile(kosul <= 100)\n{\nlistBox.Items.Add(kosul);\nkosul += aralik;\n}");
        }
    }
}
