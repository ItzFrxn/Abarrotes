namespace Abarrotes
{
	partial class FrmProductos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboMarcas = new System.Windows.Forms.ComboBox();
			this.cboCategorias = new System.Windows.Forms.ComboBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnAleatorio = new System.Windows.Forms.Button();
			this.pbCodigo = new System.Windows.Forms.PictureBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lstvwProductos = new System.Windows.Forms.ListView();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlpContador = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboMarcas);
			this.groupBox1.Controls.Add(this.cboCategorias);
			this.groupBox1.Controls.Add(this.txtPrecio);
			this.groupBox1.Controls.Add(this.txtCantidad);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(254, 229);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del Producto";
			// 
			// cboMarcas
			// 
			this.cboMarcas.FormattingEnabled = true;
			this.cboMarcas.Location = new System.Drawing.Point(102, 92);
			this.cboMarcas.Name = "cboMarcas";
			this.cboMarcas.Size = new System.Drawing.Size(121, 21);
			this.cboMarcas.TabIndex = 9;
			// 
			// cboCategorias
			// 
			this.cboCategorias.FormattingEnabled = true;
			this.cboCategorias.Location = new System.Drawing.Point(102, 65);
			this.cboCategorias.Name = "cboCategorias";
			this.cboCategorias.Size = new System.Drawing.Size(121, 21);
			this.cboCategorias.TabIndex = 8;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(102, 153);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(121, 20);
			this.txtPrecio.TabIndex = 7;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(102, 123);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(121, 20);
			this.txtCantidad.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(102, 41);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(121, 20);
			this.txtNombre.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Precio:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Cantidad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Marca:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Categoria:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnEliminar);
			this.groupBox2.Controls.Add(this.btnGuardar);
			this.groupBox2.Controls.Add(this.btnAleatorio);
			this.groupBox2.Controls.Add(this.pbCodigo);
			this.groupBox2.Controls.Add(this.btnImprimir);
			this.groupBox2.Controls.Add(this.btnGenerar);
			this.groupBox2.Controls.Add(this.txtCodigo);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(332, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(276, 229);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Generar Código:";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(177, 192);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(15, 193);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnAleatorio
			// 
			this.btnAleatorio.Location = new System.Drawing.Point(15, 73);
			this.btnAleatorio.Name = "btnAleatorio";
			this.btnAleatorio.Size = new System.Drawing.Size(75, 23);
			this.btnAleatorio.TabIndex = 5;
			this.btnAleatorio.Text = "Aleatorio";
			this.btnAleatorio.UseVisualStyleBackColor = true;
			this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
			// 
			// pbCodigo
			// 
			this.pbCodigo.Location = new System.Drawing.Point(53, 111);
			this.pbCodigo.Name = "pbCodigo";
			this.pbCodigo.Size = new System.Drawing.Size(165, 76);
			this.pbCodigo.TabIndex = 4;
			this.pbCodigo.TabStop = false;
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(177, 73);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(75, 23);
			this.btnImprimir.TabIndex = 3;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			// 
			// btnGenerar
			// 
			this.btnGenerar.Location = new System.Drawing.Point(96, 72);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(75, 23);
			this.btnGenerar.TabIndex = 2;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(96, 40);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Codigo:";
			// 
			// lstvwProductos
			// 
			this.lstvwProductos.HideSelection = false;
			this.lstvwProductos.Location = new System.Drawing.Point(38, 261);
			this.lstvwProductos.Name = "lstvwProductos";
			this.lstvwProductos.Size = new System.Drawing.Size(660, 116);
			this.lstvwProductos.TabIndex = 2;
			this.lstvwProductos.UseCompatibleStateImageBehavior = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tlpContador});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
			this.toolStripStatusLabel1.Text = "Cantidad:";
			// 
			// tlpContador
			// 
			this.tlpContador.Name = "tlpContador";
			this.tlpContador.Size = new System.Drawing.Size(13, 17);
			this.tlpContador.Text = "0";
			// 
			// FrmProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lstvwProductos);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmProductos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Catalogo de Productos";
			this.Load += new System.EventHandler(this.FrmProductos_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboMarcas;
		private System.Windows.Forms.ComboBox cboCategorias;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pbCodigo;
		private System.Windows.Forms.Button btnAleatorio;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.ListView lstvwProductos;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tlpContador;
	}
}