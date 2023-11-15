using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using WpfApp_IMTAHAN_TURBO_AZ.Models;
using WpfApp_IMTAHAN_TURBO_AZ.MyCommand;
using WpfApp_IMTAHAN_TURBO_AZ.View.Pages;

namespace WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages
{
    public class MainPageViewModel
    {
       
        public RealeCommand GirisCommand { get; set; }
        public RealeCommand YeniElanCommand { get; set; }


        public int GIndex { get; set; } = -1;

        public MainPageViewModel()
        {

            GirisCommand = new RealeCommand(_GirisCommand);
            YeniElanCommand = new RealeCommand(_YeniElanCommand, _CanYeniElanCommand);

            GIndex = JsonSerializer.Deserialize<int>(File.ReadAllText("../../../DataBaseJson/index.json"));
        }


        public void _GirisCommand(object? par)
        {

            LoginView loginView = new LoginView();

            loginView.DataContext = new LoginViewModel(); 

            (par as Page)!.NavigationService.Navigate(loginView);


        }


        public bool _CanYeniElanCommand(object? par)
        {
           
            

            if (GIndex == -1) { return false; }
            
            return true;

        }

        public void _YeniElanCommand(object? par) {  }  // bos bunu yaz



    }
}
