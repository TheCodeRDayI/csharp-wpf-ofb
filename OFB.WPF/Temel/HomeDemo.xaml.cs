using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
using static OFB.Data.Araclar.UserControlCagir;

namespace OFB.WPF.Temel
{
    /// <summary>
    /// Interaction logic for HomeDemo.xaml
    /// </summary>
    public partial class HomeDemo : Window
    {
        public HomeDemo()
        {
            InitializeComponent();

            try
            {
                UserControlAdd(Content_Icerik, new UserControls.Control_Anasayfa());

                btnkonular.IsEnabled = false;
                btnoyunlar.IsEnabled = false;
                btnprogramlar.IsEnabled = false;
                btnyonetici.IsEnabled = false;

                //Data.Kullanici.KullaniciInfo.K_AD = "TEST";
                //Data.Kullanici.KullaniciInfo.K_SOYAD = "BETA";
                //Data.Kullanici.KullaniciInfo.K_ADI = "Test";
                //Data.Kullanici.KullaniciInfo.K_EPOSTA = "test@gmail.com";
                //Data.Kullanici.KullaniciInfo.K_TC = "11111111111";

                btnkonular.Opacity = btnoyunlar.Opacity = btnprogramlar.Opacity = btnyonetici.Opacity = 0.5;

                var _Admin = Data.Kullanici.KullaniciInfo.IsAdmin;
                var _KonuOrnek = Data.Kullanici.KullaniciInfo.IsKonuOrnek;
                var _Programlar = Data.Kullanici.KullaniciInfo.IsProgramlar;
                var _Oyunlar = Data.Kullanici.KullaniciInfo.IsOyunlar;
                var _Login = Data.Kullanici.KullaniciInfo.IsNoLogin;


                if (_Admin == "True")
                {
                    btnkonular.IsEnabled = true;
                    btnoyunlar.IsEnabled = true;
                    btnprogramlar.IsEnabled = true;
                    btnyonetici.IsEnabled = true;
                    btnkonular.Opacity = btnoyunlar.Opacity = btnprogramlar.Opacity = btnyonetici.Opacity = 1;
                }
                else
                {
                    if (_KonuOrnek == "True")
                    {
                        btnkonular.IsEnabled = true;
                        btnkonular.Opacity = 1;
                    }
                    if (_Programlar == "True")
                    {
                        btnprogramlar.IsEnabled = true;
                        btnprogramlar.Opacity = 1;
                    }
                    if (_Oyunlar == "True")
                    {
                        btnoyunlar.IsEnabled = true;
                        btnoyunlar.Opacity = 1;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenter2Message.Show("hata", ex.Message);
            }

            if (Data.Kullanici.KullaniciInfo.IsNoLogin != "True") { 
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();
            }else
            {
                btnbilgilerupdate.IsEnabled = false;
                btnbilgilerupdate.Opacity = .5;
            }

        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            if (await Data.Araclar.InternetKontrol.KontrolEt() == false)
            {
                timer.Stop();
                MessageBox.PopupCenter2Message.Show("internet bağlantısı", "İnternet bağlantınız kesildiği için programdan atıldınız. İnternet bağlantınızı kontrol ettikden sonra programa tekrar erişim sağlayınız.");
                Temel.ExitNoNet exit = new ExitNoNet();

            }
        }

        DispatcherTimer timer = new DispatcherTimer();
        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Temel.Exit exit = new Exit();

        }

        private void btnAltal_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void lblVersiyon_MouseEnter(object sender, MouseEventArgs e)
        {
            lblVersiyon.Opacity = 1;
        }

        private void lblVersiyon_MouseLeave(object sender, MouseEventArgs e)
        {
            lblVersiyon.Opacity = 0.6;
        }

        private void facebook_MouseEnter(object sender, MouseEventArgs e)
        {
            facebook.Opacity = 1;
        }

        private void facebook_MouseLeave(object sender, MouseEventArgs e)
        {
            facebook.Opacity = 0.9;
        }

        private void instagram_MouseEnter(object sender, MouseEventArgs e)
        {
            instagram.Opacity = 1;
        }

        private void instagram_MouseLeave(object sender, MouseEventArgs e)
        {
            instagram.Opacity = 0.9;
        }

        private void google_plus_MouseEnter(object sender, MouseEventArgs e)
        {
            google_plus.Opacity = 1;
        }

        private void google_plus_MouseLeave(object sender, MouseEventArgs e)
        {
            google_plus.Opacity = 0.9;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }



        private void Quesion_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        byte a = 0;
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            a++;
            if (a == 1)
            {
                GridLength grdl = new GridLength(60, GridUnitType.Pixel);
                GrdSlider.Width = grdl;

                lblbilgiler.Visibility = lblIletisim.Visibility = lblkonular.Visibility = lbloyunlar.Visibility = lblprogramlar.Visibility = Visibility.Hidden;

                imgHome.Width = 50;
                facebook.Visibility = instagram.Visibility = google_plus.Visibility = Visibility.Hidden;

                borderversiyon.Visibility = Visibility.Hidden;
            }
            else
            {
                a = 0;

                GridLength grdl = new GridLength(220, GridUnitType.Pixel);
                GrdSlider.Width = grdl;

                lblbilgiler.Visibility = lblIletisim.Visibility = lblkonular.Visibility = lbloyunlar.Visibility = lblprogramlar.Visibility = Visibility.Visible;

                imgHome.Width = 160;
                facebook.Visibility = instagram.Visibility = google_plus.Visibility = Visibility.Visible;

                borderversiyon.Visibility = Visibility.Visible;
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserControlAdd(Content_Icerik, new UserControls.Control_Anasayfa());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserControlAdd(Content_Icerik, new UserControls.Control_Konular());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UserControlAdd(Content_Icerik, new UserControls.Control_Oyunlar());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UserControlAdd(Content_Icerik, new UserControls.Control_Programlar());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            UserControlAdd(Content_Icerik, new UserControls.Control_YoneticiIslem());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            UserControlAdd(Content_Icerik, new UserControls.Control_BilgileriGuncelle());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            UserControlAdd(Content_Icerik, new UserControls.Control_Iletisim());
        }

        private void Quesion_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            UserControlAdd(Content_Icerik, new UserControls.Control_Anasayfa_Quesion());
        }

        MessageBox.PopupLoading _load = new MessageBox.PopupLoading(2);
        private void instagram_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://api.whatsapp.com/send?phone=905372991322&text=Merhaba,%20Sizinle%20%C4%B0leti%C5%9Fime%20Ge%C3%A7mem%20Laz%C4%B1m%20Musait%20Misiniz%20?");
            _load.ShowDialog();
        }

        private void facebook_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100011437907665");
            _load.ShowDialog();
        }

        private void google_plus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://mrgamingtr.com");
            _load.ShowDialog();
        }

        private void lblVersiyon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.PopupCenterMessage.Show("Versiyon Bilgisi", "Programın versiyonu: " + lblVersiyon.Content + "\nProgram versiyonunu güncel tutunuz. Aksi taktirde yeniliklerden uzak kalıcaksınız.");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Hide();
            Temel.Exit exxit = new Exit();

        }



        private void TEST_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

            MessageBox.PopupCenterMessage.Show("TEST", "Birinci Bilgilendirme Mesajı");
            MessageBox.PopupCenter2Message.Show("TEST", "İkinci Bilgilendirme Mesajı");
            MessageBox.PopupOutputMessage.Show("Üçüncü Bilgilendirme Mesajı", MessageBox.PopupOutputMessage.AlertType.success, 3);
            //    MessageBox.PopupOutputMessage.Show("Hiçbir sorun gözükmemektedir.", MessageBox.PopupOutputMessage.AlertType.error, 3);
            //     MessageBox.PopupOutputMessage.Show("Hiçbir sorun gözükmemektedir.", MessageBox.PopupOutputMessage.AlertType.info, 3);
            //    MessageBox.PopupOutputMessage.Show("Hiçbir sorun gözükmemektedir.", MessageBox.PopupOutputMessage.AlertType.warnig, 3);
            MessageBox.PopupResultMessage.Show("TEST", "Dörtüncü Bilgilendirme Mesajı");
            if (MessageBox.PopupResultMessage.ResultYesOrNo == true)
            {
                MessageBox.PopupCenterMessage.Show("TEST", "Evet Basıldı");
            }
            else
            {
                MessageBox.PopupCenterMessage.Show("TEST", "Hayır Basıldı");
            }

        }


        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void Noti_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //notification

        }

        private void lblNotiStatus_MouseEnter(object sender, MouseEventArgs e)
        {
            lblNotiStatus.Opacity = 1;
        }

        private void lblNotiStatus_MouseLeave(object sender, MouseEventArgs e)
        {
            lblNotiStatus.Opacity = 0.7;
        }
    }
}
