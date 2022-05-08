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
    /// Interaction logic for UserAddAndDelete.xaml
    /// </summary>
    public partial class UserAddAndDelete : Window
    {
        DataTable dt = new DataTable();
        public UserAddAndDelete()
        {
            InitializeComponent();
            Users();
            dataGrid1.ItemsSource = dt.DefaultView;
        }

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

        private void thisWindowClose_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.PopupCenter2Message.Show("Bilgilendirme", "Şifrenizi unuttuğunuz taktirde E-Mail Adresiniz büyük önem taşımaktadır. Geçerli Mail Adresileri: \nhotmail.com, outlook.com, gmail.com, protonmail.com, yandex.com, yahoo.com, berka.com, mrgamingtr.com");
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
        byte k_nullkontrol = 0;
        string _ad, _soyad, _kadi, _sifre, _email, _tc;



        private async void gridButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.PopupResultMessage.Show("Emin Misiniz?", "Kullanıcıyı silmek istediğinizden emin misiniz? Bu işlemin geri gelmeyeceğini bilmeniz gerekir.");
            if (MessageBox.PopupResultMessage.ResultYesOrNo == true)
            {
                DataRowView dtrowView = (DataRowView)((Button)e.Source).DataContext;
                string a3 = dtrowView[2].ToString();
                try
                {
                    using (Baglanti.Baglanti())
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM ofb_kullanicilar WHERE K_Adi='" + a3 + "'", Baglanti.Baglanti()))
                        {
                            cmd.Connection.Open();
                            cmd.ExecuteNonQuery();
                            Users();
                            dataGrid1.ItemsSource = null;
                            dataGrid1.ItemsSource = dt.DefaultView;
                            MessageBox.PopupCenterMessage.Show("Başarılı", "Başarıyla " + a3 + " kullanıcısı silindi.");
                           await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "User Delete", "Kullanıcı, " + a3 + " kullanıcı adına sahip kullanıcıyı sildi.");
                            cmd.Connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
                }
            }

        }

        private void dataGrid1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        MessageBox.PopupLoadingNoTime load = new MessageBox.PopupLoadingNoTime();
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            k_nullkontrol = 0;
            try
            {
                _ad = textBox.Text.Trim();
                _soyad = textBox_Copy.Text.Trim();
                _kadi = textBox_Copy1.Text.Trim();
                _sifre = Data.Araclar.ConvertPassToSymbol.Gizle(textBox_Copy3.Text.Trim());
                _email = textBox_Copy4.Text.Trim();
                _tc = textBox_Copy2.Text.Trim();
                KontrolEmail = KontrolKadi = false;

                if (string.IsNullOrEmpty(textBox.Text) == false && string.IsNullOrEmpty(textBox_Copy.Text) == false && string.IsNullOrEmpty(textBox_Copy1.Text) == false && string.IsNullOrEmpty(textBox_Copy2.Text) == false && string.IsNullOrEmpty(textBox_Copy3.Text) == false && string.IsNullOrEmpty(textBox_Copy4.Text) == false)
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
                    else if (textBox_Copy3.Text.Contains(" "))
                    {
                        MessageBox.PopupCenterMessage.Show("", "Şifrenizde boşluk bırakamazsınız.");
                        k_nullkontrol = 1;
                    }
                    else if (textBox_Copy4.Text.Contains(" "))
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
                                if (textBox_Copy4.Text.Contains("@hotmail.com") || textBox_Copy4.Text.Contains("@outlook.com") || textBox_Copy4.Text.Contains("@gmail.com") || textBox_Copy4.Text.Contains("@protonmail.com") || textBox_Copy4.Text.Contains("@yandex.com") || textBox_Copy4.Text.Contains("@yahoo.com") || textBox_Copy4.Text.Contains("@berka.com") || textBox_Copy4.Text.Contains("@mrgamingtr.com"))
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
                                                Users();
                                                dataGrid1.ItemsSource = null;
                                                dataGrid1.ItemsSource = dt.DefaultView;
                                                MessageBox.PopupCenterMessage.Show("Başarılı", _ad + " " + _soyad + " Başarıyla Programa Kayıt Ettiniz.");
                                                await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "Admin User Add", "Programa " + _kadi + " kullanıcıyı kayıt etti");
                                                await Data.Tetikleyiciler.UserPermAdd.UserAdd(_kadi);
                                            }
                                            else
                                            {
                                                MessageBox.PopupCenter2Message.Show("Kayıt Hatası", "Yazdığınız kullanıcı adı başkası tarafından kullanılmaktadır. Lütfen tekrar deneyiniz.");
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
    }
}
