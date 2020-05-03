﻿using System;
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

        private void FriendsSV_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            FriendsSV.IsPaneOpen = true;
            SearchFriendsTextBox.Visibility = Visibility.Visible;
        }

        private void FriendsSV_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            FriendsSV.IsPaneOpen = false;
            SearchFriendsTextBox.Visibility = Visibility.Collapsed;
        }

        private void Image_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/brilloCoche.png"));
        }

        private void Image_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/lowPolyCar.png"));
        }

        private void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            //Ir a garaje
        }

        private void thiefButton_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            thiefButton.Source = new BitmapImage(new Uri("ms-appx:///Assets/botonThiefPress.png"));
        }

        private void thiefButton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            thiefButton.Source = new BitmapImage(new Uri("ms-appx:///Assets/botonThief.png"));
        }

        private void policeButton_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            policeButton.Source = new BitmapImage(new Uri("ms-appx:///Assets/PoliceButonPress.png"));
        }

        private void policeButton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            policeButton.Source = new BitmapImage(new Uri("ms-appx:///Assets/PoliceButon.png"));
        }
    }
}
