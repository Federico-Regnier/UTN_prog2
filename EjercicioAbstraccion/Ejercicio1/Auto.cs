using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public abstract class Auto : Vehiculo
    {
        public int cantidadPuertas;
        private int _cantRuedas;
        public override int CantidadRuedas
        {
            get 
            {
                return this._cantRuedas; 
            }
        }
        
        public Auto(string patente) : base(patente) 
        {
            this._cantRuedas = 4;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine("auto");
            sb.Append("Cantidad Puertas: ");
            sb.AppendLine(this.cantidadPuertas.ToString());
            return sb.ToString();
        }

    }
}
