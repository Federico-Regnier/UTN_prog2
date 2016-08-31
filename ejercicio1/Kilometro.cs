using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Kilometros
    {
        private int _cantidad;

        private Kilometros(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static Kilometros operator +(Kilometros kms, int cantidad)
        {
            kms._cantidad = kms._cantidad + cantidad;
            return kms;
        }

        public static Kilometros operator +(Kilometros kms, Kilometros valor)
        {
            kms._cantidad = kms._cantidad + valor._cantidad;
            return kms;
        }

        public static Kilometros operator -(Kilometros kms, int cantidad)
        {
            kms._cantidad -= cantidad;
            return kms;
        }

        public static Kilometros operator -(Kilometros kms, Kilometros valor)
        {
            kms._cantidad -= valor._cantidad;
            return kms;
        }

        public static bool operator ==(Kilometros km1, Kilometros km2)
        {
            return (km1._cantidad == km2._cantidad);
        }

        public static bool operator ==(Kilometros km1, int cantidad)
        {
            return (km1._cantidad == cantidad);
        }

        public static bool operator !=(Kilometros km1, Kilometros km2)
        {
            return !(km1 == km2);
        }

        public static bool operator !=(Kilometros km1, int cantidad)
        {
            return !(km1 == cantidad);
        }

        public static implicit operator Kilometros(int numero)
        {
            return new Kilometros(numero);
        }

        public static explicit operator int(Kilometros kms)
        {
            return kms._cantidad;
        }

        public static bool operator <(Kilometros km1, Kilometros km2)
        {
            return (km1._cantidad < km2._cantidad);
        }

        public static bool operator >(Kilometros km1, Kilometros km2)
        {
            return (km1._cantidad > km2._cantidad);
        }

        public static bool operator <(Kilometros km1, int numero)
        {
            return (km1._cantidad < numero);
        }

        public static bool operator >(Kilometros km1, int numero)
        {
            return (km1._cantidad > numero);
        }
    }

}
