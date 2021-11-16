
namespace TP_Grupo5
{
    partial class frmConsultaCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.rbEliminado = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbListaClientes = new System.Windows.Forms.GroupBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarCliente = new System.Windows.Forms.GroupBox();
            this.gbFechaAlta = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesdeFechaA = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblNombreBarrio = new System.Windows.Forms.Label();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblRazonS = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbNombre.SuspendLayout();
            this.gbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.gbBuscarCliente.SuspendLayout();
            this.gbFechaAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNombre
            // 
            this.gbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNombre.Controls.Add(this.btnEliminar);
            this.gbNombre.Controls.Add(this.rbTodos);
            this.gbNombre.Controls.Add(this.btnAgregar);
            this.gbNombre.Controls.Add(this.rbActivos);
            this.gbNombre.Controls.Add(this.btnActualizar);
            this.gbNombre.Controls.Add(this.rbEliminado);
            this.gbNombre.Controls.Add(this.btnSalir);
            this.gbNombre.Controls.Add(this.gbListaClientes);
            this.gbNombre.Controls.Add(this.gbBuscarCliente);
            this.gbNombre.Controls.Add(this.btnBuscar);
            this.gbNombre.Controls.Add(this.btnLimpiar);
            this.gbNombre.Location = new System.Drawing.Point(12, 12);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(806, 463);
            this.gbNombre.TabIndex = 11;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Cliente";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Location = new System.Drawing.Point(416, 409);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 30);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(725, 73);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 15;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(277, 409);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 30);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbActivos
            // 
            this.rbActivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(725, 30);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(60, 17);
            this.rbActivos.TabIndex = 13;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Location = new System.Drawing.Point(346, 409);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 30);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // rbEliminado
            // 
            this.rbEliminado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbEliminado.AutoSize = true;
            this.rbEliminado.Location = new System.Drawing.Point(725, 52);
            this.rbEliminado.Name = "rbEliminado";
            this.rbEliminado.Size = new System.Drawing.Size(75, 17);
            this.rbEliminado.TabIndex = 14;
            this.rbEliminado.TabStop = true;
            this.rbEliminado.Text = "Eliminados";
            this.rbEliminado.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(733, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 30);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbListaClientes
            // 
            this.gbListaClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbListaClientes.Controls.Add(this.grdClientes);
            this.gbListaClientes.Location = new System.Drawing.Point(6, 167);
            this.gbListaClientes.Name = "gbListaClientes";
            this.gbListaClientes.Size = new System.Drawing.Size(794, 236);
            this.gbListaClientes.TabIndex = 18;
            this.gbListaClientes.TabStop = false;
            this.gbListaClientes.Text = "Lista de clientes";
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.razonS,
            this.cuit,
            this.barrio,
            this.calle,
            this.nroCalle,
            this.fechaAlta,
            this.contacto,
            this.borrado});
            this.grdClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClientes.Location = new System.Drawing.Point(3, 16);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.RowTemplate.Height = 25;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(788, 217);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.SelectionChanged += new System.EventHandler(this.grdClientes_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // razonS
            // 
            this.razonS.HeaderText = "Razon Social";
            this.razonS.Name = "razonS";
            this.razonS.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // barrio
            // 
            this.barrio.HeaderText = "Barrio";
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // nroCalle
            // 
            this.nroCalle.HeaderText = "Nro";
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha de Alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // contacto
            // 
            this.contacto.HeaderText = "Contacto";
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // gbBuscarCliente
            // 
            this.gbBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbBuscarCliente.Controls.Add(this.gbFechaAlta);
            this.gbBuscarCliente.Controls.Add(this.lblNombreBarrio);
            this.gbBuscarCliente.Controls.Add(this.cboBarrio);
            this.gbBuscarCliente.Controls.Add(this.lblCUIT);
            this.gbBuscarCliente.Controls.Add(this.txtCuit);
            this.gbBuscarCliente.Controls.Add(this.lblRazonS);
            this.gbBuscarCliente.Controls.Add(this.txtRazonSocial);
            this.gbBuscarCliente.Location = new System.Drawing.Point(6, 30);
            this.gbBuscarCliente.Name = "gbBuscarCliente";
            this.gbBuscarCliente.Size = new System.Drawing.Size(713, 131);
            this.gbBuscarCliente.TabIndex = 12;
            this.gbBuscarCliente.TabStop = false;
            this.gbBuscarCliente.Text = "Opción de búsqueda";
            // 
            // gbFechaAlta
            // 
            this.gbFechaAlta.Controls.Add(this.lblHasta);
            this.gbFechaAlta.Controls.Add(this.dtpFechaHasta);
            this.gbFechaAlta.Controls.Add(this.lblDesdeFechaA);
            this.gbFechaAlta.Controls.Add(this.dtpFechaDesde);
            this.gbFechaAlta.Location = new System.Drawing.Point(403, 19);
            this.gbFechaAlta.Name = "gbFechaAlta";
            this.gbFechaAlta.Size = new System.Drawing.Size(304, 75);
            this.gbFechaAlta.TabIndex = 3;
            this.gbFechaAlta.TabStop = false;
            this.gbFechaAlta.Text = "Fecha alta";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(34, 49);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 12;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(74, 44);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(224, 20);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // lblDesdeFechaA
            // 
            this.lblDesdeFechaA.AutoSize = true;
            this.lblDesdeFechaA.Location = new System.Drawing.Point(33, 19);
            this.lblDesdeFechaA.Name = "lblDesdeFechaA";
            this.lblDesdeFechaA.Size = new System.Drawing.Size(41, 13);
            this.lblDesdeFechaA.TabIndex = 10;
            this.lblDesdeFechaA.Text = "Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(74, 16);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(224, 20);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.AutoSize = true;
            this.lblNombreBarrio.Location = new System.Drawing.Point(253, 39);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblNombreBarrio.TabIndex = 1;
            this.lblNombreBarrio.Text = "Barrio:";
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(293, 37);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(104, 21);
            this.cboBarrio.TabIndex = 2;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(42, 63);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(35, 13);
            this.lblCUIT.TabIndex = 3;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(78, 61);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(169, 20);
            this.txtCuit.TabIndex = 1;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // lblRazonS
            // 
            this.lblRazonS.AutoSize = true;
            this.lblRazonS.Location = new System.Drawing.Point(5, 38);
            this.lblRazonS.Name = "lblRazonS";
            this.lblRazonS.Size = new System.Drawing.Size(71, 13);
            this.lblRazonS.TabIndex = 1;
            this.lblRazonS.Text = "Razon social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(78, 36);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(169, 20);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(725, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 30);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Location = new System.Drawing.Point(725, 131);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 30);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.gbNombre);
            this.Name = "frmConsultaCliente";
            this.Text = "Clientes";
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.gbBuscarCliente.ResumeLayout(false);
            this.gbBuscarCliente.PerformLayout();
            this.gbFechaAlta.ResumeLayout(false);
            this.gbFechaAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.RadioButton rbEliminado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbListaClientes;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
        private System.Windows.Forms.GroupBox gbBuscarCliente;
        private System.Windows.Forms.GroupBox gbFechaAlta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblDesdeFechaA;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblNombreBarrio;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblRazonS;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

