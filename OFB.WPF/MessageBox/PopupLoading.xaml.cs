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
    /// Interaction logic for PopupLoading.xaml
    /// </summary>
    public partial class PopupLoading : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public PopupLoading(int TimeSeconds)
        {
            InitializeComponent();

            this.Height = System.Windows.SystemParameters.VirtualScreenHeight;
            this.Width = System.Windows.SystemParameters.VirtualScreenWidth;



            timer.Interval = TimeSpan.FromSeconds(TimeSeconds);
            timer.Tick += Timer_Tick;
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        public static void Loading(int Time)
        {
            new PopupLoading(Time).Show();
        }
    }
}
