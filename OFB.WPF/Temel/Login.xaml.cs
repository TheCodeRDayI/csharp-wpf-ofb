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
using MySql.Data.MySqlClient;
using OFB.Data;
using System.Threading;

namespace OFB.WPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox_Copy2.Text = Data.Araclar.StringKodUret.Uret(4);

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Temel.ExitNoNet s = new Temel.ExitNoNet();
        }


        private Task GirisYap()
        {
            return Task.Run(() =>
            {
                using (Baglanti.Baglanti())
                {
                    using (MySqlCommand komut = new MySqlCommand("select * from ofb_kullanicilar where K_Adi='" + K_Adi_Login + "' and K_Sifre='" + K_Sifre_Login + "'", Baglanti.Baglanti()))
                    {
                        komut.Connection.Open();
                        using (MySqlDataReader dr = komut.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MySqlCommand cmd9 = new MySqlCommand("select K_Ban from ofb_kullanicilar where K_Adi ='" + K_Adi_Login + "'", Baglanti.Baglanti());
                                cmd9.Connection.Open();
                                K_Ban = cmd9.ExecuteScalar().ToString();
                                cmd9.Connection.Close();

                                if (K_Ban == "False" || K_Ban == "false")
                                {


                                    MySqlCommand cmd10 = new MySqlCommand("update ofb_kullanicilar SET K_Online='" + true + "' where K_Adi='" + K_Adi_Login + "'", Baglanti.Baglanti());
                                    cmd10.Connection.Open();
                                    cmd10.ExecuteNonQuery();
                                    cmd10.Connection.Close();



                                    {
                                        MySqlCommand UserRegister = new MySqlCommand("select * from ofb_kullanicilar where K_Adi='" + K_Adi_Login + "'", Baglanti.Baglanti());
                                        UserRegister.Connection.Open();
                                        MySqlDataReader Dr = UserRegister.ExecuteReader();
                                        while (Dr.Read())
                                        {
                                            Data.Kullanici.KullaniciInfo.K_ID = Dr[0].ToString();
                                            Data.Kullanici.KullaniciInfo.K_AD = Dr[1].ToString();
                                            Data.Kullanici.KullaniciInfo.K_SOYAD = Dr[2].ToString();
                                            Data.Kullanici.KullaniciInfo.K_ADI = Dr[3].ToString();
                                            Data.Kullanici.KullaniciInfo.K_PW = Dr[4].ToString();
                                            Data.Kullanici.KullaniciInfo.K_TC = Dr[5].ToString();
                                            Data.Kullanici.KullaniciInfo.K_EPOSTA = Dr[6].ToString();
                                            Data.Kullanici.KullaniciInfo.K_KAYITTarih = Dr[9].ToString();
                                            Data.Kullanici.KullaniciInfo.K_SONGIRIS = Dr[10].ToString();
                                        }
                                        UserRegister.Connection.Close();
                                    }
                                    {
                                        MySqlCommand UserRegister = new MySqlCommand("select * from ofb_kullaniciyetkileri where K_Adi='" + K_Adi_Login + "'", Baglanti.Baglanti());
                                        UserRegister.Connection.Open();
                                        MySqlDataReader Dr = UserRegister.ExecuteReader();
                                        while (Dr.Read())
                                        {
                                            Data.Kullanici.KullaniciInfo.IsAdmin = Dr[2].ToString();
                                            Data.Kullanici.KullaniciInfo.IsKonuOrnek = Dr[3].ToString();
                                            Data.Kullanici.KullaniciInfo.IsProgramlar = Dr[4].ToString();
                                            Data.Kullanici.KullaniciInfo.IsOyunlar = Dr[5].ToString();
                                        }
                                        UserRegister.Connection.Close();
                                    }


                                    #region SonGırıs
                                    MySqlCommand cmd11 = new MySqlCommand("Update ofb_kullanicilar set SonGiris='" + DateTime.Now + "' where K_Adi='" + Data.Kullanici.KullaniciInfo.K_ADI + "'", Baglanti.Baglanti());
                                    cmd11.Connection.Open();
                                    cmd11.ExecuteNonQuery();
                                    cmd11.Connection.Close();
                                    #endregion


                                }
                                else
                                {
                                    UserBan = true;
                                }

                                Giris = true;
                            }
                            else
                            {
                                Giris = false;

                            }
                        }
                        komut.Connection.Close();
                    }
                }
            });
        }

        bool UserBan = false;
        private async void button_Click(object sender, RoutedEventArgs e)//Giris Yap Button
        {
            try
            {
                if (await OFB.Data.Araclar.InternetKontrol.KontrolEt() == false)
                {
                    MessageBox.PopupCenter2Message.Show("hata", "İnternet Bağlantınız Bulunmamaktadır. Programı Kullanabilmek İçin İnternet Bağlantınız Olmalıdır.");
                }
                else
                {
                    K_Adi_Login = textBox.Text.Trim();
                    K_Sifre_Login = Data.Araclar.ConvertPassToSymbol.Gizle(passwordBox.Password.Trim());


                    if (textBox.Text != "Kullanıcı Adınız" && passwordBox.Password != "Şifreniz" && textBox.Text != "" && passwordBox.Password != "")
                    {
                        if (textBox_Copy1.Text == textBox_Copy2.Text)
                        {

                            try
                            {
                                _load.Show();
                                await GirisYap();
                                if (Giris == true)
                                {
                                    if (UserBan == false)
                                    {
                                        Temel.HomeDemo s = new Temel.HomeDemo();
                                        s.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        textBox_Copy2.Text = Data.Araclar.StringKodUret.Uret(4);
                                        MessageBox.PopupCenter2Message.Show("Ban", "Yönetici Sizi Programdan Uzaklaştırdığı İçin Programa Giriş Sağlıyamıyorsunuz. Yöneticiyle İletişime Geçiniz.");
                                    }

                                }
                                else
                                {
                                    MessageBox.PopupCenter2Message.Show("hata", "Kullanıcı Adınız ve/veya şifreniz yanlış. Tekrar Deneyiniz.");
                                    textBox_Copy2.Text = Data.Araclar.StringKodUret.Uret(4);

                                }
                                _load.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.PopupCenterMessage.Show("HATA", ex.Message);
                                _load.Hide();
                            }



                        }
                        else
                        {
                            MessageBox.PopupCenter2Message.Show("Hata", "Lütfen güvenlik kodunuz doğru giriniz.");
                            textBox_Copy2.Text = Data.Araclar.StringKodUret.Uret(4);

                        }
                    }
                    else
                    {


                        MessageBox.PopupCenter2Message.Show("Hata!", "Lütfen tüm alanları doldurunuz.");
                        textBox_Copy2.Text = Data.Araclar.StringKodUret.Uret(4);
                    }





                }
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenter2Message.Show("hata", ex.Message);
                _load.Hide();
            }



        }


        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Temel.ExitNoNet exitt = new Temel.ExitNoNet();

        }


        public string K_Ban, K_Adi_Login, K_Sifre_Login;
        bool Giris = false;
        MessageBox.PopupLoadingNoTime _load = new MessageBox.PopupLoadingNoTime();

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Kullanıcı Adınız";
                textBox.Foreground = Brushes.Silver;
                textBox.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "Kullanıcı Adınız")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                textBox.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));

            }
        }

        private void textBox_Copy_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "Şifreniz")
            {
                passwordBox.Password = "";
                passwordBox.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                passwordBox.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));

            }
        }

        private void textBox_Copy_LostFocus(object sender, RoutedEventArgs e)
        {

            if (passwordBox.Password == "")
            {
                passwordBox.Password = "Şifreniz";
                passwordBox.Foreground = Brushes.Silver;
                passwordBox.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
        }

        private void textBox_Copy1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_Copy1.Text == "")
            {
                textBox_Copy1.Text = "####";
                textBox_Copy1.Foreground = Brushes.Silver;
            }
        }

        private void textBox_Copy1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox_Copy1.Text == "####")
            {
                textBox_Copy1.Text = "";
                textBox_Copy1.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {


        }

        private void image_MouseEnter(object sender, MouseEventArgs e)
        {
            image.Width += 5;
            image.Height += 5;
        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void image_MouseLeave(object sender, MouseEventArgs e)
        {
            image.Width -= 5;
            image.Height -= 5;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            textBox_Copy2.Text = Data.Araclar.StringKodUret.Uret(4);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Temel.Register rgs = new Temel.Register();
            rgs.Show();
            this.Hide();
        }

        private void button_Copy_Click_1(object sender, RoutedEventArgs e)
        {
            Data.Kullanici.KullaniciInfo.IsAdmin = "False";
            Data.Kullanici.KullaniciInfo.IsKonuOrnek = "True";
            Data.Kullanici.KullaniciInfo.IsOyunlar = "False";
            Data.Kullanici.KullaniciInfo.IsProgramlar = "False";
            Data.Kullanici.KullaniciInfo.K_ADI = "Misafir Kullanıcı";
            Data.Kullanici.KullaniciInfo.K_SOYAD = "Misafir Kullanıcı";
            Data.Kullanici.KullaniciInfo.K_ADI = "Misafir Kullanıcı";
            Data.Kullanici.KullaniciInfo.K_PW = "Misafir Kullanıcı";
            Data.Kullanici.KullaniciInfo.K_TC = "00000000000";
            Data.Kullanici.KullaniciInfo.K_EPOSTA = "omer@mrgamingtr.com";
            Data.Kullanici.KullaniciInfo.K_KAYITTarih = DateTime.Now.ToString();
            Data.Kullanici.KullaniciInfo.K_SONGIRIS = DateTime.Now.ToString();
            Data.Kullanici.KullaniciInfo.IsNoLogin = "True";
            Temel.HomeDemo s = new Temel.HomeDemo();
            s.Show();
            this.Hide();
            MessageBox.PopupCenter2Message.Show("Misafir Kullanıcı", "Programa misafir kullanıcı olarak giriş yaptığınız için programdaki tüm özellikleri kullanamıyorsunuz. Giriş/Kayıt yaparak diğer özelliklerden faydalanabilirsiniz.");
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            textBox_Copy2.Text = Data.Araclar.StringKodUret.Uret(4);
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            Temel.ExitNoNet exitt = new Temel.ExitNoNet();

        }
    }
}
