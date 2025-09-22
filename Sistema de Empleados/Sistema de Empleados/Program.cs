//Crea una clase Empleado con atributos privados para el nombre, salario y ID.
//Implementa métodos getters y setters con validaciones
//(el salario no puede ser negativo y el ID debe tener un formato específico).


using System.Security.Cryptography.X509Certificates;

namespace Sistema_de_Empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Empleado empleado1 = new()
            {Nombre = "a",Salario=4000,Id="A1428"
            };
            Console.WriteLine(empleado1.Nombre + "/"+empleado1.Salario + "/"+empleado1.Id);
        }
    }
}
