using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Grupo5.BusinesLayer;

namespace TP_Grupo5.GUILayer.Reportes
{
    public partial class frmReporteDetalleFactura : Form
    {
        ReporteServicio oReporteServicio;
        private string consulta;
        public frmReporteDetalleFactura()
        {
            InitializeComponent();
            oReporteServicio = new ReporteServicio();
        }

        public void cargarConsluta(string consulta)
        {
            this.consulta = consulta;
        }

        private void cargarReporte()
        {
            this.rvFactura.LocalReport.DataSources.Clear();
            this.rvFactura.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", oReporteServicio.consultarFacturaDetalle(consulta)));
            this.rvFactura.RefreshReport();
        }

        private void frmReporteDetalleFactura_Load(object sender, EventArgs e)
        {
            this.rvFactura.RefreshReport();
            cargarReporte();
        }
    }
}
