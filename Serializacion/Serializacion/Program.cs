using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<Persona> listadoPersonas = new List<Persona>();
            //listadoPersonas.Add(new Persona("Jorge"));
            //listadoPersonas.Add(new Persona("Juan"));
            //listadoPersonas.Add(new Alumno(1, "Asd"));

            //Aula unAula = new Aula(1, "El Aula", listadoPersonas);
            //unAula.profesor = new Persona("AAAA");

            //Serializador.SerializarAula(unAula);

            Persona unaPers = new Persona("Jose");
            Serializador.SerializarPersona(unaPers);
            unaPers = null;            
            unaPers = Serializador.DeserializarPersona();
            Console.WriteLine(unaPers.nombre);
            //Serializador.SerializarListadoPersonas(listadoPersonas);
            //Serializador.SerializarPersona(listadoPersonas);

            Console.ReadLine();
        }
    }
}
