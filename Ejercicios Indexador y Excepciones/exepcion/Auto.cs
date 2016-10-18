using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepcion
{
    public class Auto
    {
        public string marca;
        public int numero;
        public List<Rueda> listaRuedas;

        public Auto(string marca, int numero)
        {
            this.listaRuedas = new List<Rueda>();
            this.marca = marca;
            this.numero = numero;
        }

        public void Andar()
        {
            if (this.listaRuedas.Count < 4)
            {
                throw new miExcepcion(DateTime.Now, "Ruedas insuficientes");
            }
            else
            {
                try
                {
                    foreach (Rueda item in this.listaRuedas)
                    {
                        item.Rodar();
                    }
                }
                catch (PinchaduraException ex)
                {
                    AutoException exceptionAuto = new AutoException("Pinchadura en rueda " + ex.marca, DateTime.Now, this, ex);
                    throw exceptionAuto;
                }
                
            }
        }
    }
}
