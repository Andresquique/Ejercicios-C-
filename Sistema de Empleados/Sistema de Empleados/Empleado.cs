using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Empleados
{
    internal class Empleado{
        private string _nombre;
        private double _salario;
        private string _id;

        public string Nombre
        {
            get {return _nombre;}
            set {
                if (value!=""){
                    _nombre = value;
                }
                else{
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
            }
        }

        public double Salario
        {
            get { return _salario; }
            set
            {
                if (value >= 0)
                {
                    _salario = value;
                }
                else
                {
                    throw new ArgumentException("El salario no puede ser negativo.");
                }
            }
        }

        public string Id
        {
            get { return _id; }
            set {
                if (!string.IsNullOrWhiteSpace(_id))
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentException("El id es incorrecto.");
                }
            }
        }


        public Empleado()
        {
            _nombre = "";
            _salario = 0;
            _id = "";
        }
    }
}
