using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class DepositoPintura
    {
        public List<Producto> listaPintura;
        public int cantidadMaxima;

        public DepositoPintura(int cantidad)
        {
            this.listaPintura = new List<Producto>();
            this.cantidadMaxima = cantidad;
        }

        public bool Agregar(Producto algo)
        {
            return this + algo;
        }

        public bool NoHayLugar()
        {
            return this.cantidadMaxima == this.listaPintura.Count;
        }

        public bool existeElElemento(Producto algo)
        {
            foreach (Producto item in this.listaPintura)
            {
                if (item == algo)
                    return true;
            }
            return false;
        }

        public static bool operator +(DepositoPintura deposito, Producto prod)
        {
            if (!deposito.NoHayLugar() && !deposito.existeElElemento(prod))
            {
                deposito.listaPintura.Add(prod);
                return true;
            } 
            return false;
        }

    }
}
