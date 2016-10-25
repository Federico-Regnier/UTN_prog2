using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito<Producto> depositoProductos = new Deposito<Producto>(3);
            Deposito<Persona> depositoPersonas = new Deposito<Persona>(3);
            Deposito<Vehiculo> depositoVehiculos = new Deposito<Vehiculo>(3);
            Deposito<Mascota> depositoMascotas = new Deposito<Mascota>(3);

            depositoProductos.Agregar(new Producto(1,"Algun prod 1", 12f));
            depositoProductos.Agregar(new Producto(2,"Descr 2", 10f));
            depositoProductos.Agregar(new Producto(3, "Descr 3", 9f));
            depositoProductos.Agregar(new Producto(1, "Algun prod 1", 12f));

            depositoPersonas.Agregar(new Persona("Juan", 35604899));
            depositoPersonas.Agregar(new Persona("Juan", 20000333));
            depositoPersonas.Agregar(new Persona("Jorge", 45555666));

            depositoVehiculos.Agregar(new Vehiculo("Honda", "Verde", "AAA 111"));
            depositoVehiculos.Agregar(new Vehiculo("Ford", "Azul", "BBB 222"));
            depositoVehiculos.Agregar(new Vehiculo("Fiat", "Negro", "CCC 333"));

            depositoMascotas.Agregar(new Mascota("aaa", "lab"));
            depositoMascotas.Agregar(new Mascota("bbb", "asd"));
            depositoMascotas.Agregar(new Mascota("ccc", "lab"));
            
            foreach (Mascota item in depositoMascotas)
            {
                Console.WriteLine(item.nombre);
            }

            Console.ReadLine();
        }
    }
}
