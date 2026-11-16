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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			string usuario = txtUsuario.Text;
			string contrasena = txtContrasena.Text;

			if (usuario == "" || contrasena == "")
			{
				MessageBox.Show("No se permiten campos vacios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else {
				if (ObtenerStatus(usuario, contrasena))
				{
					MDIParent1 mdiMenu = new MDIParent1();
					mdiMenu.Show();
					//this.Hide();
				}
				else
				{
					MessageBox.Show("No se encuetra el usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public bool ObtenerStatus(string user, string pass)
		{
			StreamReader archivo = new StreamReader(@"..\..\..\Archivos\usuarios.txt");
			string linea = archivo.ReadLine();
			bool status = false;

			while (linea != null)
			{
				string[] datos = linea.Split('|');
				string datoUsuario = datos[0];
				string datoContrasena = datos[1];
				string datoRol = datos[2];

				if (user == datoUsuario && pass == datoContrasena)
				{
					status = true;
				}
				linea = archivo.ReadLine();
			}
			archivo.Close();
			return status;
		}
	}
}
