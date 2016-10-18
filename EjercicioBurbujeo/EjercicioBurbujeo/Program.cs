using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBurbujeo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1)Constructor - instancia - program
             * 2)Static - instancia - program
             * 3)instancia - static - constructor - program
             * 4)3 static - program
             * 5) 3 instancia - static - constructor - program
             * 
             */
            Class2 clase = new Class2();

            //Ejercicio 1
            try
            {
                clase.agregar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ejercicio 1");
                Console.WriteLine(ex.Message + " pase por " + ex.InnerException.Message);
            }
            
            // Ejercicio 2
            try
            {
                clase.Ejercicio2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ejercicio 2");
                Console.WriteLine(ex.Message);
            }

            //Ejercicio 3

            try
            {
                Class3 clase3 = new Class3();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ejercicio 3");
                Console.WriteLine(ex.Message +" " + ex.InnerException.Message + " " + ex.InnerException.InnerException.Message);
            }

            //Ejercicio 4
            try
            {
                Class3.metodoEstatico();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ejercicio 4");
                Console.WriteLine(ex.Message + " " + ex.InnerException.Message + " " + ex.InnerException.InnerException.Message);
            }

            //Ejercicio 5
            try
            {
                Class1 clase1 = new Class1(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ejercicio 5");
                Console.WriteLine(ex.Message + " - " + ex.InnerException.Message + " - " + ex.InnerException.InnerException.Message + " - " + ex.InnerException.InnerException.InnerException.Message + " - " + ex.InnerException.InnerException.InnerException.InnerException.Message); 
            }

            Console.ReadLine();
        }
    }
}
