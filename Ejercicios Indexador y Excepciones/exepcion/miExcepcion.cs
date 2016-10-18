using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepcion
{
    public class miExcepcion : Exception
    {
        public DateTime horaExcepcion;

        public miExcepcion(DateTime hora, string mensaje,Exception excepAnterior)
            : base(mensaje,excepAnterior)
        {
            this.horaExcepcion = hora;
            
        }

        public miExcepcion(DateTime hora, string mensaje) : this(hora, mensaje, null) { }

    }
}
