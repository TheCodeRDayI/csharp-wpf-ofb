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

namespace OFB.WPF.Konular.Ornekler.Events
{
    /// <summary>
    /// Interaction logic for MouseHoverForm.xaml
    /// </summary>
    public partial class MouseHoverForm : UserControl
    {
        public MouseHoverForm()
        {
            InitializeComponent();
        }

        private void label_Copy_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.DarkGray;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("//label1_MouseHover        \nthis.BackColor = Color.IndianRed;\n\n//label1_MouseLeave       \nthis.BackColor = Color.LightGray;");
        }

        private void label_Copy_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(34, 36, 49));
        }
    }
}
