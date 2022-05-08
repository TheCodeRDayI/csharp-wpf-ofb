using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace OFB.WPF.Programlar.QRCode_Olusturucu
{
    /// <summary>
    /// Interaction logic for QRCode_Create_.xaml
    /// </summary>
    public partial class QRCode_Create_ : Window
    {
        public QRCode_Create_()
        {
            InitializeComponent();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            wClose();
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        void wClose()
        {
            _Window.Opacity = 1;
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text) == false && string.IsNullOrWhiteSpace(textBox.Text) == false)
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBox.Text.Trim(), QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(100, "#01c0ff", "#fff");

                image.Source = BitmapToImageSource(qrCodeImage);

                MessageBox.PopupResultMessage.Show("Başarılı","Başarıyla QRCode oluştu. QRCode'u resim formatında kaydetmek ister misiniz ?");
                if (MessageBox.PopupResultMessage.ResultYesOrNo==true)
                {
                    Helper.SaveImageCapture((BitmapSource)image.Source);
                }
            }
            else
            {
                MessageBox.PopupCenter2Message.Show("HATA", "Lütfen Tüm Alanları Doldurunuz!");
            }

        }
        private ImageSource BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }
    }
    class Helper
    {
        //Block Memory Leak
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr handle);
        public static BitmapSource bs;
        public static IntPtr ip;
        public static BitmapSource LoadBitmap(System.Drawing.Bitmap source)
        {

            ip = source.GetHbitmap();

            bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip, IntPtr.Zero, System.Windows.Int32Rect.Empty,

                System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());

            DeleteObject(ip);

            return bs;

        }
        public static void SaveImageCapture(BitmapSource bitmap)
        {
            try
            {
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmap));
                encoder.QualityLevel = 100;


                // Configure save file dialog box
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "QRCode_" + Data.Araclar.StringKodUret.Uret(5) + "_OFB"; // Default file name
                dlg.DefaultExt = ".Jpg"; // Default file extension
                dlg.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

                // Show save file dialog box
                Nullable<bool> result = dlg.ShowDialog();

                // Process save file dialog box results
                if (result == true)
                {
                    // Save document
                    string filename = dlg.FileName;
                    FileStream fstream = new FileStream(filename, FileMode.Create);
                    encoder.Save(fstream);
                    fstream.Close();
                    MessageBox.PopupCenterMessage.Show("başarılı", "Resminiz başarıyla kaydedilmiştir. \n" + filename);
                }
            }
            catch
            {
                Console.WriteLine("Hata: İmageSave");
            }

        }
    }
}
