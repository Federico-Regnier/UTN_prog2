using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    public static class Serializador
    {
        public static void SerializarPersona(Persona pers)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    serializador.Serialize(escritor, pers);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw e;
            }
        }

        public static Persona DeserializarPersona()
        {
            Persona personaRetornar = null;
            try
            {
                
                using (XmlTextReader lector = new XmlTextReader("Persona.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    personaRetornar = (Persona)serializador.Deserialize(lector);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }

            return personaRetornar;
        }

        public static void SerializarListadoPersonas(List<Persona> listado)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Personas.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));
                    serializador.Serialize(escritor, listado);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw e;
            }
        }

        public static void SerializarAula(Aula aula)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Aula.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));
                    serializador.Serialize(escritor, aula);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw e;
            }
        }

        public static bool SerializarGenerico(ISerializable2016 serializable)
        {
            return serializable.Serializar();
        }

        
    }
}
