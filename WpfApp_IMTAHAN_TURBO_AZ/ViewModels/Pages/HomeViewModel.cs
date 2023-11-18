using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp_IMTAHAN_TURBO_AZ.Models;
using WpfApp_IMTAHAN_TURBO_AZ.MyCommand;
using MaterialDesignThemes;
using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Diagnostics.SymbolStore;
using System.Windows.Media;
using WpfApp_IMTAHAN_TURBO_AZ.View.Pages;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages
{
    public class HomeViewModel 
    {



        public Frame Base { get; set; }

        public RealeCommand ElanGosterCommand { get; set; }

        public RealeCommand HamsiCommand { get; set; }
        public RealeCommand YeniCommand { get; set; }
        public RealeCommand SurulmusCommand { get; set; }
        public int HamsiIndex { get; set; } = 0;

        public ObservableCollection<Car> CarsEsas { get; set; }
        public ObservableCollection<Car> Cars { get; set; }

        public double Uzunluq { get; set; }


    


        ///---Materiyalar----//

        public List<string> Azn { get; set; } public string SAzn { get; set; }   
        public List<string> BNovu { get; set; } public string SBNovu { get; set; }
        public List<Marka> Markas { get; set; } public Marka Marka { get; set; }
        public List<string> Seherler { get; set; } public string SSeherler { get; set; }   
        public List<string> IllerMax { get; set; } public string SIllerMax { get; set; }   
        public List<string> IllerMin { get; set; } public string SIllerMin { get; set; }   

        

        public HomeViewModel(Frame Base)
        {
            this.Base = Base;

            ElanGosterCommand = new RealeCommand(_ElanGosterCommand);


            HamsiCommand = new RealeCommand(_HamsiCommand);
            YeniCommand = new RealeCommand(_YeinCommand);
            SurulmusCommand = new RealeCommand(_SurulmusCommand);



            Cars = new ObservableCollection<Car>();
            CarsEsas = new ObservableCollection<Car>();

            Cars = JsonSerializer.Deserialize<ObservableCollection<Car>>(File.ReadAllText("../../../DataBaseJson/cars.json"))!;
            CarsEsas = JsonSerializer.Deserialize<ObservableCollection<Car>>(File.ReadAllText("../../../DataBaseJson/cars.json"))!;

            for (int i = 0; i < Cars.Count; i++)
            {
                Cars[i].HeartCommand = new RealeCommand(_HeartCommand);
                Cars[i].KecCommand = new RealeCommand(_KecCommand);
            }
            for (int i = 0; i < CarsEsas.Count; i++)
            {
                CarsEsas[i].HeartCommand = new RealeCommand(_HeartCommand);
                CarsEsas[i].KecCommand = new RealeCommand(_KecCommand);
            }



            




            Marka = new Marka();
            Markas = new();

            Markas = JsonSerializer.Deserialize<List<Marka>>(File.ReadAllText("../../../DataBaseJson/markalar.json"))!;

            Azn = new List<string>() { "AZN", "USD", "EUR" };
            SAzn = "AZN";


            BNovu = new List<string>();
            BNovu = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/bannovleri.json"))!;
            SBNovu = "";

           
            IllerMax = new List<string>(); IllerMax = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/iller.json"))!;
            SIllerMax = "";

            IllerMin = new List<string>(); IllerMin = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/iller.json"))!;
            SIllerMin = "";










            Seherler = new List<string>();

            Seherler = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("../../../DataBaseJson/seherler.json"))!;

            SSeherler = "";



            #region elave bax
            //List<Car> cars = new List<Car>();


            //for (int i = 0; i < 20; i++)
            //{

            //    cars.Add(new Car()
            //    {

            //        Seher = "Baki",
            //        Marka = "Lada",
            //        Model = "Lada12",
            //        BuraxlisIli = "2020",
            //        BanNovu = "Masin",
            //        Reng = "Sari",
            //        Muherik = "1300",
            //        Yurus = "30000",
            //        SuretQutusu = "Mexaniki",
            //        Otrucu = "On",
            //        Yeni = true,
            //        YreSayi = 3,
            //        Veziyyet = 2,
            //        Qimet = 44000,
            //        NecenciSahib = 3,
            //        ElaveMelumat = "Super",
            //        AvSecimler = "Yüngül lehimli disklərABSLyukYağış sensoruMərkəzi qapanmaPark radarı",
            //        Images = new List<string>() { "Images/foto1.png", "Images/foto1.1.png" },
            //        PImage = "Images/foto1.png",
            //        Elaqe = new Elaqe() { Ad = "Ad", Email = "gmail@gmail.com", Seher = "Sumqayit", Telefon = "(012) 505-77-55\r\n" },
            //        VIN_Kod = "HJ2K1OS9",
            //        Beyen = true,
            //        Vip = true,
            //        PulVahidi = "AZE",
            //        PDataTime = $"{DateTime.Now.ToShortDateString()}",
            //        HBazar = "Azərbaycan",
            //        MuherikGucu = 3,
            //        YanacaqNovu = "Bezin",
            //        ElanIndex = cars.Count 





            //    }) ;

            //}


            //File.WriteAllText("../../../DataBaseJson/cars.json", JsonSerializer.Serialize(cars, new JsonSerializerOptions() { WriteIndented = true }));

            #endregion



        }







        public void _KecCommand(object? par)
        {

            int index = 0;
            if (par is Button button)
            {

                var content = button.Content;

                if (content is Grid grid)
                {

                    
                    var label = grid.Children.OfType<Label>().FirstOrDefault();

                    index = int.Parse(label!.Content.ToString()!);


                }

            }

            var carView = new CarView();
            carView.DataContext = new CarViewModel(Cars[index]);

            Base.Content = carView;




        }


        public void _HeartCommand(object? par)
        {

            if (par is Button button)
            {
               
                var content = button.Content;

                if (content is Grid grid)
                {
                   
                    var mtIcon = grid.Children.OfType<MaterialDesignThemes.Wpf.PackIcon>().FirstOrDefault();
                    var label = grid.Children.OfType<Label>().FirstOrDefault();

                    int index = int.Parse(label!.Content.ToString()!);

                    if (CarsEsas[index].Beyen){ mtIcon!.Kind = PackIconKind.CardsHeartOutline; CarsEsas[index].Beyen = false; mtIcon.Foreground = Brushes.White; }
                    else {                      mtIcon!.Kind = PackIconKind.CardsHeart;        CarsEsas[index].Beyen = true;  
                        mtIcon.Foreground = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22)); }



                    for (int i = 0; i < Cars.Count; i++)
                    {
                        CarsEsas[i].HeartCommand = null;
                        CarsEsas[i].KecCommand = null;
                    }


                    File.WriteAllText("../../../DataBaseJson/cars.json", JsonSerializer.Serialize(CarsEsas, new JsonSerializerOptions() { WriteIndented = true }));


                    for (int i = 0; i < Cars.Count; i++)
                    {
                        CarsEsas[i].HeartCommand = new RealeCommand(_HeartCommand);
                        CarsEsas[i].KecCommand = new RealeCommand(_KecCommand);
                    }


                }

            }

        }

        

        public void _ElanGosterCommand(object? par)
        {
            var esas = par as HomeView;


           
            

            
            if (IntYoxla(esas!.QimetMinComboBox.Text) && IntYoxla(esas!.QimetMaxComboBox.Text))
            {

                var cs = new List<Car>();

                cs = JsonSerializer.Deserialize<List<Car>>(File.ReadAllText("../../../DataBaseJson/cars.json"))!;

                for (int i = 0; i < cs.Count; i++)
                {
                    cs[i].HeartCommand = new RealeCommand(_HeartCommand);
                    cs[i].KecCommand = new RealeCommand(_KecCommand);
                }




                Cars.Clear();
                for (int i = 0; i < cs.Count; i++)
                {
                    bool marka = (cs[i].Marka == esas!.MarkaComboBox.Text) || (esas!.MarkaComboBox.Text.Length == 0);
                    bool model = (cs[i].Model == esas!.ModelComboBox.Text) || (esas!.ModelComboBox.Text.Length == 0);

                    bool hamsi = (HamsiIndex == 0 ? true : HamsiIndex == 1 && cs[i].Yeni ? true : HamsiIndex == 2 && !cs[i].Yeni ? true : false);
                    bool seher = (cs[i].Seher == esas!.SeherComboBox.Text) || (esas!.SeherComboBox.Text.Length == 0);

                    bool qimetMin = ((esas!.QimetMinComboBox.Text.Length == 0) || (cs[i].Qimet >= int.Parse(esas!.QimetMinComboBox.Text)));
                    bool qimetMax = ((esas!.QimetMaxComboBox.Text.Length == 0) || (cs[i].Qimet <= int.Parse(esas!.QimetMaxComboBox.Text)));

                    bool azn = (cs[i].PulVahidi == esas!.AznComboBox.Text);
                    bool banNovu = (cs[i].BanNovu == esas!.BanNovuComboBox.Text) || (esas!.BanNovuComboBox.Text.Length == 0);

                    bool ilMin = (string.IsNullOrEmpty(esas!.IlMinComboBox.Text) || int.Parse(cs[i].BuraxlisIli!) >= int.Parse(esas!.IlMinComboBox.Text));
                    bool ilMax = (string.IsNullOrEmpty(esas!.IlMaxComboBox.Text) || int.Parse(cs[i].BuraxlisIli!) <= int.Parse(esas!.IlMaxComboBox.Text));




                    if (marka && model && hamsi && seher && qimetMin && qimetMax && azn && banNovu && ilMin && ilMax)
                    {
                        Cars.Add(cs[i]);

                    }


                }

                esas!.ListView.ItemsSource = Cars;
            }


        }









        public void _HamsiCommand(object? par)
        {
            var esas = par as HomeView;

            HamsiIndex = 0;

            esas!.YeniButton.Background = Brushes.White;
            esas!.YeniButton.Foreground = Brushes.DarkGray;

            esas!.SurulmusButton.Background = Brushes.White;
            esas!.SurulmusButton.Foreground = Brushes.DarkGray;

            esas!.HamsiButton.Background = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22));
            esas!.HamsiButton.Foreground = Brushes.White;


        }
        public void _YeinCommand(object? par)
        {
            var esas = par as HomeView;

            HamsiIndex = 1;

            esas!.YeniButton.Background = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22));
            esas!.YeniButton.Foreground = Brushes.White;

            esas!.SurulmusButton.Background = Brushes.White;
            esas!.SurulmusButton.Foreground = Brushes.DarkGray;

            esas!.HamsiButton.Background = Brushes.White;
            esas!.HamsiButton.Foreground = Brushes.DarkGray;
        }
        public void _SurulmusCommand(object? par)
        {
            var esas = par as HomeView;

            HamsiIndex = 2;

            esas!.YeniButton.Background = Brushes.White;
            esas!.YeniButton.Foreground = Brushes.DarkGray;

            esas!.SurulmusButton.Background = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22));
            esas!.SurulmusButton.Foreground = Brushes.White;

            esas!.HamsiButton.Background = Brushes.White;
            esas!.HamsiButton.Foreground = Brushes.DarkGray;
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
