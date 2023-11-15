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

namespace WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages
{
    public class HomeViewModel
    {

        public List<Car> Cars { get; set; }

        public double Uzunluq { get; set; }

        ///---comands----//
        public RealeCommand HeartCommand { get; set; }


        ///---Materiyalar----//

        public List<string> Azn { get; set; } public string SAzn { get; set; }   
        public List<string> BNovu { get; set; } public string SBNovu { get; set; }   
        public List<Marka> Markas { get; set; } public Marka Marka { get; set; }
        public List<string> Seherler { get; set; } public string SSeherler { get; set; }   
        public List<string> IllerMax { get; set; } public string SIllerMax { get; set; }   
        public List<string> IllerMin { get; set; } public string SIllerMin { get; set; }   

        

        public HomeViewModel()
        {

            HeartCommand = new RealeCommand(_HeartCommand, _b);







            Cars = new List<Car>();

            Cars = JsonSerializer.Deserialize<List<Car>>(File.ReadAllText("../../../DataBaseJson/cars.json"))!;

            Uzunluq = Cars.Count * 100;

            


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





        }




        public bool _b(object? p)
        {
            return true;
        }


        public void _HeartCommand(object? par)
        {
          
            //Button button = (Button)par!;

            //Grid grid = (button.FindName("gr1") as Grid)!;

            //Label label = (grid.FindName("LIndex") as Label)!;

            //PackIcon packIcon = (grid.FindName("MtIcon") as PackIcon)!;


            //MessageBox.Show(label.Content.ToString());
            MessageBox.Show("bax");









        }











    }
}
