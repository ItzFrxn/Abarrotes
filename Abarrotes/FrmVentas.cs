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
	public partial class FrmVentas : Form
	{
		public FrmVentas()
		{
			InitializeComponent();
		}
		private void FrmVentas_Load(object sender, EventArgs e)
		{
			lstvwProductos.Columns.Add("Codigo", 100);
			lstvwProductos.Columns.Add("Nombre", 100);
			lstvwProductos.Columns.Add("Categoria", 100);
			lstvwProductos.Columns.Add("Marca", 100);
			lstvwProductos.Columns.Add("Cantidad", 100);
			lstvwProductos.Columns.Add("Precio", 100);

			lstvwProductos.View = View.Details;
			lstvwProductos.FullRowSelect = true;
			lstvwProductos.GridLines = true;
			lstvwProductos.CheckBoxes = true;
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			BuscarProducto();
			tlpContador.Text = lstvwProductos.Items.Count.ToString();
		}
		
		private void BuscarProducto()
		{
			try
			{
				StreamReader archivo = new StreamReader(@"..\..\..\Archivos\productos.txt");
				string linea = archivo.ReadLine();

				while (linea != null)
				{
					string[] datos = linea.Split('|');
					if (txtCodigo.Text == datos[0])
					{
						ListViewItem item = new ListViewItem(datos);
						lstvwProductos.Items.Add(item);
					}
					linea = archivo.ReadLine();
				}
			}
			catch
			{
				MessageBox.Show("Error al cargar los productos");
			};
		}

		private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				txtCodigo.ResetText();
				txtCodigo.Focus();
			}
		}
	}
}
