
namespace TP_Grupo5.GUILayer
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuIzq = new System.Windows.Forms.Panel();
            this.panelReporte = new System.Windows.Forms.Panel();
            this.btnFacturaDetalle = new System.Windows.Forms.Button();
            this.btnProyAndProd = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panelSoporte = new System.Windows.Forms.Panel();
            this.btnProyecto = new System.Windows.Forms.Button();
            this.btnBarrio = new System.Windows.Forms.Button();
            this.btnContactos = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSoporte = new System.Windows.Forms.Button();
            this.panelArchivo = new System.Windows.Forms.Panel();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelMenuIzq.SuspendLayout();
            this.panelReporte.SuspendLayout();
            this.panelSoporte.SuspendLayout();
            this.panelArchivo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuIzq
            // 
            this.panelMenuIzq.AutoScroll = true;
            this.panelMenuIzq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenuIzq.Controls.Add(this.btnAbout);
            this.panelMenuIzq.Controls.Add(this.panelReporte);
            this.panelMenuIzq.Controls.Add(this.btnReportes);
            this.panelMenuIzq.Controls.Add(this.panelSoporte);
            this.panelMenuIzq.Controls.Add(this.btnSoporte);
            this.panelMenuIzq.Controls.Add(this.panelArchivo);
            this.panelMenuIzq.Controls.Add(this.btnArchivo);
            this.panelMenuIzq.Controls.Add(this.panelLogo);
            this.panelMenuIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIzq.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIzq.Name = "panelMenuIzq";
            this.panelMenuIzq.Size = new System.Drawing.Size(159, 524);
            this.panelMenuIzq.TabIndex = 0;
            // 
            // panelReporte
            // 
            this.panelReporte.Controls.Add(this.btnFacturaDetalle);
            this.panelReporte.Controls.Add(this.btnProyAndProd);
            this.panelReporte.Controls.Add(this.btnFacturacion);
            this.panelReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReporte.Location = new System.Drawing.Point(0, 415);
            this.panelReporte.Name = "panelReporte";
            this.panelReporte.Size = new System.Drawing.Size(142, 110);
            this.panelReporte.TabIndex = 6;
            // 
            // btnFacturaDetalle
            // 
            this.btnFacturaDetalle.Location = new System.Drawing.Point(12, 0);
            this.btnFacturaDetalle.Name = "btnFacturaDetalle";
            this.btnFacturaDetalle.Size = new System.Drawing.Size(130, 30);
            this.btnFacturaDetalle.TabIndex = 0;
            this.btnFacturaDetalle.Text = "Detalle de factura";
            this.btnFacturaDetalle.UseVisualStyleBackColor = true;
            this.btnFacturaDetalle.Click += new System.EventHandler(this.btnFacturaDetalle_Click);
            // 
            // btnProyAndProd
            // 
            this.btnProyAndProd.Location = new System.Drawing.Point(12, 71);
            this.btnProyAndProd.Name = "btnProyAndProd";
            this.btnProyAndProd.Size = new System.Drawing.Size(130, 30);
            this.btnProyAndProd.TabIndex = 2;
            this.btnProyAndProd.Text = "Proyectos y productos";
            this.btnProyAndProd.UseVisualStyleBackColor = true;
            this.btnProyAndProd.Click += new System.EventHandler(this.btnProyAndProd_Click_1);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(12, 36);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(130, 30);
            this.btnFacturacion.TabIndex = 1;
            this.btnFacturacion.Text = "Lista de facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.Location = new System.Drawing.Point(0, 375);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(142, 40);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelSoporte
            // 
            this.panelSoporte.Controls.Add(this.btnProyecto);
            this.panelSoporte.Controls.Add(this.btnBarrio);
            this.panelSoporte.Controls.Add(this.btnContactos);
            this.panelSoporte.Controls.Add(this.btnCliente);
            this.panelSoporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSoporte.Location = new System.Drawing.Point(0, 236);
            this.panelSoporte.Name = "panelSoporte";
            this.panelSoporte.Size = new System.Drawing.Size(142, 139);
            this.panelSoporte.TabIndex = 4;
            // 
            // btnProyecto
            // 
            this.btnProyecto.Location = new System.Drawing.Point(12, 108);
            this.btnProyecto.Name = "btnProyecto";
            this.btnProyecto.Size = new System.Drawing.Size(130, 30);
            this.btnProyecto.TabIndex = 3;
            this.btnProyecto.Text = "Proyecto";
            this.btnProyecto.UseVisualStyleBackColor = true;
            this.btnProyecto.Click += new System.EventHandler(this.btnProyecto_Click);
            // 
            // btnBarrio
            // 
            this.btnBarrio.Location = new System.Drawing.Point(12, 72);
            this.btnBarrio.Name = "btnBarrio";
            this.btnBarrio.Size = new System.Drawing.Size(130, 30);
            this.btnBarrio.TabIndex = 2;
            this.btnBarrio.Text = "Barrio";
            this.btnBarrio.UseVisualStyleBackColor = true;
            this.btnBarrio.Click += new System.EventHandler(this.btnBarrio_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.Location = new System.Drawing.Point(12, 36);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(130, 30);
            this.btnContactos.TabIndex = 1;
            this.btnContactos.Text = "Contacto";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(130, 30);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnSoporte
            // 
            this.btnSoporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoporte.Location = new System.Drawing.Point(0, 196);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(142, 40);
            this.btnSoporte.TabIndex = 3;
            this.btnSoporte.Text = "Soporte";
            this.btnSoporte.UseVisualStyleBackColor = true;
            this.btnSoporte.Click += new System.EventHandler(this.btnSoporte_Click);
            // 
            // panelArchivo
            // 
            this.panelArchivo.Controls.Add(this.btnFactura);
            this.panelArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArchivo.Location = new System.Drawing.Point(0, 160);
            this.panelArchivo.Name = "panelArchivo";
            this.panelArchivo.Size = new System.Drawing.Size(142, 36);
            this.panelArchivo.TabIndex = 2;
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(12, 0);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(130, 30);
            this.btnFactura.TabIndex = 0;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchivo.Location = new System.Drawing.Point(0, 120);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(142, 40);
            this.btnArchivo.TabIndex = 1;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(142, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogo.Image = global::TP_Grupo5.Properties.Resources.logo_small2;
            this.btnLogo.Location = new System.Drawing.Point(6, 1);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(133, 117);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(159, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(844, 524);
            this.panelContenedor.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::TP_Grupo5.Properties.Resources.Facturacion;
            this.pictureBox1.Location = new System.Drawing.Point(67, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 477);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.Location = new System.Drawing.Point(0, 525);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(142, 40);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "Acerca de AGM";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1003, 524);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuIzq);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelMenuIzq.ResumeLayout(false);
            this.panelReporte.ResumeLayout(false);
            this.panelSoporte.ResumeLayout(false);
            this.panelArchivo.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIzq;
        private System.Windows.Forms.Panel panelSoporte;
        private System.Windows.Forms.Button btnSoporte;
        private System.Windows.Forms.Panel panelArchivo;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelReporte;
        private System.Windows.Forms.Button btnProyAndProd;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnBarrio;
        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnProyecto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFacturaDetalle;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Button btnAbout;
    }
}