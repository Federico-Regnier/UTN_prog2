using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pc pcUno = new Pc("Dell", "Linux");
            //Pc pcDos = new Pc("Asus");
            Laboratorio miLab = new Laboratorio("Lab4");

            //Pc pcTres = new Pc("Sony");



            miLab[0] = "Sony";
            miLab[1] = "Dell";
            miLab[2] = "Asus";
            // Pc varInt = miLab[5]; 
            for (int i = 0; i < miLab.listaDePc.Count; i++)
            {
                Console.WriteLine(miLab.listaDePc[i].marca + " " + miLab.listaDePc[i].SO + " " + miLab.listaDePc[i].numero.ToString() );
            }

            Console.ReadKey();
        }
    }
}
