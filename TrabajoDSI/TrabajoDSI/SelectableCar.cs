using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDSI
{

    public class SelectableCar
    {

        public string image { get; set; }
        public string statsImage { get; set; }
        public string previewimage { get; set; }

    }
    public class Carmanager
    {

        public static List<SelectableCar> GetCars()
        {
            var listaCoches = new List<SelectableCar>();
            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche1.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar1.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar.png"
            });

            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche2.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar2.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar2.png"
            });

            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche3.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar3.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar3.png"
            });
            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche4.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar4.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar4.png"
            });
            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche1.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar1.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar.png"
            });

            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche2.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar2.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar2.png"
            });

            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche3.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar3.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar3.png"
            });
            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche4.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar4.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar4.png"
            });

            return listaCoches;
        }

    }
}
