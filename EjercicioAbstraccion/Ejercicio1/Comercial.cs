using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Comercial : Avion
    {
        
        public Comercial(string patente, double cuit) : base(patente, cuit) { }
        public override string Datos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Avion Comercial");
                sb.Append(base.Datos);
                return sb.ToString();
            }
        }

    }
}
