using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBurbujeo
{
    public class Class2
    {
        public List<Class1> listaClases;

        public Class2()
        {
            this.listaClases = new List<Class1>();
        }

        public void agregar()
        {
            try
            {
                this.listaClases.Add(new Class1());
            }
            catch (Exception ex)
            {
                throw new Exception("excepcion metodo instancia", ex);
            }
            
        }

        public static void metodoEstatico()
        {
            throw new Exception("excepcion metodo estatico");
        }

        public void Ejercicio2()
        {
            try
            {
                Class2.metodoEstatico();
            }
            catch (Exception excep)
            {
                throw new Exception("excepcion metodo instancia");
            }
        }

        public void lanzarExcep()
        {
            throw new Exception("excepcion metodo instancia 1");
        }

        public void lanzarExcep2()
        {
            try
            {
                this.lanzarExcep();
            }
            catch (Exception ex)
            {
                throw new Exception("excep metodo instancia 2", ex);
            }
        }

        public void lanzarExcep3()
        {
            try
            {
                this.lanzarExcep2();
            }
            catch (Exception ex)
            {
                throw new Exception("excep metodo instancia 3", ex);
            }
        }


    }
}
