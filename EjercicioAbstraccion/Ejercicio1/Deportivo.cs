using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Deportivo : Auto, IAFIP
    {
        private double _cuit;
        public double RetornarCUIT
        {
            get
            {
                return this._cuit;
            }

        }
        public Deportivo(string patente, double cuit) : base(patente) 
        {
            this._cuit = cuit;
        }

        public override float CalcularCosto()
        {
            return 150f;
        }

        public float RetornarImpuesto()
        {
            return 20f;
        }
    }

}
