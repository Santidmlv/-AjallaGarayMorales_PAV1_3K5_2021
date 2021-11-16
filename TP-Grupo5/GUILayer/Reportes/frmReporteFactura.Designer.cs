
namespace TP_Grupo5.GUILayer.Reportes
{
    partial class frmReporteFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DT_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Reportes = new TP_Grupo5.GUILayer.Reportes.DS_Reportes();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbRVFactura = new System.Windows.Forms.GroupBox();
            this.rvFacturaListado = new Microsoft.Reporting.WinForms.ReportViewer();
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
            ((System.ComponentModel.ISupportInitialize)(this.DT_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).BeginInit();
            this.gbNombre.SuspendLayout();
            this.gbRVFactura.SuspendLayout();
            this.gbFacturaFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // DT_FacturaBindingSource
            // 
            this.DT_FacturaBindingSource.DataMember = "DT_Factura";
            this.DT_FacturaBindingSource.DataSource = this.DS_Reportes;
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
            this.gbNombre.Controls.Add(this.gbRVFactura);
            this.gbNombre.Controls.Add(this.chkTodos);
            this.gbNombre.Controls.Add(this.btnListar);
            this.gbNombre.Controls.Add(this.gbFacturaFiltro);
            this.gbNombre.Location = new System.Drawing.Point(13, 13);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(819, 480);
            this.gbNombre.TabIndex = 0;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Lista de facturación";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(693, 451);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Location = new System.Drawing.Point(690, 81);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbRVFactura
            // 
            this.gbRVFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbRVFactura.Controls.Add(this.rvFacturaListado);
            this.gbRVFactura.Location = new System.Drawing.Point(58, 110);
            this.gbRVFactura.Name = "gbRVFactura";
            this.gbRVFactura.Size = new System.Drawing.Size(710, 335);
            this.gbRVFactura.TabIndex = 10;
            this.gbRVFactura.TabStop = false;
            // 
            // rvFacturaListado
            // 
            this.rvFacturaListado.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DT_FacturaBindingSource;
            this.rvFacturaListado.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFacturaListado.LocalReport.ReportEmbeddedResource = "TP_Grupo5.GUILayer.Reportes.rptFactura.rdlc";
            this.rvFacturaListado.Location = new System.Drawing.Point(3, 16);
            this.rvFacturaListado.Name = "rvFacturaListado";
            this.rvFacturaListado.ServerReport.BearerToken = null;
            this.rvFacturaListado.Size = new System.Drawing.Size(704, 316);
            this.rvFacturaListado.TabIndex = 0;
            // 
            // chkTodos
            // 
            this.chkTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(693, 29);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 7;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // btnListar
            // 
            this.btnListar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListar.Location = new System.Drawing.Point(690, 52);
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
            this.gbFacturaFiltro.Location = new System.Drawing.Point(58, 19);
            this.gbFacturaFiltro.Name = "gbFacturaFiltro";
            this.gbFacturaFiltro.Size = new System.Drawing.Size(626, 85);
            this.gbFacturaFiltro.TabIndex = 8;
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
            // frmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 505);
            this.Controls.Add(this.gbNombre);
            this.Name = "frmReporteFactura";
            this.Text = "Reporte de facturación";
            this.Load += new System.EventHandler(this.frmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DT_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).EndInit();
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbRVFactura.ResumeLayout(false);
            this.gbFacturaFiltro.ResumeLayout(false);
            this.gbFacturaFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DT_FacturaBindingSource;
        private DS_Reportes DS_Reportes;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbRVFactura;
        private Microsoft.Reporting.WinForms.ReportViewer rvFacturaListado;
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