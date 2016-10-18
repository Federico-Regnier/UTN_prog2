using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class Pc
    {
        public string marca;
        public string SO;
        public static int contadorPc;
        public int numero;


        private Pc(string marca) // :this(marca, "void")
        {
            this.marca = marca;
            this.SO = "windows";
            this.numero = Pc.contadorPc;
            Pc.contadorPc++;
        }

        //public Pc(string marca, string so)
        //{
        //    this.marca = marca;
        //    this.SO = so;
        //}

        static Pc()
        {
            Pc.contadorPc = 1;
        }

        public static implicit operator Pc(string marca)
        {
            Pc unaPc = new Pc(marca);
            return unaPc;
        }

    }
}
