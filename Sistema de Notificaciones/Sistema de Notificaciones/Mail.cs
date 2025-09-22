using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Notificaciones
{
    internal class Mail:Inotificacion
    {
        public void Enviar()
        {
            Console.WriteLine("enviando Mail");
        }
    }
}
