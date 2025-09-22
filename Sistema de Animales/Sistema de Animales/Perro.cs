using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Animales
{
    internal class Perro:Aanimal
    {
        public override void hacerSonido()
        {
            Console.WriteLine("guau guau");
        }

        public override void moverse()
        {
            Console.WriteLine("me fui a mi cucha");
        }
    }
}
