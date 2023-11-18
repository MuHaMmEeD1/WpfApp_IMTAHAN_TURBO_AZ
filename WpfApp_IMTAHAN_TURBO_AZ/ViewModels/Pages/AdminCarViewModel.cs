using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp_IMTAHAN_TURBO_AZ.Models;
using WpfApp_IMTAHAN_TURBO_AZ.MyCommand;
using WpfApp_IMTAHAN_TURBO_AZ.View.Pages;

namespace WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages
{
    public class AdminCarViewModel : INotifyPropertyChanged
    {

        public Car Car { get; set; }
        public string Yeni { get; set; }
        public string Vezyet { get; set; }




        public RealeCommand ImageDeyisCommand { get; set; }
        public RealeCommand ElaveEtCommand { get; set; }
        public RealeCommand ReddEtCommand { get; set; }


        public Frame Base { get; set; }





        public int indexImage { get; set; } = 0;

        public string? Image { get; set; }

        public AdminCarViewModel(Car car, Frame fream)
        {
            Base = fream;

            Car = car;
            Image = car.Images![0];


            ImageDeyisCommand = new RealeCommand(_ImageDeyisCommand);

            ElaveEtCommand = new RealeCommand(_ElaveEtCommand);
            ReddEtCommand = new RealeCommand(_ReddEtCommand);



            Yeni = car.Yeni ? "Bəli" : "Xeyir";

            Vezyet = car.Veziyyet == 0 ? "Vuruğu var" : car.Veziyyet == 1 ? "Rənglənib" : "Digər";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPrCh([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void _ImageDeyisCommand(object? par)
        {
            var img = par as ImageBrush;

            if (indexImage < Car.Images!.Count - 1) { indexImage++; }
            else { indexImage = 0; }

            Image = Car.Images![indexImage];
            OnPrCh(nameof(Image));


        }



        public void _ElaveEtCommand(object? par)
        {

            var Cars = JsonSerializer.Deserialize<ObservableCollection<Car>>(File.ReadAllText("../../../DataBaseJson/cars.json"))!;

            int index = Car.ElanIndex;

            Car.ElanIndex = Cars.Count;

            Cars.Add(Car);

            Car.HeartCommand = null;
            Car.KecCommand = null;
            

            File.WriteAllText("../../../DataBaseJson/cars.json", JsonSerializer.Serialize(Cars, new JsonSerializerOptions() { WriteIndented = true }));



            var AdimnCars = JsonSerializer.Deserialize<ObservableCollection<Car>>(File.ReadAllText("../../../DataBaseJson/adminCars.json"))!;

            AdimnCars.RemoveAt(index);


            for (int i = 0; i < AdimnCars.Count; i++)
            {
                AdimnCars[i].ElanIndex = i;
            }


            File.WriteAllText("../../../DataBaseJson/adminCars.json", JsonSerializer.Serialize(AdimnCars, new JsonSerializerOptions() { WriteIndented = true }));


            HomeView homeView = new HomeView(Base);

            homeView.DataContext = new HomeViewModel(Base);

            Base.Content = homeView;


        }
        public void _ReddEtCommand(object? par)
        {
            var AdimnCars = JsonSerializer.Deserialize<ObservableCollection<Car>>(File.ReadAllText("../../../DataBaseJson/adminCars.json"))!;

            AdimnCars.RemoveAt(Car.ElanIndex);


            for (int i = 0; i < AdimnCars.Count; i++)
            {
                AdimnCars[i].ElanIndex = i;
            }


            File.WriteAllText("../../../DataBaseJson/adminCars.json", JsonSerializer.Serialize(AdimnCars, new JsonSerializerOptions() { WriteIndented = true }));


            HomeView homeView = new HomeView(Base);

            homeView.DataContext = new HomeViewModel(Base);

            Base.Content = homeView;

        }



    }
}
