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
    /// Interaction logic for PopupCenterMessage.xaml
    /// </summary>
    public partial class PopupCenterMessage : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public PopupCenterMessage(string title, string message)
        {
            InitializeComponent();

            this.Opacity = 0.6;
            timer.Interval = TimeSpan.FromMilliseconds(TimerInterval);
            timer.Tick += Timer_Tick;
            timer.Start();

            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(title)));

            richTextBox_Copy.Document.Blocks.Clear();
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run(message)));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerInterval += 100;
            if (TimerInterval >= 400)
            {
           
                timer.Stop();
            }
            this.Opacity += 0.1;


        }
        int TimerInterval = 100;

        private void thisWindowClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public static void Show(string _title, string _message)
        {
            new PopupCenterMessage(_title.ToUpper(), _message).ShowDialog();
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void lblVersiyon_MouseLeave(object sender, MouseEventArgs e)
        {
            lblVersiyon.Opacity = 0.6;
        }

        private void lblVersiyon_MouseEnter(object sender, MouseEventArgs e)
        {
            lblVersiyon.Opacity = 1;
        }

        private void lblVersiyon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
