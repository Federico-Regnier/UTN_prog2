using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Privado avionPrivado = new Privado(100, 100);
            Comercial avionComercial = new Comercial(200, 200);
            IAFIP interfaz = (IAFIP)avionPrivado;

            Console.WriteLine(interfaz.CalcularImpuesto());
            Console.WriteLine(((IAFIP)avionComercial).CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionPrivado));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionComercial));
            
            Console.ReadLine();

        }
    }
}

/*
 *                      Clase Estatica                          Clase No Estatica
 *          
 *  Similitudes       * Pueden contener const estatico
 *                    * Puede tener atrib estaticos
 *                    * Puede tener propiedades y metodos estaticos
 *                    *   
 *
 * 
 * Diferencias       * Tiene palabra static                      * No static  
 *                   * No se puede instanciar                    * Se puede isntanciar
 *                   * No puede tener const                      * Puede tener const de instancia
 *                   * No puede heredar                          * Puede heredar
 *                   * No puede implementar interfaces           * Puede implementar interfaces
 *                   * No tiene prop y metodos de instancia      * Tiene metodos y prop de isntancia
 * 
*/