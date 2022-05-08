using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace OFB.WPF.Programlar.MailSender
{
    /// <summary>
    /// Interaction logic for EmailSend.xaml
    /// </summary>
    public partial class EmailSend : Window
    {

        public EmailSend()
        {
            InitializeComponent();

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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox_Copy.Text = "";
            textBox_Copy1.Text = "";
            richTextBox.Document.Blocks.Clear();
            MessageBox.PopupCenter2Message.Show("başarılı", "Tüm alanlar başarıyla temizlenmiştir.");
        }




        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                MailGonderr();

            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("HATA", ex.Message);
            }









        }



        async void MailGonderr()
        {

            string _mesaj = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text;
            string _adsoyad = textBox.Text.Trim();
            string _gonderilen = textBox_Copy.Text.Trim();
            string _konu = textBox_Copy1.Text.Trim().ToUpper();

            if (textBox.Text != "" && textBox_Copy.Text != "" && textBox_Copy1.Text != "" && _mesaj != "")
            {
                if (textBox_Copy.Text.Contains("@") && textBox_Copy.Text.Contains("."))
                {
                    if (OFB.Data.Araclar.EmailSender.MailGonder(_gonderilen, _konu, "Gönderen Kişi: " + _adsoyad + " \n\n" + _mesaj) == true)
                    {
                        MessageBox.PopupCenter2Message.Show("Başarılı", "Mailiniz başarıyla gönderilmiştir.");
                        await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "Mail Sender", "Kullanıcı " + _gonderilen + " kişisine \" " + _mesaj + " \" gönderdi.");
                        richTextBox.Document.Blocks.Clear();
                        textBox.Clear();
                        textBox_Copy.Clear();
                        textBox_Copy1.Clear();
                    }
                    else
                    {
                        MessageBox.PopupCenter2Message.Show("hata", "Mail gönderilirken hata oluştu. Lütfen tekrar deneyiniz.");
                    }
                }
                else
                {
                    MessageBox.PopupCenterMessage.Show("Geçersiz Mail", "Lütfen geçerli bir mail edresi giriniz.\n@hosting .com .net .xyz");
                }
            }
            else
            {
                MessageBox.PopupCenterMessage.Show("Boş Değer", "Lütfen tüm alanları doldurunuz, boş bırakmayınız.");
            }

        }
    }
}
