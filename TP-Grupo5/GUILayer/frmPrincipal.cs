using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_Grupo5.GUILayer;
using TP_Grupo5.GUILayer.Reportes;

namespace TP_Grupo5.GUILayer
{
    public partial class frmPrincipal : Form
    {
        private Form frmActivo = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin ofrmLogin = new frmLogin();
            ofrmLogin.ShowDialog();

            

            this.Text = "Nombre de usuario: " + ofrmLogin.Text;

            customizeDesing();
        }

        private void customizeDesing()
        {
            panelArchivo.Visible = false;
            panelReporte.Visible = false;
            panelSoporte.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelArchivo.Visible == true)
                panelArchivo.Visible = false;
            if (panelSoporte.Visible == true)
                panelSoporte.Visible = false;
            if (panelReporte.Visible == true)
                panelReporte.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void abrirFormularioHijo(Form frmHijo)
        {
            if (frmActivo != null)
                frmActivo.Dispose();
            frmActivo = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmHijo);
            panelContenedor.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelArchivo);
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSoporte);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReporte);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmTransaccionFactura());
            panelContenedor.Focus();

            foreach (Control buttonX in panelSoporte.Controls)
                if (buttonX != btnBarrio)
                {
                    btnFactura.BackColor = Color.LightBlue;
                    buttonX.BackColor = Color.LightGray;
                }
            foreach (Control buttonX in panelSoporte.Controls)
                buttonX.BackColor = Color.LightGray;
            foreach (Control buttonX in panelReporte.Controls)
                buttonX.BackColor = Color.LightGray;
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmConsultaCliente());
            panelContenedor.Focus();

            foreach (Control buttonX in panelSoporte.Controls)
                if (buttonX != btnCliente)
                {
                    btnCliente.BackColor = Color.LightBlue;
                    buttonX.BackColor = Color.LightGray;
                }
            foreach (Control buttonX in panelArchivo.Controls)
                buttonX.BackColor = Color.LightGray;
            foreach (Control buttonX in panelReporte.Controls)
                buttonX.BackColor = Color.LightGray;

        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmConsultarContacto());
            panelContenedor.Focus();
            foreach (Control buttonX in panelSoporte.Controls)
                if (buttonX != btnContactos)
                {
                    btnContactos.BackColor = Color.LightBlue;
                    buttonX.BackColor = Color.LightGray;
                }
            foreach (Control buttonX in panelArchivo.Controls)
                buttonX.BackColor = Color.LightGray;
            foreach (Control buttonX in panelReporte.Controls)
                buttonX.BackColor = Color.LightGray;
        }

        private void btnBarrio_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmConsultarBarrio());
            panelContenedor.Focus();
            foreach (Control buttonX in panelSoporte.Controls)
                if (buttonX != btnBarrio)
                {
                    btnBarrio.BackColor = Color.LightBlue;
                    buttonX.BackColor = Color.LightGray;
                }
            foreach (Control buttonX in panelArchivo.Controls)
                buttonX.BackColor = Color.LightGray;
            foreach (Control buttonX in panelReporte.Controls)
                buttonX.BackColor = Color.LightGray;

        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmConsultarProyecto());
            panelContenedor.Focus();
            foreach (Control buttonX in panelSoporte.Controls)
                if (buttonX != btnProyecto)
                {
                    btnProyecto.BackColor = Color.LightBlue;
                    buttonX.BackColor = Color.LightGray;
                }
            foreach (Control buttonX in panelArchivo.Controls)
                buttonX.BackColor = Color.LightGray;
            foreach (Control buttonX in panelReporte.Controls)
                buttonX.BackColor = Color.LightGray;

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmReporteFactura());
            panelContenedor.Focus();
            foreach (Control buttonX in panelReporte.Controls)
                if (buttonX != btnFacturacion)
                {
                    btnFacturacion.BackColor = Color.LightBlue;
                    buttonX.BackColor = Color.LightGray;
                }
            foreach (Control buttonX in panelArchivo.Controls)
                buttonX.BackColor = Color.LightGray;
            foreach (Control buttonX in panelSoporte.Controls)
                buttonX.BackColor = Color.LightGray;
        }

        private void btnProyAndProd_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmReporteDetalleCantidad());
        }

        private void btnProyAndProd_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmReporteDetalleCantidad());
            panelContenedor.Focus();
            foreach (Control buttonX in panelReporte.Controls)
                if (buttonX != btnProyAndProd)
                {
                    btnProyAndProd.BackColor = Color.LightBlue;
                    buttonX.BackColor = Color.LightGray;
                }
            foreach (Control buttonX in panelArchivo.Controls)
                buttonX.BackColor = Color.LightGray;
            foreach (Control buttonX in panelSoporte.Controls)
                buttonX.BackColor = Color.LightGray;
        }

        private void btnFacturaDetalle_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmConsultarFacturas());
            panelContenedor.Focus();
            foreach (Control buttonX in panelReporte.Controls)
                if (buttonX != btnFacturaDetalle)
                {
                    btnFacturaDetalle.BackColor = Color.LightBlue;
                    buttonX.BackColor = Color.LightGray;
                }
            foreach (Control buttonX in panelArchivo.Controls)
                buttonX.BackColor = Color.LightGray;
            foreach (Control buttonX in panelSoporte.Controls)
                buttonX.BackColor = Color.LightGray;
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            if(frmActivo!=null)
                frmActivo.Dispose();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmPresentacion frm = new frmPresentacion();
            frm.ShowDialog();
        }
    }
}
