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
using System.Data;

namespace OFB.WPF.YoneticiIslem
{
    /// <summary>
    /// Interaction logic for UserPerms.xaml
    /// </summary>
    public partial class UserPerms : Window
    {
        public UserPerms()
        {
            InitializeComponent();
            Users();
            dataGrid1.ItemsSource = dt.DefaultView;
        }


        void Users()
        {
            try
            {
                using (baglanti.Baglanti())
                {
                    dt.Clear();
                    using (MySqlDataAdapter adtr = new MySqlDataAdapter("select K_Adi AS 'KullanıcıAdı', Admin AS 'Admin_Yetkisi', KonuOrnek AS 'Konular_Yetkisi',Programlar AS 'Programlar_Yetkisi',Oyunlar AS 'Oyunlar_Yetkisi' from ofb_kullaniciyetkileri", baglanti.Baglanti()))
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

        DataTable dt = new DataTable();
        Data.Sql.SqlBaglanti baglanti = new Data.Sql.SqlBaglanti();
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void wClose()
        {
            _Window.Opacity = 1;
            this.Close();
        }

        private void thisWindowClose_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            wClose();
        }

        private void gridButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dtrowView = (DataRowView)((Button)e.Source).DataContext;
            string a1, a2, a3, a4;
            if (dtrowView[1].ToString() == "True")
                a1 = "Evet";
            else
                a1 = "Hayır";
            if (dtrowView[2].ToString() == "True")
                a2 = "Evet";
            else
                a2 = "Hayır";
            if (dtrowView[3].ToString() == "True")
                a3 = "Evet";
            else
                a3 = "Hayır";
            if (dtrowView[4].ToString() == "True")
                a4 = "Evet";
            else
                a4 = "Hayır";


            textBox.Text = dtrowView[0].ToString();
            combobox1.Text = a1;
            combobox1_Copy.Text = a2;
            combobox1_Copy1.Text = a3;
            combobox1_Copy2.Text = a4;
        }
        string perm1, perm2, perm3, perm4;
        MessageBox.PopupLoadingNoTime _load = new MessageBox.PopupLoadingNoTime();
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(combobox1.Text) == false && string.IsNullOrEmpty(combobox1_Copy.Text) == false && string.IsNullOrEmpty(combobox1_Copy1.Text) == false && string.IsNullOrEmpty(combobox1_Copy2.Text) == false && string.IsNullOrWhiteSpace(combobox1.Text) == false && string.IsNullOrWhiteSpace(combobox1_Copy.Text) == false && string.IsNullOrWhiteSpace(combobox1_Copy1.Text) == false && string.IsNullOrWhiteSpace(combobox1_Copy2.Text) == false)
            {

                if (combobox1.Text == "Evet") perm1 = "True";
                else perm1 = "False";
                if (combobox1_Copy.Text == "Evet") perm2 = "True";
                else perm2 = "False";
                if (combobox1_Copy1.Text == "Evet") perm3 = "True";
                else perm3 = "False";
                if (combobox1_Copy2.Text == "Evet") perm4 = "True";
                else perm4 = "False";

                _load.Show();
                using (baglanti.Baglanti())
                {
                    using (MySqlCommand cmd1 = new MySqlCommand("Update ofb_kullaniciyetkileri SET Admin='" + perm1 + "',KonuOrnek='" + perm2 + "',Programlar='" + perm3 + "',Oyunlar='" + perm4 + "' WHERE K_Adi='" + textBox.Text + "'", baglanti.Baglanti()))
                    {
                        cmd1.Connection.Open();
                        cmd1.ExecuteNonQuery();
                        cmd1.Connection.Close();
                    }
                }
                 _load.Hide();
                MessageBox.PopupCenter2Message.Show("Başarılı", "Başarıyla "+textBox.Text+" kullanıcısının yetkileri güncellendi");
                Users();
                dataGrid1.ItemsSource = dt.DefaultView;
                await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "User Perm Update", "Kullanıcı başarıyla yetkisi değiştirildi.");



            }
            else
            {
                MessageBox.PopupCenter2Message.Show("HATA", "Tüm alanları doldurunuz. Boş alan bırakılamaz!");
            }
        }

    }
}
