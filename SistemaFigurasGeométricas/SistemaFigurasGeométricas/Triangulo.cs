using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFigurasGeométricas
{
    internal class Triangulo:AFigura
    {
        public double Base{ get; set; }
        public double Altura{ get; set; }
        public Triangulo(double _base, double altura)
        {
            this.Base = _base;
            this.Altura = altura;
        }

        public override double CalcularArea()
        {
            return (this.Base * this.Altura)/2;
        }
    }
    
}
