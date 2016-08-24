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
        public float tamaño;
        /// <summary>
        /// Constructor por defecto. Tamaño en 0 y la marca en 'Sin marca'
        /// </summary>
        public Rueda()
        {
            this.marca = "Sin Marca";
        }
        /// <summary>
        /// Constructor que inicializa la marca de rueda 
        /// </summary>
        /// <param name="marca">Marca de rueda</param>
        public Rueda(string marca)
        {
            this.marca = marca;
        }

        /// <summary>
        /// Constructor que inicializa el tamaño de rueda
        /// </summary>
        /// <param name="tamaño">Tamaño de rueda</param>
        public Rueda(int tamaño):this()
        {
            this.tamaño = tamaño;
        }

        /// <summary>
        /// Constructor toma como parametros la marca y tamaño de rueda
        /// </summary>
        /// <param name="marca">Marca de la rueda</param>
        /// <param name="tamaño">Tamaño de la rueda</param>
        public Rueda(string marca, int tamaño):this(tamaño)
        {
            this.marca = marca;
        }

        /// <summary>
        /// Constructor que toma como parametros el tamaño de rueda y la marca
        /// </summary>
        /// <param name="tamaño">Tamaño de la rueda</param>
        /// <param name="marca">Marca de la rueda</param>
        public Rueda(int tamaño, string marca) : this(marca, tamaño) { }
       
        public void MostrarRueda()
        {
            Console.WriteLine("El tamaño de rueda es: " + this.tamaño);
        }
    }
}
