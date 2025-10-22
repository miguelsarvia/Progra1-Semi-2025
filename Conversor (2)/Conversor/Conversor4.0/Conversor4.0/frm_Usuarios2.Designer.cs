namespace Conversor4._0
{
    partial class frm_Usuarios2
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
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grbEdiccion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbNavegacionUsuarios = new System.Windows.Forms.GroupBox();
            this.lblnRegistros = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.grbDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.idUsuario = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.llbClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.grbEdiccion.SuspendLayout();
            this.grbNavegacionUsuarios.SuspendLayout();
            this.grbDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.grdUsuarios);
            this.grbBusqueda.Controls.Add(this.txtBuscar);
            this.grbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusqueda.Location = new System.Drawing.Point(343, 51);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(463, 260);
            this.grbBusqueda.TabIndex = 8;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Busqueda Alumnos";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.usuario,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdUsuarios.Location = new System.Drawing.Point(28, 79);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.Size = new System.Drawing.Size(429, 164);
            this.grdUsuarios.TabIndex = 1;
            this.grdUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuarios_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(89, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 21);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // grbEdiccion
            // 
            this.grbEdiccion.Controls.Add(this.btnEliminar);
            this.grbEdiccion.Controls.Add(this.btnModificar);
            this.grbEdiccion.Controls.Add(this.btnNuevo);
            this.grbEdiccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdiccion.Location = new System.Drawing.Point(406, 346);
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // grbNavegacionUsuarios
            // 
            this.grbNavegacionUsuarios.Controls.Add(this.lblnRegistros);
            this.grbNavegacionUsuarios.Controls.Add(this.btnUltimo);
            this.grbNavegacionUsuarios.Controls.Add(this.btnSiguiente);
            this.grbNavegacionUsuarios.Controls.Add(this.btnAnterior);
            this.grbNavegacionUsuarios.Controls.Add(this.btnPrimero);
            this.grbNavegacionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionUsuarios.Location = new System.Drawing.Point(44, 346);
            this.grbNavegacionUsuarios.Name = "grbNavegacionUsuarios";
            this.grbNavegacionUsuarios.Size = new System.Drawing.Size(275, 74);
            this.grbNavegacionUsuarios.TabIndex = 6;
            this.grbNavegacionUsuarios.TabStop = false;
            this.grbNavegacionUsuarios.Text = "Navegacion";
            // 
            // lblnRegistros
            // 
            this.lblnRegistros.AutoSize = true;
            this.lblnRegistros.Location = new System.Drawing.Point(114, 30);
            this.lblnRegistros.Name = "lblnRegistros";
            this.lblnRegistros.Size = new System.Drawing.Size(46, 15);
            this.lblnRegistros.TabIndex = 11;
            this.lblnRegistros.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(212, 20);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(39, 29);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = "<I";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(167, 20);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(39, 29);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(71, 19);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(39, 29);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(26, 19);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(39, 29);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "l<";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // grbDatosUsuarios
            // 
            this.grbDatosUsuarios.Controls.Add(this.txtClave);
            this.grbDatosUsuarios.Controls.Add(this.llbClave);
            this.grbDatosUsuarios.Controls.Add(this.idUsuario);
            this.grbDatosUsuarios.Controls.Add(this.txtNumero);
            this.grbDatosUsuarios.Controls.Add(this.txtDireccion);
            this.grbDatosUsuarios.Controls.Add(this.lblNumero);
            this.grbDatosUsuarios.Controls.Add(this.lblDireccion);
            this.grbDatosUsuarios.Controls.Add(this.txtNombre);
            this.grbDatosUsuarios.Controls.Add(this.lblNombre);
            this.grbDatosUsuarios.Controls.Add(this.lblUsuario);
            this.grbDatosUsuarios.Controls.Add(this.txtUsuario);
            this.grbDatosUsuarios.Controls.Add(this.lblidUsuario);
            this.grbDatosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosUsuarios.Location = new System.Drawing.Point(34, 51);
            this.grbDatosUsuarios.Name = "grbDatosUsuarios";
            this.grbDatosUsuarios.Size = new System.Drawing.Size(297, 260);
            this.grbDatosUsuarios.TabIndex = 5;
            this.grbDatosUsuarios.TabStop = false;
            this.grbDatosUsuarios.Text = "Datos";
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSize = true;
            this.idUsuario.Location = new System.Drawing.Point(102, 16);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(47, 15);
            this.idUsuario.TabIndex = 10;
            this.idUsuario.Text = "label6";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(85, 176);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(109, 21);
            this.txtNumero.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 147);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(181, 21);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(7, 182);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(86, 15);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero TL: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 150);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(76, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion: ";
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 78);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 15);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(85, 75);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(109, 21);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(7, 38);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(29, 15);
            this.lblidUsuario.TabIndex = 0;
            this.lblidUsuario.Text = "ID: ";
            // 
            // llbClave
            // 
            this.llbClave.AutoSize = true;
            this.llbClave.Location = new System.Drawing.Point(7, 228);
            this.llbClave.Name = "llbClave";
            this.llbClave.Size = new System.Drawing.Size(50, 15);
            this.llbClave.TabIndex = 11;
            this.llbClave.Text = "Clave: ";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(85, 222);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(109, 21);
            this.txtClave.TabIndex = 12;
            // 
            // id
            // 
            this.id.DataPropertyName = "idUsuario";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "Usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Visible = false;
            // 
            // frm_Usuarios2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 470);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.grbEdiccion);
            this.Controls.Add(this.grbNavegacionUsuarios);
            this.Controls.Add(this.grbDatosUsuarios);
            this.Name = "frm_Usuarios2";
            this.Text = "frm_Usuarios2";
            this.Load += new System.EventHandler(this.frm_Usuarios2_Load);
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.grbEdiccion.ResumeLayout(false);
            this.grbNavegacionUsuarios.ResumeLayout(false);
            this.grbNavegacionUsuarios.PerformLayout();
            this.grbDatosUsuarios.ResumeLayout(false);
            this.grbDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox grbEdiccion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbNavegacionUsuarios;
        private System.Windows.Forms.Label lblnRegistros;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.GroupBox grbDatosUsuarios;
        private System.Windows.Forms.Label idUsuario;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label llbClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}