using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        public Random random;

        
        public void CorrerCarrera(Kilometros kilometros)
        {
            Auto ganador;

            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();

            for (int i = 0; i < kilometros; i++)
            {
                this.auto1.AgregarTiempo(random.Next(10, 100));
                this.auto2.AgregarTiempo(random.Next(10, 100));
                this.auto3.AgregarTiempo(random.Next(10, 100));
                this.auto4.AgregarTiempo(random.Next(10, 100));
                this.auto5.AgregarTiempo(random.Next(10, 100));
                this.auto6.AgregarTiempo(random.Next(10, 100));
            }

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
                ganador = auto6;
            
            Console.Write("El ganador es: ");
            ganador.MostrarAuto();
        }

        public void CorrerCarrera(Tiempo tiempo)
        {
            Auto ganador;

            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();

            for (int i = 0; i < tiempo; i++)
            {
                this.auto1.AgregarKilometros(random.Next(10, 100));
                this.auto2.AgregarKilometros(random.Next(10, 100));
                this.auto3.AgregarKilometros(random.Next(10, 100));
                this.auto4.AgregarKilometros(random.Next(10, 100));
                this.auto5.AgregarKilometros(random.Next(10, 100));
                this.auto6.AgregarKilometros(random.Next(10, 100));
            }

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
                ganador = auto6;

            Console.Write("El ganador es: ");
            ganador.MostrarAuto();
        }

        public void MostrarCarrera()
        {
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
        }

        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
            this.random = new Random();
        }
    }
}
