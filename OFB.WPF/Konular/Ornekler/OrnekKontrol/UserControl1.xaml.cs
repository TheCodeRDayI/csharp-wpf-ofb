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

namespace OFB.WPF.Konular.Ornekler.OrnekKontrol
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            AllComboHide();

        }

        void AllComboHide()
        {
            comboBaslangic.Visibility = comboIfElse.Visibility = comboSwitchCase.Visibility = comboFor.Visibility = comboWhile.Visibility = comboDoWhile.Visibility = comboTryCatchFinally.Visibility = comboMetot.Visibility = comboClass.Visibility = comboDizi.Visibility = comboKalitim.Visibility = comboInterface.Visibility = comboTemsilci.Visibility = comboEvents.Visibility = comboToolbox.Visibility = Visibility.Hidden;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    AllComboHide();
                    comboBaslangic.Visibility = Visibility.Visible;
                    break;
                case 1:
                    AllComboHide();
                    comboToolbox.Visibility = Visibility.Visible;
                    break;
                case 2:
                    AllComboHide();
                    comboIfElse.Visibility = Visibility.Visible;
                    break;
                case 3:
                    AllComboHide();
                    comboSwitchCase.Visibility = Visibility.Visible;
                    break;
                case 4:
                    AllComboHide();
                    comboFor.Visibility = Visibility.Visible;
                    break;
                case 5:
                    AllComboHide();
                    comboWhile.Visibility = Visibility.Visible;
                    break;
                case 6:
                    AllComboHide();
                    comboDoWhile.Visibility = Visibility.Visible;
                    break;
                case 7:
                    AllComboHide();
                    comboTryCatchFinally.Visibility = Visibility.Visible;
                    break;
                case 8:
                    AllComboHide();
                    comboMetot.Visibility = Visibility.Visible;
                    break;
                case 9:
                    AllComboHide();
                    comboClass.Visibility = Visibility.Visible;
                    break;
                case 10:
                    AllComboHide();
                    comboDizi.Visibility = Visibility.Visible;
                    break;
                case 11:
                    AllComboHide();
                    comboKalitim.Visibility = Visibility.Visible;
                    break;
                case 12:
                    AllComboHide();
                    comboInterface.Visibility = Visibility.Visible;
                    break;
                case 13:
                    AllComboHide();
                    comboTemsilci.Visibility = Visibility.Visible;
                    break;
                case 14:
                    AllComboHide();
                    comboEvents.Visibility = Visibility.Visible;
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboBox_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBaslangic.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Baslangic.GirileniYazma());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Baslangic.ToplamaIslem());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Baslangic.SayininKaresi());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Baslangic.IkiSayininOrtalamasi());
                    break;
                case 4:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Baslangic.Sayac());
                    break;
                case 5:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Baslangic.MarketProgrami());
                    break;

                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboIfElse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboIfElse.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.IfElse.HangiSayiBuyuk());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.IfElse.SayiNegatifPozitif());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.IfElse.SayiTekCift());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.IfElse.UserLoginIslemi());
                    break;
                case 4:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.IfElse.Cevirme());
                    break;

                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboSwitchCase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboSwitchCase.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.SwitchCase.GunBulma());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.SwitchCase.MevsimBulma());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.SwitchCase.RenkDegisme());
                    break;

                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboFor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboFor.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.For.IsimYazdirma());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.For.ForIleToplama());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.For.Faktoriyel());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.For.Alfabe());
                    break;
                case 4:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.For.Ucgen());
                    break;
                case 5:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.For.SayininKuvveti());
                    break;
                case 6:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.For.SekizDokuz());
                    break;

                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboWhile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboWhile.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.While.Faktoriyel());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.While.Cift());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.While.Toplama());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.While.Aralikli());
                    break;
                case 4:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.While.Kare());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboDoWhile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboDoWhile.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.DoWhile.Yirmiser());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.DoWhile.Random8());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.DoWhile.CarpimTablo());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.DoWhile.RandomSayi());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboTryCatchFinally_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboTryCatchFinally.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.TryCatchFinally.Toplama());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.TryCatchFinally.Ortalama());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.TryCatchFinally.Cikartma());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboMetot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboMetot.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Metot.YuzKezIsim());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Metot.SayiTekCift());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Metot.WhoMax());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Metot.ZamUygulama());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboClass.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Class.DegerYollama());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Class.DortIslem());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Class.SayininKupVeKaresi());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Class.UcgeninDurumu());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboDizi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboDizi.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Dizi.DiziyeRandomEleman());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Dizi.DizilerdeMetotlar());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Dizi.SesliHarfler());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Dizi.TerseCevir());
                    break;
                case 4:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Dizi.DiziAylar());
                    break;
                case 5:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Dizi.AddPlus10());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboKalitim_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboKalitim.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Kalitim.AlanCevre());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Kalitim.IkiSayiToplami());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Kalitim.OgrenciAdd());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboInterface_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboInterface.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Interface.IkiSayiOrtalama());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Interface.Musteri());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Interface.Ucgen());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboTemsilci_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboTemsilci.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Temsilci.Metotlar());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Temsilci.BuyukHarf());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Temsilci.KucukHarf());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Temsilci.AHarfSilme());
                    break;
                case 4:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Temsilci.Faktoriyel());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboEvents.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Events.MouseHoverForm());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Events.TextboxChange());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Events.GirisCikis());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Events.RakamRandom());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }

        private void comboToolbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboToolbox.SelectedIndex)
            {
                case 0:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.ElemanEkleme());
                    break;
                case 1:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.ElemanSilme());
                    break;
                case 2:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.SecilenEleman());
                    break;
                case 3:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.IkıVeUc());
                    break;
                case 4:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.ComboElemanSilEkle());
                    break;
                case 5:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.ComboElemanKare());
                    break;
                case 6:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.CheckUrunToplama());
                    break;
                case 7:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.OgrenciIndirim());
                    break;
                case 8:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.DortIslemRadiobutton());
                    break;
                case 9:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.KDVRadioButton());
                    break;
                case 10:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.TimerListboxVeri());
                    break;
                case 11:
                    UserControlAdd(Content_Icerik2, new Konular.Ornekler.Toolbox.TimerKronometre());
                    break;
                default:
                    AllComboHide();
                    break;
            }
        }
    }
}
