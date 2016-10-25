using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected double velocidadMaxima;

        public Avion(double precio, double velMax) : base(precio)
        {
            this.velocidadMaxima = velMax;
        }

        double IAFIP.CalcularImpuesto()
        {
            return (this._precio * 0.33);
        }

        double IARBA.CalcularImpuesto()
        {
            return (this._precio * 0.27);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
    }
}
