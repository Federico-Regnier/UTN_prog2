using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Tiempo
    {
        private int _cantidad;

        private Tiempo(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static Tiempo Sumar(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad + valor;
            return tiempoAux;
        }

        public static Tiempo operator +(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad + valor;
            return tiempoAux;
        }

        public static Tiempo operator +(Tiempo tiempoAux, Tiempo valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad + valor._cantidad;
            return tiempoAux;
        }

        public static Tiempo operator -(Tiempo tiempoAux, int valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad - valor;
            return tiempoAux;
        }

        public static Tiempo operator -(Tiempo tiempoAux, Tiempo valor)
        {
            tiempoAux._cantidad = tiempoAux._cantidad - valor._cantidad;
            return tiempoAux;
        }

        public static bool operator ==(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1._cantidad == tiempo2._cantidad);
        }

        public static bool operator ==(Tiempo tiempo1, int tiempo2)
        {
            return (tiempo1._cantidad == tiempo2);
        }

        public static bool operator !=(Tiempo tiempo1, Tiempo tiempo2)
        {
            return !(tiempo1 == tiempo2);
        }

        public static bool operator !=(Tiempo tiempo1, int tiempo2)
        {
            return !(tiempo1 == tiempo2);
        }

        public static implicit operator Tiempo(int numero)
        {
            return new Tiempo(numero);
        }

        public static explicit operator int(Tiempo tiempo)
        {
            return tiempo._cantidad;
        }

        public static bool operator <(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1._cantidad < tiempo2._cantidad);
        }

        public static bool operator >(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (tiempo1._cantidad > tiempo2._cantidad);
        }

        public static bool operator <(Tiempo tiempo1, int numero)
        {
            return (tiempo1._cantidad < numero);
        }

        public static bool operator >(Tiempo tiempo1, int numero)
        {
            return (tiempo1._cantidad > numero);
        }
    }
}
