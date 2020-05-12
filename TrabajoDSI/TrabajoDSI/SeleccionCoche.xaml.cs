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
        private string ImagenbandoJugador;
        private string TituloBandoJugador;
        private string PosicionPlayer1;
        private string PosicionPlayer2;
        private string PosicionPlayer3;
        private string PosicionPlayer4;
        private string PosicionPlayer5;
        private string PosicionPlayer6;
        private string PosicionPlayer7;
        private string PosicionPlayer8;

        bool playerReady;




        public SeleccionCoche()
        {
            this.InitializeComponent();
            ListaCoches = Carmanager.GetCars();
            selectedCar = null;
            InitializePlayerIcons();
            ImagenbandoJugador = TeamsInfo.getImagePlayerTeam();
            TituloBandoJugador = TeamsInfo.getTitlePlayerTeam();
            playerReady = false;
        }

        private void InitializePlayerIcons()
        {
            string preparado = TeamsInfo.PlayerConnectedIcon();
            string noPreparado = TeamsInfo.PlayerDisconnectedicon();
            string alpha = TeamsInfo.AlphaImage();
            if (TeamsInfo.ladron)
            {
                PosicionPlayer1 = noPreparado;
                PosicionPlayer2 = preparado;
                PosicionPlayer3 = preparado;
                PosicionPlayer4 = preparado;
                PosicionPlayer5 =alpha;
                PosicionPlayer6 = alpha;
                PosicionPlayer7 = noPreparado ;
                PosicionPlayer8 = noPreparado;
            }
            else
            {
                PosicionPlayer1 = noPreparado;
                PosicionPlayer2 = preparado;
                PosicionPlayer3 = alpha;
                PosicionPlayer4 = alpha;
                PosicionPlayer5 = noPreparado;
                PosicionPlayer6 = noPreparado;
                PosicionPlayer7 = noPreparado;
                PosicionPlayer8 = noPreparado;
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (selectedCar != null)
                this.Frame.Navigate(typeof(MenuPosicionamiento));
        }

        private void IconosCoches_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConfirmButton.Visibility = Visibility.Visible;
            if (!playerReady)
            {
                playerReady=true;
                Player1.Source = new BitmapImage(new Uri(TeamsInfo.PlayerConnectedIcon()));
                ImagenCocheSeleccionado.Visibility = Visibility.Visible;
                ImagenStatsCocheSeleccionado.Visibility = Visibility.Visible;
            }
            //Devolver al estado anterior el boton que estaba seleccionado
            selectedCar = (SelectableCar)e.ClickedItem;
            string aux = selectedCar.image;
            ImagenStatsCocheSeleccionado.Source = new BitmapImage(new Uri(selectedCar.statsImage));
            ImagenCocheSeleccionado.Source = new BitmapImage(new Uri(selectedCar.previewimage));
        }
    }
}
