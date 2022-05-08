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

namespace OFB.WPF.MessageBox
{
    /// <summary>
    /// Interaction logic for PopupCenter2Message.xaml
    /// </summary>
    public partial class PopupCenter2Message : Window
    {
        public static string GelenWindow;

        public PopupCenter2Message(string title, string message)
        {
            InitializeComponent();



            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(title.ToUpper())));

            richTextBox_Copy.Document.Blocks.Clear();
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run(message)));

            this.Height = System.Windows.SystemParameters.VirtualScreenHeight;
            this.Width = System.Windows.SystemParameters.VirtualScreenWidth;

            grid.Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;

        }
        void thisclose()
        {
            this.Close();
          //  Application.Current.Windows.Cast<Window>().SingleOrDefault(x => x.IsActive).Opacity = 1;

        }
        private void lblVersiyon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            thisclose();
        }

        private void lblVersiyon_MouseEnter(object sender, MouseEventArgs e)
        {
            lblVersiyon.Opacity = 1;
        }

        private void lblVersiyon_MouseLeave(object sender, MouseEventArgs e)
        {
            lblVersiyon.Opacity = 0.9;
        }
        public static void Show(string _title, string _message)
        {
            new PopupCenter2Message(_title, _message).ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            thisclose();
        }
    }
}
