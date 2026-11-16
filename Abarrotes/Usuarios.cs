using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes
{
	internal class Usuarios
	{
		private string usuario;
		private string contrasena;
		private string tipo;

		public Usuarios(string user, string pass, string rol) {
			this.usuario = user;
			this.contrasena = pass;
			this.tipo = rol;
		}

		public void GuardarUsuario()
		{
			StreamWriter archvo = new StreamWriter(@"..\..\..\Archivos\usuarios.txt", true);
			archvo.WriteLine(usuario + "|" +  contrasena + "|" + tipo);
			archvo.Flush();
			archvo.Close();
		}
	}
}
