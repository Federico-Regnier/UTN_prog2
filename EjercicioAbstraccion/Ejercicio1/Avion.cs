using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Avion : Vehiculo, IAFIP
    {
        private double _cuit;
        public double RetornarCUIT
        {
            get
            {
                return this._cuit;
            }

        }
        private int _cantidadRuedas;
        public override int CantidadRuedas
        {
            get 
            { 
                return this._cantidadRuedas; 
            }
        }
        public virtual string Datos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Cuit: {0}", this._cuit).AppendLine();
                sb.AppendFormat("Cantidad Ruedas: {0}", this.CantidadRuedas).AppendLine();
                return sb.ToString();
            }
        }

        public override float CalcularCosto()
        {
            return 1500f;
        }

        public Avion(string patente, double cuit) : base(patente) 
        {
            this._cuit = cuit;
            this._cantidadRuedas = 2;
        }

        public float RetornarImpuesto()
        {
            return 100f;
        }
    }
}
