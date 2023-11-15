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
    }
}
