using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDSI
{
    public class SelectableCar
    {

        public int width { get; set; }
        public int height { get; set; }
        public string nombre { get; set; }
        public string image { get; set; }
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

        public static  List<SelectableCar> GetCars()
        {
            var listaCoches = new List<SelectableCar>();
            listaCoches.Add(new SelectableCar { image = "ms-appx:///Assets/SeleccionCoche/BotonCoche1.png" ,imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche1Seleccionado.png" });
            listaCoches.Add(new SelectableCar { image = "ms-appx:///Assets/SeleccionCoche/BotonCoche2.png", imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche2Seleccionado.png" });
            listaCoches.Add(new SelectableCar { image = "ms-appx:///Assets/SeleccionCoche/BotonCoche3.png", imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche3Seleccionado.png" });
            listaCoches.Add(new SelectableCar { image = "ms-appx:///Assets/SeleccionCoche/BotonCoche4.png", imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche4Seleccionado.png" });
            listaCoches.Add(new SelectableCar { image = "ms-appx:///Assets/SeleccionCoche/BotonCoche1.png", imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche1Seleccionado.png" });
            listaCoches.Add(new SelectableCar { image = "ms-appx:///Assets/SeleccionCoche/BotonCoche2.png", imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche2Seleccionado.png" });
            listaCoches.Add(new SelectableCar { image = "ms-appx:///Assets/SeleccionCoche/BotonCoche3.png", imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche3Seleccionado.png" });
            listaCoches.Add(new SelectableCar { image = "ms-appx:///Assets/SeleccionCoche/BotonCoche4.png", imageSelected = "ms-appx:///Assets/SeleccionCoche/BotonCoche4Seleccionado.png" });
            return listaCoches;
        }

    }
}
