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
	public partial class FrmMarcas : Form
	{
		public FrmMarcas()
		{
			InitializeComponent();
		}

		private void FrmMarcas_Load(object sender, EventArgs e)
		{
			lstvwMarcas.Columns.Add("Marca", 200);
			lstvwMarcas.View = View.Details;
			lstvwMarcas.FullRowSelect = true;
			lstvwMarcas.GridLines = true;
			lstvwMarcas.CheckBoxes = true;

			MostrarMarcas();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text == "")
			{
				MessageBox.Show("El campo 'nombre' esta vacio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				Marcas marca = new Marcas(this.txtNombre.Text);
				marca.RegistrarMarca();

				txtNombre.Text = "";
				txtNombre.Focus();

				MostrarMarcas();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (lstvwMarcas.CheckedIndices.Count == 0)
			{
				MessageBox.Show("No hay elementos seleccionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				DialogResult respuesta = MessageBox.Show("¿Deseas eliminanr los  siguientes datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				
				if (respuesta == DialogResult.Yes)
				{
					for (int i = lstvwMarcas.CheckedIndices.Count - 1; i >= 0; i--)
					{
						lstvwMarcas.Items.RemoveAt(lstvwMarcas.CheckedIndices[i]);
					}

					ActualizarArchivo();
					MostrarMarcas();
				}
			}
		}

		private void MostrarMarcas()
		{
			lstvwMarcas.Items.Clear();

			StreamReader archivo = new StreamReader(@"..\..\..\Archivos\marcas.txt");
			string linea = archivo.ReadLine();
			int contador = 0;

			while (linea != null)
			{
				string[] datos = new string[1];
				datos[0] = linea;

				ListViewItem item = new ListViewItem(datos);
				lstvwMarcas.Items.Add(item);

				linea = archivo.ReadLine();
				contador++;
			}

			archivo.Close();
			tlpCantidad.Text = Convert.ToString(contador);
		}

		private void ActualizarArchivo()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\..\Archivos\marcas.txt");
			int cantidad = lstvwMarcas.Items.Count;

			for (int x = 0; x < cantidad; x++)
			{
				string marca = lstvwMarcas.Items[x].Text;
				archivo.WriteLine(marca);

			}

			archivo.Flush();
			archivo.Close();
		}
	}
}
