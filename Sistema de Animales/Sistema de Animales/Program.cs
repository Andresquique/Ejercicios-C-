namespace Sistema_de_Animales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pajaro Piolin = new();
            Perro Pluto = new();

            Piolin.hacerSonido();
            Pluto.moverse();
        }
    }
}
