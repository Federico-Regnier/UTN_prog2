using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepcion
{
    public class AutoException : miExcepcion
    {
        public Auto miAuto;

        public AutoException(string mensaje, DateTime fecha, Auto auto,Exception excepAnterior)
            : base(fecha, mensaje,excepAnterior)
        {
            this.miAuto = auto;
        }

        public AutoException(string mensaje, DateTime fecha, Auto auto) : this(mensaje, fecha, auto, null) { }
    }
}
