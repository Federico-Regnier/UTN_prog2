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

        public void porTiempo(int minutos)
        {
            int max;
            string ganador;

            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();

            for (int i = 0; i < minutos; i++)
            {
                this.auto1.AgregarKilometros(random.Next(10, 100));
                this.auto2.AgregarKilometros(random.Next(10, 100));
                this.auto3.AgregarKilometros(random.Next(10, 100));
                this.auto4.AgregarKilometros(random.Next(10, 100));
                this.auto5.AgregarKilometros(random.Next(10, 100));
                this.auto6.AgregarKilometros(random.Next(10, 100));
            }

            max = auto1.GetKms();
            ganador = "auto1";

            if (max < auto2.GetKms())
            {
                max = auto2.GetKms();
                ganador = "auto2";
            }

            if (max < auto3.GetKms())
            {
                max = auto3.GetKms();
                ganador = "auto3";
            }
            if(max < auto4.GetKms())
            {
                max = auto4.GetKms();
                ganador = "auto4";
            }
            if(max < auto5.GetKms())
            {
                max = auto5.GetKms();
                ganador = "auto5";
            }
            if(max < auto6.GetKms())
            {
                max = auto6.GetKms();
                ganador = "auto6";
            }

            Console.WriteLine("El ganador es: " + ganador);
            
        }

        public void CorrerCarrera(Kilometro kilometros)
        {
            int min;
            string ganador;

            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();

            for (int i = 0; i < kilometros.cantidad; i++)
            {
                this.auto1.AgregarTiempo(random.Next(10, 100));
                this.auto2.AgregarTiempo(random.Next(10, 100));
                this.auto3.AgregarTiempo(random.Next(10, 100));
                this.auto4.AgregarTiempo(random.Next(10, 100));
                this.auto5.AgregarTiempo(random.Next(10, 100));
                this.auto6.AgregarTiempo(random.Next(10, 100));
            }

            min = auto1.GetTiempo();
            ganador = "Auto 1";

            if (min > auto2.GetTiempo())
            {
                min = auto2.GetTiempo();
                ganador = "Auto 2";
            }

            if (min > auto3.GetTiempo())
            {
                min = auto3.GetTiempo();
                ganador = "Auto 3";
            }
            if (min > auto4.GetTiempo())
            {
                min = auto4.GetTiempo();
                ganador = "Auto 4";
            }
            if (min > auto5.GetTiempo())
            {
                min = auto5.GetTiempo();
                ganador = "Auto 5";
            }
            if (min > auto6.GetTiempo())
            {
                min = auto6.GetTiempo();
                ganador = "Auto 6";
            }

            Console.WriteLine("El ganador es: " + ganador);
        }

        public void CorrerCarrera(Tiempo tiempo)
        {
            int max;
            string ganador;

            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();

            for (int i = 0; i < tiempo.cantidad; i++)
            {
                this.auto1.AgregarKilometros(random.Next(10, 100));
                this.auto2.AgregarKilometros(random.Next(10, 100));
                this.auto3.AgregarKilometros(random.Next(10, 100));
                this.auto4.AgregarKilometros(random.Next(10, 100));
                this.auto5.AgregarKilometros(random.Next(10, 100));
                this.auto6.AgregarKilometros(random.Next(10, 100));
            }

            max = auto1.GetKms();
            ganador = "auto1";

            if (max < auto2.GetKms())
            {
                max = auto2.GetKms();
                ganador = "auto2";
            }

            if (max < auto3.GetKms())
            {
                max = auto3.GetKms();
                ganador = "auto3";
            }
            if (max < auto4.GetKms())
            {
                max = auto4.GetKms();
                ganador = "auto4";
            }
            if (max < auto5.GetKms())
            {
                max = auto5.GetKms();
                ganador = "auto5";
            }
            if (max < auto6.GetKms())
            {
                max = auto6.GetKms();
                ganador = "auto6";
            }

            Console.WriteLine("El ganador es: " + ganador);
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
