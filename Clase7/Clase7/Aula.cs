using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    public class Aula
    {
        public int numero;
        public Alumno[] listaDeAlumnos;

        public Aula()
        {
            this.listaDeAlumnos = new Alumno[10];
            /* No hacer esto
            for (int i = 0; i < 10; i++)
            {
                this.listaDeAlumnos[i] = new Alumno();
            }
            
            foreach (Alumno objAlumno in this.listaDeAlumnos)
            {
                objAlumno.nombre = "Natalia Natalia";
            }*/
        }

        public static void MostrarAlumno(Aula aula)
        {
            foreach (Alumno objAlum in aula.listaDeAlumnos)
            {
                if ((Object)objAlum != null)
                    Console.WriteLine(objAlum.nombre);
            }
        }

        /// <summary>
        /// Devuelve el indice del primer elemento null, de lo contrario
        /// retorna -1.
        /// </summary>
        /// <returns></returns>
        public int ObtenerIndice()
        {
            int indice;
            for (indice = 0; indice < this.listaDeAlumnos.Length; indice++)
            {
                if ((Object)this.listaDeAlumnos[indice] == null)
                    break;
            }

            if (indice < this.listaDeAlumnos.Length)
                return indice;
            return -1;
        }

        /// <summary>
        /// Retorna el indice del objeto, de lo contrario retorna -1
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public int ObtenerIndice(Alumno alumno)
        {
            for (int indice = 0; indice < this.listaDeAlumnos.Length; indice++)
            {
                if ((Object) this.listaDeAlumnos[indice] != null && this.listaDeAlumnos[indice] == alumno)
                    return indice;
            }

            return -1;
        }
        
        public void AgregarAlumno(Alumno alumno)
        {
            int indice = this.ObtenerIndice();

            if (!this.ExisteAlumno(alumno))
                if (indice != -1)
                    listaDeAlumnos[indice] = alumno;
                else
                    Console.WriteLine("No hay espacio");
            else
                Console.WriteLine("El alumno ya existe");
        }

        public void BorrarAlumno(Alumno alumno)
        {
            int indice = this.ObtenerIndice(alumno);
            if (indice != -1)
                this.listaDeAlumnos[indice] = null;
            
        }

        public bool ExisteAlumno(Alumno alumno)
        {
            if (this.ObtenerIndice(alumno) != -1)
                return true;
            return false;
        }

        public static bool operator ==(Aula aula, Alumno alumno)
        {
            if (aula.ObtenerIndice(alumno) != -1)
                return true;
            return false;
        }

        public static bool operator !=(Aula aula, Alumno alumno)
        {
            return !(aula == alumno);
        }

        public static Aula operator +(Aula aula, Alumno alumno)
        {
            aula.AgregarAlumno(alumno);
            return aula;
        }

        public static Aula operator -(Aula aula, Alumno alumno)
        {
            aula.BorrarAlumno(alumno);
            return aula;
        }
    }
}
