
//Crea una clase abstracta Figura con un método abstracto calcularArea().
//Luego implementa las clases Circulo, Rectángulo y triangulo que hereden de Figura y sobrescriban
//el método para calcular su área específica.

namespace SistemaFigurasGeométricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado Cuadrado1 = new(10);
            Circulo Circulo1 = new(5);
            Triangulo Triangulo1 = new(2, 3);

            Console.WriteLine(Cuadrado1.CalcularArea());
            Console.WriteLine(Circulo1.CalcularArea());
            Console.WriteLine(Triangulo1.CalcularArea());


        }
    }
}
