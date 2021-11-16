using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;
using TP_Grupo5.DataAccesLayer;

namespace TP_Grupo5.GUILayer
{
    public partial class frmConsultarBarrio : Form
    {
        private BarrioServicio oBarrioServicio;
        public frmConsultarBarrio()
        {
            InitializeComponent();
            oBarrioServicio = new BarrioServicio();
        }
        private void frmConsultarBarrio_Load(object sender, EventArgs e)
        {
            rbActivos.Checked = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void llenarGrilla(DataGridView grilla, IList<Barrio> lista)
        {
            grilla.Rows.Clear();
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvBarrios.Rows.Add(
                        lista[i].Id_Barrio,
                        lista[i].Nombre,
                        lista[i].Borrado
                        );
                    if(lista[i].Borrado)
                        dgvBarrios.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron Barrios", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvBarrios.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmABMBarrio ofrmABMBarrio = new frmABMBarrio();
                ofrmABMBarrio.SeleccionarBarrio(frmABMBarrio.FormMode.update, (int)dgvBarrios.CurrentRow.Cells[0].Value);
                ofrmABMBarrio.ShowDialog();
                btnBuscar_Click(sender, e);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmABMBarrio ofrmABMBarrio = new frmABMBarrio();
            ofrmABMBarrio.ShowDialog();
            btnBuscar_Click(sender, e);
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvBarrios.Rows.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = string.Empty;

            if (rbActivos.Checked)
                filtro += "b.borrado=0";
            if (rbEliminado.Checked)
                filtro += "b.borrado=1";
            if (rbTodos.Checked)
                filtro += "( b.borrado=1 OR b.borrado=0)";
            if (txtNombreBarrio.Text != string.Empty)
                filtro = filtro + " AND b.nombre LIKE '%" + txtNombreBarrio.Text + "%'";
            llenarGrilla(dgvBarrios, oBarrioServicio.consultaConFiltros(filtro));

            dgvBarrios.CurrentCell = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvBarrios.CurrentRow == null)
                MessageBox.Show("Seleccione una fila de la grilla", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmABMBarrio ofrmABMBarrio = new frmABMBarrio();
                if (!(bool)dgvBarrios.CurrentRow.Cells["borrado"].Value)
                {
                    ofrmABMBarrio.SeleccionarBarrio(frmABMBarrio.FormMode.delete, (int)dgvBarrios.CurrentRow.Cells[0].Value);
                    if (!oBarrioServicio.BarriosVinculadosConClientes((int)dgvBarrios.CurrentRow.Cells[0].Value))
                        ofrmABMBarrio.borrar_barrio();
                    else
                        MessageBox.Show("No se puede eliminar el barrio, ya que esta asociado a un cliente activo", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    ofrmABMBarrio.SeleccionarBarrio(frmABMBarrio.FormMode.restored, (int)dgvBarrios.CurrentRow.Cells[0].Value);
                    ofrmABMBarrio.restaurar_barrio();
                    btnBuscar_Click(sender, e);
                }
                
            }
        }

        private void dgvBarrios_SelectionChanged(object sender, EventArgs e)
        {
            if ((bool)dgvBarrios.CurrentRow.Cells["borrado"].Value)
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
