using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDSI
{
    public class PlayerInfo
    {
        public string dinero { get; set; }
        public string nombre { get; set; }
        public string coche { get; set; }
        public string image { get; set; }

    }


    public class PlayerInfoManager
    {

        public static List<PlayerInfo> Bandoladrones()
        {
            var listaCoches = new List<PlayerInfo>();
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono1.png", dinero = "2000$", coche = "BMW M2 CS", nombre = "Yukilled" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono2.png", dinero = "1500$", coche = "Audi-R8", nombre = "Alonefcp" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono3.png", dinero = "1000$", coche = "Audi-R8", nombre = "Pertur" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono4.png", dinero = "2700$", coche = "Jeep Compass", nombre = "Paulkmv" });
            TeamsInfo.dineroLadrones = 2000 + 1500 + 1000 + 2700;
            TeamsInfo.dineroPolicias = 2000 + 1500;
            return listaCoches;
        }
        public static List<PlayerInfo> BandoPolicias()
        {
            var listaCoches = new List<PlayerInfo>();
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono5.png", coche = "BMW Coupé", dinero = "2000$", nombre = "Estrujillo" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono6.png", coche = "Toyota Prius", dinero = "1500$", nombre = "Fenomen" });

            return listaCoches;
        }
    }
    public class TeamsInfo
    {
        static public int dineroLadrones { get; set; }
        static public int dineroPolicias { get; set; }

        static public string PlayerConnectedIcon() { return "ms-appx:///Assets/SeleccionCoche/PlayerConnected.png"; }
        static public string PlayerDisconnectedicon() { return "ms-appx:///Assets/SeleccionCoche/PlayerDisConnected.png"; }
        static public string AlphaImage() { return "ms-appx:///Assets/SeleccionCoche/Alpha.png"; }


        public static bool ladron { get; set; }

        public static string getImagePlayerTeam()
        {
            string image;
            if (ladron)
                image = "ms-appx:///Assets/SeleccionCoche/BandoLadrones.png";
            else
                image = "ms-appx:///Assets/SeleccionCoche/BandoPolicias.png";
            return image;
        }
        public static string getTitlePlayerTeam()
        {
            string image;
            if (ladron)
                image = "ms-appx:///Assets/SeleccionCoche/TituloLadrones.png";
            else
                image = "ms-appx:///Assets/SeleccionCoche/TituloPolicias.png";
            return image;
        }
        public static string getImageWinnerTeam()
        {
            string image;
            if (ladron)
                image = "ms-appx:///Assets/PostPartida/BandoLadronesGanan.png";
            else
                image = "ms-appx:///Assets/PostPartida/BandoPoliciasGanan.png";
            return image;
        }
    }


}
