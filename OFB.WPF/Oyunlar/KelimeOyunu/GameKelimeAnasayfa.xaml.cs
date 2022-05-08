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
using System.Windows.Threading;
using MySql.Data.MySqlClient;
using System.Data;

namespace OFB.WPF.Oyunlar.KelimeOyunu
{
    /// <summary>
    /// Interaction logic for GameKelimeAnasayfa.xaml
    /// </summary>
    public partial class GameKelimeAnasayfa : Window
    {
        Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();
        DataTable dt = new DataTable();
        public GameKelimeAnasayfa()
        {
            InitializeComponent();

            richTextBox_Copy.Document.Blocks.Clear();
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• Hızlı yazma testine hoşgeldin " + Data.Kullanici.KullaniciInfo.K_AD)));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run(" ")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• Oyuna Başla Butonuna bastıktan sonra 30 saniyelik süre verilir ve yazmanız için size yeni bir kelime üretilir. Bu kelimeyi büyük küçük harflere, sembollere, rakamlara dikkat edilerek aynısı yazılır. Eğer doğru yazarsanız puanınız ve doğru kelime sayınız artar.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run(" ")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• Oyundaki puan sistemi tamamen rastgeledir. Her doğru yazışınızda 9,10,11,veya 13 puanı hanenize eklenir.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run(" ")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• Sıralama bölümünden birincilik için rakiplerinizin puanlarını görebilirsiniz. Sıralama sadece ilk 10 yüksek puan gösterilir. Rakipleriniz sizi geçmeden hemen antremanlara başlayınız.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run(" ")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• Bu oyun size otomatik hızlı klavye kullanmanızı sağlıyacaktır. Dikkat et rakiplerin çok da kolay değil.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run(" ")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• Herhangi bir sorun oluşursa OmerFarukBacaksz@Gmail.Com Mail Adresime mail atabilirsiniz. İyi Oyunlar.")));

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;


        }

        Task Ilk10()
        {
            return Task.Run(() =>
            {

                try
                {
                    dt.Clear();
                    using (Baglanti.Baglanti())
                    {
                        using (MySqlDataAdapter adtr = new MySqlDataAdapter("select * from ofb_oyunlar_kelimeoyunu ORDER BY Puan DESC LIMIT 10", Baglanti.Baglanti()))
                        {
                            adtr.Fill(dt);

                        }

                    }




                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            });

        }

        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        void wClsoe()
        {
            _Window.Opacity = 1;
            timer.Stop();
            this.Close();
        }
        DispatcherTimer timer = new DispatcherTimer();
        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            wClsoe();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            wClsoe();
        }
        Random Rnd = new Random();
        byte Sayi, Sayi2;
        string YeniKelime = "";
        string KelimeUret()
        {
            Sayi = Convert.ToByte(Rnd.Next(1, 5));
            switch (Sayi)
            {
                case 1:
                    YeniKelime = FakeData.NameData.GetFirstName();
                    break;
                case 2:
                    YeniKelime = FakeData.NameData.GetSurname();
                    break;
                case 3:
                    YeniKelime = FakeData.NameData.GetMaleFirstName();
                    break;
                case 4:
                    YeniKelime = FakeData.NameData.GetCompanyName();
                    break;
                default:
                    YeniKelime = FakeData.NameData.GetFullName();
                    break;
            }
            return YeniKelime.ToLower().Trim();
        }
        byte dogru, sure, puan;
        bool SiralamaBilgi = false;
        byte SiralamaTRY = 0;
        Task Top10Girme()
        {
            return Task.Run(() =>
            {

                //2 Var + Puanda yüksek
                //1 Var + Puan alçak
                //0 Yok
                using (Baglanti.Baglanti())
                {
                    using (MySqlCommand cmd1 = new MySqlCommand("select * from ofb_oyunlar_kelimeoyunu LIMIT 10", Baglanti.Baglanti()))
                    {
                        cmd1.Connection.Open();
                        using (MySqlDataReader dr1 = cmd1.ExecuteReader())
                        {
                            while (dr1.Read())
                            {
                                if (dr1["K_Adi"].ToString() == Data.Kullanici.KullaniciInfo.K_ADI)
                                {
                                    SiralamaTRY = 1;
                                    if (Convert.ToInt32(dr1["Puan"]) < puan)
                                    {
                                        MySqlCommand cmd2 = new MySqlCommand("update ofb_oyunlar_kelimeoyunu set Puan='" + puan + "', PuanTarih='" + DateTime.Now.ToString("MM/dd/yyyy") + "' Where K_Adi='" + dr1["K_Adi"].ToString() + "'", Baglanti.Baglanti());
                                        cmd2.Connection.Open();
                                        cmd2.ExecuteNonQuery();
                                        SiralamaTRY = 2;
                                        cmd2.Connection.Close();
                                    }

                                }
                            }
                            if (SiralamaTRY == 0)
                            {
                                MySqlCommand cmd = new MySqlCommand("select * From ofb_oyunlar_kelimeoyunu Order BY Puan asc LIMIT 1", Baglanti.Baglanti());
                                cmd.Connection.Open();
                                MySqlDataReader dr2 = cmd.ExecuteReader();
                                while (dr2.Read())
                                {
                                    if (Convert.ToInt32(dr2["Puan"]) <= puan)
                                    {
                                        MySqlCommand cm2 = new MySqlCommand("update ofb_oyunlar_kelimeoyunu set K_Adi='" + Data.Kullanici.KullaniciInfo.K_ADI + "',Puan='" + puan + "',PuanTarih='" + DateTime.Now.ToString("MM/dd/yyyy") + "' where K_Adi='" + dr2["K_Adi"] + "'", Baglanti.Baglanti());
                                        cm2.Connection.Open();
                                        cm2.ExecuteNonQuery();
                                        SiralamaBilgi = true;
                                        cm2.Connection.Close();
                                    }
                                }
                                cmd.Connection.Close();
                            }
                        }
                        cmd1.Connection.Close();
                    }
                }






            });
        }
        private async void Timer_Tick(object sender, EventArgs e)
        {
            sure--;
            txtsure.Text = sure.ToString();
            if (sure <= 0)
            {
                timer.Stop();
                await Top10Girme();
                if (SiralamaBilgi == true)
                {
                    MessageBox.PopupCenter2Message.Show("Bilgilendirme", "Süreniz bitmiştir. Tebrikler sıralamaya girebildiniz. Sayfayı yenilemeyi unutmayın! İstatistikleriniz: \nDogru Sayısı: " + dogru + " \nPuan: " + puan);
                    await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "Kelime Oyunu", "Kullanıcı Kelime oyununda ilk 10 kişi sıralamasıan girdi.");
                }
                else if (SiralamaTRY == 2)
                {
                    MessageBox.PopupCenter2Message.Show("Bilgilendirme", "Süreniz bitmiştir. Tebrikler eski skorunuzu geçerek sıralamaya girdiniz. Sayfayı yenilemeyi unutmayın! İstatistikleriniz: \nDogru Sayısı: " + dogru + " \nPuan: " + puan);
                    await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "Kelime Oyunu", "Kullanıcı Kelime oyununda eski skorunu geçerek İlk 10 listesinde güncellendi.");
                }
                else
                {
                    MessageBox.PopupCenter2Message.Show("Bilgilendirme", "Süreniz bitmiştir. Maalesef sıralamaya giremediniz. İstatistikleriniz: \nDogru Sayısı: " + dogru + " \nPuan: " + puan);
                }


            }



        }
        void PuanArttır()
        {
            Sayi2 = Convert.ToByte(Rnd.Next(1, 4));
            switch (Sayi2)
            {
                case 1:
                    puan += 9;
                    break;
                case 2:
                    puan += 10;
                    break;
                case 3:
                    puan += 12;
                    break;
                default:
                    puan += 13;
                    break;
            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await Ilk10();
            dataGrid1.ItemsSource = dt.DefaultView;
        }


        private async void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            await Ilk10();
            dataGrid1.ItemsSource = null;
            dataGrid1.ItemsSource = dt.DefaultView;
        }

        private void txtYazilacak_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtYazilacak.Text.Trim() == txtYeniKelime.Content.ToString())
            {
                txtYazilacak.Text = "";
                txtYeniKelime.Content = KelimeUret();
                dogru++;
                txtdogru.Text = dogru.ToString();
                PuanArttır();
                txtpuan.Text = puan.ToString();

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtYazilacak.Text = "";
            timer.Start();

            dogru = 0; sure = 30; puan = 0;
            txtdogru.Text = dogru.ToString();
            txtsure.Text = sure.ToString();
            txtpuan.Text = puan.ToString();

            txtYazilacak.Focus();
            txtYeniKelime.Content = KelimeUret();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            MessageBox.PopupCenter2Message.Show("Bilgilendirme", "Oyunu bitirdiniz. İstatistikleriniz: \nDogru Sayısı: " + dogru + " \nPuan: " + puan + " \nKalan Süre: " + sure);
            dogru = 0; sure = 0; puan = 0;
        }
    }
}
