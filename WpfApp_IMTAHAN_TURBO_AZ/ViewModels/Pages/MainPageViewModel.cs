﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
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
        public RealeCommand ButunElanlarCommand { get; set; }   

        public RealeCommand TapAzCommand { get; set; }   
        public RealeCommand BinaAzCommand { get; set; }   
        public RealeCommand BossAzCommand { get; set; }

        public Client CL { get; set; } = null!;

        public int GIndex { get; set; } = JsonSerializer.Deserialize<int>(File.ReadAllText("../../../DataBaseJson/index.json"));

        public MainPageViewModel()
        {

            TapAzCommand = new RealeCommand(_TapAzCommand);
            BinaAzCommand = new RealeCommand(_BinaAzCommand);
            BossAzCommand = new RealeCommand(_BossAzCommand);

            CL = new Client();

            GirisCommand = new RealeCommand(_GirisCommand);
            YeniElanCommand = new RealeCommand(_YeniElanCommand, _CanYeniElanCommand);
            ButunElanlarCommand = new RealeCommand(_ButunElanlarCommand);

            GIndex = JsonSerializer.Deserialize<int>(File.ReadAllText("../../../DataBaseJson/index.json"));
        }


        public void _GirisCommand(object? par)
        {

            LoginView loginView = new LoginView();

            loginView.DataContext = new LoginViewModel(); 

            (par as Page)!.NavigationService.Navigate(loginView);


        }

        public void _ButunElanlarCommand(object? par)
        {

            var p = (par as MainPageView);

            HomeView homeView = new HomeView(p!.EsasSeyfe);

            homeView.DataContext = new HomeViewModel(p.EsasSeyfe);

            p.EsasSeyfe.Content = homeView;


        }

        public bool _CanYeniElanCommand(object? par)
        {

            var p = (par as MainPageView);

            if (CL.Nov == "Admin")
            {
                p!.YeniElanTextBlock.Text = "Idarə";
            }
            else if (CL.Nov == "Satici")
            {
                p!.YeniElanTextBlock.Text = "Yeni elan";

            }
            else { p!.YeniElanTextBlock.Text = "Bağlıdı"; }


            if (GIndex == -1) { return false; }

            return true;

        }

        public void _YeniElanCommand(object? par) {

            var p = (par as MainPageView);

            List<Client> clients = new List<Client>();

            clients = JsonSerializer.Deserialize<List<Client>>(File.ReadAllText("../../../DataBaseJson/clients.json"))!;

            CL = clients[GIndex];
           

            if(CL.Nov == "Admin") {

               

                AdminView adminView = new AdminView();

                adminView.DataContext = new AdminViewModel(p.EsasSeyfe);

                p.EsasSeyfe.Content = adminView;

            }
            else if(CL.Nov == "Satici")
            {
                

                YeniElanView yeniElanView = new YeniElanView();

                yeniElanView.DataContext = new YeniElanViewModel(p!);

                p!.EsasSeyfe.Content = yeniElanView;
            }
           



        }  // bos bunu yaz





            public void _TapAzCommand(object? parametr)
        {
            string websiteUrl = "https://tap.az/";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        public void _BinaAzCommand(object? parametr)
        {
            string websiteUrl = "https://bina.az/";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        public void _BossAzCommand(object? parametr)
        {
            string websiteUrl = "https://boss.az/";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }


    }
}
