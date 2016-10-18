using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBurbujeo
{
    public class Class1
    {
        public Class1()
        {
            throw new Exception("excepcion constructor");
        }

        public Class1(int i)
        {
            try
            {
                Class3.metodoUno(new Class2());
            }
            catch (Exception ex)
            {
                throw new Exception("excep constructor", ex);
            }
            
        }

        public static void metodoEstatico()
        {
            try
            {
                Class2.metodoEstatico();
            }
            catch (Exception ex)
            {
                throw new Exception("excep Constructor", ex);
            }
        }

    }

}
