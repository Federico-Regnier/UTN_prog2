using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepcion
{
    public class Rueda
    {
        public string marca;
        public static Random rnd;

        public Rueda(string marca)
        {
            this.marca = marca;
        }

        static Rueda()
        {
            Rueda.rnd = new Random();
        }

        public void Pinchar()
        {
            throw new PinchaduraException("Rueda Pinchada", DateTime.Now, this.marca);
        }

        public void Rodar()
        {
            
            int random = Rueda.rnd.Next(1,11);
            if (random == 5)
            {
                this.Pinchar();
            }
            else
            {
                Console.WriteLine(random);
            }

        }
    }
}
