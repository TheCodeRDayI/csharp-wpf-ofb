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
    /// Interaction logic for ToolBox.xaml
    /// </summary>
    public partial class ToolBox : Window
    {
        class Item
        {
            public string type { get; set; }
            public string comment { get; set; }


        }
        public ToolBox()
        {
            InitializeComponent();
            dataGrid1.Items.Add(new Item()
            {
                type = "",
                comment = ""
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "Button",
                comment = "Üzerine tıklandığında bir olayı tetikler."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "CheckBox",
                comment = "Kutucuğu işaretleme veya işareti kaldırma durumunda farklı durumların gerçekleşmesini sağlar."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "ComboBox",
                comment = "Tek bir seçim yapılabilen açılır listedir."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "DataGridView",
                comment = "Satır ve sütunlardan oluşan veri tablosudur. Veritabanındaki tabloların görünmesini ve üzerinde değişiklik yapılabilmesini sağlar."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "DateTimePicker",
                comment = "Başlangıçta tek bir satır olarak görünür. Tıklandığında tarih seçmeniz için bir takvim açılır."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "GroupBox",
                comment = "İstediğiniz form kontrollerini gruplandırabileceğiniz ve karışıklığı önleyen bir kutudur."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "Label",
                comment = "Açıklayıcı yazılar yazabilmenizi sağlayan metin kutusudur."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "LinkLabel",
                comment = "İnternet tarayıcısında açılması istenen web adresinin linkini barındıran metin kutusudur."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "ListBox",
                comment = "Üzerinde seçim yapabilmenizi de sağlayan liste kutusudur."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "PictureBox",
                comment = "Form üzerinde resim görüntüleyebilmenizi sağlar."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "RadioButton",
                comment = "Kullanıcının, birden fazla yuvarlak butondan sadece birini seçebilmesine olanak tanır."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "RichTextBox",
                comment = "Zengin biçimlendirme özellikleri taşıyan metin kutusudur."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "TextBox",
                comment = "Kullanıcının, içerisine yazı yazabildiği metin kutusudur."
            });
            dataGrid1.Items.Add(new Item()
            {
                type = "Timer",
                comment = "Bir olayı, belirlenen zaman aralıklarında çalışmasını sağlar."
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
