namespace Trabajo_Final_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.nudCuit = new System.Windows.Forms.NumericUpDown();
            this.nudFactura = new System.Windows.Forms.NumericUpDown();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.gbDetalleCompra = new System.Windows.Forms.GroupBox();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.nudCodArticulo = new System.Windows.Forms.NumericUpDown();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.ColCodArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBorrarProdcuto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactura)).BeginInit();
            this.gbDetalleCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.btnBuscarFactura);
            this.gbDatosCliente.Controls.Add(this.txtRazonSocial);
            this.gbDatosCliente.Controls.Add(this.nudCuit);
            this.gbDatosCliente.Controls.Add(this.nudFactura);
            this.gbDatosCliente.Controls.Add(this.lblFactura);
            this.gbDatosCliente.Controls.Add(this.lblCuit);
            this.gbDatosCliente.Controls.Add(this.lblRazonSocial);
            this.gbDatosCliente.Location = new System.Drawing.Point(29, 15);
            this.gbDatosCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosCliente.Size = new System.Drawing.Size(1275, 100);
            this.gbDatosCliente.TabIndex = 0;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.Location = new System.Drawing.Point(1102, 23);
            this.btnBuscarFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(148, 53);
            this.btnBuscarFactura.TabIndex = 16;
            this.btnBuscarFactura.Text = "Buscar Factura";
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(8, 59);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(151, 22);
            this.txtRazonSocial.TabIndex = 5;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudCuit
            // 
            this.nudCuit.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCuit.Location = new System.Drawing.Point(311, 60);
            this.nudCuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCuit.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCuit.Name = "nudCuit";
            this.nudCuit.Size = new System.Drawing.Size(155, 22);
            this.nudCuit.TabIndex = 4;
            this.nudCuit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nudFactura
            // 
            this.nudFactura.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudFactura.Location = new System.Drawing.Point(633, 60);
            this.nudFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudFactura.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudFactura.Name = "nudFactura";
            this.nudFactura.Size = new System.Drawing.Size(155, 22);
            this.nudFactura.TabIndex = 3;
            this.nudFactura.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(651, 31);
            this.lblFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(72, 16);
            this.lblFactura.TabIndex = 2;
            this.lblFactura.Text = "N° Factura:";
            this.lblFactura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(359, 31);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 16);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "Cuit:";
            this.lblCuit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(25, 31);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(90, 16);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razon Social:";
            this.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbDetalleCompra
            // 
            this.gbDetalleCompra.Controls.Add(this.btnCargarProducto);
            this.gbDetalleCompra.Controls.Add(this.nudDescuento);
            this.gbDetalleCompra.Controls.Add(this.lblDescuento);
            this.gbDetalleCompra.Controls.Add(this.nudCantidad);
            this.gbDetalleCompra.Controls.Add(this.lblCantidad);
            this.gbDetalleCompra.Controls.Add(this.nudPrecio);
            this.gbDetalleCompra.Controls.Add(this.lblPrecio);
            this.gbDetalleCompra.Controls.Add(this.txtDescripcion);
            this.gbDetalleCompra.Controls.Add(this.lblDescripcion);
            this.gbDetalleCompra.Controls.Add(this.nudCodArticulo);
            this.gbDetalleCompra.Controls.Add(this.lblCodArticulo);
            this.gbDetalleCompra.Location = new System.Drawing.Point(29, 135);
            this.gbDetalleCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetalleCompra.Name = "gbDetalleCompra";
            this.gbDetalleCompra.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDetalleCompra.Size = new System.Drawing.Size(1275, 113);
            this.gbDetalleCompra.TabIndex = 1;
            this.gbDetalleCompra.TabStop = false;
            this.gbDetalleCompra.Text = "Detalle de compra";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(1102, 29);
            this.btnCargarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(148, 53);
            this.btnCargarProducto.TabIndex = 15;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // nudDescuento
            // 
            this.nudDescuento.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDescuento.Location = new System.Drawing.Point(689, 62);
            this.nudDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(155, 22);
            this.nudDescuento.TabIndex = 14;
            this.nudDescuento.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(707, 32);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(75, 16);
            this.lblDescuento.TabIndex = 13;
            this.lblDescuento.Text = "Descuento:";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCantidad.Location = new System.Drawing.Point(524, 62);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantidad.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(155, 22);
            this.nudCantidad.TabIndex = 12;
            this.nudCantidad.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(541, 32);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudPrecio.Location = new System.Drawing.Point(353, 62);
            this.nudPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPrecio.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(155, 22);
            this.nudPrecio.TabIndex = 10;
            this.nudPrecio.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(401, 32);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(184, 60);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(151, 22);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(215, 32);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudCodArticulo
            // 
            this.nudCodArticulo.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCodArticulo.Location = new System.Drawing.Point(13, 62);
            this.nudCodArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCodArticulo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCodArticulo.Name = "nudCodArticulo";
            this.nudCodArticulo.Size = new System.Drawing.Size(155, 22);
            this.nudCodArticulo.TabIndex = 6;
            this.nudCodArticulo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Location = new System.Drawing.Point(48, 32);
            this.lblCodArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(85, 16);
            this.lblCodArticulo.TabIndex = 5;
            this.lblCodArticulo.Text = "Cod. Articulo:";
            this.lblCodArticulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodArticulo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.ColDescuento,
            this.ColSubTotal});
            this.dgvFactura.Location = new System.Drawing.Point(29, 256);
            this.dgvFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 51;
            this.dgvFactura.Size = new System.Drawing.Size(1074, 351);
            this.dgvFactura.TabIndex = 2;
            // 
            // ColCodArticulo
            // 
            this.ColCodArticulo.HeaderText = "Cod.Articulo";
            this.ColCodArticulo.MinimumWidth = 6;
            this.ColCodArticulo.Name = "ColCodArticulo";
            this.ColCodArticulo.Width = 125;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Width = 125;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Width = 125;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Width = 125;
            // 
            // ColDescuento
            // 
            this.ColDescuento.HeaderText = "Descuento";
            this.ColDescuento.MinimumWidth = 6;
            this.ColDescuento.Name = "ColDescuento";
            this.ColDescuento.Width = 125;
            // 
            // ColSubTotal
            // 
            this.ColSubTotal.HeaderText = "SubTotal";
            this.ColSubTotal.MinimumWidth = 6;
            this.ColSubTotal.Name = "ColSubTotal";
            this.ColSubTotal.Width = 125;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(1131, 445);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(148, 53);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBorrarProdcuto
            // 
            this.btnBorrarProdcuto.Location = new System.Drawing.Point(1131, 256);
            this.btnBorrarProdcuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarProdcuto.Name = "btnBorrarProdcuto";
            this.btnBorrarProdcuto.Size = new System.Drawing.Size(148, 53);
            this.btnBorrarProdcuto.TabIndex = 17;
            this.btnBorrarProdcuto.Text = "Borrar Producto";
            this.btnBorrarProdcuto.UseVisualStyleBackColor = true;
            this.btnBorrarProdcuto.Click += new System.EventHandler(this.btnBorrarProdcuto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(1131, 347);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(148, 53);
            this.btnModificarProducto.TabIndex = 18;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1131, 542);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 53);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 651);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnBorrarProdcuto);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.gbDetalleCompra);
            this.Controls.Add(this.gbDatosCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactura)).EndInit();
            this.gbDetalleCompra.ResumeLayout(false);
            this.gbDetalleCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.NumericUpDown nudCuit;
        private System.Windows.Forms.NumericUpDown nudFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.GroupBox gbDetalleCompra;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.NumericUpDown nudCodArticulo;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBorrarProdcuto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnSalir;
    }
}

