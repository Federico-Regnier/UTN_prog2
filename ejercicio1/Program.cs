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
            /*eFabricante fabricante;

            fabricante = eFabricante.Honda;
            Console.WriteLine(fabricante);
            fabricante = (eFabricante)1;
            Console.WriteLine(fabricante);
            Console.ReadKey();*/

            /*Kilometro kilometros = new Kilometro(5);
            Tiempo tiempo = new Tiempo(20);
            Carrera carrera = new Carrera();
            carrera.CorrerCarrera(tiempo);
            carrera.CorrerCarrera(kilometros);*/

            Tiempo t1 = new Tiempo();
            Tiempo result = t1 + 10;
            Console.WriteLine(result.cantidad);
            Console.ReadKey();

        }
    }
}
