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

namespace OFB.WPF.Konular.Ozetler.OzetKontrol
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
           Konular.Ozetler.Degiskenler send = new Konular.Ozetler.Degiskenler();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.IfElse send = new Konular.Ozetler.IfElse();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.SwitchCase send = new Konular.Ozetler.SwitchCase();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void label2_Copy1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.For send = new Konular.Ozetler.For();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonUp_3(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.While send = new Konular.Ozetler.While();
            _Window.Opacity = 0.4;
            send.ShowDialog();

        }

        private void label2_Copy3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.DoWhile send = new Konular.Ozetler.DoWhile();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonUp_4(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.TryCatchFinally send = new Konular.Ozetler.TryCatchFinally();
            _Window.Opacity = 0.4;
            send.ShowDialog();

        }

        private void StackPanel_MouseLeftButtonUp_5(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.ToolBox send = new Konular.Ozetler.ToolBox();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonUp_6(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.Metot send = new Konular.Ozetler.Metot();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonUp_7(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler._Class send = new Konular.Ozetler._Class();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void label2_Copy7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler._Diziler send = new Konular.Ozetler._Diziler();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void label2_Copy8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.Kalitim send = new Konular.Ozetler.Kalitim();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void StackPanel_MouseLeftButtonUp_8(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler._Interface send = new Konular.Ozetler._Interface();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void label2_Copy10_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler.Temsilci send = new Konular.Ozetler.Temsilci();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }

        private void label2_Copy11_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            Konular.Ozetler._Events send = new Konular.Ozetler._Events();
            _Window.Opacity = 0.4;
            send.ShowDialog();
        }
    }
}
