using TP_Grupo5.Entities;
using TP_Grupo5.BusinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TP_Grupo5.GUILayer
{
    public partial class frmABMProyecto : Form
    {
        private Proyecto oProyecto;
        private ProyectoServicio oProyectoServicio;
        private ProductoServicio oProductoServicio;
        private UsuarioServicio oUsuarioServicio;
        private int idProyecto;
        private FormMode op = FormMode.insert;
        public enum FormMode
        {
            insert,
            update,
            delete,
            restore
        }

        public frmABMProyecto()
        {
            InitializeComponent();
            this.oProyecto = new Proyecto();
            this.oProyectoServicio = new ProyectoServicio();
            this.oProductoServicio = new ProductoServicio();
            this.oUsuarioServicio = new UsuarioServicio();
        }

        public void SeleccionarProyecto(FormMode opcion, int id)
        {
            this.op = opcion;
            this.idProyecto = id;
        }
        private void frmProyectoABM_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            LlenarCombo(cboProducto, oProductoServicio.ObtenerTodos(), "Nombre", "Id_producto");
            LlenarCombo(cboResponsable, oUsuarioServicio.ObtenerTodos(), "Nombre", "Id_usuario");
            switch (op)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Proyecto";
                    }
                    break;
                case FormMode.update:
                    {
                        this.Text = "Editar Proyecto";
                        llenarCampos();
                        habilitarCampos(true);
                    }
                    break;
                case FormMode.delete:
                    {
                        this.Text = "Eliminar Proyecto";
                        llenarCampos();
                        habilitarCampos(false);
                    }
                    break;
                case FormMode.restore:
                    {
                        this.Text = "Recuperar Proyecto";
                        llenarCampos();
                        habilitarCampos(false);
                    }
                    break;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        public void llenarCampos()
        {
            this.oProyecto =  oProyectoServicio.ObtenerProyectoPorID(this.idProyecto.ToString());

            txtID.Text = oProyecto.Id_proyecto.ToString();
            cboProducto.SelectedValue = oProyecto.Producto.Id_Producto;
            cboResponsable.SelectedValue = oProyecto.Responsable.Id_Usuario;
            txtDescripcion.Text = oProyecto.Descripcion;
            txtVersion.Text = oProyecto.Version;
            txtAlcance.Text = oProyecto.Alcance;
            
        }

        private void habilitarCampos(bool x)
        {
            cboProducto.Enabled = x;
            cboResponsable.Enabled = x;
            txtDescripcion.Enabled = x;
            txtVersion.Enabled = x;
            txtAlcance.Enabled = x;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case FormMode.insert:
                    {
                        if (validarCampos())
                        {
                            oProyecto = new Proyecto();
                            oProyecto.Producto = new Producto();
                            oProyecto.Producto.Id_Producto = (int)cboProducto.SelectedValue;
                            oProyecto.Responsable= new Usuario();
                            oProyecto.Responsable.Id_Usuario = (int)cboResponsable.SelectedValue;
                            oProyecto.Descripcion = txtDescripcion.Text;
                            oProyecto.Version = txtVersion.Text;
                            oProyecto.Alcance = txtAlcance.Text;
                            
                            if (oProyectoServicio.CrearProyecto(oProyecto))
                            {

                                MessageBox.Show("Proyecto creado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Falló la creación del proyecto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        break;
                    }
                case FormMode.update:
                    {
                        if (validarCampos())
                        {
                            oProyecto.Producto = new Producto();
                            oProyecto.Producto.Id_Producto = (int)cboProducto.SelectedValue;
                            oProyecto.Responsable = new Usuario();
                            oProyecto.Responsable.Id_Usuario = (int)cboResponsable.SelectedValue;
                            oProyecto.Descripcion = txtDescripcion.Text;
                            oProyecto.Version = txtVersion.Text;
                            oProyecto.Alcance = txtAlcance.Text;

                            if (oProyectoServicio.ActualizarProyecto(oProyecto))
                            {
                                MessageBox.Show("Proyecto actualizado","Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Falló la actualización del proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case FormMode.delete: 
                    {
                        var resp = MessageBox.Show("¿Está seguro que desea eliminar este proyecto?","Advertencia",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                        if (resp == DialogResult.OK)
                        {
                            if (oProyectoServicio.EliminarProyecto(oProyecto))
                            {
                                MessageBox.Show("Proyecto eliminado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Falló la eliminación del proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    break;
                case FormMode.restore:
                    {
                        if (oProyectoServicio.RestaurarProyecto(oProyecto))
                        {
                            MessageBox.Show("Proyecto recuperado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Falló la eliminación del proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                    
            }

            
        }
        private bool validarCampos()
        {
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un Producto","Notificación",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cboProducto.Focus();
                return false;
            }

            if (cboResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un Responsable", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboResponsable.Focus();
                return false;
            }

            if (txtDescripcion.Text == string.Empty)
            {
                txtDescripcion.BackColor = Color.LightPink;
                txtDescripcion.Focus();
                return false;
            }
            else
                txtDescripcion.BackColor = Color.White;

            if (txtVersion.Text == string.Empty)
            {
                txtVersion.BackColor = Color.LightPink;
                txtVersion.Focus();
                return false;
            }
            else
                txtVersion.BackColor = Color.White;

            return true;
        }



    }
}
