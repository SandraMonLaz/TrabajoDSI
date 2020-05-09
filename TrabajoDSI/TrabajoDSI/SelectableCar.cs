using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDSI
{

    public class bandoJugador
    {
        public static bool ladron { get; set;}

        public static string getImagePlayerTeam()
        {
            string image;
            if (ladron)
                image = "ms-appx:///Assets/SeleccionCoche/BandoLadrones.png";
            else
                image = "ms-appx:///Assets/SeleccionCoche/BandoPolicias.png";
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
    public class SelectableCar
    {

        public int width { get; set; }
        public int height { get; set; }
        public string nombre { get; set; }
        public string image { get; set; }
        public string statsImage { get; set; }
        public string previewimage { get; set; }
        public string imageSelected { get; set; }



        //public static List<SelectableCar> selectableCars = new List<SelectableCar>()
        //{
        //    new SelectableCar()
        //    {
        //        image ="ms-appx:///Assets/SeleccionCoche/BotonCoche1.png"

        //     },
        //     new SelectableCar()
        //    {
        //        image ="ms-appx:///Assets/SeleccionCoche/BotonCoche2.png"

        //     },
        //      new SelectableCar()
        //    {
        //        image ="ms-appx:///Assets/SeleccionCoche/BotonCoche3.png"

        //     },
        //       new SelectableCar()
        //    {
        //        image ="ms-appx:///Assets/SeleccionCoche/BotonCoche4.png"

        //     },


        //  };


        //public static IList<SelectableCar> GetAllSelectablecars()
        //{
        //    return selectableCars;
        //}

        //public static SelectableCar GetSelectableCarbyId(int id)
        //{
        //    return selectableCars[id];
        //}
    }
    public class Carmanager
    {

        public static List<SelectableCar> GetCars()
        {
            var listaCoches = new List<SelectableCar>();
            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche1.png",
                imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche1Seleccionado.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar1.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar.png"
            });

            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche2.png",
                imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche2Seleccionado.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar2.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar2.png"
            });

            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche3.png",
                imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche3Seleccionado.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar3.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar3.png"
            });
            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche4.png",
                imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche4Seleccionado.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar4.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar4.png"
            });
            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche1.png",
                imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche1Seleccionado.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar1.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar.png"
            });

            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche2.png",
                imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche2Seleccionado.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar2.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar2.png"
            });

            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche3.png",
                imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche3Seleccionado.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar3.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar3.png"
            });
            listaCoches.Add(new SelectableCar
            {
                image = "ms-appx:///Assets/SeleccionCoche/BotonCoche4.png",
                imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche4Seleccionado.png",
                statsImage = "ms-appx:///Assets/SeleccionCoche/StatsCar4.png",
                previewimage = "ms-appx:///Assets/SeleccionCoche/lowPolyCar4.png"
            });

            return listaCoches;
        }

    }
}
