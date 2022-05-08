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
using MySql.Data.MySqlClient;
using OFB.Data;

namespace OFB.WPF.Temel
{
    /// <summary>
    /// Interaction logic for Exit.xaml
    /// </summary>
    public partial class Exit : Page
    {

        Data.Sql.SqlBaglanti Baglanti = new Data.Sql.SqlBaglanti();

        public Exit()
        {
            //Program Kapatılmadan önce neler olucak ?

            try
            {
                using (Baglanti.Baglanti())
                {
                    using (MySqlCommand cmd10 = new MySqlCommand("update ofb_kullanicilar SET K_Online='" + false + "' where K_Adi='" + Data.Kullanici.KullaniciInfo.K_ADI + "'", Baglanti.Baglanti()))
                    {
                        cmd10.Connection.Open();
                        cmd10.ExecuteNonQuery();
                        cmd10.Connection.Close();
                    }
                }
            }
            catch (Exception)
            {

            }


            Application.Current.Shutdown();


            InitializeComponent();
        }


    }
}
