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
    /// Interaction logic for TimerKronometre.xaml
    /// </summary>
    public partial class TimerKronometre : UserControl
    {
        public TimerKronometre()
        {
            InitializeComponent();
            textBox.Text = "0";
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick1; ;
        }
        DispatcherTimer timer = new DispatcherTimer();
        int Sayac = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
        private void Timer_Tick1(object sender, EventArgs e)
        {
            Sayac++;
            textBox.Text = Sayac.ToString();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(Sayac);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int sayac = 0;\n//Timer\nSayac++;\ntextBox.Text = Sayac.ToString();\n\n//Start Button Click\ntimer.Start();\n\n//Stop Button Click\ntimer.Stop();\n\n//Tur Button Click\nlistBox.Items.Add(Sayac);");
        }
    }
}
