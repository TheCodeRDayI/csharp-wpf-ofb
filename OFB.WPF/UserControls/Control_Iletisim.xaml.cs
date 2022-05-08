using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace OFB.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Control_Iletisim.xaml
    /// </summary>
    public partial class Control_Iletisim : UserControl
    {
        public Control_Iletisim()
        {
            InitializeComponent();
        }

        private void label_Copy5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.PopupLoading _load = new MessageBox.PopupLoading(2);
            Process.Start("https://www.mrgamingtr.com");
            _load.ShowDialog();
        }
    }
    
}
