using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public abstract class Vehiculo
    {
        protected double _precio;

        protected Vehiculo(double precio)
        {
            this._precio = precio;
        }

        public abstract void MostrarPrecio();
        
    }
}
