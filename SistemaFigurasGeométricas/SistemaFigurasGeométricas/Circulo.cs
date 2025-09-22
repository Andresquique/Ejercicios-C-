using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFigurasGeométricas
{
    internal class Circulo : AFigura
    {
        protected double Radio { get; set; }
        public Circulo(double radio){
            this.Radio = radio;
        }
        public override double CalcularArea(){
            return this.Radio * Math.PI;
        }
    }
}
