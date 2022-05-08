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

namespace OFB.WPF.Temel
{
    /// <summary>
    /// Interaction logic for RegisterSozlesme.xaml
    /// </summary>
    public partial class RegisterSozlesme : Window
    {
        public RegisterSozlesme()
        {
            InitializeComponent();

            richTextBox_Copy.Document.Blocks.Clear();
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• MADDE 1: PROJE AMACI:")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("1.1. Bu proje C# Yazılım Dili ile yapılan bir çok programın bir arada toplanmış halidir. Konu anlatımları ile konu anlatılmaktadır. Örneklerde bulunan kodlar ile sizde takıldığınız yerlerde kodlara bakabilirsiniz.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• MADDE 2: KULLANICI'NIN YÜKÜMLÜLÜKLERİ:")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("2.1. Programda Şiddet,Küfür,Cinsellik bulunmamasına rağmen gözümüzden kaçan olay var ise bundan kodlayan kişi sorumlu tutulmaz.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("2.2. Kullanıcı'nın dile getirdiği tüm fikir, düşünce, ifade, yorum ve yazıların kendisine ait olduğunu, Kodlayanın hiçbir şekilde sorumlu olmadığını kabul ve beyan eder.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("2.3. Kullanıcı, Ömer Faruk Bacaksız tarafından üretilen yazılımlarda kullanılan özel yazılım tekniklerinin telif hakkının Ömer Faruk Bacaksız‘a ait olduğunu, bu yazılımların hiçbir şekilde çoğaltılıp, dağıtılmayacağını kabul ve beyan eder.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• MADDE 3: GİZLİLİK VE GÜVENLİK:")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("3.1. Hem Coder'ın hem de Kullanıcı'nın birbirlerinin gizlilik kurallarına saygı göstermelidir. Üçüncü şahıslarla paylaşılması zorunlu olmayan ve zaten diğer kişilerin ulaşımına açık olmayan tüm bilgiler gizli kabul edilip başka kişilerle paylaşılmamalıdır.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("3.2. Kullanıcı, kendi çalışanlarının, herhangi bir kasıt, ihmal ya da kusurundan dolayı şifrelerin 3. kişi veya kuruluşların eline geçmesi halinde doğabilecek zararlardan Ömer Faruk Bacaksız mesul değildir.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("3.3. Programın Kodları Hiçbir Şekilde Kopyalanamaz. Aksi Taktirde Telif Haklarından Dolayı Paza Cezası Uygulanır.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• MADDE 4: VERİ TABANI:")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("4.1. Bu Programda Veri Tabanı Olarak MySQL Veri Tabanı Kullanılmıştır.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("4.2. Herhangi Bir Olaydan Çalınan Veri Tabanı ÖMER FARUK BACAKSIZ'a Ait Sorumuluk Kabul Edilmez.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("• MADDE 5: CODER:")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("5.1. Bu Programı Kodlayan ÖMER FARUK BACAKSIZ Hiçbir Sorumluluk Üstüne Almaz.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("MADDE 6: UYUMLULUK:")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("6.1 Bu Program Hiç Bir Promlemle Karşılaşmamak İçin .NETFramework 4.5.2 Kurulu Olması Lazım.")));
            richTextBox_Copy.Document.Blocks.Add(new Paragraph(new Run("6.2 Windows 7 Ve Üstü İçin Uyumluluk Gösterir.")));
        }

        Temel.Register _Window = (Temel.Register)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        void closewindowwsss()
        {
            _Window.Opacity = 1;
            this.Close();

        }
        private void Window_Closed_1(object sender, EventArgs e)
        {
            closewindowwsss();
        }

        private void btnKapat_Click(object sender, RoutedEventArgs e)
        {
            closewindowwsss();

        }

        private void lblVersiyon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            closewindowwsss();

        }

        private void lblVersiyon_MouseEnter(object sender, MouseEventArgs e)
        {
            lblVersiyon.Opacity = 1;
        }

        private void lblVersiyon_MouseLeave(object sender, MouseEventArgs e)
        {
            lblVersiyon.Opacity = 0.6;
        }

        private void btnKapat_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
