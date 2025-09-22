using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Animales
{
    internal class Pajaro : Aanimal
    {
        public override void hacerSonido()
        {
            Console.WriteLine("pio pio");
        }

        public override void moverse()
        {
            Console.WriteLine("vole muy lejos");
        }
    }
}
