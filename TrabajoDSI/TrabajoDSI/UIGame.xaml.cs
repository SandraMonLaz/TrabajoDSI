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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace NonStopDriver
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class UIGame : Page
    {
        public UIGame()
        {
            this.InitializeComponent();
        }

        private void grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double w = grid.ActualWidth;
            double h = grid.ActualHeight;

            //Barra
            Barra.Width = w / 2;
            Barra.Height = h / 7;
            Canvas.SetLeft(Barra, canvas.ActualWidth - Barra.Width * 1.5);
            Canvas.SetTop(Barra, Barra.Height / 3);

            //Velocimetro
            Velocimetro.Width = w / 3;
            Velocimetro.Height = h / 3;
            Canvas.SetLeft(Velocimetro, canvas.ActualWidth - Velocimetro.Width / 1.3);
            Canvas.SetTop(Velocimetro, canvas.ActualHeight - Velocimetro.Height);

            //Minimapa
            minimapa.Width = w / 3;
            minimapa.Height = h / 3;
            Canvas.SetLeft(minimapa, canvas.ActualWidth - minimapa.Width * 3.2);
            Canvas.SetTop(minimapa, canvas.ActualHeight - minimapa.Height);

            //Dinero
            dinero.Width = w / 10;
            dinero.Height = h / 5;
            Canvas.SetLeft(dinero, canvas.ActualWidth - minimapa.Width * 2.9);
            Canvas.SetTop(dinero, canvas.ActualHeight - minimapa.Height * 1.2);
        }
    }
}
