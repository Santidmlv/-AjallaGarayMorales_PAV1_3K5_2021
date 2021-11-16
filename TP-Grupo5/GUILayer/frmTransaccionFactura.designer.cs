
namespace TP_Grupo5.GUILayer
{
    partial class frmTransaccionFactura
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
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.cboUCreador = new System.Windows.Forms.ComboBox();
            this.lblUCreador = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbFacturaDetalle = new System.Windows.Forms.GroupBox();
            this.gbGrilla = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grbFacturaDetalle = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbNombre.SuspendLayout();
            this.gbFacturaDetalle.SuspendLayout();
            this.gbGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbFacturaDetalle)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNombre
            // 
            this.gbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNombre.Controls.Add(this.btnNuevoCliente);
            this.gbNombre.Controls.Add(this.cboUCreador);
            this.gbNombre.Controls.Add(this.lblUCreador);
            this.gbNombre.Controls.Add(this.btnSalir);
            this.gbNombre.Controls.Add(this.btnGuardar);
            this.gbNombre.Controls.Add(this.gbFacturaDetalle);
            this.gbNombre.Controls.Add(this.cboCliente);
            this.gbNombre.Controls.Add(this.lblCliente);
            this.gbNombre.Controls.Add(this.dtpFecha);
            this.gbNombre.Controls.Add(this.lblFecha);
            this.gbNombre.Location = new System.Drawing.Point(12, 12);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(806, 463);
            this.gbNombre.TabIndex = 13;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Factura";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevoCliente.Location = new System.Drawing.Point(119, 98);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(64, 30);
            this.btnNuevoCliente.TabIndex = 15;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // cboUCreador
            // 
            this.cboUCreador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboUCreador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUCreador.FormattingEnabled = true;
            this.cboUCreador.Location = new System.Drawing.Point(333, 73);
            this.cboUCreador.Name = "cboUCreador";
            this.cboUCreador.Size = new System.Drawing.Size(159, 21);
            this.cboUCreador.TabIndex = 17;
            // 
            // lblUCreador
            // 
            this.lblUCreador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUCreador.AutoSize = true;
            this.lblUCreador.Location = new System.Drawing.Point(283, 76);
            this.lblUCreador.Name = "lblUCreador";
            this.lblUCreador.Size = new System.Drawing.Size(47, 13);
            this.lblUCreador.TabIndex = 22;
            this.lblUCreador.Text = "Creador:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(662, 369);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(580, 369);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbFacturaDetalle
            // 
            this.gbFacturaDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFacturaDetalle.Controls.Add(this.gbGrilla);
            this.gbFacturaDetalle.Controls.Add(this.gbDetalle);
            this.gbFacturaDetalle.Location = new System.Drawing.Point(70, 127);
            this.gbFacturaDetalle.Name = "gbFacturaDetalle";
            this.gbFacturaDetalle.Size = new System.Drawing.Size(667, 236);
            this.gbFacturaDetalle.TabIndex = 20;
            this.gbFacturaDetalle.TabStop = false;
            // 
            // gbGrilla
            // 
            this.gbGrilla.Controls.Add(this.lblTotal);
            this.gbGrilla.Controls.Add(this.txtTotal);
            this.gbGrilla.Controls.Add(this.btnEliminar);
            this.gbGrilla.Controls.Add(this.grbFacturaDetalle);
            this.gbGrilla.Location = new System.Drawing.Point(249, 19);
            this.gbGrilla.Name = "gbGrilla";
            this.gbGrilla.Size = new System.Drawing.Size(412, 211);
            this.gbGrilla.TabIndex = 1;
            this.gbGrilla.TabStop = false;
            this.gbGrilla.Text = "Detalle de Factura";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(339, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(339, 142);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(67, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(272, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grbFacturaDetalle
            // 
            this.grbFacturaDetalle.AllowUserToAddRows = false;
            this.grbFacturaDetalle.AllowUserToDeleteRows = false;
            this.grbFacturaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grbFacturaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.precio});
            this.grbFacturaDetalle.Location = new System.Drawing.Point(5, 19);
            this.grbFacturaDetalle.Name = "grbFacturaDetalle";
            this.grbFacturaDetalle.ReadOnly = true;
            this.grbFacturaDetalle.RowTemplate.Height = 25;
            this.grbFacturaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grbFacturaDetalle.Size = new System.Drawing.Size(331, 143);
            this.grbFacturaDetalle.TabIndex = 0;
            this.grbFacturaDetalle.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grbFacturaDetalle_RowPostPaint);
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.txtPrecio);
            this.gbDetalle.Controls.Add(this.lblProducto);
            this.gbDetalle.Controls.Add(this.lblPrecio);
            this.gbDetalle.Controls.Add(this.cboProducto);
            this.gbDetalle.Controls.Add(this.btnAgregar);
            this.gbDetalle.Controls.Add(this.lblProyecto);
            this.gbDetalle.Controls.Add(this.cboProyecto);
            this.gbDetalle.Location = new System.Drawing.Point(5, 19);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(238, 211);
            this.gbDetalle.TabIndex = 0;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Proyecto/Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(59, 94);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(86, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(3, 71);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 16;
            this.lblProducto.Text = "Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 96);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(59, 69);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(144, 21);
            this.cboProducto.TabIndex = 1;
            this.cboProducto.SelectionChangeCommitted += new System.EventHandler(this.cboProducto_SelectionChangeCommitted);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(168, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 30);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(5, 46);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(52, 13);
            this.lblProyecto.TabIndex = 14;
            this.lblProyecto.Text = "Proyecto:";
            // 
            // cboProyecto
            // 
            this.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Location = new System.Drawing.Point(59, 44);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(144, 21);
            this.cboProyecto.TabIndex = 0;
            this.cboProyecto.SelectionChangeCommitted += new System.EventHandler(this.cboProyecto_SelectionChangeCommitted);
            // 
            // cboCliente
            // 
            this.cboCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(119, 73);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(159, 21);
            this.cboCliente.TabIndex = 14;
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(74, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 18;
            this.lblCliente.Text = "Cliente:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(544, 73);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(193, 20);
            this.dtpFecha.TabIndex = 19;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(504, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha:";
            // 
            // frmTransaccionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.gbNombre);
            this.Name = "frmTransaccionFactura";
            this.Text = "frmTransaccionFactura";
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbFacturaDetalle.ResumeLayout(false);
            this.gbGrilla.ResumeLayout(false);
            this.gbGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbFacturaDetalle)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ComboBox cboUCreador;
        private System.Windows.Forms.Label lblUCreador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbFacturaDetalle;
        private System.Windows.Forms.GroupBox gbGrilla;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView grbFacturaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}