using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public interface IAFIP
    {
        float RetornarImpuesto();
        double RetornarCUIT { get; }
    }
}
