using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Privada avionPrivado = new Privada("aaa 111", 5555555);
            Comercial avionComercial = new Comercial("bbb 222", 4444444);
            List<Avion> listaAviones = new List<Avion>();
            List<IAFIP> listaAfip = new List<IAFIP>();

            listaAviones.Add(avionComercial);
            listaAviones.Add(avionPrivado);
            foreach (Avion item in listaAviones)
            {
                Console.WriteLine(item.Datos);
            }

            listaAfip.Add(avionPrivado);
            listaAfip.Add(avionComercial);
            Console.WriteLine("IMPUESTOS");
            foreach (IAFIP item in listaAfip)
            {
                Console.WriteLine(Gestion.MostrarImp(item));
            }
            Console.ReadLine();
        }
    }
}
