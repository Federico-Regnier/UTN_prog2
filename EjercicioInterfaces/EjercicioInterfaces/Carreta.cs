using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Carreta : Vehiculo, IARBA
    {
        public Carreta(double precio) : base(precio) { }

        double IARBA.CalcularImpuesto()
        {
            return (this._precio * 0.18);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
    }
}
