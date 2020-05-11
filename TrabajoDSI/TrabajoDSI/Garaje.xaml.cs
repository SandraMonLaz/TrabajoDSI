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
        public CocheGaraje[] ArrayGaraje;
        private int selectedCar;
 
        public Garaje()
        {
            this.InitializeComponent();

            ArrayGaraje = GarajeMngr.GetGaraje();
            selectedCar = 0;
            texto.Text = ArrayGaraje[selectedCar].info;
            NombreCoche.Text = ArrayGaraje[selectedCar].nombreCoche;
            //Inicializamos
            color.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].color[ArrayGaraje[selectedCar].icolor]));
            ruedas.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].ruedas[ArrayGaraje[selectedCar].iruedas]));
            motor.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].motor[ArrayGaraje[selectedCar].imotor]));

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

            ArrayGaraje[selectedCar].estadoActual = CocheGaraje.Estado.motor;

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

            ArrayGaraje[selectedCar].estadoActual = CocheGaraje.Estado.ruedas;

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
            //Adejuntamos la nuea imagen del parachoques
            parachoques.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].parachoques[ArrayGaraje[selectedCar].iparachoques]));
            ArrayGaraje[selectedCar].estadoActual = CocheGaraje.Estado.parachoques;

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

            ArrayGaraje[selectedCar].estadoActual = CocheGaraje.Estado.color;

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

        private void RightCar_Click(object sender, RoutedEventArgs e)
        {
            selectedCar = (selectedCar + 1) % (ArrayGaraje.GetLength(0));
            texto.Text = ArrayGaraje[selectedCar].info;
            NombreCoche.Text = ArrayGaraje[selectedCar].nombreCoche;
            color.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].color[ArrayGaraje[selectedCar].icolor]));

            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].estadistica));
            estadistica.Background = a;
        }

        private void LeftCar_Click(object sender, RoutedEventArgs e)
        {
            if (selectedCar > 0) selectedCar = (selectedCar - 1) % (ArrayGaraje.GetLength(0));
            else selectedCar = ArrayGaraje.GetLength(0) - 1;
            texto.Text = ArrayGaraje[selectedCar].info;
            NombreCoche.Text = ArrayGaraje[selectedCar].nombreCoche;
            color.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].color[ArrayGaraje[selectedCar].icolor]));

            ImageBrush a = new ImageBrush();
            a.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].estadistica));
            estadistica.Background = a;
        }

        private void RightButtonCar_Click(object sender, RoutedEventArgs e)
        {
            switch (ArrayGaraje[selectedCar].estadoActual)
            {
                case CocheGaraje.Estado.color:
                {
                    ArrayGaraje[selectedCar].icolor= (ArrayGaraje[selectedCar].icolor+1) % ArrayGaraje[selectedCar].color.GetLength(0);
                    color.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].color[ArrayGaraje[selectedCar].icolor]));
                }
                break;
                case CocheGaraje.Estado.parachoques: 
                {
                    ArrayGaraje[selectedCar].iparachoques = (ArrayGaraje[selectedCar].iparachoques + 1) % ArrayGaraje[selectedCar].parachoques.GetLength(0);
                    parachoques.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].parachoques[ArrayGaraje[selectedCar].iparachoques]));
                }
                break;
                case CocheGaraje.Estado.ruedas:
                {
                    ArrayGaraje[selectedCar].iruedas = (ArrayGaraje[selectedCar].iruedas + 1) % ArrayGaraje[selectedCar].ruedas.GetLength(0);
                    ruedas.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].ruedas[ArrayGaraje[selectedCar].iruedas]));
                }
                break;
                case CocheGaraje.Estado.motor:
                {
                    ArrayGaraje[selectedCar].imotor = (ArrayGaraje[selectedCar].imotor + 1) % ArrayGaraje[selectedCar].motor.GetLength(0);
                    motor.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].motor[ArrayGaraje[selectedCar].imotor]));
                }
                break;
            }
        }

        private void LeftButtonCar_Click(object sender, RoutedEventArgs e)
        {
        
            switch (ArrayGaraje[selectedCar].estadoActual)
            {
                case CocheGaraje.Estado.color:
                    {
                        if (ArrayGaraje[selectedCar].icolor > 0)
                            ArrayGaraje[selectedCar].icolor = (ArrayGaraje[selectedCar].icolor - 1) % ArrayGaraje[selectedCar].color.GetLength(0);
                        else ArrayGaraje[selectedCar].icolor = ArrayGaraje[selectedCar].color.GetLength(0) - 1;
                        color.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].color[ArrayGaraje[selectedCar].icolor]));
                    }
                    break;
                case CocheGaraje.Estado.parachoques:
                    {
                        if (ArrayGaraje[selectedCar].iparachoques > 0)
                           ArrayGaraje[selectedCar].iparachoques = (ArrayGaraje[selectedCar].iparachoques - 1) % ArrayGaraje[selectedCar].parachoques.GetLength(0);
                        else ArrayGaraje[selectedCar].iparachoques = ArrayGaraje[selectedCar].parachoques.GetLength(0) - 1;
                        parachoques.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].parachoques[ArrayGaraje[selectedCar].iparachoques]));
                    }
                    break;
                case CocheGaraje.Estado.ruedas:
                    {
                        if (ArrayGaraje[selectedCar].iruedas > 0)
                            ArrayGaraje[selectedCar].iruedas = (ArrayGaraje[selectedCar].iruedas - 1) % ArrayGaraje[selectedCar].ruedas.GetLength(0);
                        else ArrayGaraje[selectedCar].iruedas = ArrayGaraje[selectedCar].ruedas.GetLength(0) - 1;
                      
                        ruedas.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].ruedas[ArrayGaraje[selectedCar].iruedas]));
                    }
                    break;
                case CocheGaraje.Estado.motor:
                    {
                        if(ArrayGaraje[selectedCar].imotor > 0)
                            ArrayGaraje[selectedCar].imotor = (ArrayGaraje[selectedCar].imotor - 1) % ArrayGaraje[selectedCar].motor.GetLength(0);
                        else ArrayGaraje[selectedCar].imotor = ArrayGaraje[selectedCar].motor.GetLength(0) - 1;
                        
                        motor.Source = new BitmapImage(new Uri("ms-appx:///" + ArrayGaraje[selectedCar].motor[ArrayGaraje[selectedCar].imotor]));
                    }
                    break;
            }
        }
    }
}
