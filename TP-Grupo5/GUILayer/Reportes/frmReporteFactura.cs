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
    public partial class frmReporteFactura : Form
    {
        ReporteServicio oReporteServicio;
        ClienteServicio oClienteServicio;
        UsuarioServicio oUsuarioServicio;
        public frmReporteFactura()
        {
            InitializeComponent();
            oReporteServicio = new ReporteServicio();
            oClienteServicio = new ClienteServicio();
            oUsuarioServicio = new UsuarioServicio();
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            this.rvFacturaListado.Clear();
            //this.rvFacturaListado.RefreshReport();
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
            LlenarCombo(cboCliente, oClienteServicio.dameTodo(), "Razon_social", "Id_cliente");
            LlenarCombo(cboUCreador, oUsuarioServicio.ObtenerTodos(), "Nombre", "Id_Usuario");
            
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        

        private void btnListar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;

            if (!chkTodos.Checked)
            {
                if (cboCliente.SelectedIndex != -1)
                    filtro +=" AND c.id_cliente=" + (int)cboCliente.SelectedValue;

                if (cboUCreador.SelectedIndex != -1)
                    filtro += " AND u.id_usuario=" + (int)cboUCreador.SelectedValue;

                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("La fecha desde es mayor a la fecha hasta", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFechaDesde.Focus();
                    return;
                }
                else
                {
                    filtro += " AND f.fecha  BETWEEN Convert(DateTime, " + "'" + dtpFechaDesde.Value.ToShortDateString() + "'" + ", 103)" +
                                  " AND Convert(DateTime, " + "'" + dtpFechaHasta.Value.ToShortDateString() + "'" + ", 103)";
                }
            }
            this.rvFacturaListado.LocalReport.DataSources.Clear();
            this.rvFacturaListado.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", oReporteServicio.consultarFacturaReporte(filtro)));
            this.rvFacturaListado.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.rvFacturaListado.Clear();
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
            rvFacturaListado.LocalReport.DataSources.Clear();
            cboCliente.SelectedIndex = -1;
            cboUCreador.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                gbFacturaFiltro.Enabled = false;
            }
            else
            {
                gbFacturaFiltro.Enabled = true;
            }
        }
    }
}
