namespace Conversor4._0
{
    partial class frmMaterias
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
            this.grbBuscarMaterias = new System.Windows.Forms.GroupBox();
            this.cboBuscarMateria = new System.Windows.Forms.ComboBox();
            this.grdMaterias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.grbEdiccion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.idMateria = new System.Windows.Forms.Label();
            this.txtUvMaterias = new System.Windows.Forms.TextBox();
            this.lbluvMateria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblidMateria = new System.Windows.Forms.Label();
            this.grbBuscarMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).BeginInit();
            this.grbEdiccion.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBuscarMaterias
            // 
            this.grbBuscarMaterias.Controls.Add(this.cboBuscarMateria);
            this.grbBuscarMaterias.Controls.Add(this.grdMaterias);
            this.grbBuscarMaterias.Controls.Add(this.txtBuscarMaterias);
            this.grbBuscarMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscarMaterias.Location = new System.Drawing.Point(321, 12);
            this.grbBuscarMaterias.Name = "grbBuscarMaterias";
            this.grbBuscarMaterias.Size = new System.Drawing.Size(463, 260);
            this.grbBuscarMaterias.TabIndex = 8;
            this.grbBuscarMaterias.TabStop = false;
            this.grbBuscarMaterias.Text = "Busqueda Materia";
            // 
            // cboBuscarMateria
            // 
            this.cboBuscarMateria.FormattingEnabled = true;
            this.cboBuscarMateria.Items.AddRange(new object[] {
            "Codigo",
            "Nombre"});
            this.cboBuscarMateria.Location = new System.Drawing.Point(28, 38);
            this.cboBuscarMateria.Name = "cboBuscarMateria";
            this.cboBuscarMateria.Size = new System.Drawing.Size(112, 23);
            this.cboBuscarMateria.TabIndex = 2;
            // 
            // grdMaterias
            // 
            this.grdMaterias.AllowUserToAddRows = false;
            this.grdMaterias.AllowUserToDeleteRows = false;
            this.grdMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion});
            this.grdMaterias.Location = new System.Drawing.Point(28, 79);
            this.grdMaterias.Name = "grdMaterias";
            this.grdMaterias.ReadOnly = true;
            this.grdMaterias.Size = new System.Drawing.Size(435, 164);
            this.grdMaterias.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "IdMaterias";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "uv";
            this.direccion.HeaderText = "UV";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(157, 38);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(300, 21);
            this.txtBuscarMaterias.TabIndex = 0;
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp_1);
            // 
            // grbEdiccion
            // 
            this.grbEdiccion.Controls.Add(this.btnEliminar);
            this.grbEdiccion.Controls.Add(this.btnModificar);
            this.grbEdiccion.Controls.Add(this.btnNuevo);
            this.grbEdiccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdiccion.Location = new System.Drawing.Point(384, 307);
            this.grbEdiccion.Name = "grbEdiccion";
            this.grbEdiccion.Size = new System.Drawing.Size(400, 74);
            this.grbEdiccion.TabIndex = 7;
            this.grbEdiccion.TabStop = false;
            this.grbEdiccion.Text = "Edicion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(262, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(146, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(18, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblnRegistrosMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionMateria.Location = new System.Drawing.Point(22, 307);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Size = new System.Drawing.Size(275, 74);
            this.grbNavegacionMateria.TabIndex = 6;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblnRegistrosMateria
            // 
            this.lblnRegistrosMateria.AutoSize = true;
            this.lblnRegistrosMateria.Location = new System.Drawing.Point(114, 30);
            this.lblnRegistrosMateria.Name = "lblnRegistrosMateria";
            this.lblnRegistrosMateria.Size = new System.Drawing.Size(46, 15);
            this.lblnRegistrosMateria.TabIndex = 11;
            this.lblnRegistrosMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(212, 20);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(39, 29);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = "<I";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(167, 20);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(39, 29);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(71, 19);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(39, 29);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(26, 19);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(39, 29);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "l<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = false;
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.idMateria);
            this.grbDatosMateria.Controls.Add(this.txtUvMaterias);
            this.grbDatosMateria.Controls.Add(this.lbluvMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombre);
            this.grbDatosMateria.Controls.Add(this.lblNombre);
            this.grbDatosMateria.Controls.Add(this.lblCodigo);
            this.grbDatosMateria.Controls.Add(this.txtCodigo);
            this.grbDatosMateria.Controls.Add(this.lblidMateria);
            this.grbDatosMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosMateria.Location = new System.Drawing.Point(12, 12);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Size = new System.Drawing.Size(297, 231);
            this.grbDatosMateria.TabIndex = 5;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "Datos";
            // 
            // idMateria
            // 
            this.idMateria.AutoSize = true;
            this.idMateria.Location = new System.Drawing.Point(102, 16);
            this.idMateria.Name = "idMateria";
            this.idMateria.Size = new System.Drawing.Size(47, 15);
            this.idMateria.TabIndex = 10;
            this.idMateria.Text = "label6";
            // 
            // txtUvMaterias
            // 
            this.txtUvMaterias.Location = new System.Drawing.Point(85, 147);
            this.txtUvMaterias.Name = "txtUvMaterias";
            this.txtUvMaterias.Size = new System.Drawing.Size(64, 21);
            this.txtUvMaterias.TabIndex = 7;
            // 
            // lbluvMateria
            // 
            this.lbluvMateria.AutoSize = true;
            this.lbluvMateria.Location = new System.Drawing.Point(33, 153);
            this.lbluvMateria.Name = "lbluvMateria";
            this.lbluvMateria.Size = new System.Drawing.Size(33, 15);
            this.lbluvMateria.TabIndex = 5;
            this.lbluvMateria.Text = "UV: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 21);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 78);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(64, 15);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(85, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(109, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblidMateria
            // 
            this.lblidMateria.AutoSize = true;
            this.lblidMateria.Location = new System.Drawing.Point(7, 38);
            this.lblidMateria.Name = "lblidMateria";
            this.lblidMateria.Size = new System.Drawing.Size(29, 15);
            this.lblidMateria.TabIndex = 0;
            this.lblidMateria.Text = "ID: ";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 396);
            this.Controls.Add(this.grbBuscarMaterias);
            this.Controls.Add(this.grbEdiccion);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Name = "frmMaterias";
            this.Text = "frmMaterias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            this.grbBuscarMaterias.ResumeLayout(false);
            this.grbBuscarMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).EndInit();
            this.grbEdiccion.ResumeLayout(false);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBuscarMaterias;
        private System.Windows.Forms.DataGridView grdMaterias;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.GroupBox grbEdiccion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblnRegistrosMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.Label idMateria;
        private System.Windows.Forms.TextBox txtUvMaterias;
        private System.Windows.Forms.Label lbluvMateria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblidMateria;
        private System.Windows.Forms.ComboBox cboBuscarMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}