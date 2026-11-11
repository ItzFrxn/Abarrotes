using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abarrotes
{
	internal class Productos
	{
		private string codigo, nombre, categoria, marca;
		private double precio;
		private int cantidad;

		public string GenerarCodigo
		{
			get
			{
				string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
				int cantidad = abc.Length;

				Random rnd = new Random();
				for (int i = 0; i < 10; i++)
				{
					int valor = rnd.Next(cantidad);
					string caracter = abc.Substring(valor, 1);
					codigo += caracter;
				}
				return codigo;
			}
		}

		public Productos() { }

		public Productos(string codigo, string nombre, string categoria, string marca, double precio, int cantidad)
		{
			this.codigo = codigo;
			this.nombre = nombre;
			this.categoria = categoria;
			this.marca = marca;
			this.precio = precio;
			this.cantidad = cantidad;
		}

		public void GuardarInformacion()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\..\Archivos\productos.txt", true);
			archivo.WriteLine(codigo + "|" + nombre + "|" + categoria + "|" + marca + "|" + precio + "|" + cantidad);
			archivo.Flush();
			archivo.Close();
		}
	}
}
