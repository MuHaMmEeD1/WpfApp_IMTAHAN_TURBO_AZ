using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp_IMTAHAN_TURBO_AZ.Models;
using WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages;

namespace WpfApp_IMTAHAN_TURBO_AZ.View.Pages
{

    public partial class HomeView : Page
    {
        public HomeView(Frame Base, ObservableCollection<Car> cars = null!, bool secilmis = false)
        {

            
            DataContext = new HomeViewModel(Base, cars, secilmis);

            InitializeComponent();

            

        }

    
    }
}
