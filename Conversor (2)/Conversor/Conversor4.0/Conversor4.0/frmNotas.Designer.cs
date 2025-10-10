namespace Conversor4._0
{
    partial class frmNotas
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
            System.Windows.Forms.Label lblidNota;
            System.Windows.Forms.Label lblMateria;
            System.Windows.Forms.Label lblPeriodo;
            System.Windows.Forms.Label lblFecha;
            this.idNotaLabel1 = new System.Windows.Forms.Label();
            this.notasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_academicaDataSet1 = new Conversor4._0.db_academicaDataSet();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_academicaDataSet2 = new Conversor4._0.db_academicaDataSet();
            this.fechaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dnotasDataGridView = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.notasTableAdapter1 = new Conversor4._0.db_academicaDataSetTableAdapters.notasTableAdapter();
            this.tableAdapterManager1 = new Conversor4._0.db_academicaDataSetTableAdapters.TableAdapterManager();
            this.dnotasTableAdapter = new Conversor4._0.db_academicaDataSetTableAdapters.dnotasTableAdapter();
            this.materiasTableAdapter = new Conversor4._0.db_academicaDataSetTableAdapters.materiasTableAdapter();
            this.periodosTableAdapter = new Conversor4._0.db_academicaDataSetTableAdapters.periodosTableAdapter();
            lblidNota = new System.Windows.Forms.Label();
            lblMateria = new System.Windows.Forms.Label();
            lblPeriodo = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidNota
            // 
            lblidNota.AutoSize = true;
            lblidNota.Location = new System.Drawing.Point(94, 20);
            lblidNota.Name = "lblidNota";
            lblidNota.Size = new System.Drawing.Size(24, 13);
            lblidNota.TabIndex = 0;
            lblidNota.Text = "ID: ";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new System.Drawing.Point(84, 49);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(48, 13);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia: ";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new System.Drawing.Point(359, 49);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new System.Drawing.Size(49, 13);
            lblPeriodo.TabIndex = 4;
            lblPeriodo.Text = "Periodo: ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(84, 91);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(43, 13);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha: ";
            // 
            // idNotaLabel1
            // 
            this.idNotaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource1, "idNota", true));
            this.idNotaLabel1.Location = new System.Drawing.Point(144, 20);
            this.idNotaLabel1.Name = "idNotaLabel1";
            this.idNotaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idNotaLabel1.TabIndex = 1;
            this.idNotaLabel1.Text = "label1";
            // 
            // notasBindingSource1
            // 
            this.notasBindingSource1.DataMember = "notas";
            this.notasBindingSource1.DataSource = this.db_academicaDataSet1;
            // 
            // db_academicaDataSet1
            // 
            this.db_academicaDataSet1.DataSetName = "db_academicaDataSet";
            this.db_academicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboMateria
            // 
            this.cboMateria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiasBindingSource, "nombre", true));
            this.cboMateria.DataSource = this.materiasBindingSource;
            this.cboMateria.DisplayMember = "nombre";
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(147, 46);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(200, 21);
            this.cboMateria.TabIndex = 3;
            this.cboMateria.ValueMember = "idMateria";
            this.cboMateria.SelectedValueChanged += new System.EventHandler(this.cboMateria_SelectedValueChanged);
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.db_academicaDataSet1;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodosBindingSource, "periodo", true));
            this.cboPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.periodosBindingSource, "idPeriodo", true));
            this.cboPeriodo.DataSource = this.periodosBindingSource;
            this.cboPeriodo.DisplayMember = "periodo";
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(422, 46);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(200, 21);
            this.cboPeriodo.TabIndex = 5;
            this.cboPeriodo.ValueMember = "idPeriodo";
            this.cboPeriodo.SelectedValueChanged += new System.EventHandler(this.cboPeriodo_SelectedValueChanged);
            // 
            // periodosBindingSource
            // 
            this.periodosBindingSource.DataMember = "periodos";
            this.periodosBindingSource.DataSource = this.db_academicaDataSet2;
            // 
            // db_academicaDataSet2
            // 
            this.db_academicaDataSet2.DataSetName = "db_academicaDataSet";
            this.db_academicaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fechaDateTimePicker1
            // 
            this.fechaDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource1, "fecha", true));
            this.fechaDateTimePicker1.Location = new System.Drawing.Point(147, 89);
            this.fechaDateTimePicker1.Name = "fechaDateTimePicker1";
            this.fechaDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker1.TabIndex = 7;
            // 
            // dnotasDataGridView
            // 
            this.dnotasDataGridView.AllowUserToAddRows = false;
            this.dnotasDataGridView.AllowUserToDeleteRows = false;
            this.dnotasDataGridView.AutoGenerateColumns = false;
            this.dnotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.idNota,
            this.idMateria,
            this.alumno,
            this.lab1,
            this.lab2,
            this.parcial,
            this.nota_final});
            this.dnotasDataGridView.DataSource = this.dnotasBindingSource;
            this.dnotasDataGridView.Location = new System.Drawing.Point(41, 130);
            this.dnotasDataGridView.Name = "dnotasDataGridView";
            this.dnotasDataGridView.Size = new System.Drawing.Size(645, 278);
            this.dnotasDataGridView.TabIndex = 8;
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "idDetalle";
            this.idDetalle.HeaderText = "ID";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            this.idDetalle.Width = 50;
            // 
            // idNota
            // 
            this.idNota.DataPropertyName = "idNota";
            this.idNota.HeaderText = "idNota";
            this.idNota.Name = "idNota";
            this.idNota.ReadOnly = true;
            this.idNota.Visible = false;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "idMateria";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
            // 
            // alumno
            // 
            this.alumno.DataPropertyName = "nombre";
            this.alumno.HeaderText = "ALUMNO";
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            this.alumno.Width = 200;
            // 
            // lab1
            // 
            this.lab1.DataPropertyName = "lab1";
            this.lab1.HeaderText = "LAB1";
            this.lab1.Name = "lab1";
            // 
            // lab2
            // 
            this.lab2.DataPropertyName = "lab2";
            this.lab2.HeaderText = "LAB2";
            this.lab2.Name = "lab2";
            // 
            // parcial
            // 
            this.parcial.DataPropertyName = "parcial";
            this.parcial.HeaderText = "PARCIAL";
            this.parcial.Name = "parcial";
            // 
            // nota_final
            // 
            this.nota_final.DataPropertyName = "nf";
            this.nota_final.HeaderText = "NF";
            this.nota_final.Name = "nota_final";
            this.nota_final.ReadOnly = true;
            // 
            // dnotasBindingSource
            // 
            this.dnotasBindingSource.DataMember = "dnotas";
            this.dnotasBindingSource.DataSource = this.db_academicaDataSet1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(484, 89);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // notasTableAdapter1
            // 
            this.notasTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.alumnosTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.dnotasTableAdapter = null;
            this.tableAdapterManager1.docentesTableAdapter = null;
            this.tableAdapterManager1.materiasTableAdapter = null;
            this.tableAdapterManager1.notasTableAdapter = this.notasTableAdapter1;
            this.tableAdapterManager1.periodosTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Conversor4._0.db_academicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dnotasTableAdapter
            // 
            this.dnotasTableAdapter.ClearBeforeFill = true;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // periodosTableAdapter
            // 
            this.periodosTableAdapter.ClearBeforeFill = true;
            // 
            // frmNotas
            // 
            this.ClientSize = new System.Drawing.Size(723, 420);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dnotasDataGridView);
            this.Controls.Add(lblidNota);
            this.Controls.Add(this.idNotaLabel1);
            this.Controls.Add(lblMateria);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(lblPeriodo);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(lblFecha);
            this.Controls.Add(this.fechaDateTimePicker1);
            this.Name = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicaDataSet db_academicaDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton notasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idNotaTextBox;
        private System.Windows.Forms.TextBox idAlumnoTextBox;
        private System.Windows.Forms.TextBox idPeriodoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private db_academicaDataSet db_academicaDataSet1;
        private System.Windows.Forms.BindingSource notasBindingSource1;
        private db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter1;
        private db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label idNotaLabel1;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker1;
        private System.Windows.Forms.BindingSource dnotasBindingSource;
        private db_academicaDataSetTableAdapters.dnotasTableAdapter dnotasTableAdapter;
        private System.Windows.Forms.DataGridView dnotasDataGridView;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private db_academicaDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private db_academicaDataSet db_academicaDataSet2;
        private System.Windows.Forms.BindingSource periodosBindingSource;
        private db_academicaDataSetTableAdapters.periodosTableAdapter periodosTableAdapter;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_final;
    }
}