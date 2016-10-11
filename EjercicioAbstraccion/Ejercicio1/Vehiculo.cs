using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public abstract class Vehiculo
    {
        public string patente;
        public abstract int CantidadRuedas { get; }

        public abstract float CalcularCosto();

        public override string ToString()
        {
            return this.patente;
        }

        protected Vehiculo(string patente)
        {
            this.patente = patente;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("vehiculo");
            sb.AppendLine(this.patente);
            return sb.ToString();
        }

        
    }
}
