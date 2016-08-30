using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); 
            Kilometros kilometros = random.Next(1, 100);
            Tiempo tiempo = random.Next(1, 100);
            Carrera carrera = new Carrera();
            
            carrera.CorrerCarrera(tiempo);
            carrera.CorrerCarrera(kilometros);
            
            Console.ReadKey();

        }
    }
}
