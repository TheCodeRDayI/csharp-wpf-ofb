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
    /// Interaction logic for Control_Oyunlar.xaml
    /// </summary>
    public partial class Control_Oyunlar : UserControl
    {
        public Control_Oyunlar()
        {
            InitializeComponent();
        }

        private void KOyunu(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            Oyunlar.KelimeOyunu.GameKelimeAnasayfa Git = new Oyunlar.KelimeOyunu.GameKelimeAnasayfa();
            Git.ShowDialog();

        }

        private void Snake(object sender, MouseButtonEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.4;
            Oyunlar.Snake.SnakeGame Git = new Oyunlar.Snake.SnakeGame();
            Git.ShowDialog();
        }
    }
}
