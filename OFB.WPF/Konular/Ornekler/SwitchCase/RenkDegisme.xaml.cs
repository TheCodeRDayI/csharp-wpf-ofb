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

namespace OFB.WPF.Konular.Ornekler.SwitchCase
{
    /// <summary>
    /// Interaction logic for RenkDegisme.xaml
    /// </summary>
    public partial class RenkDegisme : UserControl
    {
        public RenkDegisme()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (comboBox.SelectedIndex)
                {
                    case 0:
                        lblCikti.Foreground = new SolidColorBrush(Colors.Red); break;
                    case 1:
                        lblCikti.Foreground = new SolidColorBrush(Colors.Yellow); break;
                    case 2:
                        lblCikti.Foreground = new SolidColorBrush(Colors.Blue); break;
                    case 3:
                        lblCikti.Foreground = new SolidColorBrush(Colors.Orange); break;
                    case 4:
                        lblCikti.Foreground = new SolidColorBrush(Colors.Green); break;
                    case 5:
                        lblCikti.Foreground = new SolidColorBrush(Colors.Silver); break;
                    case 6:
                        lblCikti.Foreground = new SolidColorBrush(Colors.White); break;
                    case 7:
                        lblCikti.Foreground = new SolidColorBrush(Colors.Pink); break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("switch (comboBox.SelectedIndex)\n{\ncase 0:\nlblCikti.Foreground = new Color.Red; break;\ncase 1:\nlblCikti.Foreground = new Color.Yellow; break;\ncase 2:\nlblCikti.Foreground = new Color.Blue; break;\ncase 3:\nlblCikti.Foreground = new Color.Orange; break;\ncase 4:\nlblCikti.Foreground = new Color.Green; break;\ncase 5:\nlblCikti.Foreground = new Color.Silver; break;\ncase 6:\nlblCikti.Foreground = new Color.White; break;\ncase 7:\nlblCikti.Foreground = new Color.Pink; break;\ndefault:\nbreak;\n}");
        }
    }
}
