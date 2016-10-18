using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepcion
{
    public class PinchaduraException : miExcepcion
    {
        public string marca;

        public PinchaduraException(string mensaje, DateTime fecha, string marcaRueda, Exception excepAnterior)
            : base(fecha, mensaje, excepAnterior)
        {
            this.marca = marcaRueda;
        }

        public PinchaduraException(string mensaje, DateTime fecha, string marcaRueda)
            : this(mensaje, fecha, marcaRueda, null) { }
        
    }
}
