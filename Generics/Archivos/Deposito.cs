using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Deposito<T> : IEnumerable<T>
    {
        public List<T> listaPintura;
        public int cantidadMaxima;

        public Deposito(int cantidad)
        {
            this.listaPintura = new List<T>();
            this.cantidadMaxima = cantidad;
        }

        public bool Agregar(T algo)
        {
            return this + algo;
        }

        public bool NoHayLugar()
        {
            return this.cantidadMaxima == this.listaPintura.Count;
        }

        public bool existeElElemento(T algo)
        {
            foreach (T item in this.listaPintura)
            {
                if (item.Equals(algo))
                    return true;
            }
            return false;
        }

        public static bool operator +(Deposito<T> deposito, T algo)
        {
            if (!deposito.NoHayLugar() && !deposito.existeElElemento(algo))
            {
                deposito.listaPintura.Add(algo);
                return true;
            } 
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.listaPintura)
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
