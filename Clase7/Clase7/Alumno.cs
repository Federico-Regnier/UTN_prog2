using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Alumno
    {
        public string nombre;
        public int legajo;

        public Alumno(string nombre, int legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public Alumno(int legajo, string nombre) : this(nombre, legajo) { }

        static public bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            if(alumno1.legajo == alumno2.legajo)
                return true;
            return false;
        }

        static public bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1 == alumno2);
        }
    }
}
