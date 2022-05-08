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

namespace OFB.WPF.Konular.Ozetler
{
    /// <summary>
    /// Interaction logic for Degiskenler.xaml
    /// </summary>
    public partial class Degiskenler : Window
    {
        class Item
        {
            public string variable { get; set; }
            public string comment { get; set; }
            public string size { get; set; }
            public string maxsize { get; set; }
            public string minsize { get; set; }


        }
        public Degiskenler()
        {
            InitializeComponent();
            dataGrid1.Items.Add(new Item()
            {
                variable = "",
                comment = "",
                size = "",
                minsize = "",
                maxsize = ""
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "byte",
                comment = "Tam Sayı",
                size = "1 byte",
                minsize = "0",
                maxsize = "255"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "sbyte",
                comment = "Tam Sayı",
                size = "1 byte",
                minsize = "-128",
                maxsize = "+127"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "ushort",
                comment = "Tam Sayı",
                size = "2 byte",
                minsize = "0",
                maxsize = "65535"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "short",
                comment = "Tam Sayı",
                size = "2 byte",
                minsize = "-32768",
                maxsize = "+32767"
            }); dataGrid1.Items.Add(new Item()
            {
                variable = "uint",
                comment = "Tam Sayı",
                size = "4 byte",
                minsize = "0",
                maxsize = "2^32-1"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "int",
                comment = "Tam Sayı",
                size = "4 byte",
                minsize = "-2^31",
                maxsize = "+2^31-1"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "ulong",
                comment = "Tam Sayı",
                size = "8 byte",
                minsize = "0",
                maxsize = "2^64-1"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "long",
                comment = "Tam Sayı",
                size = "8 byte",
                minsize = "-2^63",
                maxsize = "+2^63-1"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "float",
                comment = "Kesirli Sayı",
                size = "4 byte",
                minsize = "± 1.5x10^-45",
                maxsize = "± 3.4x10^38"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "double",
                comment = "Kesirli Sayı",
                size = "8 byte",
                minsize = "± 5x10^-324",
                maxsize = "± 1.7x10^308"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "decimal",
                comment = "Kesirli Sayı",
                size = "16 byte",
                minsize = "± 1.5x10^-28",
                maxsize = "± 7.9x10^28"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "char",
                comment = "Karakter",
                size = "2 byte",
                minsize = "u0000-uFFFF arası Unicode karakter",
                maxsize = "-"
            });
            dataGrid1.Items.Add(new Item()
            {
                variable = "string",
                comment = "Metin",
                size = "-",
                minsize = "Unicode String",
                maxsize = "-"
            });
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
    }
}
