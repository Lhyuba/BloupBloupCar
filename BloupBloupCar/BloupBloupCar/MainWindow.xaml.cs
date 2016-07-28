using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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

        private void ChangeResolution(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbItem = sender as ComboBoxItem;
            iVideoContainer.Width = 800;

            switch (cbItem.Content.ToString())
            {
                case "16:9":
                    iVideoContainer.Height = 450;
                    break;

                //case "16:10":
                case "4:3":
                default:
                    iVideoContainer.Height = 600;
                    break;
            }
        }
    }
}
