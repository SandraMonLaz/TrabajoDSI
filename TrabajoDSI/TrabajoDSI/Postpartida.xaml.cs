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
    public sealed partial class Postpartida : Page
    {

        public List<PlayerInfo> ListaLadrones;
        public List<PlayerInfo> ListaPolicias;
        private string DineroTotalLadrones;
        private string DineroTotalPolicias;
        private string ImagenGanadorPartida;

        private string _nombreP1;
        private string _dineroP1;
        private string _cocheP1;
        private string _imageP1;

        private string _nombreP2;
        private string _dineroP2;
        private string _cocheP2;
        private string _imageP2;


        private string _nombreP3;
        private string _dineroP3;
        private string _cocheP3;
        private string _imageP3;


        private string _nombreP4;
        private string _dineroP4;
        private string _cocheP4;
        private string _imageP4;


        private string _nombreP5;
        private string _dineroP5;
        private string _cocheP5;
        private string _imageP5;



        private string _nombreP6;
        private string _dineroP6;
        private string _cocheP6;
        private string _imageP6;


        public Postpartida()
        {
            this.InitializeComponent();
            ListaLadrones = PlayerInfoManager.Bandoladrones();
            ListaPolicias = PlayerInfoManager.BandoPolicias();
            ImagenGanadorPartida = TeamsInfo.getImageWinnerTeam();
            InitializePlayersInfo();
        }

        private void rematchB_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SeleccionCoche));
        }

        private void MenuB_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }




        private void textBoxChat_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ListViewChat.Visibility = Visibility.Visible;

        }


        private void textBoxChat_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                TextBlock mensage = new TextBlock();
                mensage.Text = "Alonefcp: " + textBoxChat.Text;
                textBoxChat.Text = "";
                ListViewChat.Items.Add(mensage);
            }

        }



        private void Grid_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ListViewChat.Visibility = Visibility.Collapsed;
        }

        private void InitializePlayersInfo()
        {
            _nombreP1 = ListaLadrones.ElementAt(0).nombre;
            _cocheP1 = ListaLadrones.ElementAt(0).coche;
            _dineroP1 = ListaLadrones.ElementAt(0).dinero + "$";
            _imageP1 = ListaLadrones.ElementAt(0).image;

            _nombreP2 = ListaLadrones.ElementAt(1).nombre;
            _cocheP2 = ListaLadrones.ElementAt(1).coche;
            _dineroP2 = ListaLadrones.ElementAt(1).dinero + "$";
            _imageP2 = ListaLadrones.ElementAt(1).image;

            _nombreP3 = ListaLadrones.ElementAt(2).nombre;
            _cocheP3 = ListaLadrones.ElementAt(2).coche;
            _dineroP3 = ListaLadrones.ElementAt(2).dinero + "$";
            _imageP3 = ListaLadrones.ElementAt(2).image;

            _nombreP4 = ListaLadrones.ElementAt(3).nombre;
            _cocheP4 = ListaLadrones.ElementAt(3).coche;
            _dineroP4 = ListaLadrones.ElementAt(3).dinero + "$";
            _imageP4 = ListaLadrones.ElementAt(3).image;

            _nombreP5 = ListaPolicias.ElementAt(0).nombre;
            _cocheP5 = ListaPolicias.ElementAt(0).coche;
            _dineroP5 = ListaPolicias.ElementAt(0).dinero + "$";
            _imageP5 = ListaPolicias.ElementAt(0).image;

            _nombreP6 = ListaPolicias.ElementAt(1).nombre;
            _cocheP6 = ListaPolicias.ElementAt(1).coche;
            _dineroP6 = ListaPolicias.ElementAt(1).dinero + "$";
            _imageP6 = ListaPolicias.ElementAt(1).image;

            int dineroLadrones = 0;
            for (int i = 0; i < ListaLadrones.Count; i++)
            {
                dineroLadrones += ListaLadrones.ElementAt(i).dinero;
            }
            DineroTotalLadrones = dineroLadrones + "$";
            int dineroPolicias = 0;
            for (int i = 0; i < ListaPolicias.Count; i++)
            {
                dineroPolicias += ListaPolicias.ElementAt(i).dinero;
            }
            DineroTotalPolicias = dineroPolicias + "$";

        }
    }
}
