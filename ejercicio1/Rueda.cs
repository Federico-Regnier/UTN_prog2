using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Rueda
    {
        public string marca;
        public float tamanio;

        public Rueda()
        {
            this.marca = "Sin Marca";
        }

        public void MostrarRueda()
        {
            Console.WriteLine("El tamaño de rueda es: " + this.tamanio);
        }
    }
}
