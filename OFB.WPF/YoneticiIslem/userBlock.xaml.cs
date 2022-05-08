using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace OFB.WPF.YoneticiIslem
{
    /// <summary>
    /// Interaction logic for userBlock.xaml
    /// </summary>
    public partial class userBlock : Window
    {
        public userBlock()
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
                    using (MySqlDataAdapter adtr = new MySqlDataAdapter("select Ad,Soyad,K_Adi AS 'KullanıcıAdı',K_Ban AS 'Yasak' from ofb_kullanicilar ORDER BY Id DESC", Baglanti.Baglanti()))
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

        private void gridButton_Click(object sender, RoutedEventArgs e)
        {
            //Yasakla
            try
            {
                DataRowView dtrowView = (DataRowView)((Button)e.Source).DataContext;
                string a3 = dtrowView[2].ToString();
                using (Baglanti.Baglanti())
                {
                    using (MySqlCommand cmd = new MySqlCommand("Update ofb_kullanicilar SET K_Ban='True' WHERE K_Adi='" + a3 + "'", Baglanti.Baglanti()))
                    {
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        Users();
                        dataGrid1.ItemsSource = null;
                        dataGrid1.ItemsSource = dt.DefaultView;
                        MessageBox.PopupCenterMessage.Show("Başarılı", "Başarıyla " + a3 + " kullanıcısı programdan yasaklandı.");
                        cmd.Connection.Close();
                        Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "User Ban", "Kullanıcı, " + a3 + " kullanıcısını programdan yasakladı.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenter2Message.Show("HATA", ex.Message);
            }
        }

        private void gridButton_Click_1(object sender, RoutedEventArgs e)
        {
            //Yasagi Kaldir
            try
            {
                DataRowView dtrowView = (DataRowView)((Button)e.Source).DataContext;
                string a3 = dtrowView[2].ToString();
                using (Baglanti.Baglanti())
                {
                    using (MySqlCommand cmd = new MySqlCommand("Update ofb_kullanicilar SET K_Ban='False' WHERE K_Adi='" + a3 + "'", Baglanti.Baglanti()))
                    {
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        Users();
                        dataGrid1.ItemsSource = null;
                        dataGrid1.ItemsSource = dt.DefaultView;
                        cmd.Connection.Close();
                        MessageBox.PopupCenterMessage.Show("Başarılı", "Başarıyla " + a3 + " kullanıcısının programdan yasağı kaldırıldı.");
                        Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "User Ban", "Kullanıcı, " + a3 + " kullanıcısınının yasağını kaldırdı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenter2Message.Show("HATA", ex.Message);
            }
        }

        private void textBox_Copy3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox_Copy3.Text) == false && string.IsNullOrWhiteSpace(textBox_Copy3.Text) == false)
                {
                    using (Baglanti.Baglanti())
                    {
                        dt.Clear();
                        using (MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT Ad,Soyad,K_Adi AS 'KullanıcıAdı',K_Ban AS 'Yasak' FROM ofb_kullanicilar WHERE Ad like '%" + textBox_Copy3.Text.Trim() + "%' or Soyad like '%" + textBox_Copy3.Text.Trim() + "%' or K_Adi like '%" + textBox_Copy3.Text.Trim() + "%'", Baglanti.Baglanti()))
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
                MessageBox.PopupCenter2Message.Show("HATA", ex.Message);
            }
        }
    }
}
