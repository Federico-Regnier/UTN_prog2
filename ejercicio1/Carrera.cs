using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Carrera
    {
        /* Deprecated por coleccion
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
         */
        public List<Auto> listaDeAutos;
        public Random random;

        
        public void CorrerCarrera(Kilometros kilometros)
        {
            Auto ganador;

            foreach (Auto auto in this.listaDeAutos)
            {
                auto.VolverACero();
            }

            for (int i = 0; i < kilometros; i++)
            {
                foreach (Auto auto in this.listaDeAutos)
                {
                    auto.Agregar((Tiempo)random.Next(10, 100));

                }
            }

            

            ganador = this.listaDeAutos[0];

            for (int elemento = 1; elemento < this.listaDeAutos.Count; elemento++)
            {
                if (ganador.GetTiempo() > this.listaDeAutos[elemento].GetTiempo())
                    ganador = this.listaDeAutos[elemento];
            }
            
            /*DEPRECATED por colecciones
            ganador = auto1;
            if (ganador.GetTiempo() > auto2.GetTiempo())
                ganador = auto2;
            if (ganador.GetTiempo() > auto3.GetTiempo())
                ganador = auto3;
            if (ganador.GetTiempo() > auto4.GetTiempo())
                ganador = auto4;
            if (ganador.GetTiempo() > auto5.GetTiempo())
                ganador = auto5;
            if (ganador.GetTiempo() > auto6.GetTiempo())
                ganador = auto6;*/

            Console.WriteLine("El ganador es: {0} con un tiempo de {1}", ganador.MostrarAuto(), (int)ganador.GetTiempo());
        }

        public void CorrerCarrera(Tiempo tiempo)
        {
            Auto ganador;

            foreach (Auto auto in this.listaDeAutos)
            {
                auto.VolverACero();
            }
            
            for (int i = 0; i < tiempo; i++)
            {
                foreach (Auto auto in this.listaDeAutos)
                {
                    auto.Agregar((Kilometros)random.Next(10, 100));
                }    
            }
            
            ganador = this.listaDeAutos[0];
            for (int elemento = 1; elemento < this.listaDeAutos.Count; elemento++)
            {
                if (ganador.GetKms() < this.listaDeAutos[elemento].GetKms())
                    ganador = this.listaDeAutos[elemento];
            }
            
            /*DEPRECATED por colecciones
            ganador = auto1;
            if (ganador.GetKms() < auto2.GetKms())
                ganador = auto2;
            if (ganador.GetKms() < auto3.GetKms())
                ganador = auto3;
            if (ganador.GetKms() < auto4.GetKms())
                ganador = auto4;
            if (ganador.GetKms() < auto5.GetKms())
                ganador = auto5;
            if (ganador.GetKms() < auto6.GetKms())
                ganador = auto6;*/

            Console.WriteLine("El ganador es: {0} con {1}kms recorridos", ganador.MostrarAuto(), (int)ganador.GetKms());
            
        }
        
        public string MostrarCarrera()
        {
            /* Deprecated por colecciones
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
             */
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Carrera");
            foreach (Auto auto in this.listaDeAutos)
            {
                sb.AppendLine(auto.retornarString());
            }

            return sb.ToString();
        }

        #region Constructores

        public Carrera()
        {
            /* Deprecated por colecciones
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
             */
            this.listaDeAutos = new List<Auto>();
            this.random = new Random();
        }

        #endregion

        #region Colecciones

        private bool AgregarAuto(Auto auto)
        {
            this.listaDeAutos.Add(auto);
            return true;
        }

        public static Carrera operator +(Carrera carrera, Auto auto)
        {
            carrera.AgregarAuto(auto);
            return carrera;
        }

        #endregion
    }
}
