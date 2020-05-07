using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDSI
{
    public class Coche
    {
        public enum Estado{ruedas, motor, parachoques, color};
        Estado actual = Estado.motor;

        string info;
        string nombreCoche;
        string[] motor;
        string[] ruedas;
        string[] parachoques;
        string[] color;
        Coche() {
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
        public string getMotor(int i)
        {
            return motor[i];
        }
        public string getRuedas(int i)
        {
            return ruedas[i];
        }
        public string getParachoques(int i)
        {
            return parachoques[i];
        }
        public string getColor(int i)
        {
            return color[i];
        }
        public void setEstado(Estado e) { actual = e; }
        public Estado getEstado()
        {
            return actual;
        }

        public class Coche1 :  Coche{
            Coche1()
            {
                info = " Rol: Hacker /n Habilidad: Adios Visión! Nuestro hacker podrá quitar la visión del equipo contrario durante 2.5 segundos" +
                       " haciendo que su mapa se transforme en una gran mancha negra.";
                nombreCoche = "MUSTANG-SHELBY";
                color = new string[3];
                color[0] = "Assets/Garaje/Coches/coche1color1.png";
                color[1] = "Assets/Garaje/Coches/coche1color2.png";
            }
        }
        public class Coche2 : Coche
        {
            Coche2()
            {
                info = " Rol: Ladrón de la Carga /n Habilidad: Nitro! Este coche tiene nitro, el cual el jugador podrá usar con el fin de recorrer largas calles" +
                       " de la manera más rápida. Tiene varios usos, pero consta de un tiempo de reutilización, asi que, ¡cuidado!";
                nombreCoche = "MERCEDES-BENZ";
                color = new string[3];
                color[0] = "Assets/Garaje/Coches/coche2color1.png";
                color[1] = "Assets/Garaje/Coches/coche2color2.png";
                color[2] = "Assets/Garaje/Coches/coche2color3.png";
            }
        }
    }
}


