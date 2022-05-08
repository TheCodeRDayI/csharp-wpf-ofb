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
    /// Interaction logic for Control_YoneticiIslem.xaml
    /// </summary>
    public partial class Control_YoneticiIslem : UserControl
    {
        public Control_YoneticiIslem()
        {
            InitializeComponent();
        }


        private void Kullanicilar(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            YoneticiIslem.KullaniciList yonetimk = new YoneticiIslem.KullaniciList();
            yonetimk.ShowDialog();

        }



        private void log(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            YoneticiIslem.ProgramLogs yonetimk = new YoneticiIslem.ProgramLogs();
            yonetimk.ShowDialog();
        }

        private void KullaniciAdd(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            YoneticiIslem.UserAddAndDelete yonetimk = new YoneticiIslem.UserAddAndDelete();
            yonetimk.ShowDialog();
        }

        private void UpdateUser(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            YoneticiIslem.UserGuncelleAndSearch yonetimk = new YoneticiIslem.UserGuncelleAndSearch();
            yonetimk.ShowDialog();
        }

        private void UserPerm(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            YoneticiIslem.UserPerms yonetimk = new YoneticiIslem.UserPerms();
            yonetimk.ShowDialog();
        }

        private void userBlock(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            YoneticiIslem.userBlock yonetimk = new YoneticiIslem.userBlock();
            yonetimk.ShowDialog();
        }
    }
}
