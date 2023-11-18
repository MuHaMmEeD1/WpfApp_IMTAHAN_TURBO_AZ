using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp_IMTAHAN_TURBO_AZ.Models
{
    public class Car
    {

        public string? Seher { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? BuraxlisIli { get; set; }
        public string? BanNovu { get; set; }
        public string? Reng { get; set; }
        public string? Muherik { get; set; }
        public string? Yurus { get; set; }
        public string? SuretQutusu { get; set; }
        public string? Otrucu { get; set; }
        public bool Yeni { get; set; }
        public int YreSayi { get; set; }
        public int Veziyyet { get; set; }
        public int Qimet { get; set; }
        public int NecenciSahib {get; set; }
        public string? ElaveMelumat { get; set; }
        public string? AvSecimler { get; set; }
        public List<string>? Images { get; set; }
        public string? PImage { get; set; }
        public Elaqe? Elaqe { get; set; }
        public string? VIN_Kod { get; set; }
        public string? PulVahidi { get; set; }
        public bool Beyen { get; set; }
        public bool Vip { get; set; }
        public string? PDataTime { get; set; }
        public string? HBazar { get; set; }
        public int MuherikGucu { get; set; }
        public string? YanacaqNovu { get; set; }
        public int ElanIndex { get; set; }
        public ICommand? HeartCommand { get; set; }  
        public ICommand? KecCommand { get; set; }  
    }
}
