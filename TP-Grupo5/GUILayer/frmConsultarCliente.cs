using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;
using TP_Grupo5.GUILayer;

namespace TP_Grupo5
{
    public partial class frmConsultaCliente : Form
    {
        private BarrioServicio oBarrioServicio;
        private ClienteServicio oClienteServicio;
        public frmConsultaCliente()
        {
            InitializeComponent();
            oBarrioServicio = new BarrioServicio();
            oClienteServicio = new ClienteServicio();
            LlenarCombo(cboBarrio,oBarrioServicio.consultaConFiltros("b.borrado=0"),"Nombre","Id_barrio");
            habilitarCampos(true);
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;

            if (!rbTodos.Checked)
            {
                if (rbEliminado.Checked)
                {
                    filtro = filtro + " c.borrado=1";
                }
                if (rbActivos.Checked)
                {
                    filtro = filtro + " c.borrado=0";
                }
                if (txtRazonSocial.Text != string.Empty)
                {
                    filtro = filtro + " AND c.razon_social LIKE '%" + txtRazonSocial.Text + "%'";
                }
                if (cboBarrio.SelectedIndex != -1)
                {
                    filtro = filtro + " AND c.id_barrio=" + cboBarrio.SelectedValue;
                }
                if (txtCuit.Text != string.Empty)
                {
                    filtro = filtro + " AND c.cuit=" + Convert.ToInt32(txtCuit.Text);
                }
                if (dtpFechaDesde.Value > dtpFechaHasta.Value)
                {
                    MessageBox.Show("La fecha desde es mayor a la fecha hasta", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFechaHasta.Focus();
                    return;
                }
                else
                {
                    DateTime fechaHasta = dtpFechaHasta.Value.AddDays(1);
                    filtro += " AND c.fecha_alta  BETWEEN Convert(DateTime, " + "'" + dtpFechaDesde.Value.ToShortDateString() + "'" + ", 103)" +
                                  " AND Convert(DateTime, " + "'" + fechaHasta.ToShortDateString() + "'" + ", 103)";
                    llenarGrilla(grdClientes, oClienteServicio.consultaConFiltros(filtro));
                }

            }
            else
                llenarGrilla(grdClientes, oClienteServicio.consultaConFiltros(" (c.borrado=1 or c.borrado=0) "));

            grdClientes.CurrentCell = null;
        }

        private void habilitarCampos(Boolean valor)
        {
            rbActivos.Checked = true;
            rbActivos.Checked = valor;
            txtRazonSocial.Text = string.Empty;
            txtCuit.Text = string.Empty;
            dtpFechaDesde.Value = DateTime.Today.AddYears(-1);
            dtpFechaHasta.Value = DateTime.Today;
            cboBarrio.SelectedIndex = -1;
            grdClientes.Rows.Clear();
            btnActualizar.Enabled = !valor;
            btnEliminar.Enabled = !valor;
        }

        private void llenarGrilla(DataGridView grilla, IList<Cliente> lista)
        {
            grilla.Rows.Clear();
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    grdClientes.Rows.Add(
                        lista[i].Id_cliente,
                        lista[i].Razon_social,
                        lista[i].Cuit,
                        lista[i].Barrio.Nombre,
                        lista[i].Calle,
                        lista[i].Numero,
                        lista[i].Fecha_alta,
                        lista[i].Contacto,
                        lista[i].Borrado
                        );

                    if (lista[i].Borrado)
                        grdClientes.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron Clientes", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMCliente ofrmABMCliente = new frmABMCliente();
            ofrmABMCliente.ShowDialog();
            btnBuscar_Click(sender, e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (grdClientes.CurrentRow == null)
            {

                MessageBox.Show("Seleccione una fila de la grilla", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmABMCliente ofrmABMCliente = new frmABMCliente();
                int id = (int)grdClientes.CurrentRow.Cells[0].Value;
                ofrmABMCliente.SeleccionarCliente(frmABMCliente.FormMode.update, id);
                ofrmABMCliente.ShowDialog();
                btnBuscar_Click(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdClientes.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmABMCliente ofrmABMCliente = new frmABMCliente();
                if ((bool)grdClientes.CurrentRow.Cells["borrado"].Value)
                    ofrmABMCliente.SeleccionarCliente(frmABMCliente.FormMode.restored, (int)grdClientes.CurrentRow.Cells[0].Value);
                else
                    ofrmABMCliente.SeleccionarCliente(frmABMCliente.FormMode.delete, (int)grdClientes.CurrentRow.Cells[0].Value);
                ofrmABMCliente.ShowDialog();
                btnBuscar_Click(sender, e);
            }
        }

        

        

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
                gbBuscarCliente.Enabled = false;
            else
                gbBuscarCliente.Enabled = true;
        }

        private void grdClientes_SelectionChanged(object sender, EventArgs e)
        {
            if ((bool)grdClientes.CurrentRow.Cells["borrado"].Value)
            {
                btnEliminar.Text = "Recuperar";
                btnActualizar.Enabled = false;
            }

            else
            {
                btnEliminar.Text = "Eliminar";
                btnActualizar.Enabled = true;
            }

        }
    }
}
