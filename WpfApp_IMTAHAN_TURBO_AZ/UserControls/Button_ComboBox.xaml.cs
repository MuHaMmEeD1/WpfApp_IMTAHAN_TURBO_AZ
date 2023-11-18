using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp_IMTAHAN_TURBO_AZ.UserControls
{
    /// <summary>
    /// Interaction logic for Button_ComboBox.xaml
    /// </summary>
    public partial class Button_ComboBox : UserControl
    {

        public Button_ComboBox()
        {
            InitializeComponent();
            listbox.Visibility = Visibility.Collapsed;
            
        }

       
        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            listbox.Visibility = Visibility.Visible;
            btn.Opacity = 0.7;
        }

        private void btn_MouseLeave(object sender, MouseEventArgs e)
        {
            listbox.Visibility= Visibility.Collapsed;
            btn.Opacity= 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4045&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*a4g6sa*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4046&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*nh4b4f*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4044&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*dhqsnp*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4047&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*c732fs*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4043&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*m56v9e*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4119&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*m56v9e*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4048&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*1r4hsq4*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4050&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*11nt5rq*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string websiteUrl = "https://tap.az/elanlar/neqliyyat/ehtiyyat-hisseleri-ve-aksesuarlar?p%5B798%5D=4051&utm_source=turboaz&utm_medium=link&utm_content=accessories&utm_campaign=desktop#_gl=1*qr7bxt*_ga*MjM5ODAxNzguMTY5ODk0NDA0Mw..*_ga_68B6PJZXYD*MTcwMDE3MzczMS4zNC4xLjE3MDAxNzM3NjIuMjkuMC4w";

            Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true

            });
        }
    }
}
