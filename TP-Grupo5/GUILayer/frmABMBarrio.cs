using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.BusinesLayer;
using TP_Grupo5.Entities;
using TP_Grupo5.GUILayer;

namespace TP_Grupo5.GUILayer
{
    public partial class frmABMBarrio : Form
    {
        private BarrioServicio oBarrioServicio;
        private FormMode formMode = FormMode.insert;
        private int id_barrio;
        public frmABMBarrio()
        {
            InitializeComponent();
            oBarrioServicio = new BarrioServicio();
        }

        public enum FormMode
        {
            insert,
            update,
            delete,
            restored
        }

        public void SeleccionarBarrio(FormMode op, int id)
        {
            formMode = op;
            id_barrio = id;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (validarCampos())
                        {
                            Barrio oBarrio = new Barrio
                            {
                                Nombre = txtNombreBarrio.Text,
                            };
                            bool valor = oBarrioServicio.InsertarBarrio(oBarrio);
                            if (valor)
                            {
                                MessageBox.Show("Creado","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    };
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            Barrio oBarrio = new Barrio
                            {
                                Nombre = txtNombreBarrio.Text,
                                Id_Barrio = id_barrio
                            };
                            bool valor = oBarrioServicio.ActualizarBarrio(oBarrio);
                            if (valor)
                            {
                                MessageBox.Show("Actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    };
            }
        }
        private void LlenarCampos()
        {
            Barrio oBarrio = oBarrioServicio.consultaConFiltros(" AND b.id_barrio="+id_barrio)[0];
            txtIDBarrio.Text = oBarrio.Id_Barrio.ToString();
            txtNombreBarrio.Text = oBarrio.Nombre;
        }
        private bool validarCampos()
        {
            if (txtNombreBarrio.Text == string.Empty)
            {
                txtNombreBarrio.BackColor = Color.LightPink;
                txtNombreBarrio.Focus();
                return false;
            }
            if (existeBarrio(txtNombreBarrio.Text))
            {
                MessageBox.Show("Ese nombre ya existe", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool existeBarrio(string nombre)
        {
            IList<Barrio> lista = oBarrioServicio.consultaConFiltros(" b.nombre = '" + nombre+"'");
            if (lista.Count > 0)
                return true;
            return false;
        }
        

        public void borrar_barrio()
        {
            Barrio oBarrio = new Barrio
            {
                Id_Barrio = id_barrio
            };
            var info = MessageBox.Show("¿Esta seguro que desea eliminar este barrio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (info == DialogResult.Yes)
            {
                bool valor = oBarrioServicio.EliminarBarrio(oBarrio);
                if (valor)
                {
                    MessageBox.Show("Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void restaurar_barrio()
        {
            Barrio oBarrio = new Barrio
            {
                Id_Barrio = id_barrio
            };
            if (oBarrioServicio.RestaurarBarrio(oBarrio))
            {
                MessageBox.Show("Restaurado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frmABMBarrio_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Barrio";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Barrio";
                        LlenarCampos();
                        break;
                    };
                case FormMode.delete:
                    {
                        this.Text = "Eliminar Barrio";
                        LlenarCampos();
                        break;
                    }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

