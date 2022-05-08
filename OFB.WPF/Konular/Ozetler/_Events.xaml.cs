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
    /// Interaction logic for _Events.xaml
    /// </summary>
    public partial class _Events : Window
    {
        class Item
        {
            public string _event { get; set; }
            public string comment { get; set; }


        }
        public _Events()
        {
            InitializeComponent();

            dataGrid1.Items.Add(new Item()
            {
                _event = "",
                comment = ""
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "Click",
                comment = "Tıklama olayıdır. Belirtilen nesneye tıklandığında çalışır."
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "TextChanged",
                comment = "Metnin değişmesi olayıdır."
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "SelectedIndexChanged",
                comment = "ComboBox ve listBox gibi nesnelerin seçili elemanları değiştirildiğinde çalışır."
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "CheckedChanged",
                comment = "CheckBox ve radioButton gibi nesnelerin durumlarında değişiklik yapıldığında çalışır. "
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "DoubleClick",
                comment = ": Çift tıklama olayıdır. Belirtilen nesneye çift tıklandığında çalışır."
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "KeyPress",
                comment = "Klavyeden bir tuşa basıldığında ve basıldığı sürece çalışır."
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "KeyDown",
                comment = "Klavyeden bir tuşa basıldığı anda yani tuş aşağı indiği anda çalışır. "
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "KeyUp",
                comment = "Klavyeden basılan tuş bırakıldığında çalışır."
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "MouseDown",
                comment = "Tıklandığı anda yani farenin tuşu aşağıya indiği anda çalışır."
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "MouseUp",
                comment = "Farenin tuşu basılıyken bırakıldığı anda çalışır. "
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "MouseMove",
                comment = "Fare bir kontrol üzerinde hareket ettirildiğinde çalışır. "
            });
            dataGrid1.Items.Add(new Item()
            {
                _event = "MouseMove",
                comment = "Fare ile bir nesnenin üzerine gelindiğinde çalışır. "
            });
        }
        Temel.HomeDemo _Window = (Temel.HomeDemo)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        private void wClose()
        {
            _Window.Opacity = 1;
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            wClose();
        }

        private void thisWindowClose_Click(object sender, RoutedEventArgs e)
        {
            wClose();
        }
    }
}
