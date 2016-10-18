using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBurbujeo
{
    public class Class3
    {
        public static void metodo(Class2 clase)
        {

            try
            {
                clase.lanzarExcep();
            }
            catch (Exception ex)
            {
                
                throw new Exception("excep metodo estatico", ex);
            }
                
        }

        public static void metodoUno(Class2 clase)
        {

            try
            {
                clase.lanzarExcep3();
            }
            catch (Exception ex)
            {

                throw new Exception("excep metodo estatico", ex);
            }

        }

        public Class3()
        {
            try
            {
                Class3.metodo(new Class2());
            }
            catch (Exception ex)
            {
                
                throw new Exception("excepcion constructor", ex);
            }
            
        }

        public static void metodoEstatico()
        {
            try
            {
                Class1.metodoEstatico();
            }
            catch (Exception ex)
            {
                throw new Exception("excep metodo estatico", ex);
            }
        }


    }
}
