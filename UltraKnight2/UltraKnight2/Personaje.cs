using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraKnight2
{
    internal class Personaje
    {
        public string Nombre
        {
            get; set;
        }
        public int Fuerza
        {
            get; set;
        }
        public int Defensa
        {
            get; set;
        }
        public int Vida
        {
            get; set;
        }
        public int Energía
        {
            get; set;
        }
        public Personaje(string Nombre, int Fuerza, int Defensa, int Vida, int Energía)
        {
            this.Nombre = Nombre;
            this.Fuerza = Fuerza;
            this.Defensa = Defensa;
            this.Vida = Defensa * 2;
            this.Energía = Fuerza * 2;
        }
    }
}
