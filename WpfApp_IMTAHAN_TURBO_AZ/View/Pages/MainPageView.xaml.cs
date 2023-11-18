using System;
using System.Collections.Generic;
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
using WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages;

namespace WpfApp_IMTAHAN_TURBO_AZ.View.Pages
{
    /// <summary>
    /// Interaction logic for MainPageView.xaml
    /// </summary>
    public partial class MainPageView : Page
    {
        public MainPageView()
        {
            InitializeComponent();

           

            EsasSeyfe.Content = new HomeView(EsasSeyfe);

            DataContext = new MainPageViewModel(this);
        }
    }
}
