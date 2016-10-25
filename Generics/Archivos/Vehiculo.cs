using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Vehiculo
    {
        public string marca;
        public string color;
        public string patente;

        public Vehiculo(string marca, string color, string patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;
        }

        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            if (vehiculo1.patente == vehiculo2.patente)
                return true;
            return false;
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }

        public override bool Equals(object obj)
        {
            if (this == (Vehiculo)obj)
                return true;
            return false;
        }
    }
}
