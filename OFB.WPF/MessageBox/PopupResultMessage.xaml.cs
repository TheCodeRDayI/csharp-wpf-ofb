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

namespace OFB.WPF.MessageBox
{
    /// <summary>
    /// Interaction logic for PopupResultMessage.xaml
    /// </summary>
    public partial class PopupResultMessage : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public PopupResultMessage(string title, string message)
        {
            InitializeComponent();
            this.Opacity = 1;
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(title)));

            richTextBox_Copy.Document.Blocks.Clear();
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run(message)));

            ResultYesOrNo = false;
        }

        private void lblVersiyon_MouseEnter(object sender, MouseEventArgs e)
        {
            lblevet.Opacity = 1;
        }

        private void lblVersiyon_MouseLeave(object sender, MouseEventArgs e)
        {
            lblevet.Opacity = 0.6;
        }

        private void lblhayir_MouseEnter(object sender, MouseEventArgs e)
        {
            lblhayir.Opacity = 1;
        }

        private void lblhayir_MouseLeave(object sender, MouseEventArgs e)
        {
            lblhayir.Opacity = 0.6;
        }


        public static bool ResultYesOrNo = false;

        private void lblevet_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            ResultYesOrNo = true;
            this.Close();
        }

        private void lblhayir_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ResultYesOrNo = false;
            this.Close();
        }

        private void Quesion_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void Show(string _title, string _message)
        {
            new PopupResultMessage(_title, _message).ShowDialog();
        }
    }
}
