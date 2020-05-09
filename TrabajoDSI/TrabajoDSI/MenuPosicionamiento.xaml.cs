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
using static TrabajoDSI.Lugar;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace TrabajoDSI
{
    public class Lugar
    {
        public string punto;
        public string puntoJugador;
        public Image img;
        public string nombre;

        public class PuntoA : Lugar
        {
            public PuntoA(Image img_)
            {
                img = img_;
                punto = "Assets/A.png";
                puntoJugador = "Assets/Posicionamiento/AJugador.png";
                nombre = "(A) Callejon los Antonios";
            }
        }

        public class PuntoB : Lugar
        {
            public PuntoB(Image img_)
            {
                img = img_;
                punto = "Assets/IconoBancoPos.png";
                puntoJugador = "Assets/Posicionamiento/IconoBancoJugador.png";
                nombre = "(B) Entrada trasera";
            }
        }

        public class PuntoC : Lugar
        {
            public PuntoC(Image img_)
            {
                img = img_;
                punto = "Assets/C.png";
                puntoJugador = "Assets/Posicionamiento/CJugador.png";
                nombre = "(C) Mesón Paco";
            }
        }

        public class PuntoD : Lugar
        {
            public PuntoD(Image img_)
            {
                img = img_;
                punto = "Assets/D.png";
                puntoJugador = "Assets/Posicionamiento/DJugador.png";
                nombre = "(D) Boca de metro";
            }
        }
    }


    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MenuPosicionamiento : Page
    {
        public ObservableCollection<Lugar> ListaLugares { get; } = new ObservableCollection<Lugar>();

        public MenuPosicionamiento()
        {
            this.InitializeComponent();

            //Creo y añado los lugares a la ListaLugares
            ListaLugares.Add(new PuntoA(PuntoA));
            ListaLugares.Add(new PuntoB(Banco));
            ListaLugares.Add(new PuntoC(PuntoC));
            ListaLugares.Add(new PuntoD(PuntoD));

            //Los elementos de la lista lugares los añado al listview llamado Lugares
            foreach (Lugar l in ListaLugares) Lugares.Items.Add(l);
        }


        private void button_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            button.Opacity = 0.5;
        }

        private void button_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            button.Opacity = 1;
        }

        private void grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double w = ((Frame)Window.Current.Content).ActualWidth;
            double h = ((Frame)Window.Current.Content).ActualHeight;

            Places.Width = w / 5;
            Places.Height = h / 3;

            button.Width = w / 5;
            button.Height = h / 6;
        }

        private void auxGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double w = auxGrid.ActualWidth;
            double h = auxGrid.ActualHeight;

            //Icono de policia
            Policia.Width = w / 10;
            Policia.Height = h / 10;
            Canvas.SetLeft(Policia, w - Policia.Width);
            Canvas.SetTop(Policia, Policia.Height);

            //Icono de destino
            Destino.Width = w / 10;
            Destino.Height = h / 10;
            Canvas.SetLeft(Destino, Destino.Width);
            Canvas.SetTop(Destino, Destino.Height);

            //Icono de banco
            Banco.Width = w / 5;
            Banco.Height = h / 5;
            Canvas.SetLeft(Banco, w / 2 - Banco.Width);
            Canvas.SetTop(Banco, h / 2 - Banco.Height);

            //Puntos
            PuntoA.Width = w / 13;
            PuntoA.Height = h / 13;
            Canvas.SetLeft(PuntoA, Canvas.GetLeft(Banco) + PuntoA.Width * 1.5);
            Canvas.SetTop(PuntoA, Canvas.GetTop(Banco) + PuntoA.Height * 2);

            PuntoC.Width = w / 13;
            PuntoC.Height = h / 13;
            Canvas.SetLeft(PuntoC, Canvas.GetLeft(Banco) - PuntoC.Width / 2);
            Canvas.SetTop(PuntoC, Canvas.GetTop(Banco) + PuntoC.Height);

            PuntoD.Width = w / 13;
            PuntoD.Height = h / 13;
            Canvas.SetLeft(PuntoD, Canvas.GetLeft(Banco));
            Canvas.SetTop(PuntoD, Canvas.GetTop(Banco) + PuntoD.Height * 3);

            ////Jugador
            //Jugador.Width = w / 10;
            //Jugador.Height = h / 10;
            //Canvas.SetLeft(Jugador, Canvas.GetLeft(Banco) + PuntoA.Width * 1.5);
            //Canvas.SetTop(Jugador, Canvas.GetTop(Banco) + PuntoA.Height * 2);
        }

        private void onClick(object sender, PointerRoutedEventArgs e)
        {
            //Si hay algun lugar seleccinado podemos pasar al siguiente menu
            if (Lugares.SelectedItem != null) this.Frame.Navigate(typeof(UIGame));
        }

        private void Lugares_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

              Lugar l = Lugares.SelectedItem as Lugar;

              foreach (Lugar a in e.RemovedItems) a.img.Source = new BitmapImage(new Uri("ms-appx:///" + a.punto));

              if (l != null)
              {
                  l.img.Source = new BitmapImage(new Uri("ms-appx:///" + l.puntoJugador));
              }
 
        }
    }
}
