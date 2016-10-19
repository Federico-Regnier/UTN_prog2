using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Producto
    {
        public int codigo;
        public string descripcion;
        public float precioVenta;

        public Producto(int codigo, string descripcion, float precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioVenta = precio;
        }

        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (prod1.codigo == prod2.codigo)
                return true;
            return false;
        }
        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Codigo Producto: {0}", this.codigo).AppendLine();
            sb.AppendFormat("Descripcion : {0}", this.descripcion).AppendLine();
            sb.AppendFormat("Precio Venta: {0}", this.precioVenta).AppendLine();

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool bandera = false;
            try
            {
                if (this == (Producto)obj)
                    bandera = true;
            }
            catch (Exception)
            {
                
            }
            return bandera;
        }
    }
}
