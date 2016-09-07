using System;
using System.Collections.Generic;
using System.Collections;
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
            Kilometros kilometros = random.Next(1, 10);
            Tiempo tiempo = random.Next(1, 10);
            Carrera carrera = new Carrera();
            List<Auto> listaDeAutos = new List<Auto>();
            ArrayList miArrayList = new ArrayList();
            Stack<Auto> miPila = new Stack<Auto>();//Pila. Los elementos se agregan en ultimo lugar
            Queue<Auto> miQueue = new Queue<Auto>();//Salen en el mismo orden en que llegaron

            miArrayList.Add(new Auto());
            miArrayList.Add(new Auto());
            

            for (int i = 0; i < 10; i++)
            {
                carrera = carrera + new Auto();
            }
            
            carrera.CorrerCarrera(tiempo);
            carrera.CorrerCarrera(kilometros);
            //Console.Write(carrera.MostrarCarrera());
            Console.ReadKey();

        }
    }
}
