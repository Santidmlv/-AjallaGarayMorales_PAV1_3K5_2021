
namespace TP_Grupo5.GUILayer.Reportes
{
    partial class frmReporteDetalleFactura
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
            this.DT_DetallFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Reportes = new TP_Grupo5.GUILayer.Reportes.DS_Reportes();
            this.rvFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DT_DetallFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // DT_DetallFacturaBindingSource
            // 
            this.DT_DetallFacturaBindingSource.DataMember = "DT_DetallFactura";
            this.DT_DetallFacturaBindingSource.DataSource = this.DS_Reportes;
            // 
            // DS_Reportes
            // 
            this.DS_Reportes.DataSetName = "DS_Reportes";
            this.DS_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvFactura
            // 
            this.rvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DT_DetallFacturaBindingSource;
            this.rvFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFactura.LocalReport.ReportEmbeddedResource = "TP_Grupo5.GUILayer.Reportes.rptDetalleFactura.rdlc";
            this.rvFactura.Location = new System.Drawing.Point(0, 0);
            this.rvFactura.Name = "rvFactura";
            this.rvFactura.ServerReport.BearerToken = null;
            this.rvFactura.Size = new System.Drawing.Size(669, 450);
            this.rvFactura.TabIndex = 0;
            // 
            // frmReporteDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.rvFactura);
            this.Name = "frmReporteDetalleFactura";
            this.Text = "Detalle de factura";
            this.Load += new System.EventHandler(this.frmReporteDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DT_DetallFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFactura;
        private System.Windows.Forms.BindingSource DT_DetallFacturaBindingSource;
        private DS_Reportes DS_Reportes;
    }
}