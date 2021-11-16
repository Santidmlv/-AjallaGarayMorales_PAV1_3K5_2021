
namespace TP_Grupo5.GUILayer.Reportes
{
    partial class frmReporteDetalleCantidad
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DT_DetallesCantidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Reportes = new TP_Grupo5.GUILayer.Reportes.DS_Reportes();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.rbProdYProy = new System.Windows.Forms.RadioButton();
            this.rbProductos = new System.Windows.Forms.RadioButton();
            this.rbProyectos = new System.Windows.Forms.RadioButton();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.cboUCreador = new System.Windows.Forms.ComboBox();
            this.lblUCreador = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rvDetalleCantidad = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DT_DetallesCantidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).BeginInit();
            this.gbNombre.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DT_DetallesCantidadBindingSource
            // 
            this.DT_DetallesCantidadBindingSource.DataMember = "DT_DetallesCantidad";
            this.DT_DetallesCantidadBindingSource.DataSource = this.DS_Reportes;
            // 
            // DS_Reportes
            // 
            this.DS_Reportes.DataSetName = "DS_Reportes";
            this.DS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbNombre
            // 
            this.gbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNombre.Controls.Add(this.btnSalir);
            this.gbNombre.Controls.Add(this.btnLimpiar);
            this.gbNombre.Controls.Add(this.btnListar);
            this.gbNombre.Controls.Add(this.rbProdYProy);
            this.gbNombre.Controls.Add(this.rbProductos);
            this.gbNombre.Controls.Add(this.rbProyectos);
            this.gbNombre.Controls.Add(this.gbOption);
            this.gbNombre.Controls.Add(this.groupBox2);
            this.gbNombre.Location = new System.Drawing.Point(13, 13);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(805, 462);
            this.gbNombre.TabIndex = 0;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Proyectos y productos";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(724, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Location = new System.Drawing.Point(724, 98);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListar.Location = new System.Drawing.Point(643, 98);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 13;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // rbProdYProy
            // 
            this.rbProdYProy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbProdYProy.AutoSize = true;
            this.rbProdYProy.Location = new System.Drawing.Point(643, 75);
            this.rbProdYProy.Name = "rbProdYProy";
            this.rbProdYProy.Size = new System.Drawing.Size(130, 17);
            this.rbProdYProy.TabIndex = 11;
            this.rbProdYProy.TabStop = true;
            this.rbProdYProy.Text = "Productos y proyectos";
            this.rbProdYProy.UseVisualStyleBackColor = true;
            // 
            // rbProductos
            // 
            this.rbProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbProductos.AutoSize = true;
            this.rbProductos.Location = new System.Drawing.Point(642, 52);
            this.rbProductos.Name = "rbProductos";
            this.rbProductos.Size = new System.Drawing.Size(73, 17);
            this.rbProductos.TabIndex = 10;
            this.rbProductos.TabStop = true;
            this.rbProductos.Text = "Productos";
            this.rbProductos.UseVisualStyleBackColor = true;
            // 
            // rbProyectos
            // 
            this.rbProyectos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbProyectos.AutoSize = true;
            this.rbProyectos.Location = new System.Drawing.Point(643, 29);
            this.rbProyectos.Name = "rbProyectos";
            this.rbProyectos.Size = new System.Drawing.Size(72, 17);
            this.rbProyectos.TabIndex = 9;
            this.rbProyectos.TabStop = true;
            this.rbProyectos.Text = "Proyectos";
            this.rbProyectos.UseVisualStyleBackColor = true;
            // 
            // gbOption
            // 
            this.gbOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbOption.Controls.Add(this.dtpFechaHasta);
            this.gbOption.Controls.Add(this.lblFechaHasta);
            this.gbOption.Controls.Add(this.cboUCreador);
            this.gbOption.Controls.Add(this.lblUCreador);
            this.gbOption.Controls.Add(this.cboCliente);
            this.gbOption.Controls.Add(this.lblCliente);
            this.gbOption.Controls.Add(this.dtpFechaDesde);
            this.gbOption.Controls.Add(this.lblFechaDesde);
            this.gbOption.Location = new System.Drawing.Point(6, 19);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(630, 102);
            this.gbOption.TabIndex = 12;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Opciones de busqueda";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(431, 47);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaHasta.TabIndex = 3;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(353, 50);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(69, 13);
            this.lblFechaHasta.TabIndex = 29;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // cboUCreador
            // 
            this.cboUCreador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUCreador.FormattingEnabled = true;
            this.cboUCreador.Location = new System.Drawing.Point(65, 47);
            this.cboUCreador.Name = "cboUCreador";
            this.cboUCreador.Size = new System.Drawing.Size(159, 21);
            this.cboUCreador.TabIndex = 1;
            // 
            // lblUCreador
            // 
            this.lblUCreador.AutoSize = true;
            this.lblUCreador.Location = new System.Drawing.Point(15, 50);
            this.lblUCreador.Name = "lblUCreador";
            this.lblUCreador.Size = new System.Drawing.Size(47, 13);
            this.lblUCreador.TabIndex = 27;
            this.lblUCreador.Text = "Creador:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(65, 19);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(159, 21);
            this.cboCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 25;
            this.lblCliente.Text = "Cliente:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(431, 19);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaDesde.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(353, 22);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(72, 13);
            this.lblFechaDesde.TabIndex = 23;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.rvDetalleCantidad);
            this.groupBox2.Location = new System.Drawing.Point(3, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 293);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // rvDetalleCantidad
            // 
            this.rvDetalleCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DT_DetallesCantidadBindingSource;
            this.rvDetalleCantidad.LocalReport.DataSources.Add(reportDataSource3);
            this.rvDetalleCantidad.LocalReport.ReportEmbeddedResource = "TP_Grupo5.GUILayer.Reportes.rptDetalleCantidad.rdlc";
            this.rvDetalleCantidad.Location = new System.Drawing.Point(3, 16);
            this.rvDetalleCantidad.Name = "rvDetalleCantidad";
            this.rvDetalleCantidad.ServerReport.BearerToken = null;
            this.rvDetalleCantidad.Size = new System.Drawing.Size(790, 274);
            this.rvDetalleCantidad.TabIndex = 0;
            // 
            // frmReporteDetalleCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.gbNombre);
            this.Name = "frmReporteDetalleCantidad";
            this.Text = "Reporte de proyectos y productos facturados";
            this.Load += new System.EventHandler(this.frmReporteDetalleCantidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DT_DetallesCantidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).EndInit();
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DT_DetallesCantidadBindingSource;
        private DS_Reportes DS_Reportes;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RadioButton rbProdYProy;
        private System.Windows.Forms.RadioButton rbProductos;
        private System.Windows.Forms.RadioButton rbProyectos;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.ComboBox cboUCreador;
        private System.Windows.Forms.Label lblUCreador;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rvDetalleCantidad;
    }
}