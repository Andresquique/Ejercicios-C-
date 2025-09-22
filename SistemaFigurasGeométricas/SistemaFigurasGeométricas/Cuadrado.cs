using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFigurasGeométricas
{
    internal class Cuadrado: AFigura{

        public double Lado {get; set;}
        public Cuadrado(double lado)
        {
            this.Lado = lado;
        }

        public override double CalcularArea()
        {
            return this.Lado * this.Lado;
        }
    }
}
