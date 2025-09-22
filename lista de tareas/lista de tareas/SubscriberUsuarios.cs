using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_tareas
{
    internal class SubscriberUsuarios
    {
        private List<Usuario> usuarios = new List<Usuario>();

		public Usuario Susbscriber
		{
			set { usuarios.Add(value); }
		}

		public void Notificar()
		{
			this.usuarios.ForEach(u => u.RecibirNotificacion());
		}

	}
}
