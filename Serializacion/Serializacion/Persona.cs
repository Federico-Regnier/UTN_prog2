using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    [XmlInclude(typeof(Alumno))]
    public class Persona : ISerializable2016
    {
        public string nombre;

        public Persona() { }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public bool Serializar()
        {
            bool bandera = false;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(this.nombre + ".xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    serializador.Serialize(escritor, this);
                    bandera = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            return bandera;
        }

        public bool DeSerializar()
        {
            bool bandera = false;
            try
            {
                Persona aux = Serializador.DeserializarPersona();
                this.nombre = aux.nombre;
                bandera = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw e;
            }

            return bandera;
        }


    }

    
}
