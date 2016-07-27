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

namespace BloupBloupCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Boolean lights = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void StartConnection(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleLights(object sender, RoutedEventArgs e)
        {
            if (lights)
            {
                lightImage.Source = new BitmapImage(new Uri(@"Assets\Images\light_off.png", UriKind.Relative));
                lights = false;
            }
            else
            {
                lightImage.Source = new BitmapImage(new Uri(@"Assets\Images\light_on.png", UriKind.Relative));
                lights = true;
            }
        }
    }
}
