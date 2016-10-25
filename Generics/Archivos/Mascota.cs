using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Mascota
    {
        public string nombre;
        public string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            if (m1.nombre == m2.nombre && m1.raza == m2.raza)
                return true;
            return false;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }

        public override bool Equals(object obj)
        {
            bool bandera = false;
            try
            {
                if (this == (Mascota)obj)
                    bandera = true;
            }
            catch (Exception)
            {

            }

            return bandera;
        }
    }
}
