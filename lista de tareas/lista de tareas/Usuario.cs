using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_tareas
{
    internal class Usuario{

        private string _Nombre;
        private string _Apellido;
        private int _Dni;
        private List<Tarea> _Tareas;

        public Usuario(string nombre, string apellido , int Dni )
        {
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._Dni = Dni;
            this._Tareas = new List<Tarea>();
        }

        public void CrearTareas(Tarea tarea)
        {
            this._Tareas.Add(tarea);
        }

        public void RecibirNotificacion()
        {
            Console.WriteLine("recibido");
        }
    }

    
}
