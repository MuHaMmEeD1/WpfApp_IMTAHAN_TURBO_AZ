using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp_IMTAHAN_TURBO_AZ.Models;
using WpfApp_IMTAHAN_TURBO_AZ.MyCommand;
using WpfApp_IMTAHAN_TURBO_AZ.View.Pages;

namespace WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages
{
    public class YeniElanViewModel
    {
        public MainPageView Base { get; set; }
        public RealeCommand DevametCommand { get; set; }
        public RealeCommand FotoCommand { get; set; }
      

        public int FotoCount { get; set; } = 0;
        public List<string> Fotos { get; set; } = new List<string> { "0","0","0","0" } ;
        public string ProfilFoto { get; set; } = "";

        public List<Marka> Markas { get; set; } public Marka Marka { get; set; }
        public List<string> BNovu { get; set; }
        public List<string> Seherler { get; set; }
        public List<string> Yanacaq { get; set; }
        public List<string> Oturucu { get; set; }
        public List<string> SuretQutusu { get; set; }
        public List<string> Iller { get; set; }
        public List<string> Muherrik { get; set; }
        public List<string> HansiBazar { get; set; }
        public List<string> NecenciSahib { get; set; }
        public List<string> Rengler { get; set; }


        public YeniElanViewModel(MainPageView Base)
        {
            this.Base = Base;

            DevametCommand = new RealeCommand(_DevametCommand, _CanDevametCommand);
            FotoCommand = new RealeCommand(_FotoCommand);

            Marka = new Marka();
            Markas = new();

            Markas = JsonSerializer.Deserialize<List<Marka>>(File.ReadAllText("../../../DataBaseJson/markalar.json"))!;

            BNovu = new List<string>();
            BNovu = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/bannovleri.json"))!;

            Seherler = new List<string>();
            Seherler = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/seherler.json"))!;

            Yanacaq = new List<string>();
            Yanacaq = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/yanacaqNovu.json"))!;

            Oturucu = new List<string>() { "Arxa", "On", "Tam" };

            SuretQutusu = new List<string>() { "Mexaniki" , "Avtomat" };

            Iller = new List<string>(); Iller = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/iller.json"))!;

            Muherrik = new List<string>(); Muherrik = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/muherrik.json"))!;


            HansiBazar = new List<string>(); HansiBazar = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/hansiBazar.json"))!;


            NecenciSahib = new List<string>() { "1", "2", "3", "4+" };
            Rengler = new List<string>() { "Ağ", "Qara", "Sarı", "Qırmızı", "Mavi", "Yaşıl", "Göy", "Narıncı", "Boz" }; 

        }















        public bool _CanDevametCommand(object? par)
        {
            var esas = par as YeniElanView;


            esas!.MarkaComboBox.BorderBrush = Brushes.DarkGray;
            esas!.ModelComboBox.BorderBrush = Brushes.DarkGray;
            esas!.BanNovuComboBox.BorderBrush = Brushes.DarkGray;
            esas!.YurusComboBox.BorderBrush = Brushes.DarkGray;
            esas!.QimetComboBox.BorderBrush = Brushes.DarkGray;
            esas!.NecenciSahibComboBox.BorderBrush = Brushes.DarkGray;
            esas!.RengComboBox.BorderBrush = Brushes.DarkGray;
            esas!.YanacaqNovuComboBox.BorderBrush = Brushes.DarkGray;
            esas!.OtrucuComboBox.BorderBrush = Brushes.DarkGray;
            esas!.SuretQutusuComboBox.BorderBrush = Brushes.DarkGray;
            esas!.IlComboBox.BorderBrush = Brushes.DarkGray;
            esas!.MuherikComboBox.BorderBrush = Brushes.DarkGray;
            esas!.MuherikGucuComboBox.BorderBrush = Brushes.DarkGray;
            esas!.HansiBazarComboBox.BorderBrush = Brushes.DarkGray;

            esas!.Image1.BorderBrush = Brushes.DarkGray; esas!.Image1.BorderThickness = new Thickness(0); 
            esas!.Image2.BorderBrush = Brushes.DarkGray; esas!.Image2.BorderThickness = new Thickness(0); 
            esas!.Image3.BorderBrush = Brushes.DarkGray; esas!.Image3.BorderThickness = new Thickness(0); 
            esas!.Image4.BorderBrush = Brushes.DarkGray; esas!.Image4.BorderThickness = new Thickness(0); 

            esas!.ElaqeAdComboBox.BorderBrush = Brushes.DarkGray;
            esas!.ElaqeSeherComboBox.BorderBrush = Brushes.DarkGray;
            esas!.ElaqeEmailComboBox.BorderBrush = Brushes.DarkGray;
            esas!.ElaqeTelefonComboBox.BorderBrush = Brushes.DarkGray;



            bool isde = true;

            if(esas!.MarkaComboBox.Text.Length == 0) { isde = false; esas!.MarkaComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.ModelComboBox.Text.Length == 0) { isde = false; esas!.ModelComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.BanNovuComboBox.Text.Length == 0) { isde = false; esas!.BanNovuComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.YurusComboBox.Text.Length == 0 || !IntYoxla(esas!.YurusComboBox.Text)) { isde = false; esas!.YurusComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.QimetComboBox.Text.Length == 0 || !IntYoxla(esas!.QimetComboBox.Text)) { isde = false; esas!.QimetComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.NecenciSahibComboBox.Text.Length == 0) { isde = false; esas!.NecenciSahibComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.RengComboBox.Text.Length == 0) { isde = false; esas!.RengComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.YanacaqNovuComboBox.Text.Length == 0) { isde = false; esas!.YanacaqNovuComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.OtrucuComboBox.Text.Length == 0) { isde = false; esas!.OtrucuComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.SuretQutusuComboBox.Text.Length == 0) { isde = false; esas!.SuretQutusuComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.IlComboBox.Text.Length == 0) { isde = false; esas!.IlComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.MuherikComboBox.Text.Length == 0) { isde = false; esas!.MuherikComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.MuherikGucuComboBox.Text.Length == 0 || !IntYoxla(esas!.MuherikGucuComboBox.Text)) { isde = false; esas!.MuherikGucuComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if(esas!.HansiBazarComboBox.Text.Length == 0) { isde = false; esas!.HansiBazarComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if (FotoCount < 2) { isde = false;

                esas!.Image1.BorderThickness = new Thickness(1);
                esas!.Image1.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22));
                esas!.Image2.BorderThickness = new Thickness(1);
                esas!.Image2.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22));
                esas!.Image3.BorderThickness = new Thickness(1);
                esas!.Image3.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22));
                esas!.Image4.BorderThickness = new Thickness(1);
                esas!.Image4.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22));
                isde = false;
            }
            if (esas!.ElaqeAdComboBox.Text.Length == 0) { isde = false; esas!.ElaqeAdComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if (esas!.ElaqeSeherComboBox.Text.Length == 0) { isde = false; esas!.ElaqeSeherComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if (esas!.ElaqeEmailComboBox.Text.Length == 0) { isde = false; esas!.ElaqeEmailComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }
            if (esas!.ElaqeTelefonComboBox.Text.Length == 0) { isde = false; esas!.ElaqeTelefonComboBox.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }



            return isde;
        }

        public void _DevametCommand(object? par)
        {
            var esas = par as YeniElanView;

            int vezyet = esas!.VuruqvarCheckBox.IsChecked == true? 0: esas!.RənglənibCheckBox.IsChecked == true ? 1 : 2;

            int yerSayi = esas!.Yer_1_CheckBox.IsChecked == true ? 1 : esas!.Yer_2_CheckBox.IsChecked == true ? 2 : esas!.Yer_3_CheckBox.IsChecked == true ? 3 : esas!.Yer_4_CheckBox.IsChecked == true ? 4 : esas!.Yer_5_CheckBox.IsChecked == true ? 5 : esas!.Yer_6_CheckBox.IsChecked == true ? 6 : esas!.Yer_7_CheckBox.IsChecked == true ? 7 : esas!.Yer_8_CheckBox.IsChecked == true ? 8 : 9;


            string at = "";
            at += esas!.A1.IsChecked == true ? "Yüngül lehimli disklər" : "";
            at += esas!.A2.IsChecked == true ? "ABS" : "";
            at += esas!.A3.IsChecked == true ? "Lyuk" : "";
            at += esas!.A4.IsChecked == true ? "Yağış sensoru" : "";
            at += esas!.A5.IsChecked == true ? "Mərkəzi qapanma" : "";
            at += esas!.A6.IsChecked == true ? "Park radarı" : "";
            at += esas!.A7.IsChecked == true ? "Kondisioner" : "";
            at += esas!.A8.IsChecked == true ? "Oturacaqların isidilməsi" : "";
            at += esas!.A9.IsChecked == true ? "Dəri salon" : "";
            at += esas!.A10.IsChecked == true ? "Ksenon lampalar" : "";
            at += esas!.A11.IsChecked == true ? "Arxa görüntü kamerası" : "";
            at += esas!.A12.IsChecked == true ? "Yan pərdələr" : "";
            at += esas!.A13.IsChecked == true ? "Oturacaqların ventilyasiyası" : "";

            List<string> fotos = new List<string>();



            for (int i = 0; i < 4; i++)
            {
                if (Fotos[i] != "0") { fotos.Add(Fotos[i]); }
            }


            var Cs = new ObservableCollection<Car>();

            Cs = JsonSerializer.Deserialize<ObservableCollection<Car>>(File.ReadAllText("../../../DataBaseJson/adminCars.json"))!;

            Car newCar = new Car()
            {
                Marka = esas!.MarkaComboBox.Text,
                Model = esas!.ModelComboBox.Text,
                BanNovu = esas!.BanNovuComboBox.Text,
                Yurus = esas!.YurusComboBox.Text,
                Reng = esas!.RengComboBox.Text,
                Qimet = int.Parse(esas!.QimetComboBox.Text),
                NecenciSahib = int.Parse(esas!.NecenciSahibComboBox.Text),
                YanacaqNovu = esas!.YanacaqNovuComboBox.Text,
                Otrucu = esas!.OtrucuComboBox.Text,
                SuretQutusu = esas!.SuretQutusuComboBox.Text,
                BuraxlisIli = esas!.IlComboBox.Text,
                Muherik = esas!.MuherikComboBox.Text,
                MuherikGucu = int.Parse(esas!.MuherikGucuComboBox.Text),
                HBazar = esas!.HansiBazarComboBox.Text,
                Veziyyet = vezyet,
                YreSayi = yerSayi,
                AvSecimler = at,
                Images = fotos,
                PImage = ProfilFoto,
                ElanIndex = Cs.Count,
                Elaqe = new Elaqe()
                {
                    Ad = esas!.ElaqeAdComboBox.Text,
                    Seher = esas!.ElaqeSeherComboBox.Text,
                    Email = esas!.ElaqeEmailComboBox.Text,
                    Telefon = esas!.ElaqeTelefonComboBox.Text
                },
                ElaveMelumat = esas!.ElaveMelumatTextBox.Text,
                Beyen = false,
                PDataTime = DateTime.Now.ToShortDateString(),
                Seher = esas!.ElaqeSeherComboBox.Text,
                PulVahidi = esas!.QimetAznRB.IsChecked == true ? "AZN" : esas!.QimetUsdRB.IsChecked == true ? "USD" : "EUR",
                Yeni = true,
                Vip = false,
                VIN_Kod = ""



            };

            

            Cs.Add(newCar);

            File.WriteAllText("../../../DataBaseJson/adminCars.json", JsonSerializer.Serialize(Cs, new JsonSerializerOptions() { WriteIndented = true }));



            HomeView homeView = new HomeView(Base.EsasSeyfe);

            homeView.DataContext = new HomeViewModel(Base.EsasSeyfe);

            Base.EsasSeyfe.Content = homeView;

        }





        public void _FotoCommand(object? par)
        {

            var bt = par as Button;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image|*.png";

            bool sonuc = openFileDialog.ShowDialog()!.Value;

            if (sonuc)
            {

                int index = bt!.Content.ToString() == "b1" ? 0 : bt!.Content.ToString() == "b2" ? 1 : bt!.Content.ToString() == "b3" ? 2 : 3;

                if(FotoCount == 0) { ProfilFoto = openFileDialog.FileName; }
                if (Fotos[index] == "0") { FotoCount++; }

                Fotos[index] = openFileDialog.FileName;


                ImageBrush imageBrush = new ImageBrush(new BitmapImage(new Uri(openFileDialog.FileName)));

               
                bt.Background = imageBrush;

                


            }


        }




        public bool IntYoxla(string str)
        {
            bool yoxla = true;


            for (int i = 0; i < str.Length; i++)
            {

                if (!(str[i] > 47 && str[i] < 58)) { yoxla = false; break; }
            }


            return yoxla;

        }
    }
}
