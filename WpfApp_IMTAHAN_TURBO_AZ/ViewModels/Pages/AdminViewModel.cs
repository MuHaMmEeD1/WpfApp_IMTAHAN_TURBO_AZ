using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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
    public class AdminViewModel
    {



        public Frame Base { get; set; }

        public ObservableCollection<Car> CarsEsas { get; set; }
        public ObservableCollection<Car> Cars { get; set; }

        





      


        public AdminViewModel(Frame Base)
        {
            this.Base = Base;

           

            Cars = new ObservableCollection<Car>();
            CarsEsas = new ObservableCollection<Car>();

            Cars = JsonSerializer.Deserialize<ObservableCollection<Car>>(File.ReadAllText("../../../DataBaseJson/adminCars.json"))!;
            CarsEsas = JsonSerializer.Deserialize<ObservableCollection<Car>>(File.ReadAllText("../../../DataBaseJson/adminCars.json"))!;

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

            var carView = new AdminCarView();
            carView.DataContext = new AdminCarViewModel(Cars[index], Base);

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

                    if (CarsEsas[index].Beyen) { mtIcon!.Kind = PackIconKind.CardsHeartOutline; CarsEsas[index].Beyen = false; mtIcon.Foreground = Brushes.White; }
                    else
                    {
                        mtIcon!.Kind = PackIconKind.CardsHeart; CarsEsas[index].Beyen = true;
                        mtIcon.Foreground = new SolidColorBrush(Color.FromRgb((byte)202, (byte)16, (byte)22));
                    }



                    for (int i = 0; i < Cars.Count; i++)
                    {
                        CarsEsas[i].HeartCommand = null;
                        CarsEsas[i].KecCommand = null;
                    }


                    File.WriteAllText("../../../DataBaseJson/adminCars.json", JsonSerializer.Serialize(CarsEsas, new JsonSerializerOptions() { WriteIndented = true }));


                    for (int i = 0; i < Cars.Count; i++)
                    {
                        CarsEsas[i].HeartCommand = new RealeCommand(_HeartCommand);
                        CarsEsas[i].KecCommand = new RealeCommand(_KecCommand);
                    }


                }

            }

        }



        

    }



}

