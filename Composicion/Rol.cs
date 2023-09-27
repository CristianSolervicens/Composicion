using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{

    public interface I_Rol
    {
        public int PotencialOfensivoExtra();
        public string YoSoy();
    }

    internal class Guerrero: I_Rol
    {
        public int PotencialOfensivoExtra()
        {
            return 10;
        }

        public string YoSoy()
        {
            return "Guerrero";
        }
    }

    internal class Cazador : I_Rol
    {
        public Cazador(Mascota mascota)
        {
            this.mascota = mascota;
        }

        public Mascota mascota { get; set; }
        public int PotencialOfensivoExtra()
        {
            return mascota.PotencialOfensivo();
        }

        public string YoSoy()
        {
            return $"Cazador y tengo {mascota.YoSoy()}";
        }
    }

    internal class Brujo : I_Rol
    {
        public int PotencialOfensivoExtra()
        {
            return 0;
        }

        public string YoSoy()
        {
            return "Brujo";
        }
    }


    public class Mascota
    {
        public Mascota(int fuerza, bool tiene_garras, int edad)
        {
            this.fuerza = fuerza;
            this.tiene_garras = tiene_garras;
            this.edad = edad;
        }
        public int fuerza {  get; set; }
        public bool tiene_garras { get; set; }
        public int edad {  get; set; }

        public int PotencialOfensivo()
        {
            return (tiene_garras) ? fuerza * 2 : fuerza;
        }

        public string YoSoy()
        {
            return "Mascota " + ((tiene_garras)? "Con Garras":"Sin Garras");
        }
    }

}
