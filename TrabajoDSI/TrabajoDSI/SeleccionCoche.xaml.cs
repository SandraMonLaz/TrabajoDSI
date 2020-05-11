using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class SeleccionCoche : Page
    {

        public List<SelectableCar> ListaCoches;
        private SelectableCar selectedCar;

        public SeleccionCoche()
        {
            this.InitializeComponent();
            ListaCoches = Carmanager.GetCars();
            selectedCar = null;
            imagenBando.Source = new BitmapImage(new Uri(bandoJugador.getImagePlayerTeam()));
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedCar != null)
                this.Frame.Navigate(typeof(MenuPosicionamiento));
        }

        private void IconosCoches_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConfirmButton.Visibility = Visibility.Visible;
            //Devolver al estado anterior el boton que estaba seleccionado
            selectedCar = (SelectableCar)e.ClickedItem;
            string aux = selectedCar.image;
            ImagenStatsCocheSeleccionado.Source = new BitmapImage(new Uri(selectedCar.statsImage));
            ImagenCocheSeleccionado.Source = new BitmapImage(new Uri(selectedCar.previewimage));
        }
    }
}
