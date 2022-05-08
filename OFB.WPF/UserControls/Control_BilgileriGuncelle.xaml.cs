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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OFB.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Control_BilgileriGuncelle.xaml
    /// </summary>
    public partial class Control_BilgileriGuncelle : UserControl
    {
        public Control_BilgileriGuncelle()
        {
            InitializeComponent();

            MessageBox.PopupOutputMessage.Show("• Bilgilerinizi dilediğiniz zaman güncelleyebilirsiniz fakat sistem güvenliği için \"Kullanıcı Adınızı\" değiştiremiyorsunuz.",MessageBox.PopupOutputMessage.AlertType.info,3);
        }
        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Adınız";

            }
            textBox.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text);
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "Adınız")
            {
                textBox.Text = "";

            }
        }

        private void textBox_LostFocus1(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Soyadınız";


            }
            textBox1.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox1.Text);
        }

        private void textBox_GotFocus1(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "Soyadınız")
            {
                textBox1.Text = "";

            }
        }



        Data.Kullanici.PasswordStrengthChecker k_sifredurum = new Data.Kullanici.PasswordStrengthChecker();
        int k_sifresecurity = 0;
        private void textBox_LostFocus3(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "" || passwordBox.Password.Contains(" "))
            {
                passwordBox.Password = "Şifreniz";

                lblsifredurum.Content = "";
            }
        }

        private void textBox_GotFocus3(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password == "Şifreniz")
            {
                passwordBox.Password = "";





            }
        }

        private void textBox_LostFocus4(object sender, RoutedEventArgs e)
        {
            if (passwordBox_Copy.Password == "" || passwordBox_Copy.Password.Contains(" "))
            {
                passwordBox_Copy.Password = "Şifreniz (tekrar)";


            }
        }

        private void textBox_GotFocus4(object sender, RoutedEventArgs e)
        {
            if (passwordBox_Copy.Password == "Şifreniz (tekrar)")
            {
                passwordBox_Copy.Password = "";

            }

        }

        private void textBox_LostFocus5(object sender, RoutedEventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "E-Mail Adresiniz";


            }
            textBox5.Text = textBox5.Text.ToLower();

        }

        private void textBox_GotFocus5(object sender, RoutedEventArgs e)
        {
            if (textBox5.Text == "E-Mail Adresiniz")
            {
                textBox5.Text = "";

            }

        }



        private void textBox_LostFocus6(object sender, RoutedEventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "TC Kimliğiniz";


            }
        }

        private void textBox_GotFocus6(object sender, RoutedEventArgs e)
        {
            if (textBox6.Text == "TC Kimliğiniz")
            {
                textBox6.Text = "";

            }
        }
        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
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
        string _ad, _soyad, _sifre, _sifretry, _email, _tc;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = Data.Kullanici.KullaniciInfo.K_AD;
            textBox1.Text = Data.Kullanici.KullaniciInfo.K_SOYAD;
            textBox6.Text = Data.Kullanici.KullaniciInfo.K_TC;
            textBox5.Text = Data.Kullanici.KullaniciInfo.K_EPOSTA;
            passwordBox.Password = Data.Araclar.ConvertPassToSymbol.Goster(Data.Kullanici.KullaniciInfo.K_PW);
            passwordBox_Copy.Password = Data.Araclar.ConvertPassToSymbol.Goster(Data.Kullanici.KullaniciInfo.K_PW);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            _Window.Content_Icerik.Children.Clear();
        }
        bool KayitKontrol2 = false;
        public void KayitKontrolEmail(string mail)
        {
            try
            {
                using (Baglanti.Baglanti())
                {
                    using (MySqlCommand cmd = new MySqlCommand("select K_Eposta from ofb_kullanicilar where K_Eposta='" + mail + "'", Baglanti.Baglanti()))
                    {
                        cmd.Connection.Open();
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                                KayitKontrol2 = true;
                            else
                                KayitKontrol2 = false;
                        }
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("HATA",ex.Message);
            }



        }
        Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();
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
                    _sifre = passwordBox.Password.Trim();
                    _sifretry = passwordBox_Copy.Password.Trim();
                    _email = textBox5.Text.Trim();
                    _tc = textBox6.Text.Trim();

                    if (textBox.Text != "Adınız" && textBox1.Text != "Soyadınız" && textBox6.Text != "TC Kimliğiniz" && passwordBox.Password != "Şifreniz" && passwordBox_Copy.Password != "Şifreniz (tekrar)" && textBox5.Text != "E-Mail Adresiniz")
                    {
                        if (textBox6.Text.Contains(" "))
                        {
                            MessageBox.PopupCenterMessage.Show("", "Tc Kimliğinizde boşluk bırakamazsınız.");
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
                                if (textBox5.Text.Contains("@hotmail.com") || textBox5.Text.Contains("@outlook.com") || textBox5.Text.Contains("@gmail.com") || textBox5.Text.Contains("@protonmail.com") || textBox5.Text.Contains("@yandex.com") || textBox5.Text.Contains("@yahoo.com") || textBox5.Text.Contains("@berka.com") || textBox5.Text.Contains("@mrgamingtr.com"))
                                {
                                    if (k_sifresecurity >= 60)
                                    {
                                        if (_sifre == _sifretry)
                                        {

                                            if (Data.Kullanici.KullaniciInfo.K_EPOSTA != _email)
                                            {
                                                KayitKontrolEmail(_email);
                                            }

                                            if (KayitKontrol2 == false)
                                            {
                                                using (Baglanti.Baglanti())
                                                {
                                                    using (MySqlCommand cmd = new MySqlCommand("update ofb_kullanicilar SET Ad='" + _ad + "',Soyad='" + _soyad + "',Tc='" + _tc + "',K_Sifre='" + Data.Araclar.ConvertPassToSymbol.Gizle(_sifre) + "',K_Eposta='" + _email + "' where K_Adi='" + Data.Kullanici.KullaniciInfo.K_ADI + "' ", Baglanti.Baglanti()))
                                                    {
                                                        cmd.Connection.Open();
                                                        cmd.ExecuteReader();
                                                        Data.Kullanici.KullaniciInfo.K_AD = textBox.Text;
                                                        Data.Kullanici.KullaniciInfo.K_SOYAD = textBox1.Text;
                                                        Data.Kullanici.KullaniciInfo.K_TC = textBox6.Text;
                                                        Data.Kullanici.KullaniciInfo.K_EPOSTA = textBox5.Text;
                                                        Data.Kullanici.KullaniciInfo.K_PW = passwordBox.Password;
                                                        MessageBox.PopupCenterMessage.Show("Başarılı", "Başarıyla bilgilerinizi güncellediniz.");
                                                        await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "Bilgileri Güncelleme", "Kullanıcının yeni bilgileri: " + textBox.Text + " " + textBox1.Text + " " + textBox6.Text + " " + textBox5.Text + " " + Data.Araclar.ConvertPassToSymbol.Gizle(passwordBox.Password));
                                                        cmd.Connection.Close();
                                                    }
                                                }



                                            }
                                            else
                                            {
                                                MessageBox.PopupCenterMessage.Show("Hata", _email + " adresi daha önceden başka bir kullanıcı tarafından alınmıştır.");
                                            }



                                        }
                                        else
                                        {
                                            MessageBox.PopupCenterMessage.Show("Geçersiz", "2 şifreniz de farklıdır. Devam edebilmek için şifrenizi aynı giriniz.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.PopupCenterMessage.Show("Güçsüz Şifre", "Şifreniz istenilen kriterlere uymamaktadır. \nBüyük harf, Küçük harf, Rakam, Sembol Kullanabilirsiniz.");
                                    }
                                }
                                else
                                {
                                    MessageBox.PopupCenterMessage.Show("Geçersiz", "Lütfen geçerli Mail adresi giriniz.");
                                }
                            }
                            else
                            {
                                MessageBox.PopupCenterMessage.Show("Geçersiz", "Geçersiz veya yanlış TC Kimliği gidiniz \nLütfen tekrar deneyiniz.");
                                textBox6.Text = "TC Kimliğiniz";
                                textBox6.Foreground = Brushes.Silver;
                                textBox6.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                            }
                        }
                    }
                    else
                    {

                        MessageBox.PopupCenterMessage.Show("Boş değer girilmez", "Lütfen tüm alanları doldurunuz.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.PopupCenter2Message.Show("Hata", ex.Message);
            }
        }
    }
}
