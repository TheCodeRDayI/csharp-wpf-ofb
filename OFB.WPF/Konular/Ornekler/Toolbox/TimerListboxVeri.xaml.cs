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
using System.Windows.Threading;

namespace OFB.WPF.Konular.Ornekler.Toolbox
{
    /// <summary>
    /// Interaction logic for TimerListboxVeri.xaml
    /// </summary>
    public partial class TimerListboxVeri : UserControl
    {
        public TimerListboxVeri()
        {
            InitializeComponent();
        }

        DispatcherTimer timer = new DispatcherTimer();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick1; ;
            timer.Start();
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            listBox.Items.Add(textBox.Text);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("//Button Click \n{\ntimer1.Enabled = true;\n}\n//Form Load\n{\ntimer1.Interval = 1000;\n}\n//Timer \n{\nlistBox1.Items.Add(textBox1.Text);\n}");
        }
    }
}
