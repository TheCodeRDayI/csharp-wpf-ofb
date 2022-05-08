using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using WebCam_Capture;

namespace OFB.WPF.Programlar.WebCam_
{
    /// <summary>
    /// Interaction logic for WebCamera.xaml
    /// </summary>
    public partial class WebCamera : Window
    {

        public WebCamera()
        {
            InitializeComponent();


        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        void WClose()
        {
            _Window.Opacity = 1;
            webcam.Stop();
            this.Close();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            WClose();
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            WClose();
        }
        WebCam webcam;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref image);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            webcam.Start();

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            image12.Source = image.Source;
            tabitem2.IsSelected = true;
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            webcam.Stop();
        }

        private void button123_Click(object sender, RoutedEventArgs e)
        {
            Helper.SaveImageCapture((BitmapSource)image12.Source);

        }

        private void button_Copy123_Click(object sender, RoutedEventArgs e)
        {
            image12.Source = null;
            tabitem1.IsSelected = true;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            webcam.Continue();
        }
    }
    class WebCam
    {
        private WebCamCapture webcam;
        private System.Windows.Controls.Image _FrameImage;
        private int FrameNumber = 30;
        public void InitializeWebCam(ref System.Windows.Controls.Image FingerImage)
        {
            try
            {
                webcam = new WebCamCapture();
                webcam.FrameNumber = ((ulong)(0ul));
                webcam.TimeToCapture_milliseconds = FrameNumber;
                webcam.ImageCaptured += new WebCamCapture.WebCamEventHandler(webcam_ImageCaptured);
                _FrameImage = FingerImage;
            }
            catch
            {
                MessageBox.PopupCenter2Message.Show("başlatılamadı", "WeBCam başlatılamadı. WebCam'in başka bir yerde kullanılmadığından emin olunuz ve lütfen tekrar deneyiniz.");
            }

        }

        void webcam_ImageCaptured(object source, WebcamEventArgs e)
        {
            _FrameImage.Source = Helper.LoadBitmap((System.Drawing.Bitmap)e.WebCamImage);
        }

        public void Start()
        {
            try
            {
                webcam.TimeToCapture_milliseconds = FrameNumber;
                webcam.Start(0);
            }
            catch
            {
                MessageBox.PopupCenter2Message.Show("başlatılamadı", "WeBCam başlatılamadı. WebCam'in başka bir yerde kullanılmadığından emin olunuz ve lütfen tekrar deneyiniz.");
            }

        }

        public void Stop()
        {
            webcam.Stop();
        }

        public void Continue()
        {
            // change the capture time frame
            webcam.TimeToCapture_milliseconds = FrameNumber;

            // resume the video capture from the stop
            webcam.Start(this.webcam.FrameNumber);
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
                dlg.FileName = "Image_"+DateTime.Now.ToShortDateString()+"_OFB"; // Default file name
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
