using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Tiempo
    {
        public int cantidad;

        public Tiempo() { }

        public Tiempo(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Tiempo Sumar(Tiempo tiempoAux, int valor)
        {
            tiempoAux.cantidad = tiempoAux.cantidad + valor;
            return tiempoAux;
        }

        public static Tiempo operator +(Tiempo tiempoAux, int valor)
        {
            tiempoAux.cantidad = tiempoAux.cantidad + valor;
            return tiempoAux;
        }

    }
}
