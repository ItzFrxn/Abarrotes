using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes
{
	internal class Categorias
	{
		private string categoria;
		public Categorias(string c)
		{
			categoria = c;
		}
		public void RegistrarCategoria()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\..\Archivos\categorias.txt", true);
			archivo.WriteLine(categoria);
			archivo.Flush();
			archivo.Close();

		}
	}
}