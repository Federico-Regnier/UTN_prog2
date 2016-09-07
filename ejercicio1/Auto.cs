using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public class Auto
    {
        private eFabricante _fabricante;
        public Rueda ruedaDI;
        public Rueda ruedaDD;
        public Rueda ruedaTI;
        public Rueda ruedaTD;
        public static int contadorDeObjetos;
        private static Random _random;
        private Tiempo tiempoDemorado;
        private Kilometros kilometrosRecorridos;
        
        public static bool CompararAuto(Auto auto1, Auto auto2)
        {
            if (auto1._fabricante == auto2._fabricante)
                return true;
            return false;
        }

        public string MostrarAuto()
        {
            return this._fabricante.ToString();
        }

        public void VolverACero()
        {
            this.kilometrosRecorridos = 0;
            this.tiempoDemorado = 0;
        }

        /* Deprecated por sobreacarga del metodo agregar
        public void AgregarKilometros(int kilometros)
        {
            this.kilometrosRecorridos += kilometros;
        }

        public void AgregarTiempo(int tiempo)
        {
            this.tiempoDemorado += tiempo;
        }*/

        public Kilometros GetKms()
        {
            return this.kilometrosRecorridos;
        }

        public Tiempo GetTiempo()
        {
            return this.tiempoDemorado;
        }

        public void Agregar(Tiempo tiempo)
        {
            this.tiempoDemorado = this.tiempoDemorado + tiempo;
        }

        public void Agregar(Kilometros kms)
        {
            this.kilometrosRecorridos = this.kilometrosRecorridos + kms;
        }

        public string retornarString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fabricante: " + this._fabricante);
            sb.AppendLine("Kilometros: " + (int)this.kilometrosRecorridos);
            sb.AppendLine("Tiempo: " + (int)this.tiempoDemorado);

            return sb.ToString();
        }

        #region Constructores
        public Auto()
        {

            this._fabricante = (eFabricante)Auto._random.Next(0, 3);
            this.kilometrosRecorridos = 0;
            this.tiempoDemorado = 0;
            this.ruedaDD = new Rueda();
            this.ruedaDI = new Rueda();
            this.ruedaTD = new Rueda();
            this.ruedaTI = new Rueda();
            Auto.contadorDeObjetos++;
        }

        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto._random = new Random();
        }

        #endregion
    }
}
