using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;


namespace TP_Grupo5.GUILayer
{
    public partial class frmTransaccionFactura : Form
    {
        private ClienteServicio oClienteServicio;
        private UsuarioServicio oUsuarioServicio;
        private ProductoServicio oProductoServicio;
        private ProyectoServicio oProyectoServicio;
        private FacturaServicio oFacturaServicio;
        public frmTransaccionFactura()
        {
            InitializeComponent();
            oClienteServicio = new ClienteServicio();
            oUsuarioServicio = new UsuarioServicio();
            oProductoServicio = new ProductoServicio();
            oProyectoServicio = new ProyectoServicio();
            oFacturaServicio = new FacturaServicio();
            LlenarCombo(cboCliente, oClienteServicio.dameTodo(), "Razon_social", "Id_cliente");
            LlenarCombo(cboUCreador, oUsuarioServicio.ObtenerTodos(), "Nombre", "Id_Usuario");
            LlenarCombo(cboProyecto, oProyectoServicio.ConsultarConFiltrosSinParametros(" AND py.borrado=0"), "Descripcion", "Id_proyecto");
            LlenarCombo(cboProducto, oProductoServicio.ObtenerTodos(), "Nombre", "Id_Producto");

        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCamposDetalle())
            {
                Object objeto;
                if (cboProyecto.SelectedIndex != -1)
                    objeto = cboProyecto.SelectedItem;
                else
                    objeto = cboProducto.SelectedItem;
                grbFacturaDetalle.Rows.Add(new object[] { objeto, txtPrecio.Text });
                limpiarCamposDetalle();
                SumarDetalles();
            }
        }

        private void SumarDetalles()
        {
            int total = 0;
            if (grbFacturaDetalle.Rows.Count > 0)
            {
                for (int i = 0; i < grbFacturaDetalle.Rows.Count; i++)
                {
                    total = total + Convert.ToInt32(grbFacturaDetalle.Rows[i].Cells["precio"].Value.ToString());
                }
                txtTotal.Text = total.ToString();
            }
            else
                txtTotal.Text = total.ToString();

        }

        private bool validarCamposDetalle()
        {
            if (cboProyecto.SelectedIndex == -1)
            {

                if (cboProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Sleccecione un Producto o un Proyecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboProyecto.Focus();
                    return false;
                }
            }

            if (cboProyecto.SelectedIndex != -1)
            {
                if (ExisteEnGrilla(cboProyecto.SelectedItem))
                {
                    MessageBox.Show("El proyecto ya se encuentra en la lista del detalle", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }
            if (cboProducto.SelectedIndex != -1)
            {
                if (ExisteEnGrilla(cboProducto.SelectedItem))
                {
                    MessageBox.Show("El producto ya se encuentra en la lista del detalle", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese monto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrecio.BackColor = Color.LightPink;
                txtPrecio.Focus();
                return false;
            }
            return true;

        }

        private bool ExisteEnGrilla(Object objeto)
        {
            for (int i = 0; i < grbFacturaDetalle.RowCount; i++)
            {
                if (grbFacturaDetalle.Rows[i].Cells["Descripcion"].Value.Equals(objeto))
                {
                    return true;
                }
            }
            return false;
        }

        private void limpiarCamposDetalle()
        {
            cboProyecto.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            txtPrecio.Text = string.Empty;
            txtPrecio.BackColor = Color.White;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grbFacturaDetalle.SelectedRows)
            {
                grbFacturaDetalle.Rows.Remove(row);
            }
            SumarDetalles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCamposFactura())
            {
                Factura oFactura = new Factura
                {
                    Cliente = (Cliente)cboCliente.SelectedItem,
                    Creador = (Usuario)cboUCreador.SelectedItem
                };
                oFactura.Detalle = new List<FacturaDetalle>();
                for (int i = 0; i < grbFacturaDetalle.Rows.Count; i++)
                {
                    FacturaDetalle nuevoDetalle = new FacturaDetalle();
                    if (grbFacturaDetalle.Rows[i].Cells["Descripcion"].Value is Proyecto)
                    {
                        nuevoDetalle.Proyecto = (Proyecto)grbFacturaDetalle.Rows[i].Cells["Descripcion"].Value;
                    }
                    else
                        nuevoDetalle.Producto = (Producto)grbFacturaDetalle.Rows[i].Cells["Descripcion"].Value;
                    nuevoDetalle.precio = Convert.ToDouble(grbFacturaDetalle.Rows[i].Cells["precio"].Value);
                    oFactura.Detalle.Add(nuevoDetalle);
                }
                if (oFacturaServicio.InsertarFactura(oFactura))
                {
                    MessageBox.Show("Guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                    MessageBox.Show("Error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void limpiarCampos()
        {
            cboCliente.SelectedIndex = -1;
            cboUCreador.SelectedIndex = -1;
            grbFacturaDetalle.Rows.Clear();
            txtTotal.Text = string.Empty;
        }
        private bool validarCamposFactura()
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCliente.Focus();
                return false;
            }
            if (cboUCreador.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario creador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCliente.Focus();
                return false;
            }

            if (grbFacturaDetalle.RowCount == 0)
            {
                MessageBox.Show("Ingrese algún valor al detalle de la fatcura", "Inforamción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCliente.Focus();
                return false;
            }
            return true;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmABMCliente fm = new frmABMCliente();
            fm.ShowDialog();
            LlenarCombo(cboCliente, oClienteServicio.dameTodo(), "Razon_social", "Id_cliente");
        }
        private void grbFacturaDetalle_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(grbFacturaDetalle.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboProyecto.SelectedIndex = -1;
        }


        private void cboProyecto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboProducto.SelectedIndex = -1;
        }
    }
}
