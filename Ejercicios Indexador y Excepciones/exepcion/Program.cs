using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera miCarrera = new Carrera("Autodromo");
            Auto auto1 = new Auto("Ford", 1);
            Auto auto2 = new Auto("Chev", 2);
            Auto auto3 = new Auto("Audi", 3);
            Auto auto4 = new Auto("Ford2", 4);

            for (int i = 0; i < 4; i++)
            {
                auto1.listaRuedas.Add(new Rueda("AA" + (i + 1)));
                auto2.listaRuedas.Add(new Rueda("BB" + (i + 1)));
                auto3.listaRuedas.Add(new Rueda("CC" + (i + 1)));
                auto4.listaRuedas.Add(new Rueda("DD" + (i + 1)));
            }
            
            miCarrera.listaDeAutos.Add(auto1);
            miCarrera.listaDeAutos.Add(auto2);
            miCarrera.listaDeAutos.Add(auto3);
            miCarrera.listaDeAutos.Add(auto4);

            try
            {
                miCarrera.CorrerCarrera();
            }
            catch (PinchaduraException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (AutoException excepAuto)
            {
                Console.WriteLine(excepAuto.Message);
            }
            
            catch (miExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
            
        }
    }
}

