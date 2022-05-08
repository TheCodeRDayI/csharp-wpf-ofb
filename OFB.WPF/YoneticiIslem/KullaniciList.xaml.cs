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
using Microsoft.Win32;
using System.IO;

namespace OFB.WPF.YoneticiIslem
{
    /// <summary>
    /// Interaction logic for KullaniciList.xaml
    /// </summary>
    public partial class KullaniciList : Window
    {
        DataTable dt = new DataTable();
        Data.Sql.SqlBaglanti baglanti = new Data.Sql.SqlBaglanti();
        public KullaniciList()
        {
            InitializeComponent();

            try
            {
                using (baglanti.Baglanti())
                {
                    using (MySqlDataAdapter adtr = new MySqlDataAdapter("select Ad,Soyad,K_Adi AS 'KullanıcıAdı',K_Sifre AS 'KullanıcıSifresi',Tc,K_Eposta AS 'KullaniciMail',K_Ban AS 'Yasak',K_Online AS 'Aktif',KayitTarih,SonGiris from ofb_kullanicilar", baglanti.Baglanti()))
                    {
                        adtr.Fill(dt);
                        dataGrid1.ItemsSource = dt.DefaultView;
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




        private async void Button_Clickk(object sender, RoutedEventArgs e)
        {

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "pdf";
            dlg.Filter = "PDF Dosyası(*.pdf)|*.pdf";
            dlg.Title = "Kaydet";
            dlg.FileName = "Users";
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dlg.ShowDialog() == true)
            {
                try
                {

                    Data.Araclar.PDFConvert.ExportDtTableToPDF(dt, dlg.FileName, "Kayıtlı Kullanıcılar");
                    MessageBox.PopupCenterMessage.Show("Başarılı", "Kullanıcılar Pdf Başarıyla  (" + dlg.FileName + ") Oluşturulmuştur.");
                    await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "Yönetici", "Kullanıcı Yönetim/KullanıcıListesi bilgilerini PDF dosyası haline getirdi. (" + dlg.FileName + ")");
                }
                catch (Exception ex)
                {
                    MessageBox.PopupCenter2Message.Show("hata", ex.Message);
                }
            }

        }
        private void dataGrid1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void gridButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dtrowView = (DataRowView)((Button)e.Source).DataContext;
            string a1 = dtrowView[0].ToString();
            string a2 = dtrowView[1].ToString();
            string a3 = dtrowView[2].ToString();
            string a4 = dtrowView[3].ToString();
            string a5 = dtrowView[4].ToString();
            string a6 = dtrowView[5].ToString();
            string a7 = dtrowView[6].ToString();
            string a8 = dtrowView[7].ToString();
            string a9 = dtrowView[8].ToString();
            string a10 = dtrowView[9].ToString();
            Clipboard.SetText(a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + a6 + " " + a7 + " " + a8 + " " + a9 + " " + a10);
            MessageBox.PopupCenterMessage.Show("Başarılı", "Seçili satır başarıyla kopyalanmıştır.");
        }

        private void thisWindowsMaxClick(object sender, RoutedEventArgs e)
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
    }
}
