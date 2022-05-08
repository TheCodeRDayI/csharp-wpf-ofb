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

namespace OFB.WPF.YoneticiIslem
{
    /// <summary>
    /// Interaction logic for ProgramLogs.xaml
    /// </summary>
    public partial class ProgramLogs : Window
    {
        public ProgramLogs()
        {
            InitializeComponent();
            Logs();
            dataGrid1.ItemsSource = dt.DefaultView;
        }
        Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        DataTable dt = new DataTable();
        void wClose()
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
        void Logs()
        {

            try
            {
                using (Baglanti.Baglanti())
                {
                    using (MySqlDataAdapter adtr = new MySqlDataAdapter("select LogID,K_Adi AS 'KullanıcıAdı',LogAbout AS 'LogYeri', Log_ AS 'YapılanEylem',TarihSaat from ofb_logs", Baglanti.Baglanti()))
                    {
                        adtr.Fill(dt);
                    }
                }
            }
            catch
            {
                MessageBox.PopupCenterMessage.Show("Hata", "Loglar çekilemedi.");
            }


        }

        private async void Button_Clickk(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = "pdf";
            dlg.Filter = "PDF Dosyası(*.pdf)|*.pdf";
            dlg.Title = "Kaydet";
            dlg.FileName = "Logs";
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dlg.ShowDialog() == true)
            {
                try
                {

                    Data.Araclar.PDFConvert.ExportDtTableToPDF(dt, dlg.FileName, "LOGLAR");
                    MessageBox.PopupCenterMessage.Show("Başarılı", "Loglar Pdf'i Başarıyla  (" + dlg.FileName + ") Oluşturulmuştur.");
                    await Data.Araclar.Log.GelismisLOG(Data.Kullanici.KullaniciInfo.K_ADI, "Yönetici", "Kullanıcı Yönetim/Loglar'ı PDF dosyası haline getirdi. (" + dlg.FileName + ")");
                }
                catch (Exception ex)
                {
                    MessageBox.PopupCenter2Message.Show("hata", ex.Message);
                }
            }
        }
    }
}
