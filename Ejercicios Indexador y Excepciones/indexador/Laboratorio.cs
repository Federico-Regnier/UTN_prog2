using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class Laboratorio
    {
        string nombre;
        public List<Pc> listaDePc;

        // Pc dice que devuelve y recibe
        public Pc this[int indice]
        {
            get 
            {
                if (indice >= 0 && indice < this.listaDePc.Count)
                {
                    return this.listaDePc[indice];
                }
                else
                    return null;
            }
            set 
            {
                if (indice == listaDePc.Count)
                {
                    this.listaDePc.Add(value);
                }
                else if ( indice >= 0 && indice < this.listaDePc.Count)
                {
                    this.listaDePc[indice] = value;
                }
            }
        }





        public Laboratorio(string nombre)
        {
            this.listaDePc = new List<Pc>();
            this.nombre = nombre;
        }
    }
}
