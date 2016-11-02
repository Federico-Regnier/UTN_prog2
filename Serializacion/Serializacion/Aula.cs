using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    public class Aula
    {
        //            Serializacion Xml
        // La clase y los atributos deben ser publicos
        // Necesita el constructor por defecto
        // Clases que vienen despues de la herencia es necesario hacer el include
        // Serializa el atributo privado solo si tiene set y get 
        // Salvo las listas que solo con el get la serializa
        // Los atributos privado no se serializan
        public int numero;
        private List<Persona> listadoAlumnos;
        public List<Persona> ListaPersonas
        {
            get
            {
                return this.listadoAlumnos;
            }
        }
        public Persona profesor;
        private string _nombreAula;
        public string NombreAula
        {
            set
            {
                this._nombreAula = value;
            }
            get
            {
                return this._nombreAula;
            }
        }

        public Aula(){}
        public Aula(int numero, string nombre, List<Persona> listado)
        {
            this.numero = numero;
            this._nombreAula = nombre;
            this.listadoAlumnos = listado;
        }

    }
}
