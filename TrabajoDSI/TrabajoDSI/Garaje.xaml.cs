using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace TrabajoDSI
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Garaje : Page
    {
        public Garaje()
        {
            this.InitializeComponent();
        }


        private void StackMotor_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BtonSelec.png"));
            StackMotor.Background = a;
        }

        private void StackMotor_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/Boton.png"));
            StackMotor.Background = a;
        }

        private void StackMotor_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BotonPRS.png"));
            StackMotor.Background = a;

            feedbackruedas.Visibility = Visibility.Collapsed;
            feedbackpara.Visibility = Visibility.Collapsed;
            feedbackcolor.Visibility = Visibility.Collapsed;
            motor.Visibility = Visibility.Visible;
        }
        private void StackMotor_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BtonSelec.png"));
            StackMotor.Background = a;
        }

        private void StackRuedas_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BtonSelec.png"));
            StackRuedas.Background = a;
        }

        private void StackRuedas_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/Boton.png"));
            StackRuedas.Background = a;
        }

        private void StackRuedas_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BotonPRS.png"));
            StackRuedas.Background = a;

            feedbackruedas.Visibility = Visibility.Visible;
            feedbackpara.Visibility = Visibility.Collapsed;
            feedbackcolor.Visibility = Visibility.Collapsed;
            motor.Visibility = Visibility.Collapsed;
        }

        private void StackRuedas_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BtonSelec.png"));
            StackRuedas.Background = a;
        }

        private void StackParachoques_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BtonSelec.png"));
            StackParachoques.Background = a;
        }

        private void StackParachoques_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/Boton.png"));
            StackParachoques.Background = a;
        }

        private void StackParachoques_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BotonPRS.png"));
            StackParachoques.Background = a;

            feedbackruedas.Visibility = Visibility.Collapsed;
            feedbackpara.Visibility = Visibility.Visible;
            feedbackcolor.Visibility = Visibility.Collapsed;
            motor.Visibility = Visibility.Collapsed;
        }

        private void StackParachoques_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BtonSelec.png"));
            StackParachoques.Background = a;
        }

        private void StackColor_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BtonSelec.png"));
            StackColor.Background = a;
        }

        private void StackColor_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/Boton.png"));
            StackColor.Background = a;
        }

        private void StackColor_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BotonPRS.png"));
            StackColor.Background = a;

            feedbackruedas.Visibility = Visibility.Collapsed;
            feedbackpara.Visibility = Visibility.Collapsed;
            feedbackcolor.Visibility = Visibility.Visible;
            motor.Visibility = Visibility.Collapsed;
        }

        private void StackColor_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + "Assets/Garaje/BtonSelec.png"));
            StackColor.Background = a;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
