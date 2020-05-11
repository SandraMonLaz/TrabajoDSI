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

    public class TeamsInfo
    {
        static public int dineroLadrones { get; set; }
        static public int dineroPolicias { get; set; }
    }

    public class PlayerInfoManager
    {

        public static List<PlayerInfo> Bandoladrones()
        {
            var listaCoches = new List<PlayerInfo>();
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono1.png", dinero = "2000$", coche = "Audi-R8", nombre = "Yukilled" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono2.png", dinero = "1500$", coche = "Audi-R8", nombre = "Alonefcp" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono3.png", dinero = "1000$", coche = "Audi-R8", nombre = "Pertur" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono4.png", dinero = "2700$", coche = "Audi-R8", nombre = "Paulkmv" });
            TeamsInfo.dineroLadrones = 2000 + 1500 + 1000 + 2700;
            TeamsInfo.dineroPolicias = 2000 + 1500;
            return listaCoches;
        }
        public static List<PlayerInfo> BandoPolicias()
        {
            var listaCoches = new List<PlayerInfo>();
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono5.png", coche = "Audi-R8", dinero = "2000$", nombre = "Estrujillo" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono6.png", coche = "Audi-R8", dinero = "1500$", nombre = "FenomenCoyote" });

            return listaCoches;
        }
    }
}
