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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OFB.WPF.Konular.Ornekler.Interface
{
    /// <summary>
    /// Interaction logic for Musteri.xaml
    /// </summary>
    public partial class Musteri : UserControl
    {
        public Musteri()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyClass sinif = new MyClass();
                sinif.mad = textBox.Text;
                sinif.msoyad = textBox_Copy.Text;
                sinif.adet = Convert.ToInt32(textBox_Copy1.Text);
                sinif.fiyat = Convert.ToInt32(textBox_Copy2.Text);
                listBox.Items.Add(sinif.Cikti());
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata", ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("public interface IMusteri\n{\nstring mad { get; set; }\nstring msoyad { get; set; }\n}\npublic interface IUrun\n{\nint adet { get; set; }\nint fiyat { get; set; }\n}\nclass MyClass : IUrun, IMusteri\n{\nstring MAD, MSOYAD;\nint ADET, FIYAT;\npublic string mad\n{\nset { MAD = value; }\nget { return MAD; }\n}\npublic string msoyad\n{\nset { MSOYAD = value; }\nget { return MSOYAD; }\n}\npublic int adet\n{\nset { ADET = value; }\nget { return ADET; }\n}\npublic int fiyat\n{\nset { FIYAT = value; }\nget { return FIYAT; }\n}\npublic string Cikti()\n{\nreturn MAD + \" \" + MSOYAD + \" \" + ADET + \" \" + FIYAT;\n}\n}\n\n\n//Button Click\nMyClass sinif = new MyClass();\nsinif.mad = textBox.Text;\nsinif.msoyad = textBox_Copy.Text;\nsinif.adet = Convert.ToInt32(textBox_Copy1.Text);\nsinif.fiyat = Convert.ToInt32(textBox_Copy2.Text);\nlistBox.Items.Add(sinif.Cikti());");

        }
    }
    public interface IMusteri
    {
        string mad { get; set; }
        string msoyad { get; set; }
    }
    public interface IUrun
    {
        int adet { get; set; }
        int fiyat { get; set; }
    }
    class MyClass : IUrun, IMusteri
    {
        string MAD, MSOYAD;
        int ADET, FIYAT;

        public string mad
        {
            set { MAD = value; }
            get { return MAD; }
        }
        public string msoyad
        {
            set { MSOYAD = value; }
            get { return MSOYAD; }
        }
        public int adet
        {
            set { ADET = value; }
            get { return ADET; }
        }
        public int fiyat
        {
            set { FIYAT = value; }
            get { return FIYAT; }
        }
        public string Cikti()
        {
            return MAD + " " + MSOYAD + " " + ADET + " " + FIYAT;
        }

    }
}
