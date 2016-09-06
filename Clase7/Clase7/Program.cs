using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula aula1 = new Aula();
            Alumno alumno1 = new Alumno("Juan", 1);
            Alumno alumno2 = new Alumno("Jorge", 2);
            Alumno alumno3 = new Alumno("Jose", 3);
            Alumno alumno4 = new Alumno("Martin", 4);

            aula1 = aula1 + alumno1;
            aula1 = aula1 + alumno2;
            aula1 = aula1 + alumno3;
            aula1 = aula1 - alumno2;
            aula1 = aula1 + alumno4;
            aula1 = aula1 + alumno1;
            Aula.MostrarAlumno(aula1);
            
            Console.ReadKey();
        }
    }
}
