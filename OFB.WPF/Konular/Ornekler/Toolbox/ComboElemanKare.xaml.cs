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

namespace OFB.WPF.Konular.Ornekler.Toolbox
{
    /// <summary>
    /// Interaction logic for ComboElemanKare.xaml
    /// </summary>
    public partial class ComboElemanKare : UserControl
    {
        public ComboElemanKare()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ComboBoxItem typeItem = (ComboBoxItem)comboBox.SelectedItem;
                string value = typeItem.Content.ToString();
                int secim = Convert.ToInt32(value);
                listBox.Items.Add("Sayınızın Karesi: " + secim * secim);
            }
            catch (Exception ex)
            {
                MessageBox.PopupCenterMessage.Show("Hata",ex.Message);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Konular.Ornekler.OrnekKontrol.KaynakKodlari.Show("int secim = Convert.ToInt32(comboBox1.SelectedItem);\nlistBox.Items.Add(\"Sayınızın Karesi: \" + secim * secim);");
        }
    }
}
