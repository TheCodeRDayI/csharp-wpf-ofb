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
    /// Interaction logic for PopupOutputMessage.xaml
    /// </summary>
    public partial class PopupOutputMessage : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer2 = new DispatcherTimer();
        DispatcherTimer timer3 = new DispatcherTimer();

        public PopupOutputMessage(string message, AlertType type, int Time)
        {
            InitializeComponent();


            Topmost = true;
            this.Top = 0;
            this.Left = SystemParameters.PrimaryScreenWidth - this.Width - 10;

            timer.Interval = TimeSpan.FromSeconds(Time);
            timer.Tick += Timer_Tick;

            timer2.Interval = TimeSpan.FromMilliseconds(50);
            timer2.Start();
            timer2.Tick += Timer2_Tick;

            timer3.Interval = TimeSpan.FromMilliseconds(40);
            timer3.Tick += Timer3_Tick;

            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(message)));

            switch (type)
            {
                case AlertType.success:
                    image_info.Visibility = Visibility.Hidden;
                    image_error.Visibility = Visibility.Hidden;
                    image_warning.Visibility = Visibility.Hidden;
                    image_success.Visibility = Visibility.Visible;
                    this.Background = new SolidColorBrush(Color.FromRgb(40, 167, 69));
                    break;
                case AlertType.info:
                    image_info.Visibility = Visibility.Visible;
                    image_error.Visibility = Visibility.Hidden;
                    image_warning.Visibility = Visibility.Hidden;
                    image_success.Visibility = Visibility.Hidden;
                    this.Background = new SolidColorBrush(Color.FromRgb(08, 117, 125));

                    break;
                case AlertType.warnig:
                    image_info.Visibility = Visibility.Hidden;
                    image_error.Visibility = Visibility.Hidden;
                    image_warning.Visibility = Visibility.Visible;
                    image_success.Visibility = Visibility.Hidden;
                    this.Background = new SolidColorBrush(Color.FromRgb(255, 193, 7));

                    break;
                case AlertType.error:
                    image_info.Visibility = Visibility.Hidden;
                    image_error.Visibility = Visibility.Visible;
                    image_warning.Visibility = Visibility.Hidden;
                    image_success.Visibility = Visibility.Hidden;
                    this.Background = new SolidColorBrush(Color.FromRgb(220, 53, 69));

                    break;

            }
        }
        int interval = 0;
        //close
        private void Timer3_Tick(object sender, EventArgs e)
        {

            if (this.Top < 15)
            {
                this.Close();
                timer3.Stop();

            }
            else
            {
                interval -= 2;
                this.Top -= interval;
                this.Opacity -= 0.1;
            }
        }

        //show
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (this.Top < 50)
            {
                interval += 2;
                this.Top += interval;
                this.Opacity += 0.1;

            }
            else
            {
                timer2.Stop();
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //timer işlem
            timer.Stop();
            timer3.Start();
        }

  

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        void AnimeteFormShow()
        {

        }

        public enum AlertType
        {
            success,
            info,
            warnig,
            error
        }
        public static void Show(string _message, AlertType _type, int Time)
        {
            new PopupOutputMessage(_message, _type, Time).Show();
        }

       

        private void TEST2_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
