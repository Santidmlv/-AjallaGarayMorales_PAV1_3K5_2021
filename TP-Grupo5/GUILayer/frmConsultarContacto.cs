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
    public partial class frmConsultarContacto : Form
    {
        private ContactoServicio oContactoServicio;
        public frmConsultarContacto()
        {
            InitializeComponent();
            oContactoServicio = new ContactoServicio();
            habilitarCampos(true);
        }

        private void habilitarCampos(Boolean valor)
        {
            rbActivos.Checked = true;
            grbContactos.Enabled = true;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dgvContactos.Rows.Clear();
            btnActualizar.Enabled = !valor;
            btnEliminar.Enabled = !valor;
        }

        private void llenarGrilla(DataGridView grilla, IList<Contacto> lista)
        {
            grilla.Rows.Clear();
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {

                    dgvContactos.Rows.Add(
                        lista[i].Id_Contacto,
                        lista[i].Apellido,
                        lista[i].Nombre,
                        lista[i].Email,
                        lista[i].Telefono,
                        lista[i].Borrado
                        );
                    if (lista[i].Borrado == true)
                        dgvContactos.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron Contactos", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
            }


        }


        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;

            if (!rbTodos.Checked)
            {

                if (rbEliminados.Checked)
                {
                    filtro = filtro + " c.borrado=1";
                }
                if (rbActivos.Checked)
                {
                    filtro = filtro + " c.borrado=0";
                }

                if (txtNombre.Text != string.Empty)
                {
                    filtro = filtro + " AND c.nombre LIKE '%" + txtNombre.Text + "%'";
                }

                if (txtApellido.Text != string.Empty)
                {
                    filtro = filtro + " AND c.apellido LIKE '%" + txtApellido.Text + "%'";
                }
                llenarGrilla(dgvContactos, oContactoServicio.consultaConFiltros(filtro));
            }
            else
                llenarGrilla(dgvContactos, oContactoServicio.dameTodo());
            dgvContactos.CurrentCell = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmABMContacto ofrmABMContacto = new frmABMContacto();
                if ((bool)dgvContactos.CurrentRow.Cells["borrado"].Value)
                    ofrmABMContacto.SeleccionarContacto(frmABMContacto.FormMode.restored, (int)dgvContactos.CurrentRow.Cells[0].Value);
                else
                    ofrmABMContacto.SeleccionarContacto(frmABMContacto.FormMode.delete, (int)dgvContactos.CurrentRow.Cells[0].Value);
                ofrmABMContacto.ShowDialog();
                btnBuscar_Click(sender, e);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmABMContacto ofrmABMContacto = new frmABMContacto();
                int id = (int)dgvContactos.CurrentRow.Cells[0].Value;
                ofrmABMContacto.SeleccionarContacto(frmABMContacto.FormMode.update, id);
                ofrmABMContacto.ShowDialog();
                btnBuscar_Click(sender, e);

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
            frmABMContacto ofrmABMContacto = new frmABMContacto();
            ofrmABMContacto.ShowDialog();
            if (ofrmABMContacto.bandera)
            {
                btnBuscar_Click(sender, e);
            }

            ofrmABMContacto.bandera = true;
        }

        

        

        private void dgvContactos_SelectionChanged(object sender, EventArgs e)
        {
            if ((bool)dgvContactos.CurrentRow.Cells["borrado"].Value)
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

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            btnActualizar.Enabled = true;
            btnBuscar_Click(sender, e);
        }

        private void rbEliminados_CheckedChanged(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnBuscar_Click(sender, e);
        }
        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                grbContactos.Enabled = false;
                btnBuscar.Enabled = false;
            }

            else
            {
                grbContactos.Enabled = true;
                btnBuscar.Enabled = true;
            }
        }
    }

}
