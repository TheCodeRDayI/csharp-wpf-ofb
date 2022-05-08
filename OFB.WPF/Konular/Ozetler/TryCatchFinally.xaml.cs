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
using System.Windows.Shapes;

namespace OFB.WPF.Konular.Ozetler
{
    /// <summary>
    /// Interaction logic for TryCatchFinally.xaml
    /// </summary>
    public partial class TryCatchFinally : Window
    {
        public TryCatchFinally()
        {
            InitializeComponent();
        }
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void wClose()
        {
            _Window.Opacity = 1;
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            wClose();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void thisWindowClose_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }
    }
}
