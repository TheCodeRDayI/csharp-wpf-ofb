using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OFB.WPF.Temel
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();




        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            Temel.ExitNoNet net = new ExitNoNet();
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Adınız";
                textBox.Foreground = Brushes.Silver;
                textBox.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
            textBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text);
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "Adınız")
            {
                textBox.Text = "";
                textBox.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                textBox.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));
            }
        }

        private void textBox_LostFocus1(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Soyadınız";
                textBox1.Foreground = Brushes.Silver;
                textBox1.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
            textBox1.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);
        }

        private void textBox_GotFocus1(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "Soyadınız")
            {
                textBox1.Text = "";
                textBox1.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                textBox1.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));
            }
        }

        private void textBox_LostFocus2(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Kullanıcı Adınız";
                textBox2.Foreground = Brushes.Silver;
                textBox2.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
        }

        private void textBox_GotFocus2(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text == "Kullanıcı Adınız")
            {
                textBox2.Text = "";
                textBox2.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                textBox2.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));
            }
        }

        Data.Kullanici.PasswordStrengthChecker k_sifredurum = new Data.Kullanici.PasswordStrengthChecker();
        int k_sifresecurity = 0;
        private void textBox_LostFocus3(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "" || passwordBox.Password.Contains(" "))
            {
                passwordBox.Password = "Şifreniz";
                passwordBox.Foreground = Brushes.Silver;
                passwordBox.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                lblsifredurum.Content = "";
            }
        }

        private void textBox_GotFocus3(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "Şifreniz")
            {
                passwordBox.Password = "";
                passwordBox.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                passwordBox.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));




            }
        }

        private void textBox_LostFocus4(object sender, RoutedEventArgs e)
        {
            if (passwordBox_Copy.Password == "" || passwordBox_Copy.Password.Contains(" "))
            {
                passwordBox_Copy.Password = "Şifreniz (tekrar)";
                passwordBox_Copy.Foreground = Brushes.Silver;
                passwordBox_Copy.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
        }

        private void textBox_GotFocus4(object sender, RoutedEventArgs e)
        {
            if (passwordBox_Copy.Password == "Şifreniz (tekrar)")
            {
                passwordBox_Copy.Password = "";
                passwordBox_Copy.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                passwordBox_Copy.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));
            }

        }

        private void textBox_LostFocus5(object sender, RoutedEventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "E-Mail Adresiniz";
                textBox5.Foreground = Brushes.Silver;
                textBox5.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
            else
                textBox5.Text = textBox5.Text.ToLower();

        }

        private void textBox_GotFocus5(object sender, RoutedEventArgs e)
        {
            if (textBox5.Text == "E-Mail Adresiniz")
            {
                textBox5.Text = "";
                textBox5.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                textBox5.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));
            }

        }



        private void textBox_LostFocus6(object sender, RoutedEventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "TC Kimliğiniz";
                textBox6.Foreground = Brushes.Silver;
                textBox6.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            }
        }

        private void textBox_GotFocus6(object sender, RoutedEventArgs e)
        {
            if (textBox6.Text == "TC Kimliğiniz")
            {
                textBox6.Text = "";
                textBox6.Foreground = new SolidColorBrush(Color.FromRgb(1, 190, 255));
                textBox6.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 190, 255));
            }
        }
        string _ad, _soyad, _kadi, _sifre, _sifretry, _email, _tc;

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Temel.ExitNoNet exit = new ExitNoNet();

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^\p{L}+$]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void textBox6_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.PopupCenter2Message.Show("Bilgilendirme", "Şifrenizi unuttuğunuz taktirde E-Mail Adresiniz büyük önem taşımaktadır. Geçerli Mail Adresileri: \nhotmail.com, outlook.com, gmail.com, protonmail.com, yandex.com, yahoo.com, berka.com, mrgamingtr.com");
        }



        private void image_MouseLeave(object sender, MouseEventArgs e)
        {
            image.Height = 155;
            image.Width = 170;
            image.Opacity = 0.8;
        }

        private void image_MouseEnter(object sender, MouseEventArgs e)
        {
            image.Height = 170;
            image.Width = 185;
            image.Opacity = 1;
        }

        private void label_MouseEnter(object sender, MouseEventArgs e)
        {
            label.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }

        private void label_MouseLeave(object sender, MouseEventArgs e)
        {
            label.BorderBrush = new SolidColorBrush(Color.FromRgb(34, 36, 49));
        }

        private void label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Temel.RegisterSozlesme sozlesme = new RegisterSozlesme();

            Temel.Register _Window = (Temel.Register)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Opacity = 0.5;
            sozlesme.ShowDialog();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

            //    Unacceptable  <50
            //    Weak <60
            //    Normal < 80
            //    Strong < 90
            //    Secure >=90

            if (passwordBox.Password != "Şifreniz" && passwordBox.Password != "Sifreniz")
            {
                k_sifresecurity = k_sifredurum.GeneratePasswordScore(passwordBox.Password.Trim());

                if (k_sifresecurity < 50)
                {
                    lblsifredurum.Content = "Şifre Durumu: Kabul Edilemez";
                    lblsifredurum.Foreground = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                }
                else if (k_sifresecurity < 60)
                {
                    lblsifredurum.Content = "Şifre Durumu: Güçsüz";
                    lblsifredurum.Foreground = new SolidColorBrush(Color.FromRgb(236, 112, 99));
                }

                else if (k_sifresecurity < 80)
                {
                    lblsifredurum.Content = "Şifre Durumu: Normal";
                    lblsifredurum.Foreground = new SolidColorBrush(Color.FromRgb(241, 196, 15));
                }

                else if (k_sifresecurity < 90)
                {
                    lblsifredurum.Content = "Şifre Durumu: Güçlü";
                    lblsifredurum.Foreground = new SolidColorBrush(Color.FromRgb(130, 224, 170));
                }

                else if (k_sifresecurity >= 90)
                {
                    lblsifredurum.Content = "Şifre Durumu: Güvenli";
                    lblsifredurum.Foreground = new SolidColorBrush(Color.FromRgb(29, 131, 72));
                }
            }
        }

        private void textBox2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = e.Key == Key.Space;
        }



        byte k_nullkontrol = 0;
        MessageBox.PopupLoadingNoTime load = new MessageBox.PopupLoadingNoTime();
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            k_nullkontrol = 0;
            try
            {
                if (await OFB.Data.Araclar.InternetKontrol.KontrolEt() == false)
                {
                    MessageBox.PopupCenter2Message.Show("hata", "İnternet Bağlantınız Bulunmamaktadır. Programı Kullanabilmek İçin İnternet Bağlantınız Olmalıdır.");
                }
                else
                {
                    _ad = textBox.Text.Trim();
                    _soyad = textBox1.Text.Trim();
                    _kadi = textBox2.Text.Trim();
                    _sifre = Data.Araclar.ConvertPassToSymbol.Gizle(passwordBox.Password.Trim());  //test edilcek
                    _sifretry = Data.Araclar.ConvertPassToSymbol.Gizle(passwordBox_Copy.Password.Trim());
                    _email = textBox5.Text.Trim();
                    _tc = textBox6.Text.Trim();
                    KontrolEmail = KontrolKadi = false;

                    if (textBox.Text != "Adınız" && textBox1.Text != "Soyadınız" && textBox6.Text != "TC Kimliğiniz" && textBox2.Text != "Kullanıcı Adınız" && passwordBox.Password != "Şifreniz" && passwordBox_Copy.Password != "Şifreniz (tekrar)" && textBox5.Text != "E-Mail Adresiniz")
                    {


                        if (textBox6.Text.Contains(" "))
                        {
                            MessageBox.PopupCenterMessage.Show("", "Tc Kimliğinizde boşluk bırakamazsınız.");
                            k_nullkontrol = 1;
                        }
                        else if (textBox2.Text.Contains(" "))
                        {
                            MessageBox.PopupCenterMessage.Show("", "Kullanıcı Adınızda boşluk bırakamazsınız.");
                            k_nullkontrol = 1;
                        }
                        else if (passwordBox.Password.Contains(" "))
                        {
                            MessageBox.PopupCenterMessage.Show("", "Şifrenizde boşluk bırakamazsınız.");
                            k_nullkontrol = 1;
                        }
                        else if (passwordBox_Copy.Password.Contains(" "))
                        {
                            MessageBox.PopupCenterMessage.Show("", "Şifre Tekrarınızda boşluk bırakamazsınız.");
                            k_nullkontrol = 1;
                        }
                        else if (textBox5.Text.Contains(" "))
                        {
                            MessageBox.PopupCenterMessage.Show("", "Mail Adresinizde boşluk bırakamazsınız.");
                            k_nullkontrol = 1;
                        }
                        if (k_nullkontrol != 1)
                        {
                            if (Data.Araclar.UserTCKontrol.TCKontrol(_tc) == true)
                            {
                                if (_kadi.Length > 5)
                                {
                                    if (textBox5.Text.Contains("@hotmail.com") || textBox5.Text.Contains("@outlook.com") || textBox5.Text.Contains("@gmail.com") || textBox5.Text.Contains("@protonmail.com") || textBox5.Text.Contains("@yandex.com") || textBox5.Text.Contains("@yahoo.com") || textBox5.Text.Contains("@berka.com") || textBox5.Text.Contains("@mrgamingtr.com"))
                                    {
                                        if (k_sifresecurity >= 60)
                                        {
                                            if (_sifre == _sifretry)
                                            {
                                                if (checkBox.IsChecked == true)
                                                {
                                                    try
                                                    {
                                                        load.Show();
                                                        await KayitOl();
                                                        if (KontrolEmail == false)
                                                        {
                                                            if (KontrolKadi == false)
                                                            {
                                                                load.Hide();
                                                                MessageBox.PopupCenterMessage.Show("Başarılı", "Tebrikler " + _ad + " " + _soyad + "! Başarıyla Programa Kayıt Oldunuz.");
                                                                await Data.Araclar.Log.GelismisLOG(_kadi, "Register", "Programa başarıyla kayıt oldu.");
                                                                await Data.Tetikleyiciler.UserPermAdd.UserAdd(_kadi);
                                                            }
                                                            else
                                                            {
                                                                MessageBox.PopupCenter2Message.Show("Kayıt Hatası", "Aldığınız kullanıcı adı başkası tarafından kullanılmaktadır. Lütfen tekrar deneyiniz.");
                                                                textBox2.Text = "Kullanıcı Adınız";
                                                                textBox2.Foreground = Brushes.Silver;
                                                                textBox2.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.PopupCenter2Message.Show("Hata", _email + " adresi daha önceden başka bir kullanıcı tarafından alınmıştır.");
                                                        }
                                                        load.Hide();
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.PopupCenterMessage.Show("HATA", ex.Message);
                                                        load.Hide();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.PopupCenter2Message.Show("Sözleşme hatası", "Programa kayıt olabilmek için 'Kayıt Sözleşmesini' kabul etmeniz gerekmektedir.");
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.PopupCenter2Message.Show("Geçersiz", "2 şifreniz de farklıdır. Devam edebilmek için şifrenizi aynı giriniz.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.PopupCenter2Message.Show("Güçsüz Şifre", "Şifreniz istenilen kriterlere uymamaktadır. \nBüyük harf, Küçük harf, Rakam, Sembol Kullanabilirsiniz.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.PopupCenter2Message.Show("Geçersiz", "Lütfen geçerli Mail adresi giriniz.");
                                    }
                                }
                                else
                                {
                                    MessageBox.PopupCenter2Message.Show("Geçersiz", "Kullanıcı adınız en az 6 karakterli olmalıdır.");
                                }
                            }
                            else
                            {
                                MessageBox.PopupCenter2Message.Show("Geçersiz", "Geçersiz veya yanlış TC Kimliği gidiniz \nLütfen tekrar deneyiniz.");
                                textBox6.Text = "TC Kimliğiniz";
                                textBox6.Foreground = Brushes.Silver;
                                textBox6.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            }
                        }
                    }
                    else
                    {

                        MessageBox.PopupCenter2Message.Show("Boş değer girilmez", "Lütfen tüm alanları doldurunuz.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenter2Message.Show("hata", "Hata: " + ex.Message);
            }
        }
        bool KontrolEmail = false, KontrolKadi = false;
        Task KayitOl()
        {
            return Task.Run(() =>
            {
                using (Baglanti.Baglanti())
                {
                    using (MySqlCommand cmd = new MySqlCommand("select K_Eposta from ofb_kullanicilar where K_Eposta='" + _email + "'", Baglanti.Baglanti()))
                    {
                        cmd.Connection.Open();
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                                KontrolEmail = true;
                            else
                            {
                                MySqlCommand cmd2 = new MySqlCommand("Select K_Adi from ofb_kullanicilar where K_Adi='" + _kadi + "'", Baglanti.Baglanti());
                                cmd2.Connection.Open();
                                MySqlDataReader dr2 = cmd2.ExecuteReader();
                                if (dr2.Read())
                                {
                                    KontrolKadi = true;

                                }
                                else
                                {

                                    MySqlCommand cmd1 = new MySqlCommand("Insert Into ofb_kullanicilar (Ad,Soyad,K_Adi,K_Sifre,Tc,K_Eposta,SonGiris) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p10)", Baglanti.Baglanti());
                                    cmd1.Parameters.AddWithValue("@p1", _ad);
                                    cmd1.Parameters.AddWithValue("@p2", _soyad);
                                    cmd1.Parameters.AddWithValue("@p3", _kadi);
                                    cmd1.Parameters.AddWithValue("@p4", _sifre);
                                    cmd1.Parameters.AddWithValue("@p5", _tc);
                                    cmd1.Parameters.AddWithValue("@p6", _email);
                                    cmd1.Parameters.AddWithValue("@p10", DateTime.Now);
                                    cmd1.Connection.Open();
                                    cmd1.ExecuteNonQuery();
                                    cmd1.Connection.Close();



                                }
                                cmd2.Connection.Close();
                            }

                        }
                        cmd.Connection.Close();
                    }
                }





            });
        }

        Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();




    }
}
