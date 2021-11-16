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
using TP_Grupo5.Entities;
using TP_Grupo5.GUILayer.Reportes;

namespace TP_Grupo5.GUILayer
{
    public partial class frmConsultarFacturas : Form
    {
        ClienteServicio oClienteServicio;
        UsuarioServicio oUsuarioServicio;
        FacturaServicio oFacturaServicio;
        public frmConsultarFacturas()
        {
            InitializeComponent();
            oClienteServicio = new ClienteServicio();
            oUsuarioServicio = new UsuarioServicio();
            oFacturaServicio= new FacturaServicio();
        }
        private void frmConsultarFacturas_Load(object sender, EventArgs e)
        {
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
                    filtro += " AND c.id_cliente=" + (int)cboCliente.SelectedValue;

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
            llenarGrilla(oFacturaServicio.consulultaConFiltros(filtro));

        }

        private void llenarGrilla(IList<Factura> lista)
        {
            grdListadoFacturas.Rows.Clear();
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    grdListadoFacturas.Rows.Add(
                        lista[i].ID_factura,
                        lista[i].NroFactura,
                        lista[i].Fecha,
                        lista[i].Cliente.Razon_social,
                        lista[i].Creador.Nombre,
                        "Ver"
                        );
                }
            }
            else
            {
                MessageBox.Show("No se encontraron facturas", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
            cboCliente.SelectedIndex = -1;
            cboUCreador.SelectedIndex = -1;
            grdListadoFacturas.Rows.Clear();
        }

        

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grdListadoFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdListadoFacturas.Columns["verFactura"].Index)
            {
                frmReporteDetalleFactura reporte = new frmReporteDetalleFactura();
                reporte.cargarConsluta(grdListadoFacturas.CurrentRow.Cells["idFactura"].Value.ToString());
                reporte.Show();
            }
        }
        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
                gbFacturaFiltro.Enabled = false;

            else
                gbFacturaFiltro.Enabled = true;
        }
        
    }
}
