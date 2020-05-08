﻿using System;
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
        public string image { get; set; }
    }

    public class PlayerInfoManager
    {

        public static List<PlayerInfo> Bandoladrones()
        {
            var listaCoches = new List<PlayerInfo>();
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono1.png", dinero= "2000$", nombre = "Yukilled" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono2.png", dinero = "1500$", nombre = "Alonefcp" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono3.png", dinero = "1000$", nombre = "Perturbadogamer" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono4.png", dinero = "2700$", nombre = "Paulkmv" });
            return listaCoches;
        }
        public static List<PlayerInfo> BandoPolicias()
        {
            var listaCoches = new List<PlayerInfo>();
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono5.png", dinero = "2000$", nombre = "Estrujillo" });
            listaCoches.Add(new PlayerInfo { image = "ms-appx:///Assets/PostPartida/Icono6.png", dinero = "1500$", nombre = "FenomenCoyote" });

            return listaCoches;
        }

    }
}
