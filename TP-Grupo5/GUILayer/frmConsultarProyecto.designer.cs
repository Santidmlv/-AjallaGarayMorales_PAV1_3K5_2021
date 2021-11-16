namespace TP_Grupo5.GUILayer
{
    partial class frmConsultarProyecto
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
            this.components = new System.ComponentModel.Container();
            this.tTbtn = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.gbProyecto = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbActivos = new System.Windows.Forms.RadioButton();
            this.rbEliminado = new System.Windows.Forms.RadioButton();
            this.grdProyecto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gbNombre.SuspendLayout();
            this.gbProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(653, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.tTbtn.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Location = new System.Drawing.Point(242, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.tTbtn.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.Location = new System.Drawing.Point(161, 361);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 30);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.tTbtn.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.Location = new System.Drawing.Point(76, 361);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 30);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Agregar";
            this.tTbtn.SetToolTip(this.btnNuevo, "Nuevo\r\n");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbNombre
            // 
            this.gbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNombre.Controls.Add(this.btnSalir);
            this.gbNombre.Controls.Add(this.btnEliminar);
            this.gbNombre.Controls.Add(this.btnEditar);
            this.gbNombre.Controls.Add(this.btnNuevo);
            this.gbNombre.Controls.Add(this.gbProyecto);
            this.gbNombre.Location = new System.Drawing.Point(13, 13);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(805, 462);
            this.gbNombre.TabIndex = 5;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Proyecto";
            // 
            // gbProyecto
            // 
            this.gbProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbProyecto.Controls.Add(this.txtDescripcion);
            this.gbProyecto.Controls.Add(this.lblDescripcion);
            this.gbProyecto.Controls.Add(this.rbTodos);
            this.gbProyecto.Controls.Add(this.rbActivos);
            this.gbProyecto.Controls.Add(this.rbEliminado);
            this.gbProyecto.Controls.Add(this.grdProyecto);
            this.gbProyecto.Controls.Add(this.lblResponsable);
            this.gbProyecto.Controls.Add(this.cboResponsable);
            this.gbProyecto.Controls.Add(this.cboProducto);
            this.gbProyecto.Controls.Add(this.btnConsultar);
            this.gbProyecto.Controls.Add(this.lblProducto);
            this.gbProyecto.Location = new System.Drawing.Point(69, 46);
            this.gbProyecto.Name = "gbProyecto";
            this.gbProyecto.Size = new System.Drawing.Size(666, 310);
            this.gbProyecto.TabIndex = 6;
            this.gbProyecto.TabStop = false;
            this.gbProyecto.Text = "Opción de búsqueda";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(92, 25);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(129, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 29);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(584, 68);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 5;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(584, 25);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(60, 17);
            this.rbActivos.TabIndex = 3;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseVisualStyleBackColor = true;
            // 
            // rbEliminado
            // 
            this.rbEliminado.AutoSize = true;
            this.rbEliminado.Location = new System.Drawing.Point(584, 47);
            this.rbEliminado.Name = "rbEliminado";
            this.rbEliminado.Size = new System.Drawing.Size(75, 17);
            this.rbEliminado.TabIndex = 4;
            this.rbEliminado.TabStop = true;
            this.rbEliminado.Text = "Eliminados";
            this.rbEliminado.UseVisualStyleBackColor = true;
            // 
            // grdProyecto
            // 
            this.grdProyecto.AllowUserToAddRows = false;
            this.grdProyecto.AllowUserToDeleteRows = false;
            this.grdProyecto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.version,
            this.alcance,
            this.responsable,
            this.producto,
            this.borrado});
            this.grdProyecto.Location = new System.Drawing.Point(7, 126);
            this.grdProyecto.MultiSelect = false;
            this.grdProyecto.Name = "grdProyecto";
            this.grdProyecto.ReadOnly = true;
            this.grdProyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProyecto.Size = new System.Drawing.Size(652, 171);
            this.grdProyecto.TabIndex = 7;
            this.grdProyecto.SelectionChanged += new System.EventHandler(this.grdProyecto_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // version
            // 
            this.version.HeaderText = "Versión";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Width = 50;
            // 
            // alcance
            // 
            this.alcance.HeaderText = "Alcance";
            this.alcance.Name = "alcance";
            this.alcance.ReadOnly = true;
            this.alcance.Width = 150;
            // 
            // responsable
            // 
            this.responsable.HeaderText = "Responsable";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 200;
            // 
            // borrado
            // 
            this.borrado.HeaderText = "Borrado";
            this.borrado.Name = "borrado";
            this.borrado.ReadOnly = true;
            this.borrado.Visible = false;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(226, 54);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(72, 13);
            this.lblResponsable.TabIndex = 3;
            this.lblResponsable.Text = "Responsable:";
            // 
            // cboResponsable
            // 
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(298, 51);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(121, 21);
            this.cboResponsable.TabIndex = 2;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(298, 26);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(175, 21);
            this.cboProducto.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(584, 90);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 30);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(237, 29);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(58, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Productos:";
            // 
            // frmConsultarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.gbNombre);
            this.MaximizeBox = false;
            this.Name = "frmConsultarProyecto";
            this.Text = "Soporte de proyecto";
            this.Load += new System.EventHandler(this.frmConsultarProyecto_Load);
            this.gbNombre.ResumeLayout(false);
            this.gbProyecto.ResumeLayout(false);
            this.gbProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tTbtn;
        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbProyecto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbActivos;
        private System.Windows.Forms.RadioButton rbEliminado;
        private System.Windows.Forms.DataGridView grdProyecto;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcance;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrado;
    }
}