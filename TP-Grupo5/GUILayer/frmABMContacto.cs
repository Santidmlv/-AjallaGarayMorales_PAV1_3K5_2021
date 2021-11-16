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
    public partial class frmABMContacto : Form
    {
        private ContactoServicio oContactoServicio;
        private int idContacto;
        private FormMode formMode = FormMode.insert;
        public bool bandera { get; set; }
        public frmABMContacto()
        {
            InitializeComponent();
            oContactoServicio = new ContactoServicio();
        }

        public enum FormMode
        {
            insert,
            update,
            delete,
            restored
        }

        public void SeleccionarContacto(FormMode op, int id)
        {
            formMode = op;
            idContacto = id;
        }

        private void frmABMContacto_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Contacto";
                        break;
                    };
                case FormMode.update:
                    {
                        this.Text = "Actualizar Contacto";
                        LlenarCampos();
                        break;
                    };
                case FormMode.delete:
                    {
                        this.Text = "Eliminar Contacto";
                        LlenarCampos();
                        grbContacto.Enabled = false;
                        break;
                    };
                case FormMode.restored:
                    {
                        this.Text = "Recuperar Contacto";
                        LlenarCampos();
                        grbContacto.Enabled = false;
                        break;
                    };
            }
        }

        private void LlenarCampos()
        {
            Contacto oContacto = oContactoServicio.ContactoPorId(idContacto.ToString());
            txtID.Text = oContacto.Id_Contacto.ToString();
            txtNombre.Text = oContacto.Nombre;
            txtApellido.Text = oContacto.Apellido;
            txtEmail.Text = oContacto.Email;
            txtTelefono.Text = oContacto.Telefono.ToString();
        }



        private bool validarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.LightPink;
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == string.Empty)
            {
                txtApellido.BackColor = Color.LightPink;
                txtApellido.Focus();
                return false;
            }
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.BackColor = Color.LightPink;
                txtEmail.Focus();
                return false;
            }
            if (BuscarEmailDistintos(txtEmail.Text, txtID.Text))
            {
                MessageBox.Show("El Email ya existe", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtTelefono.Text == string.Empty)
            {
                txtTelefono.BackColor = Color.LightPink;
                txtTelefono.Focus();
                return false;
            }
            return true;
        }


        private bool BuscarEmailDistintos(string email, string id)
        {
            if (id != string.Empty)
            {
                id = " AND c.id_contacto !=" + id;
            }
            IList<Contacto> lista = oContactoServicio.consultaConFiltros(" c.email='" + email + "'" + id);
            if (lista.Count > 0)
                return true;
            return false;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            bandera = true;
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (validarCampos())
                        {
                            Contacto oContacto = new Contacto
                            {
                                Nombre = txtNombre.Text,
                                Apellido = txtApellido.Text,
                                Email = txtEmail.Text,
                                Telefono = txtTelefono.Text
                            };

                            bool valor = oContactoServicio.InsertarContacto(oContacto);
                            if (valor)
                            {
                                MessageBox.Show("Creado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    };
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            Contacto oContacto = new Contacto
                            {
                                Id_Contacto = Convert.ToInt32(txtID.Text),
                                Nombre = txtNombre.Text,
                                Apellido = txtApellido.Text,
                                Email = txtEmail.Text,
                                Telefono = txtTelefono.Text
                            };

                            bool valor = oContactoServicio.ActualizarContacto(oContacto);
                            if (valor)
                            {
                                MessageBox.Show("Actualizado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    };
                case FormMode.delete:
                    {
                        Contacto oContacto = new Contacto
                        {
                            Id_Contacto = idContacto
                        };
                        var info = MessageBox.Show("¿Esta seguro que desea eliminar este contacto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (info == DialogResult.Yes)
                        {
                            if (oContactoServicio.ContactosVinculadosConClientes(idContacto))
                                MessageBox.Show("No se puede eliminar el contacto, ya que está asociado a un cliente activo", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                bool valor = oContactoServicio.EliminarContacto(oContacto);
                                if (valor)
                                {
                                    MessageBox.Show("Eliminado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Dispose();
                                }
                                else
                                {
                                    MessageBox.Show("Error", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        break;
                    }
                case FormMode.restored:
                    {
                        Contacto oContacto = new Contacto
                        {
                            Id_Contacto = idContacto
                        };
                        bool valor = oContactoServicio.RecuperarContacto(oContacto);
                        if (valor)
                        {
                            MessageBox.Show("Recuperado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            bandera = false;
        }

    }
}

