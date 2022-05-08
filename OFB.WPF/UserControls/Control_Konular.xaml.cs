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
using static OFB.Data.Araclar.UserControlCagir;

namespace OFB.WPF.UserControls
{
    /// <summary>
    /// Interaction logic for Control_Konular.xaml
    /// </summary>
    public partial class Control_Konular : UserControl
    {
        public Control_Konular()
        {
            InitializeComponent();
        }

        private void csharp(object sender, MouseButtonEventArgs e)
        {
            UserControlAdd(Content_Icerik, new Konular.Ornekler.OrnekKontrol.UserControl1());
           
        }


        private void css3(object sender, MouseButtonEventArgs e)
        {
            //konu
            UserControlAdd(Content_Icerik, new Konular.Ozetler.OzetKontrol.UserControl1());
        }
    }
}
