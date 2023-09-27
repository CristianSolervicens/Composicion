using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    public class Personaje
    {
        public Personaje(I_Rol rol, int fuerza, int inteligencia)
        {
            this.rol = rol;
            this.fuerza = fuerza;
            this.inteligencia = inteligencia;
        }

        public I_Rol rol { get; set; }
        public int fuerza {  get; set; }
        public int inteligencia { get; set; }

        public virtual int PotencialOfensivo()
        {
            return (10 * fuerza) + rol.PotencialOfensivoExtra();
        }

        public virtual void YoSoy()
        {
            Console.WriteLine("Yo Soy de la Clase Base");
        }
    }

    public class Humano: Personaje 
    {
        public Humano(I_Rol rol, int fuerza, int inteligencia) : base(rol, fuerza, inteligencia)
        {
            //this.rol = rol;
            //this.fuerza = fuerza;
            //this.inteligencia = inteligencia;
        }

        public override void YoSoy()
        {
            Console.WriteLine($"Yo Soy Humano {rol.YoSoy()}: Potencial Ofensivo {PotencialOfensivo()}");
        }
    }

    public class Orco: Personaje
    {
        public Orco(I_Rol rol, int fuerza, int inteligencia) : base(rol, fuerza, inteligencia)
        {
            //this.rol = rol;
            //this.fuerza = fuerza;
            //this.inteligencia = inteligencia;
        }

        public override int PotencialOfensivo()
        {
            return Convert.ToInt32(base.PotencialOfensivo() * 1.1);
        }

        public override void YoSoy()
        {
            Console.WriteLine($"Yo Soy Orco {rol.YoSoy()}: Potencia Ofensiva {PotencialOfensivo()}");
        }
    }
}
