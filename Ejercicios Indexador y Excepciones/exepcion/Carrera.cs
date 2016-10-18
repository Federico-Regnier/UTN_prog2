using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepcion
{
    public class Carrera
    {
        public List<Auto> listaDeAutos;
        public string autodromo;

        public Carrera(string autodromo)
        {
            this.listaDeAutos = new List<Auto>();
            this.autodromo = autodromo;
        }

        public void CorrerCarrera()
        {
            if (listaDeAutos.Count < 1)
            {
                throw new miExcepcion(DateTime.Now, "Autos insuficientes");
            }
            else
            {
                foreach (Auto item in this.listaDeAutos)
                {
                    item.Andar();
                }
            }
        }
    }
}
