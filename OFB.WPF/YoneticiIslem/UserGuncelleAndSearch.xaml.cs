using System;
using System.Collections.Generic;
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
using MySql.Data.MySqlClient;
using System.Data;

namespace OFB.WPF.YoneticiIslem
{
    /// <summary>
    /// Interaction logic for UserGuncelleAndSearch.xaml
    /// </summary>
    public partial class UserGuncelleAndSearch : Window
    {
        public UserGuncelleAndSearch()
        {
            InitializeComponent();
            Users();
            dataGrid1.ItemsSource = dt.DefaultView;
        }
        Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();
        DataTable dt = new DataTable();

        void Users()
        {
            try
            {
                using (Baglanti.Baglanti())
                {
                    dt.Clear();
                    using (MySqlDataAdapter adtr = new MySqlDataAdapter("select Ad,Soyad,K_Adi AS 'KullanıcıAdı',K_Sifre AS 'KullanıcıSifresi',Tc,K_Eposta AS 'KullaniciMail',K_Ban AS 'Yasak',K_Online AS 'Aktif',KayitTarih,SonGiris from ofb_kullanicilar ORDER BY Id DESC", Baglanti.Baglanti()))
                    {
                        adtr.Fill(dt);
                    }//command bellekten kalktı
                }//baglanti kapandi

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenter2Message.Show("hata", ex.Message);
            }
        }
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void wClose()
        {
            _Window.Opacity = 1;
            this.Close();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            wClose();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void thisWindowClose_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }



        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^\p{L}+$]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void textBox_Copy2_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        MessageBox.PopupLoadingNoTime load = new MessageBox.PopupLoadingNoTime(); byte k_nullkontrol = 0;
        string _ad, _soyad, _kadi, _sifre, _email, _tc;

        private void textBox_Copy3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {     //Search Code
                if (string.IsNullOrEmpty(textBox_Copy3.Text) == false && string.IsNullOrWhiteSpace(textBox_Copy3.Text) == false)
                {
                    using (Baglanti.Baglanti())
                    {
                        dt.Clear();
                        using (MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT Ad,Soyad,K_Adi AS 'KullanıcıAdı',K_Sifre AS 'KullanıcıSifresi',Tc,K_Eposta AS 'KullaniciMail',K_Ban AS 'Yasak',K_Online AS 'Aktif',KayitTarih,SonGiris FROM ofb_kullanicilar WHERE Ad like '%" + textBox_Copy3.Text.Trim() + "%' or Soyad like '%" + textBox_Copy3.Text.Trim() + "%' or K_Adi like '%" + textBox_Copy3.Text.Trim() + "%'", Baglanti.Baglanti()))
                        {
                            adtr.Fill(dt);
                            dataGrid1.ItemsSource = null;
                            dataGrid1.ItemsSource = dt.DefaultView;
                        }
                    }
                }
                else
                {
                    Users();
                    dataGrid1.ItemsSource = null;
                    dataGrid1.ItemsSource = dt.DefaultView;
                }



            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        Task KayitOl()
        {
            return Task.Run(() =>
            {
                using (Baglanti.Baglanti())
                {
                    using (MySqlCommand cmd1 = new MySqlCommand("Update ofb_kullanicilar SET Ad='" + _ad + "',Soyad='" + _soyad + "',K_Sifre='" + Data.Araclar.ConvertPassToSymbol.Gizle(passwordBox.Password) + "',Tc='" + _tc + "' WHERE K_Adi='" + _kadi + "'", Baglanti.Baglanti()))
                    {
                        cmd1.Connection.Open();
                        cmd1.ExecuteNonQuery();
                        cmd1.Connection.Close();
                    }
                }





            });
        }
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            k_nullkontrol = 0;
            try
            {
                _ad = textBox.Text.Trim();
                _soyad = textBox_Copy.Text.Trim();
                _kadi = textBox_Copy1.Text.Trim();
                _sifre = Data.Araclar.ConvertPassToSymbol.Gizle(passwordBox.Password.Trim());
                _email = textBox_Copy4.Text.Trim();
                _tc = textBox_Copy2.Text.Trim();

                if (string.IsNullOrEmpty(textBox.Text) == false && string.IsNullOrEmpty(textBox_Copy.Text) == false && string.IsNullOrEmpty(textBox_Copy1.Text) == false && string.IsNullOrEmpty(textBox_Copy2.Text) == false && string.IsNullOrEmpty(passwordBox.Password) == false && string.IsNullOrEmpty(textBox_Copy4.Text) == false)
                {


                    if (textBox_Copy2.Text.Contains(" "))
                    {
                        MessageBox.PopupCenterMessage.Show("", "Tc Kimliğinizde boşluk bırakamazsınız.");
                        k_nullkontrol = 1;
                    }
                    else if (textBox_Copy1.Text.Contains(" "))
                    {
                        MessageBox.PopupCenterMessage.Show("", "Kullanıcı Adınızda boşluk bırakamazsınız.");
                        k_nullkontrol = 1;
                    }
                    else if (passwordBox.Password.Contains(" "))
                    {
                        MessageBox.PopupCenterMessage.Show("", "Şifrenizde boşluk bırakamazsınız.");
                        k_nullkontrol = 1;
                    }
                    if (k_nullkontrol != 1)
                    {
                        if (Data.Araclar.UserTCKontrol.TCKontrol(_tc) == true)
                        {
                            if (_kadi.Length > 5)
                            {

                                try
                                {
                                    //load.Show();
                                    await KayitOl();
                                    //load.Hide();
                                    Users();
                                    dataGrid1.ItemsSource = null;
                                    dataGrid1.ItemsSource = dt.DefaultView;
                                    MessageBox.PopupCenterMessage.Show("Başarılı", _ad + " " + _soyad + " Başarıyla Güncellendi.");
                                    await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "Admin User Update", "Kullanıcı " + _kadi + " başarıyla güncellendi.");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.PopupCenterMessage.Show("HATA", ex.Message);
                                    //load.Hide();
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
                        }
                    }
                }
                else
                {

                    MessageBox.PopupCenter2Message.Show("Boş değer girilmez", "Lütfen tüm alanları doldurunuz.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenter2Message.Show("hata", "Hata: " + ex.Message);
            }
        }

        private void gridButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dtrowView = (DataRowView)((Button)e.Source).DataContext;
            textBox.Text = dtrowView[0].ToString();
            textBox_Copy.Text = dtrowView[1].ToString();
            textBox_Copy1.Text = dtrowView[2].ToString();
            passwordBox.Password = Data.Araclar.ConvertPassToSymbol.Goster(dtrowView[3].ToString());
            textBox_Copy2.Text = dtrowView[4].ToString();
            textBox_Copy4.Text = dtrowView[5].ToString();
        }
    }
}
