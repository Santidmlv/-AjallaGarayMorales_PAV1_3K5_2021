
namespace TP_Grupo5.GUILayer
{
    partial class frmConsultarBarrio
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
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbEliminado = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvBarrios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreBarrio = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNombre
            // 
            this.gbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNombre.Controls.Add(this.rbTodos);
            this.gbNombre.Controls.Add(this.btnActualizar);
            this.gbNombre.Controls.Add(this.btnBuscar);
            this.gbNombre.Controls.Add(this.rbActivos);
            this.gbNombre.Controls.Add(this.btnAgregar);
            this.gbNombre.Controls.Add(this.rbEliminado);
            this.gbNombre.Controls.Add(this.btnLimpiar);
            this.gbNombre.Controls.Add(this.btnEliminar);
            this.gbNombre.Controls.Add(this.btnSalir);
            this.gbNombre.Controls.Add(this.dgvBarrios);
            this.gbNombre.Controls.Add(this.groupBox1);
            this.gbNombre.Location = new System.Drawing.Point(12, 12);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(806, 463);
            this.gbNombre.TabIndex = 7;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Barrio";
            // 
            // rbTodos
            // 
            this.rbTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(483, 138);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 20;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Location = new System.Drawing.Point(385, 335);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 30);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(483, 163);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbActivos
            // 
            this.rbActivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(483, 95);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(60, 17);
            this.rbActivos.TabIndex = 2;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(246, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(64, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbEliminado
            // 
            this.rbEliminado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbEliminado.AutoSize = true;
            this.rbEliminado.Location = new System.Drawing.Point(483, 117);
            this.rbEliminado.Name = "rbEliminado";
            this.rbEliminado.Size = new System.Drawing.Size(75, 17);
            this.rbEliminado.TabIndex = 19;
            this.rbEliminado.TabStop = true;
            this.rbEliminado.Text = "Eliminados";
            this.rbEliminado.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.Location = new System.Drawing.Point(483, 299);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 30);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Location = new System.Drawing.Point(315, 335);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 30);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(483, 335);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 30);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvBarrios
            // 
            this.dgvBarrios.AllowUserToAddRows = false;
            this.dgvBarrios.AllowUserToDeleteRows = false;
            this.dgvBarrios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.borrado});
            this.dgvBarrios.Location = new System.Drawing.Point(246, 199);
            this.dgvBarrios.Name = "dgvBarrios";
            this.dgvBarrios.ReadOnly = true;
            this.dgvBarrios.RowTemplate.Height = 25;
            this.dgvBarrios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarrios.Size = new System.Drawing.Size(231, 130);
            this.dgvBarrios.TabIndex = 4;
            this.dgvBarrios.SelectionChanged += new System.EventHandler(this.dgvBarrios_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblNombreBarrio);
            this.groupBox1.Controls.Add(this.txtNombreBarrio);
            this.groupBox1.Location = new System.Drawing.Point(246, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opción de búsqueda";
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.AutoSize = true;
            this.lblNombreBarrio.Location = new System.Drawing.Point(26, 44);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBarrio.TabIndex = 3;
            this.lblNombreBarrio.Text = "Nombre:";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Location = new System.Drawing.Point(77, 37);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(138, 20);
            this.txtNombreBarrio.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // frmConsultarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.gbNombre);
            this.Name = "frmConsultarBarrio";
            this.Text = "Consultar Barrios";
            this.Load += new System.EventHandler(this.frmConsultarBarrio_Load);
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarrios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvBarrios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombreBarrio;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbEliminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
    }
}