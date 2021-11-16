
namespace TP_Grupo5.GUILayer
{
    partial class frmConsultarFacturas
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbListadoFactura = new System.Windows.Forms.GroupBox();
            this.grdListadoFacturas = new System.Windows.Forms.DataGridView();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verFactura = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.gbFacturaFiltro = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.cboUCreador = new System.Windows.Forms.ComboBox();
            this.lblUCreador = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.gbNombre.SuspendLayout();
            this.gbListadoFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoFacturas)).BeginInit();
            this.gbFacturaFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNombre
            // 
            this.gbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNombre.Controls.Add(this.btnSalir);
            this.gbNombre.Controls.Add(this.gbListadoFactura);
            this.gbNombre.Controls.Add(this.btnLimpiar);
            this.gbNombre.Controls.Add(this.chkTodos);
            this.gbNombre.Controls.Add(this.btnListar);
            this.gbNombre.Controls.Add(this.gbFacturaFiltro);
            this.gbNombre.Location = new System.Drawing.Point(13, 13);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(805, 462);
            this.gbNombre.TabIndex = 6;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Detalle de factura";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(683, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbListadoFactura
            // 
            this.gbListadoFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbListadoFactura.Controls.Add(this.grdListadoFacturas);
            this.gbListadoFactura.Location = new System.Drawing.Point(44, 147);
            this.gbListadoFactura.Name = "gbListadoFactura";
            this.gbListadoFactura.Size = new System.Drawing.Size(717, 230);
            this.gbListadoFactura.TabIndex = 10;
            this.gbListadoFactura.TabStop = false;
            this.gbListadoFactura.Text = "Listado de facturas";
            // 
            // grdListadoFacturas
            // 
            this.grdListadoFacturas.AllowUserToAddRows = false;
            this.grdListadoFacturas.AllowUserToDeleteRows = false;
            this.grdListadoFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListadoFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactura,
            this.nroFactura,
            this.fecha,
            this.cliente,
            this.creador,
            this.verFactura});
            this.grdListadoFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListadoFacturas.Location = new System.Drawing.Point(3, 16);
            this.grdListadoFacturas.Name = "grdListadoFacturas";
            this.grdListadoFacturas.ReadOnly = true;
            this.grdListadoFacturas.Size = new System.Drawing.Size(711, 211);
            this.grdListadoFacturas.TabIndex = 0;
            this.grdListadoFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListadoFacturas_CellClick);
            // 
            // idFactura
            // 
            this.idFactura.HeaderText = "ID";
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            this.idFactura.Visible = false;
            // 
            // nroFactura
            // 
            this.nroFactura.HeaderText = "Nro. de factura";
            this.nroFactura.Name = "nroFactura";
            this.nroFactura.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 150;
            // 
            // creador
            // 
            this.creador.HeaderText = "Usuario creador";
            this.creador.Name = "creador";
            this.creador.ReadOnly = true;
            this.creador.Width = 150;
            // 
            // verFactura
            // 
            this.verFactura.HeaderText = "Detalle de factura";
            this.verFactura.Name = "verFactura";
            this.verFactura.ReadOnly = true;
            this.verFactura.Text = "";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Location = new System.Drawing.Point(676, 116);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(676, 65);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 8;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // btnListar
            // 
            this.btnListar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListar.Location = new System.Drawing.Point(676, 87);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // gbFacturaFiltro
            // 
            this.gbFacturaFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFacturaFiltro.Controls.Add(this.dtpFechaHasta);
            this.gbFacturaFiltro.Controls.Add(this.lblFechaHasta);
            this.gbFacturaFiltro.Controls.Add(this.cboUCreador);
            this.gbFacturaFiltro.Controls.Add(this.lblUCreador);
            this.gbFacturaFiltro.Controls.Add(this.cboCliente);
            this.gbFacturaFiltro.Controls.Add(this.lblCliente);
            this.gbFacturaFiltro.Controls.Add(this.dtpFechaDesde);
            this.gbFacturaFiltro.Controls.Add(this.lblFechaDesde);
            this.gbFacturaFiltro.Location = new System.Drawing.Point(44, 40);
            this.gbFacturaFiltro.Name = "gbFacturaFiltro";
            this.gbFacturaFiltro.Size = new System.Drawing.Size(626, 101);
            this.gbFacturaFiltro.TabIndex = 7;
            this.gbFacturaFiltro.TabStop = false;
            this.gbFacturaFiltro.Text = "Opción de busqueda";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(356, 50);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaHasta.TabIndex = 3;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(278, 53);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 13);
            this.lblFechaHasta.TabIndex = 21;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // cboUCreador
            // 
            this.cboUCreador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUCreador.FormattingEnabled = true;
            this.cboUCreador.Location = new System.Drawing.Point(75, 50);
            this.cboUCreador.Name = "cboUCreador";
            this.cboUCreador.Size = new System.Drawing.Size(159, 21);
            this.cboUCreador.TabIndex = 1;
            // 
            // lblUCreador
            // 
            this.lblUCreador.AutoSize = true;
            this.lblUCreador.Location = new System.Drawing.Point(25, 53);
            this.lblUCreador.Name = "lblUCreador";
            this.lblUCreador.Size = new System.Drawing.Size(47, 13);
            this.lblUCreador.TabIndex = 19;
            this.lblUCreador.Text = "Creador:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(75, 22);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(159, 21);
            this.cboCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(30, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 17;
            this.lblCliente.Text = "Cliente:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(356, 22);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaDesde.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(278, 25);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(72, 13);
            this.lblFechaDesde.TabIndex = 15;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // frmConsultarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.gbNombre);
            this.Name = "frmConsultarFacturas";
            this.Text = "frmConsultarFacturas";
            this.Load += new System.EventHandler(this.frmConsultarFacturas_Load);
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbListadoFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListadoFacturas)).EndInit();
            this.gbFacturaFiltro.ResumeLayout(false);
            this.gbFacturaFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbListadoFactura;
        private System.Windows.Forms.DataGridView grdListadoFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn creador;
        private System.Windows.Forms.DataGridViewButtonColumn verFactura;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox gbFacturaFiltro;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.ComboBox cboUCreador;
        private System.Windows.Forms.Label lblUCreador;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
    }
}