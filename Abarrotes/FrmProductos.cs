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
using System.Xml.Linq;

namespace Abarrotes
{
	public partial class FrmProductos : Form
	{
		public FrmProductos()
		{
			InitializeComponent();
		}

		private void FrmProductos_Load(object sender, EventArgs e)
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

			CargarCategorias();
			CargarMarcas();
			CargarProductos();
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			if (txtCodigo.Text == "")
			{
				MessageBox.Show("El campo 'codigo' esta vacio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				Zen.Barcode.Code128BarcodeDraw mgenerador = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
				pbCodigo.Image = mgenerador.Draw(txtCodigo.Text, 60);
			}
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			SaveFileDialog savefd = new SaveFileDialog();
			//savefd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			savefd.InitialDirectory = Path.GetFullPath(@"..\..\..\Codigos");
			savefd.FileName = txtCodigo.Text + ".png";

			if(savefd.ShowDialog() != DialogResult.Cancel)
			{
				string codBarras = savefd.FileName;

				Bitmap bitmap = new Bitmap(pbCodigo.Image);
				bitmap.Save(codBarras);
			}
		}

		private void btnAleatorio_Click(object sender, EventArgs e)
		{
			Productos producto = new Productos();
			txtCodigo.Text = producto.GenerarCodigo;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (txtNombre.Text == "" || txtCodigo.Text == "" || cboCategorias.Text == "" || cboMarcas.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
			{
				MessageBox.Show("Campos incompletos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (Convert.ToDouble(txtPrecio.Text) <= 0 || Convert.ToInt32(txtCantidad.Text) <= 0)
			{
				MessageBox.Show("Debe proporcionar cantidades mayores a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				Productos producto = new Productos(txtCodigo.Text, txtNombre.Text, cboCategorias.Text, cboMarcas.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));
				producto.GuardarInformacion();
				CargarProductos();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (lstvwProductos.CheckedIndices.Count == 0)
			{
				MessageBox.Show("No hay elementos seleccionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				DialogResult respuesta = MessageBox.Show("¿Deseas eliminanr los  siguientes datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (respuesta == DialogResult.Yes)
				{
					for (int i = lstvwProductos.CheckedIndices.Count - 1; i >= 0; i--)
					{
						lstvwProductos.Items.RemoveAt(lstvwProductos.CheckedIndices[i]);
					}

					ActualizarArchivo();
					CargarProductos();
				}
			}
		}

		private void CargarCategorias()
		{
			StreamReader archivo = new StreamReader(@"..\..\..\Archivos\categorias.txt");
			string linea = archivo.ReadLine();

			while (linea != null)
			{
				cboCategorias.Items.Add(linea);
				linea = archivo.ReadLine();
			}

			archivo.Close();
		}

		private void CargarMarcas()
		{
			StreamReader archivo = new StreamReader(@"..\..\..\Archivos\marcas.txt");
			string linea = archivo.ReadLine();

			while (linea != null)
			{
				cboMarcas.Items.Add(linea);
				linea = archivo.ReadLine();
			}

			archivo.Close();
		}

		private void CargarProductos()
		{
			try
			{
				StreamReader archivo = new StreamReader(@"..\..\..\Archivos\productos.txt");
				string linea = archivo.ReadLine();
				int count = 0;

				while (linea != null)
				{
					string[] datos = linea.Split('|');

					if (txtCodigo.Text == datos[0])
					{
						ListViewItem item = new ListViewItem(datos);
						lstvwProductos.Items.Add(item);
					}

					linea = archivo.ReadLine();
					count++;
				}

				archivo.Close();
				tlpContador.Text = Convert.ToString(count);
			}
			catch
			{
				MessageBox.Show("Error al cargar los productos");
			};
		}

		private void ActualizarArchivo()
		{
			StreamWriter archivo = new StreamWriter(@"..\..\..\Archivos\marcas.txt");
			int cantidad = lstvwProductos.Items.Count;

			for (int x = 0; x < cantidad; x++)
			{
				string marca = lstvwProductos.Items[x].Text;
				archivo.WriteLine(marca);

			}

			archivo.Flush();
			archivo.Close();
		}
	}
}
