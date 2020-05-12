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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace TrabajoDSI
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<Friend> friendsList;
        public MainPage()
        {
            this.InitializeComponent();
            friendsList = InitializeFriendsList.initializeFriends();
        }

        private void FriendsSV_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            FriendsSV.IsPaneOpen = true;
            SearchFriendsTextBox.Visibility = Visibility.Visible;
            flechasAmigos.Visibility = Visibility.Collapsed;
        }

        private void FriendsSV_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            FriendsSV.IsPaneOpen = false;
            SearchFriendsTextBox.Visibility = Visibility.Collapsed;
            flechasAmigos.Visibility = Visibility.Visible;
        }

        private void Image_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/MenuPrincipal/brilloCoche.png"));
        }

        private void Image_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            CarImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/MenuPrincipal/lowPolyCar.png"));
        }

        private void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Garaje));
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

        private void infoSV_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            infoSV.IsPaneOpen = true;
            flechasNews.Visibility = Visibility.Collapsed;
        }

        private void infoSV_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            infoSV.IsPaneOpen = false;
            flechasNews.Visibility = Visibility.Visible;
        }

        private void AjustesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ajustes));
        }

        private void policeButton_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            TeamsInfo.ladron = false;
            this.Frame.Navigate(typeof(SeleccionCoche));
        }

        private void thiefButton_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            TeamsInfo.ladron = true;
            this.Frame.Navigate(typeof(SeleccionCoche));
        }

        private void SearchFriendsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchName = SearchFriendsTextBox.Text;
            foreach(Friend friend in friendsList)
            {
                if (friend.name == searchName)
                {
                    FriendsList.SelectedItem = friend;
                }
            }
        }
    }
}
