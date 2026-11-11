using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abarrotes
{
	public partial class FrmCategorias : Form
	{
		public FrmCategorias()
		{
			InitializeComponent();
		}

		private void FrmCategorias_Load(object sender, EventArgs e)
		{
			lstvwCategorias.Columns.Add("Marca", 200);
			lstvwCategorias.View = View.Details;
			lstvwCategorias.FullRowSelect = true;
			lstvwCategorias.GridLines = true;
			lstvwCategorias.CheckBoxes = true;

			MostrarCategoria();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{

			if (txtNombre.Text == "")
			{
				MessageBox.Show("El campo 'nombre' esta vacio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				Categorias categoria = new Categorias(this.txtNombre.Text);
				categoria.RegistrarCategoria();

				txtNombre.Text = "";
				txtNombre.Focus();

				MostrarCategoria();
			}
		}

		private void btnEliminar_Click(Object sender, EventArgs e)
		{
			if (lstvwCategorias.CheckedIndices.Count == 0)
			{
				MessageBox.Show("No hay elementos seleccionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				DialogResult respuesta = MessageBox.Show("¿Deseas eliminanr los  siguientes datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (respuesta == DialogResult.Yes)
				{
					for (int i = lstvwCategorias.CheckedIndices.Count - 1; i >= 0; i--)
					{
						lstvwCategorias.Items.RemoveAt(lstvwCategorias.CheckedIndices[i]);
					}

					ActualizarArchivo();
					MostrarCategoria();
				}
			}
		}

		private void MostrarCategoria()
		{
			lstvwCategorias.Items.Clear();

			StreamReader archivo = new StreamReader(@"..\..\..\Archivos\categorias.txt");
			string linea = archivo.ReadLine();
			int count = 0;

			while (linea != null)
			{
				string[] datos = new string[1];
				datos[0] = linea;

				ListViewItem item = new ListViewItem(datos);
				lstvwCategorias.Items.Add(item);

				linea = archivo.ReadLine();
				count++;
			}

			archivo.Close();
			tlpContador.Text = Convert.ToString(count);
		}

		private void ActualizarArchivo()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\..\Archivos\categorias.txt");
			int cantidad = lstvwCategorias.Items.Count;

			for (int x = 0; x < cantidad; x++)
			{
				string marca = lstvwCategorias.Items[x].Text;
				archivo.WriteLine(marca);

			}

			archivo.Flush();
			archivo.Close();
		}
	}
}
