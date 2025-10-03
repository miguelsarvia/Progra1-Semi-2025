namespace Conversor4._0
{
    partial class frmDocentes
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
            this.grbBuscarDocentes = new System.Windows.Forms.GroupBox();
            this.grdDocentes = new System.Windows.Forms.DataGridView();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.grbEdiccion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbNavegacionDocentes = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosDocentes = new System.Windows.Forms.Label();
            this.btnUltimoDocentes = new System.Windows.Forms.Button();
            this.btnSiguienteDocentes = new System.Windows.Forms.Button();
            this.btnAnteriorDocentes = new System.Windows.Forms.Button();
            this.btnPrimeroDocentes = new System.Windows.Forms.Button();
            this.grbAdministrarDatosDocentes = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.idDocentes = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblidDocentes = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBuscarDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).BeginInit();
            this.grbEdiccion.SuspendLayout();
            this.grbNavegacionDocentes.SuspendLayout();
            this.grbAdministrarDatosDocentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBuscarDocentes
            // 
            this.grbBuscarDocentes.Controls.Add(this.grdDocentes);
            this.grbBuscarDocentes.Controls.Add(this.txtBuscarDocentes);
            this.grbBuscarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscarDocentes.Location = new System.Drawing.Point(323, 41);
            this.grbBuscarDocentes.Name = "grbBuscarDocentes";
            this.grbBuscarDocentes.Size = new System.Drawing.Size(463, 260);
            this.grbBuscarDocentes.TabIndex = 12;
            this.grbBuscarDocentes.TabStop = false;
            this.grbBuscarDocentes.Text = "Busqueda Docentes";
            // 
            // grdDocentes
            // 
            this.grdDocentes.AllowUserToAddRows = false;
            this.grdDocentes.AllowUserToDeleteRows = false;
            this.grdDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.numero});
            this.grdDocentes.Location = new System.Drawing.Point(28, 79);
            this.grdDocentes.Name = "grdDocentes";
            this.grdDocentes.ReadOnly = true;
            this.grdDocentes.Size = new System.Drawing.Size(435, 164);
            this.grdDocentes.TabIndex = 1;
            this.grdDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDocentes_CellClick);
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(81, 38);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(300, 21);
            this.txtBuscarDocentes.TabIndex = 0;
            this.txtBuscarDocentes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDocentes_KeyUp);
            // 
            // grbEdiccion
            // 
            this.grbEdiccion.Controls.Add(this.btnEliminar);
            this.grbEdiccion.Controls.Add(this.btnModificar);
            this.grbEdiccion.Controls.Add(this.btnNuevo);
            this.grbEdiccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdiccion.Location = new System.Drawing.Point(386, 336);
            this.grbEdiccion.Name = "grbEdiccion";
            this.grbEdiccion.Size = new System.Drawing.Size(400, 74);
            this.grbEdiccion.TabIndex = 11;
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
            // grbNavegacionDocentes
            // 
            this.grbNavegacionDocentes.Controls.Add(this.lblnRegistrosDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnUltimoDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnSiguienteDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnAnteriorDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnPrimeroDocentes);
            this.grbNavegacionDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionDocentes.Location = new System.Drawing.Point(24, 336);
            this.grbNavegacionDocentes.Name = "grbNavegacionDocentes";
            this.grbNavegacionDocentes.Size = new System.Drawing.Size(275, 74);
            this.grbNavegacionDocentes.TabIndex = 10;
            this.grbNavegacionDocentes.TabStop = false;
            this.grbNavegacionDocentes.Text = "Navegacion";
            // 
            // lblnRegistrosDocentes
            // 
            this.lblnRegistrosDocentes.AutoSize = true;
            this.lblnRegistrosDocentes.Location = new System.Drawing.Point(114, 30);
            this.lblnRegistrosDocentes.Name = "lblnRegistrosDocentes";
            this.lblnRegistrosDocentes.Size = new System.Drawing.Size(46, 15);
            this.lblnRegistrosDocentes.TabIndex = 11;
            this.lblnRegistrosDocentes.Text = "x de n";
            // 
            // btnUltimoDocentes
            // 
            this.btnUltimoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocentes.Location = new System.Drawing.Point(212, 20);
            this.btnUltimoDocentes.Name = "btnUltimoDocentes";
            this.btnUltimoDocentes.Size = new System.Drawing.Size(39, 29);
            this.btnUltimoDocentes.TabIndex = 3;
            this.btnUltimoDocentes.Text = "<I";
            this.btnUltimoDocentes.UseVisualStyleBackColor = true;
            this.btnUltimoDocentes.Click += new System.EventHandler(this.btnUltimoDocentes_Click);
            // 
            // btnSiguienteDocentes
            // 
            this.btnSiguienteDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocentes.Location = new System.Drawing.Point(167, 20);
            this.btnSiguienteDocentes.Name = "btnSiguienteDocentes";
            this.btnSiguienteDocentes.Size = new System.Drawing.Size(39, 29);
            this.btnSiguienteDocentes.TabIndex = 2;
            this.btnSiguienteDocentes.Text = ">";
            this.btnSiguienteDocentes.UseVisualStyleBackColor = true;
            this.btnSiguienteDocentes.Click += new System.EventHandler(this.btnSiguienteDocentes_Click);
            // 
            // btnAnteriorDocentes
            // 
            this.btnAnteriorDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocentes.Location = new System.Drawing.Point(71, 19);
            this.btnAnteriorDocentes.Name = "btnAnteriorDocentes";
            this.btnAnteriorDocentes.Size = new System.Drawing.Size(39, 29);
            this.btnAnteriorDocentes.TabIndex = 1;
            this.btnAnteriorDocentes.Text = "<";
            this.btnAnteriorDocentes.UseVisualStyleBackColor = true;
            this.btnAnteriorDocentes.Click += new System.EventHandler(this.btnAnteriorDocentes_Click);
            // 
            // btnPrimeroDocentes
            // 
            this.btnPrimeroDocentes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrimeroDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocentes.Location = new System.Drawing.Point(26, 19);
            this.btnPrimeroDocentes.Name = "btnPrimeroDocentes";
            this.btnPrimeroDocentes.Size = new System.Drawing.Size(39, 29);
            this.btnPrimeroDocentes.TabIndex = 0;
            this.btnPrimeroDocentes.Text = "l<";
            this.btnPrimeroDocentes.UseVisualStyleBackColor = false;
            this.btnPrimeroDocentes.Click += new System.EventHandler(this.btnPrimeroDocentes_Click);
            // 
            // grbAdministrarDatosDocentes
            // 
            this.grbAdministrarDatosDocentes.Controls.Add(this.txtNumero);
            this.grbAdministrarDatosDocentes.Controls.Add(this.lblNumero);
            this.grbAdministrarDatosDocentes.Controls.Add(this.idDocentes);
            this.grbAdministrarDatosDocentes.Controls.Add(this.txtDireccion);
            this.grbAdministrarDatosDocentes.Controls.Add(this.lblDireccion);
            this.grbAdministrarDatosDocentes.Controls.Add(this.txtNombre);
            this.grbAdministrarDatosDocentes.Controls.Add(this.lblNombre);
            this.grbAdministrarDatosDocentes.Controls.Add(this.lblCodigo);
            this.grbAdministrarDatosDocentes.Controls.Add(this.txtCodigo);
            this.grbAdministrarDatosDocentes.Controls.Add(this.lblidDocentes);
            this.grbAdministrarDatosDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdministrarDatosDocentes.Location = new System.Drawing.Point(14, 41);
            this.grbAdministrarDatosDocentes.Name = "grbAdministrarDatosDocentes";
            this.grbAdministrarDatosDocentes.Size = new System.Drawing.Size(297, 231);
            this.grbAdministrarDatosDocentes.TabIndex = 9;
            this.grbAdministrarDatosDocentes.TabStop = false;
            this.grbAdministrarDatosDocentes.Text = "Datos";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(105, 186);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(125, 21);
            this.txtNumero.TabIndex = 12;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(7, 186);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(86, 15);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Numero TL: ";
            // 
            // idDocentes
            // 
            this.idDocentes.AutoSize = true;
            this.idDocentes.Location = new System.Drawing.Point(102, 16);
            this.idDocentes.Name = "idDocentes";
            this.idDocentes.Size = new System.Drawing.Size(47, 15);
            this.idDocentes.TabIndex = 10;
            this.idDocentes.Text = "label6";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(103, 153);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(127, 21);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 153);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "DIRECCION: ";
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
            // lblidDocentes
            // 
            this.lblidDocentes.AutoSize = true;
            this.lblidDocentes.Location = new System.Drawing.Point(7, 38);
            this.lblidDocentes.Name = "lblidDocentes";
            this.lblidDocentes.Size = new System.Drawing.Size(29, 15);
            this.lblidDocentes.TabIndex = 0;
            this.lblidDocentes.Text = "ID: ";
            // 
            // id
            // 
            this.id.DataPropertyName = "idDocentes";
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
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "NUMERO";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.grbBuscarDocentes);
            this.Controls.Add(this.grbEdiccion);
            this.Controls.Add(this.grbNavegacionDocentes);
            this.Controls.Add(this.grbAdministrarDatosDocentes);
            this.Name = "frmDocentes";
            this.Text = "frmDocentes";
            this.Load += new System.EventHandler(this.frmDocentes_Load);
            this.grbBuscarDocentes.ResumeLayout(false);
            this.grbBuscarDocentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).EndInit();
            this.grbEdiccion.ResumeLayout(false);
            this.grbNavegacionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.PerformLayout();
            this.grbAdministrarDatosDocentes.ResumeLayout(false);
            this.grbAdministrarDatosDocentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBuscarDocentes;
        private System.Windows.Forms.DataGridView grdDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.GroupBox grbEdiccion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbNavegacionDocentes;
        private System.Windows.Forms.Label lblnRegistrosDocentes;
        private System.Windows.Forms.Button btnUltimoDocentes;
        private System.Windows.Forms.Button btnSiguienteDocentes;
        private System.Windows.Forms.Button btnAnteriorDocentes;
        private System.Windows.Forms.Button btnPrimeroDocentes;
        private System.Windows.Forms.GroupBox grbAdministrarDatosDocentes;
        private System.Windows.Forms.Label idDocentes;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblidDocentes;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
    }
}