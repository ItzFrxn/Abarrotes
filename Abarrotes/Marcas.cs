using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Abarrotes
{
	internal class Marcas
	{
		private string marca;

		public Marcas(string m) {
			marca = m;
		}

		public void RegistrarMarca()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\..\Archivos\marcas.txt", true);
			archivo.WriteLine(marca);
			archivo.Flush();
			archivo.Close();
		}
	}
}
