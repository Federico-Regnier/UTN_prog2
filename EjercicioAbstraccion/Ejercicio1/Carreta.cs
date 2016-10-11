using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Carreta : Vehiculo
    {
        public override int CantidadRuedas
        {
            get 
            { 
                return 2; 
            }
        }
        public override float CalcularCosto()
        {
            return 5f;
        }

        public Carreta(string patente) : base(patente) { }
    }
}
