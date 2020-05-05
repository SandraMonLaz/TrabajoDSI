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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace NonStopDriver
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void rematchB_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(Page1));
        }

        private void MenuB_Click(object sender, RoutedEventArgs e)
        {
           // this.Frame.Navigate(typeof(Page1));
        }

    


        private void textBoxChat_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ListViewChat.Visibility = Visibility.Visible;

        }

        private void textBoxChat_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ListViewChat.Visibility = Visibility.Collapsed;
        }

        private void textBoxChat_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }
    }
}
