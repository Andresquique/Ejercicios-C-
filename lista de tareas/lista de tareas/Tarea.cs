using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_tareas
{
    internal class Tarea{
        private DateTime _FechaCreacion;
        private DateTime _FechaRealizacion;
        private int _CantActualizaciones;
        private string _Descripcion;
        private string _Prioridad;

        public Tarea(DateTime fecha, string prioridad)
        {
            _FechaCreacion = DateTime.Now;
            FechaRealizacion = fecha;
            _CantActualizaciones = 0;
            _Descripcion = string.Empty;
            _Prioridad = prioridad;
        }
        public DateTime FechaRealizacion
        {
            get { return _FechaRealizacion; }
            set {
                if (value.CompareTo(_FechaCreacion)<0){
                  Console.WriteLine("La fecha no puede ser anterior a la actual");
                }
                else{
                  _FechaRealizacion = value;
                }
             }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                if (value.Length > 200)
                {
                    Console.WriteLine("La descripciondebe ser menor de 200 caracteres");
                }
                else
                {
                    _Descripcion = value;
                }
            }
        }
        public string Prioridad
        {
            get { return _Prioridad; }
            set
            {
              _Descripcion = value;
            }
        }

        private int Actualizar
        {
            get { return _CantActualizaciones; }
            set
            {
                _CantActualizaciones += 1;
            }
        }
    }
}
