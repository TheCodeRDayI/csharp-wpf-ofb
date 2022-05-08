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

namespace OFB.WPF.Programlar.LiveRadio
{
    /// <summary>
    /// Interaction logic for RadioFirstPage.xaml
    /// </summary>
    public partial class RadioFirstPage : Window
    {
        public RadioFirstPage()
        {
            InitializeComponent();
            SoundIsZero.Visibility = Visibility.Visible;
            SondZero.Visibility = Visibility.Hidden;


            richTextBox_Copy4.Document.Blocks.Clear();
            richTextBox_Copy4.Document.Blocks.Add(new Paragraph(new Run("• Radio'nun açılma süresi internetinize göre fark göstermektedir.")));
        }
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        void wClose()
        {
            _Window.Opacity = 1;
            Player.Stop();
            this.Close();

        }
        private void Window_Closed(object sender, EventArgs e)
        {
            wClose();

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }

        void RadyoPlay(string url)
        {
            try
            {
                Player.Stop();
                Player.Source = new Uri(url, UriKind.RelativeOrAbsolute);
                Player.Play();
            }
            catch (Exception ex)
            {
                saveURL = "";
                MessageBox.PopupCenter2Message.Show("hata", ex.Message);
            }
        }
        private double savedValue = 100;
        private string saveURL = "";
        private void RadyoName1_Click(object sender, RoutedEventArgs e)
        {
            saveURL = "http://fenomen.listenfenomen.com/fenomen/128/icecast.audio";
            RadyoPlay(saveURL);
        }
        private void RadyoName2_Click(object sender, RoutedEventArgs e)
        {
            Player.Stop();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Sliderr.Value != 0)
            {
                SoundIsZero.Visibility = Visibility.Visible;
                SondZero.Visibility = Visibility.Hidden;
                savedValue = Convert.ToDouble(Sliderr.Value);
                Player.Volume = savedValue;
                Player.Play();
            }
            else
            {
                SoundIsZero.Visibility = Visibility.Hidden;
                SondZero.Visibility = Visibility.Visible;
                savedValue = Convert.ToDouble(Sliderr.Value);
                Player.Volume = savedValue;
                Player.Play();
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Player.Stop();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            RadyoPlay(saveURL);
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            SoundIsZero.Visibility = Visibility.Hidden;
            SondZero.Visibility = Visibility.Visible;
            savedValue = 0;
            Sliderr.Value = 0;
            Player.Volume = savedValue;
            Player.Play();
        }

        private void SondZero_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SoundIsZero.Visibility = Visibility.Visible;
            SondZero.Visibility = Visibility.Hidden;
            savedValue = 150;
            Sliderr.Value = 150;
            Player.Volume = savedValue;
            Player.Play();
        }

        private void radyo2_Click(object sender, RoutedEventArgs e)
        {
            saveURL = "http://46.20.7.126/;stream.mp3";
            RadyoPlay(saveURL);
        }

        private void radyo3_Click(object sender, RoutedEventArgs e)
        {

            saveURL = "http://185.9.37.59:7966/;stream.mp3";
            RadyoPlay(saveURL);
        }

        private void radyo4_Click(object sender, RoutedEventArgs e)
        {
            saveURL = "http://fenomenturk.listenfenomen.com/fenomenturk/128/icecast.audio";
            RadyoPlay(saveURL);
        }

        private void radyo5_Click(object sender, RoutedEventArgs e)
        {
            saveURL = "http://37.247.98.8/stream/166/";
            RadyoPlay(saveURL);
        }

        private void radyo7_Click(object sender, RoutedEventArgs e)
        {
            saveURL = "https://www.youtube.com/watch?v=pl7YHMKeZgU";
            RadyoPlay(saveURL);
        }

        private void radyo7_Click_1(object sender, RoutedEventArgs e)
        {

            saveURL = "http://yayin2.canliyayin.org:7222/;";
            RadyoPlay(saveURL);
        }

        private void radyo8_Click(object sender, RoutedEventArgs e)
        {

            saveURL = "http://fenomenoriental.listenfenomen.com/fenomenrap/128/icecast.audio";
            RadyoPlay(saveURL);
        }

        private void radyo1_Click(object sender, RoutedEventArgs e)
        {
       
            saveURL = " http://powerturkeniyiler.listenpowerapp.com/powerturkeniyiler/mpeg/icecast.audio";
            RadyoPlay(saveURL);
        }
    }
}
