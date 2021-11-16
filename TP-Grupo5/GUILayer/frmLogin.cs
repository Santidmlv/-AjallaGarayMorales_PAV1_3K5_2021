using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.DataAccesLayer;

namespace TP_Grupo5.GUILayer
{
    public partial class frmLogin : Form
    {
        private bool usuarioValido = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                this.Close();
            }
            else
            {
                txtContraseña.Text = "";
                txtContraseña.Focus();
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ValidarUsuario(string pUsuario, string pPassword)
            {
                
                try
                {
                    String consultaSql = string.Concat(" SELECT * ",
                                                       "   FROM Usuarios ",
                                                       "  WHERE usuario =  '", pUsuario, "'");

                    DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(consultaSql);

                    if (resultado.Rows.Count >= 1)
                    {
                        if (resultado.Rows[0]["password"].ToString() == pPassword)
                        {
                            usuarioValido = true;
                            this.Text = pUsuario;
                        }
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return usuarioValido;
            }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!usuarioValido)
                Environment.Exit(0);
        }
    }
 }
