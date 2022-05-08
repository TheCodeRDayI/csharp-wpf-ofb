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

namespace OFB.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Control_Programlar.xaml
    /// </summary>
    public partial class Control_Programlar : UserControl
    {
        public Control_Programlar()
        {
            InitializeComponent();
        }

        private void mail(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Programlar.MailSender.EmailSend send = new Programlar.MailSender.EmailSend();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }


        private void radyo(object sender, MouseButtonEventArgs e)
        {

            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Programlar.LiveRadio.RadioFirstPage send = new Programlar.LiveRadio.RadioFirstPage();
            _Window.Opacity = 0.4;
            send.ShowDialog();

        }



        private void webcam_(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            Programlar.WebCam_.WebCamera send = new Programlar.WebCam_.WebCamera();
            send.ShowDialog();
        }

        private void qr_(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            Programlar.QRCode_Olusturucu.QRCode_Create_ send = new Programlar.QRCode_Olusturucu.QRCode_Create_();
            send.ShowDialog();
        }

        private void doviz(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            Programlar.DovizListesi.Dovizler send = new Programlar.DovizListesi.Dovizler();
            send.ShowDialog();
        }
    }
}
