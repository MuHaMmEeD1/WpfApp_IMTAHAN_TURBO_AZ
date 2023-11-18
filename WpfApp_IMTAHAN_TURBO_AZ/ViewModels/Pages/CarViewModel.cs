using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfApp_IMTAHAN_TURBO_AZ.Models;
using WpfApp_IMTAHAN_TURBO_AZ.MyCommand;

namespace WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages
{
    public class CarViewModel : INotifyPropertyChanged
    {

        public Car Car { get; set; }
        public string Yeni { get; set; }    
        public string Vezyet { get; set; }  
        
        public RealeCommand ImageDeyisCommand { get; set; }



        public int indexImage { get; set; } = 0;

        public string? Image { get; set; }

        public CarViewModel(Car car) {
        
            Car = car;
            Image = car.Images![0];


            ImageDeyisCommand = new RealeCommand(_ImageDeyisCommand);

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
            else {  indexImage = 0; }

            Image = Car.Images![indexImage];
            OnPrCh(nameof(Image));


        }

    }
}
