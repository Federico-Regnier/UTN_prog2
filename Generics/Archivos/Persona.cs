using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Persona
    {
        public string nombre;
        public double dni;

        public Persona(string nombre, double dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public static bool operator ==(Persona persona1, Persona persona2)
        {
            if (persona1.dni == persona2.dni)
                return true;
            return false;
        }

        public static bool operator !=(Persona persona1, Persona persona2)
        {
            return !(persona1 == persona2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}", this.nombre).AppendLine();
            sb.AppendFormat("DNI: {0}", this.dni).AppendLine();

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool bandera = false;
            try
            {
                if (this == (Persona)obj)
                    bandera = true;
            }
            catch (Exception)
            {
             
            }

            return bandera;
        }
    }
}
