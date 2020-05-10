using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDSI
{
    public class CocheGaraje
    {
        public enum Estado { ruedas, motor, parachoques, color , nada };
        public Estado estadoActual { get; set; }
        public string info { get; set; }
        public string estadistica { get; set; }
        public string nombreCoche { get; set; }
        public int imotor;
        public string[] motor;
        public int iruedas;
        public string[] ruedas;
        public int iparachoques;
        public string[] parachoques;
        public int icolor;
        public string[] color;
        public CocheGaraje() {
            imotor = 0;
            iruedas = 0;
            iparachoques = 0;
            icolor = 0;
            estadoActual = Estado.nada;
            motor = new string[2];
            motor[0] = "Assets/Garaje/Coches/motor1.png";
            motor[1] = "Assets/Garaje/Coches/motor2.png";

            ruedas = new string[2];
            ruedas[0] = "Assets/Garaje/Coches/rueda1.png";
            ruedas[1] = "Assets/Garaje/Coches/rueda2.png";

            parachoques = new string[2];
            parachoques[0] = "Assets/Garaje/Coches/para1.png";
            parachoques[1] = "Assets/Garaje/Coches/para2.png";
        }
    } 
    public class Coche1 : CocheGaraje
    {
        public Coche1()
        {
            estadistica = "Assets/Garaje/Estadistica.png";
            info = " Rol: Hacker \nHabilidad: Adios Visión! Nuestro hacker podrá quitar la visión del equipo contrario durante 2.5 segundos" +
                   " haciendo que su mapa se transforme en una gran mancha negra.";
            nombreCoche = "MUSTANG-SHELBY";
            color = new string[2];
            color[0] = "Assets/Garaje/Coches/coche1color1.png";
            color[1] = "Assets/Garaje/Coches/coche1color2.png";
        }
    }
    public class Coche2 : CocheGaraje
    {
        public Coche2()
        {
            estadistica = "Assets/Garaje/Estadistica2.png";
            info = " Rol: Ladrón de la Carga \nHabilidad: Nitro! Este coche tiene nitro, el cual el jugador podrá usar con el fin de recorrer largas calles" +
                   " de la manera más rápida. Tiene varios usos, pero consta de un tiempo de reutilización, asi que, ¡cuidado!";
            nombreCoche = "MERCEDES-BENZ";
            color = new string[3];
            color[0] = "Assets/Garaje/Coches/coche2color1.png";
            color[1] = "Assets/Garaje/Coches/coche2color2.png";
            color[2] = "Assets/Garaje/Coches/coche2color3.png";
        }
    }
    public class GarajeMngr
    {
        public static CocheGaraje[] GetGaraje()
        {
            var cochesGaraje = new CocheGaraje[2];
            cochesGaraje[0] = new Coche1();
            cochesGaraje[1] = new Coche2();
            return cochesGaraje;
        }
    }
}


