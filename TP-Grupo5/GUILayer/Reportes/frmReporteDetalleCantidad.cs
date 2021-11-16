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
    public partial class frmReporteDetalleCantidad : Form
    {
        private ReporteServicio oReporteServicio;
        private ClienteServicio oClienteServicio;
        private UsuarioServicio oUsuarioServicio;
        public frmReporteDetalleCantidad()
        {
            InitializeComponent();
            oReporteServicio = new ReporteServicio();
            oClienteServicio = new ClienteServicio();
            oUsuarioServicio = new UsuarioServicio();
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private void frmReporteDetalleCantidad_Load(object sender, EventArgs e)
        {
            this.rvDetalleCantidad.Clear();
            //this.rvDetalleCantidad.RefreshReport();
            rbProdYProy.Checked=true;
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
            LlenarCombo(cboCliente, oClienteServicio.dameTodo(), "Razon_social", "Id_cliente");
            LlenarCombo(cboUCreador, oUsuarioServicio.ObtenerTodos(), "Nombre", "Id_Usuario");

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;
            if (!rbProdYProy.Checked)
            {
                if (rbProductos.Checked)
                    filtro = filtro + " AND fd.id_proyecto IS NULL ";
                if (rbProyectos.Checked)
                    filtro = filtro + " AND fd.id_producto IS NULL ";
            }
            if (cboCliente.SelectedIndex != -1)
                filtro = filtro + " AND f.id_cliente=" + cboCliente.SelectedValue;
            if (cboUCreador.SelectedIndex != -1)
                filtro = filtro + " AND f.id_usuario_creador=" + cboUCreador.SelectedValue;
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

            this.rvDetalleCantidad.LocalReport.DataSources.Clear();
            this.rvDetalleCantidad.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", oReporteServicio.consultarDetalleCantidad(filtro)));
            this.rvDetalleCantidad.RefreshReport();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.rvDetalleCantidad.LocalReport.DataSources.Clear();
            this.rvDetalleCantidad.Clear();
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
            cboCliente.SelectedIndex = -1;
            cboUCreador.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
