using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race
{
    public class Auto
    {
        private eFabricante _fabricante;
        private string _nombrePiloto;

        public string NombrePiloto
        {
            set
            {
                this._nombrePiloto = value;
            }

            get
            {
                return this._nombrePiloto;
            }

        }

        public Dictionary<string, Rueda> ruedas;
        /* Deprecated por diccionario
        public Rueda ruedaDI;
        public Rueda ruedaDD;
        public Rueda ruedaTI;
        public Rueda ruedaTD;*/

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
            sb.AppendLine("Piloto: " + this.NombrePiloto);
            if(this.kilometrosRecorridos != 0)
                sb.AppendLine("Kilometros: " + (int)this.kilometrosRecorridos);
            if(this.tiempoDemorado != 0)
                sb.AppendLine("Tiempo: " + (int)this.tiempoDemorado);

            return sb.ToString();
        }

        private string retornarStringParaListado()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("F:" + this._fabricante + " - ");
            sb.AppendLine("P:" + this._nombrePiloto);
            
            return sb.ToString();
        }

        public string DatosEnString
        {
            get
            {
                return this.retornarStringParaListado();
            }
        }

        #region Constructores
        public Auto()
        {

            this._fabricante = (eFabricante)Auto._random.Next(0, 3);
            this.kilometrosRecorridos = 0;
            this.tiempoDemorado = 0;
            ruedas = new Dictionary<string, Rueda>();
            this.ruedas.Add("DD", new Rueda());
            this.ruedas.Add("DI", new Rueda());
            this.ruedas.Add("TD", new Rueda());
            this.ruedas.Add("TI", new Rueda());
            /* Deprecated por dictionary
            this.ruedaDD = new Rueda();
            this.ruedaDI = new Rueda();
            this.ruedaTD = new Rueda();
            this.ruedaTI = new Rueda();*/
            Auto.contadorDeObjetos++;
        }

        public Auto(string piloto, eFabricante fabricante):this()
        {
            this._fabricante = fabricante;
            this.NombrePiloto = piloto;
        }

        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto._random = new Random();
        }

        #endregion
    }
}
