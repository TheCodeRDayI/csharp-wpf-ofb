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
    /// Interaction logic for ForIleToplama.xaml
    /// </summary>
    public partial class ForIleToplama : UserControl
    {
        public ForIleToplama()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int top = 20;
                for (int i = 1; i <= 19; i++)
                {
                    lblCikti.Content += i.ToString() + "+";
                    top += i;
                }
                lblCikti.Content += "20 = " + (top + 20).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int top = 20;\nfor (int i = 1; i <= 19; i++)\n{\nlblCikti.Text += i.ToString() + \"+\";\ntop += i;\n}\nlblCikti.Text += \"20 = \" + (top + 20).ToString(); ");
        }
    }
}
