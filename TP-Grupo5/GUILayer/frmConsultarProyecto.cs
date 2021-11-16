using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;
using TP_Grupo5.GUILayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Grupo5.GUILayer
{
    public partial class frmConsultarProyecto : Form
    {
        private ProductoServicio oProductoServicio;
        private UsuarioServicio oUsuarioServicio;
        private ProyectoServicio oProyectoServicio;
        
        
        public frmConsultarProyecto()
        {
            InitializeComponent();
            oProductoServicio = new ProductoServicio();
            oUsuarioServicio = new UsuarioServicio();
            oProyectoServicio = new ProyectoServicio();
        }
        private void frmConsultarProyecto_Load(object sender, EventArgs e)
        {
            enableComponents(true);
            rbActivos.Checked = true;
            LlenarCombo(cboProducto, oProductoServicio.ObtenerTodos(), "Nombre", "Id_producto");
            LlenarCombo(cboResponsable, oUsuarioServicio.ObtenerTodos(), "Nombre", "Id_usuario");
        }


        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = string.Empty;
            if (!rbTodos.Checked)
            {
                if (rbActivos.Checked)
                    condiciones += " AND py.borrado=0";

                if (rbEliminado.Checked)
                    condiciones += " AND py.borrado=1";

                if (txtDescripcion.Text != string.Empty)
                    condiciones += " AND py.descripcion LIKE '%" + txtDescripcion.Text + "%' ";

                if (cboProducto.Text != string.Empty)
                    condiciones += " AND pd.id_producto=" + cboProducto.SelectedValue.ToString();

                if (cboResponsable.Text != string.Empty)
                    condiciones += " AND u.id_usuario=" + cboResponsable.SelectedValue.ToString();

                if (condiciones != string.Empty)
                    loadGrid(grdProyecto, oProyectoServicio.ConsultarConFiltrosSinParametros(condiciones));
            }
            else
                loadGrid(grdProyecto, oProyectoServicio.ObtenerTodos());
            grdProyecto.CurrentCell = null;
        }

        private void loadGrid(DataGridView grilla, IList<Proyecto> lista)
        {
            grilla.Rows.Clear();

            if (lista.Count > 0)
                enableComponents(false);
            else
                enableComponents(true);

            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].Id_proyecto,
                    lista[i].Descripcion,
                    lista[i].Version,
                    lista[i].Alcance,
                    lista[i].Responsable.Nombre,
                    lista[i].Producto.Nombre,
                    lista[i].Borrado
                    );
                if (lista[i].Borrado == 1)
                    grdProyecto.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
            }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMProyecto formulario = new frmABMProyecto();
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);//Recargar nuevamente la grilla
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int valor = (int)grdProyecto.CurrentRow.Cells[0].Value;
            frmABMProyecto formulario = new frmABMProyecto();
            formulario.SeleccionarProyecto(frmABMProyecto.FormMode.update, valor);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);//Recargar nuevamente la grilla
            for (int i = 0; i < grdProyecto.Rows.Count; i++)
            {
                if ((int)grdProyecto.Rows[i].Cells[0].Value == valor)
                {
                    grdProyecto.Rows[i].Selected = true;
                    break;
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)grdProyecto.CurrentRow.Cells[0].Value;

            frmABMProyecto formulario = new frmABMProyecto();
            if ((int)grdProyecto.CurrentRow.Cells["borrado"].Value == 0)
                formulario.SeleccionarProyecto(frmABMProyecto.FormMode.delete, id);
            else
                formulario.SeleccionarProyecto(frmABMProyecto.FormMode.restore, id);

            formulario.ShowDialog();
            btnConsultar_Click(sender, e);//Recargar nuevamente la grilla
        }

        /*enableComponents(bool x) habilita ciertos componestes del formulario
         */
        private void enableComponents(bool x)
        {
            grdProyecto.Enabled = !x;
            btnEditar.Enabled = !x;
            btnEliminar.Enabled = !x;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                cboProducto.Enabled = false;
                cboResponsable.Enabled = false;
                txtDescripcion.Enabled = false;
            }
            else
            {
                cboProducto.Enabled = true;
                cboResponsable.Enabled = true;
                txtDescripcion.Enabled = true;
            }
        }

        private void grdProyecto_SelectionChanged(object sender, EventArgs e)
        {
            if (grdProyecto.CurrentCell != null)
            {
                if ((int)grdProyecto.CurrentRow.Cells["borrado"].Value == 1)
                {
                    btnEliminar.Text = "Recuperar";
                    btnEditar.Enabled = false;
                }
                else
                {
                    btnEliminar.Text = "Eliminar";
                    btnEditar.Enabled = true;
                }
            }
        }

        
    }
}
