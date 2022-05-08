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
using System.Windows.Threading;

namespace OFB.WPF.MessageBox
{
    /// <summary>
    /// Interaction logic for PopupLoadingNoTime.xaml
    /// </summary>
    public partial class PopupLoadingNoTime : Window
    {
        public PopupLoadingNoTime()
        {
            InitializeComponent();

            this.Height = System.Windows.SystemParameters.VirtualScreenHeight;
            this.Width = System.Windows.SystemParameters.VirtualScreenWidth;


          
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
       
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        public static void Loading(int Time)
        {
            new PopupLoadingNoTime().Show();
        }
    }
}
